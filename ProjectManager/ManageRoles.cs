using ProjectManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class ManageRoles : Form
    {
        private RoleTreeNode _root;
        private Role _role;
        private EmployeeTreeNode _rootEmp;
        private TreeNode _currentSelectedNode;
        private EmployeeTreeNode _empTreeStructure;
        // Declare the ContextMenuStrip
        //Reference: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-attach-a-shortcut-menu-to-a-treeview-node?view=netframeworkdesktop-4.8
        private ContextMenuStrip roleMenu;
        DataManager roleManager;
        DataManager empManager;

        public ManageRoles()
        {
            InitializeComponent();
        }

        private RoleTreeNode CreateRootNode()
        {
            Role rootRole = new Role("Root", false);
            RoleTreeNode defaultRoleRootNode = new RoleTreeNode(rootRole);
            _root = defaultRoleRootNode;

            Employee rootEmp = new Employee("Root", 0);
            if (defaultRoleRootNode != null)
            {
                EmployeeTreeNode defaultEmpRootNode = new EmployeeTreeNode(rootEmp, defaultRoleRootNode);
                defaultEmpRootNode.Name = defaultEmpRootNode.Employee.Name;
                _rootEmp = defaultEmpRootNode;
            }
            empManager = new DataManager(_rootEmp);
            empManager.LoadEmpData();
            if (empManager.EmpTreeStructure != null)
            {
                EmployeeTreeNode empTreeStructure = empManager.EmpTreeStructure;
                empTreeStructure.Name = empTreeStructure.Employee.Name;
                empManager = new DataManager(empTreeStructure);
                _empTreeStructure = empManager.EmpTreeStructure;
            }
            return _root;
        }

        private void FormManageRoles_Load(object sender, EventArgs e)
        {
            RoleTreeNode defaultRoleRootNode = CreateRootNode();
            this.treeViewRole.Nodes.Add(defaultRoleRootNode);
            roleManager = new DataManager(defaultRoleRootNode);
        }

        private void treeViewRole_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _currentSelectedNode = e.Node;

            if (_currentSelectedNode != null)
            {
                RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode;
                string name = roleTreeNode.Role.Name;
                string uuid = roleTreeNode.Role.UUID;
                bool isPL = roleTreeNode.Role.IsPL;
                if (isPL)
                {
                    checkBoxProjectLeader.Checked = true;
                }
                else
                {
                    checkBoxProjectLeader.Checked = false;
                }
                textBoxName.Text = name;
                textBoxUUID.Text = uuid;
                InitializeMenuTreeView(name);

                /*EmployeeTreeNode employeeTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                string name = employeeTreeNode.Employee.EmployeeName;
                string uuid = employeeTreeNode.Employee.UUID;
                bool isPL = employeeTreeNode.Employee.IsPL;
                if (isPL)
                {
                    checkBoxProjectLeader.Checked = true;
                }
                else
                {
                    checkBoxProjectLeader.Checked = false;
                }
                textBoxName.Text = name;
                textBoxUUID.Text = uuid;*/
            }
        }

        public void InitializeMenuTreeView(string roleName)
        {
            // Create the ContextMenuStrip.
            roleMenu = new ContextMenuStrip();
            if (roleName != null)
            {
                TreeNode selectedTreeNode = treeViewRole.SelectedNode;
                RoleTreeNode selectedRoleTreeNode = (RoleTreeNode)selectedTreeNode;
                TreeNode rootNode = treeViewRole.SelectedNode;
                while (rootNode.Parent != null)
                {
                    rootNode = rootNode.Parent;
                }
                if (treeViewRole.SelectedNode == rootNode)
                {
                    //Create menu item.
                    ToolStripMenuItem addLabel = new ToolStripMenuItem();
                    addLabel.Text = "Add Role";
                    //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                    roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                    //Add the menu items to the menu.
                    roleMenu.Items.AddRange(new ToolStripMenuItem[] { addLabel });
                }
                else if (selectedRoleTreeNode.ParentRoleTreeNode.Role.IsPL == true)
                {
                    //Create some menu items.
                    ToolStripMenuItem editLabel = new ToolStripMenuItem();
                    editLabel.Text = "Edit Role";
                    ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                    removeLabel.Text = "Remove Role";

                    roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                    //Add the menu items to the menu.
                    roleMenu.Items.AddRange(new ToolStripMenuItem[]{ editLabel, removeLabel });
                }
                else
                {
                    //Create some menu items.
                    ToolStripMenuItem addLabel = new ToolStripMenuItem();
                    addLabel.Text = "Add Role";
                    ToolStripMenuItem editLabel = new ToolStripMenuItem();
                    editLabel.Text = "Edit Role";
                    ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                    removeLabel.Text = "Remove Role";

                    roleMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                    //Add the menu items to the menu.
                    roleMenu.Items.AddRange(new ToolStripMenuItem[]{ addLabel, editLabel, removeLabel });
                }
            }

            // Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewRole.ContextMenuStrip = roleMenu;
        }

        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item != null)
            {
                _currentSelectedNode = treeViewRole.SelectedNode;
                if (item.Text == "Add Role")
                {
                    if (_currentSelectedNode != null)
                    {
                        RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode;
                        string name = roleTreeNode.Role.Name;
                        bool isPL = roleTreeNode.Role.IsPL;
                        AddRole ar = new AddRole(name, isPL);
                        ar.AddRoleCallBack = AddRoleCallBackFn;
                        ar.ShowDialog();
                    }
                }
                else if (item.Text == "Edit Role")
                {
                    if (_currentSelectedNode != null)
                    {
                        RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode;
                        string uuid = roleTreeNode.Role.UUID;
                        string name = roleTreeNode.Role.Name;
                        string parentRoleName = roleTreeNode.ParentRoleTreeNode.Role.Name;
                        bool isPL = roleTreeNode.Role.IsPL;
                        bool hasGrandChildren = roleTreeNode.HasGrandChildren(roleTreeNode, 2);
                        bool isParentPL = roleTreeNode.ParentRoleTreeNode.Role.IsPL;
                        List<RoleTreeNode> childRoleTreeNodes = roleTreeNode.ChildRoleTreeNodes;
                        bool isChildPL = false;
                        bool canEditRole = false;
                        for (int i = 0; i < childRoleTreeNodes.Count; i++)
                        {
                            isChildPL = childRoleTreeNodes[i].Role.IsPL;
                            if (isChildPL)
                            {
                                break;
                            }
                        }
                        List<string> uuids = new List<string>();
                        uuids = GetRolesUUIDFromEmpTree(_empTreeStructure, uuids);
                        for (int i = 0; i < uuids.Count; i++)
                        {
                            if (uuids[i].Contains(roleTreeNode.Role.UUID))
                            {
                                canEditRole = false;
                                break;
                            }
                            else
                            {
                                canEditRole = true;
                            }
                        }

                        EditRole er = new EditRole(uuid, name, parentRoleName, isPL, hasGrandChildren, isParentPL, isChildPL, canEditRole);
                        er.EditRoleCallBack = EditRoleCallBackFn;
                        er.ShowDialog();
                    }
                }
                else if (item.Text == "Remove Role")
                {
                    if (_currentSelectedNode != null)
                    {
                        DeleteRoleTreeNode(_currentSelectedNode);
                    }
                }
            }
        }

        private void AddRoleCallBackFn(string newRoleName, bool isPL)
        {
            textBoxConsole.Clear();
            textBoxConsole.Text = "Role Added:\r\nName: " + newRoleName + "\r\n";
            RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode;
            _role = new Role(newRoleName, isPL);
            RoleTreeNode tempRole = new RoleTreeNode(_role);
            roleTreeNode.AddChildRoleTreeNode(tempRole);
        }

        private void EditRoleCallBackFn(string newRoleName, bool isPL)
        {
            textBoxConsole.Clear();
            textBoxConsole.Text = "Role Edited:\r\nName: " + newRoleName + "\r\n";
            RoleTreeNode roleTreeNode = (RoleTreeNode)_currentSelectedNode;
            roleTreeNode.UpdateRoleTreeNode(newRoleName, isPL);
            textBoxName.Text = newRoleName;
            checkBoxProjectLeader.Checked = isPL;
        }

        private List<string> GetTreeUUIDFromSelectedNode(RoleTreeNode roleTreeNode, List<string> roleTreeNodes)
        {
            RoleTreeNode tree = roleTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                numberOfChildNodes = tree.ChildRoleTreeNodes.Count;
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                if (!roleTreeNodes.Contains(tree.ChildRoleTreeNodes[i].Role.UUID))
                {
                    //Keep calling the GetTreeFromSelectedNode method
                    roleTreeNodes.Add(tree.ChildRoleTreeNodes[i].Role.UUID);
                }
                GetTreeUUIDFromSelectedNode(tree.ChildRoleTreeNodes[i], roleTreeNodes);
            }//End of for loop
            return roleTreeNodes;
        }//End of GetTreeFromSelectedNode

        private List<string> GetRolesUUIDFromEmpTree(EmployeeTreeNode empTreeNode, List<string> empTreeNodes)
        {
            EmployeeTreeNode tree = empTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                numberOfChildNodes = tree.ChildEmpTreeNodes.Count;
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                if (!empTreeNodes.Contains(tree.ChildEmpTreeNodes[i].RoleTreeNode.Role.UUID))
                {
                    //Keep calling the GetRolesFromEmpTree method
                    empTreeNodes.Add(tree.ChildEmpTreeNodes[i].RoleTreeNode.Role.UUID);
                }
                GetRolesUUIDFromEmpTree(tree.ChildEmpTreeNodes[i], empTreeNodes);
            }//End of for loop
            return empTreeNodes;
        }//End of GetRolesFromEmpTree

        public void DeleteRoleTreeNode(TreeNode selectedTreeNode)
        {
            RoleTreeNode selectedRoleTreeNode = (RoleTreeNode)selectedTreeNode;
            List<RoleTreeNode> childTreeNode = selectedRoleTreeNode.ChildRoleTreeNodes;

            List<string> roleTreeNodes = new List<string>();
            RoleTreeNode selectedNode = (RoleTreeNode)this.treeViewRole.SelectedNode;
            roleTreeNodes.Add(selectedNode.Role.UUID);
            roleTreeNodes = GetTreeUUIDFromSelectedNode((RoleTreeNode)this.treeViewRole.SelectedNode, roleTreeNodes);

            List<string> empTreeNodes = new List<string>();
            empTreeNodes = GetRolesUUIDFromEmpTree(_empTreeStructure, empTreeNodes);
            bool canDelete = false;

            if (selectedRoleTreeNode != null)
            {
                for (int i = 0; i < roleTreeNodes.Count; i++)
                {
                    if (empTreeNodes.Contains(roleTreeNodes[i]))
                    {
                        canDelete = false;
                        break;
                    }
                    else
                    {
                        canDelete = true;
                    }
                }

                if (canDelete)
                {
                    selectedRoleTreeNode.ParentRoleTreeNode.ChildRoleTreeNodes.Remove(selectedRoleTreeNode);
                    selectedRoleTreeNode = null;
                    this.treeViewRole.Nodes.Remove(selectedTreeNode);
                    this.textBoxConsole.Text = "Role Deleted";
                }
                else
                {
                    MessageBox.Show("Unable to delete selected role. There are currently employees under the selected role.", "Invalid Role");
                    return;
                }
            }
        }

        public void buttonExpand_Click(object sender, EventArgs e)
        {
            this.treeViewRole.ExpandAll();
        }

        public void buttonCollapse_Click(object sender, EventArgs e)
        {
            this.treeViewRole.CollapseAll();
        }

        public void buttonReset_Click(object sender, EventArgs e)
        {
            this.treeViewRole.Nodes.Clear();
            RoleTreeNode newRootNode = CreateRootNode();
            this.treeViewRole.Nodes.Add(newRootNode);
            MessageBox.Show("Tree View was reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void buttonSave_Click(object sender, EventArgs e)
        {
            TreeNodeCollection nodes = this.treeViewRole.Nodes;
            RoleTreeNode rootRoleTreeNode = null;
            if (nodes.Count > 0)
            {
                // Select the root node
                rootRoleTreeNode = (RoleTreeNode)nodes[0];
            }
            rootRoleTreeNode.SaveToFileBinary();
        }

        public void buttonLoad_Click(object sender, EventArgs e)
        {
            treeViewRole.Nodes.Clear();
            roleManager.LoadRoleData();
            if (roleManager.RoleTreeStructure != null)
            {
                treeViewRole.Nodes.Add(roleManager.RoleTreeStructure);
            }
            else
            {
                MessageBox.Show("No file to load. Save tree view to file first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.treeViewRole.Nodes.Add(_root);
                roleManager = new DataManager(_root);
                return;
            }
            treeViewRole.ExpandAll();
        }
    }
}
