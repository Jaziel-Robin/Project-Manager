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
    public partial class ManageEmployees : Form
    {
        private RoleTreeNode _rootRole;
        private EmployeeTreeNode _rootEmp;
        private RoleTreeNode _roleTreeStructure;
        private Employee _emp;
        private TreeNode _currentSelectedNode;
        // Declare the ContextMenuStrip
        //Reference: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-attach-a-shortcut-menu-to-a-treeview-node?view=netframeworkdesktop-4.8
        private ContextMenuStrip empMenu;
        DataManager roleManager;
        DataManager empManager;

        public ManageEmployees()
        {
            InitializeComponent();
        }

        private EmployeeTreeNode CreateRootEmpNode()
        {
            Role tempRootRole = new Role("Root", false);
            _rootRole = new RoleTreeNode(tempRootRole);
            _rootRole.Name = tempRootRole.Name;
            LoadRoleData(_rootRole);
            RoleTreeNode rootRoleTreeNode = _roleTreeStructure;
            // rootRoleTreeNode.Name = tempRootRole.Name;

            Employee rootEmp = new Employee("Root", 0);
            if (rootRoleTreeNode != null)
            {
                EmployeeTreeNode defaultEmpRootNode = new EmployeeTreeNode(rootEmp, rootRoleTreeNode);
                defaultEmpRootNode.Name = defaultEmpRootNode.Employee.Name;
                _rootEmp = defaultEmpRootNode;
                return defaultEmpRootNode;
            }
            else
            {
                return null;
            }
        }

        private void LoadRoleData(RoleTreeNode defaultRoleRootNode)
        {
            treeViewEmployee.Nodes.Clear();
            roleManager = new DataManager(defaultRoleRootNode);
            roleManager.LoadRoleData();
            if (roleManager.RoleTreeStructure != null)
            {
                _roleTreeStructure = roleManager.RoleTreeStructure;
            }
            else
            {
                MessageBox.Show("No file to load. Save role tree view to file first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*treeViewEmployee.ExpandAll();*/
        }

        private void ManageEmployees_Load(object sender, EventArgs e)
        {
            EmployeeTreeNode defaultEmpRootNode = CreateRootEmpNode();
            if (defaultEmpRootNode != null)
            {
                defaultEmpRootNode.Text = defaultEmpRootNode.Employee.Name + " - " + defaultEmpRootNode.RoleTreeNode.Role.Name + " (S$" + defaultEmpRootNode.Employee.Salary + ")";
                this.treeViewEmployee.Nodes.Add(defaultEmpRootNode);
                this.treeViewEmployee.ExpandAll();
                empManager = new DataManager(defaultEmpRootNode);
                roleManager = new DataManager(defaultEmpRootNode.RoleTreeNode);
            }
            else
            {
                return;
            }
        }

        private void treeViewEmployee_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _currentSelectedNode = e.Node;

            if (_currentSelectedNode != null)
            {
                EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                if (empTreeNode.Employee != null)
                {
                    if (empTreeNode.RoleTreeNodes != null)
                    {
                        if (empTreeNode.RoleTreeNodes[1] != null)
                        {
                            if (empTreeNode.ProjectListEmp.Count > 0)
                            {
                                string uuid;
                                string RO;
                                string name = empTreeNode.Employee.Name;
                                string salary = empTreeNode.Employee.Salary.ToString();
                                string project = "";
                                for (int i = 0; i < empTreeNode.ProjectListEmp.Count; i++)
                                {
                                    if (empTreeNode.ProjectListEmp[i] != null)
                                    {
                                        if ((empTreeNode.ProjectListEmp.Count - i) > 1)
                                        {
                                            project += empTreeNode.ProjectListEmp[i].Name + ", ";
                                        }
                                        else
                                        {
                                            project += empTreeNode.ProjectListEmp[i].Name;
                                        }
                                    }
                                }
                                bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;
                                string role = "";

                                if (empTreeNode.RoleTreeNode.Role != null)
                                {
                                    role = empTreeNode.RoleTreeNode.Role.Name;
                                }

                                if (empTreeNode.Employee.Name == empTreeNode.TreeView.TopNode.Name)
                                {
                                    uuid = empTreeNode.Employee.Name;
                                }
                                else
                                {
                                    uuid = empTreeNode.Employee.UUID;
                                }

                                if (empTreeNode.ParentEmpTreeNode != null)
                                {
                                    RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                                }
                                else
                                {
                                    RO = "N.A.";
                                }

                                if (salary == "0")
                                {
                                    salary = "N.A.";
                                }

                                textBoxUUID.Text = uuid;
                                textBoxRO.Text = RO;
                                textBoxName.Text = name;
                                textBoxSalary.Text = salary;
                                textBoxRole.Text = role;
                                textBoxProjects.Text = project;
                                if (name == "Dummy")
                                {
                                    checkBoxDummy.Checked = true;
                                }
                                else
                                {
                                    checkBoxDummy.Checked = false;
                                }
                                checkBoxPL.Checked = isPL;
                                InitializeMenuTreeView(name);
                            }
                            else
                            {
                                string uuid;
                                string RO;
                                string name = empTreeNode.Employee.Name;
                                string salary = empTreeNode.Employee.Salary.ToString();
                                string project = "No Projects";
                                bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;
                                string role = "";

                                if (empTreeNode.RoleTreeNode.Role != null)
                                {
                                    role = empTreeNode.RoleTreeNode.Role.Name;
                                }

                                if (empTreeNode.Employee.Name == empTreeNode.TreeView.TopNode.Name)
                                {
                                    uuid = empTreeNode.Employee.Name;
                                }
                                else
                                {
                                    uuid = empTreeNode.Employee.UUID;
                                }

                                if (empTreeNode.ParentEmpTreeNode != null)
                                {
                                    RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                                }
                                else
                                {
                                    RO = "N.A.";
                                }

                                if (salary == "0")
                                {
                                    salary = "N.A.";
                                }

                                textBoxUUID.Text = uuid;
                                textBoxRO.Text = RO;
                                textBoxName.Text = name;
                                textBoxSalary.Text = salary;
                                textBoxRole.Text = role;
                                textBoxProjects.Text = project;
                                if (name == "Dummy")
                                {
                                    checkBoxDummy.Checked = true;
                                }
                                else
                                {
                                    checkBoxDummy.Checked = false;
                                }
                                checkBoxPL.Checked = isPL;
                                InitializeMenuTreeView(name);
                            }
                        }
                        else if (empTreeNode.RoleTreeNode.Role != null)
                        {
                            if (empTreeNode.ProjectListEmp.Count > 0)
                            {
                                string uuid;
                                string RO;
                                string name = empTreeNode.Employee.Name;
                                string salary = empTreeNode.Employee.Salary.ToString();
                                string project = "";
                                for (int i = 0; i < empTreeNode.ProjectListEmp.Count; i++)
                                {
                                    if (empTreeNode.ProjectListEmp[i] != null)
                                    {
                                        if ((empTreeNode.ProjectListEmp.Count - i) > 1)
                                        {
                                            project += empTreeNode.ProjectListEmp[i].Name + ", ";
                                        }
                                        else
                                        {
                                            project += empTreeNode.ProjectListEmp[i].Name;
                                        }
                                    }
                                }
                                bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;
                                string role = "";

                                if (empTreeNode.RoleTreeNode.Role != null)
                                {
                                    role = empTreeNode.RoleTreeNode.Role.Name;
                                }

                                if (empTreeNode.Employee.Name == empTreeNode.TreeView.TopNode.Name)
                                {
                                    uuid = empTreeNode.Employee.Name;
                                }
                                else
                                {
                                    uuid = empTreeNode.Employee.UUID;
                                }

                                if (empTreeNode.ParentEmpTreeNode != null)
                                {
                                    RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                                }
                                else
                                {
                                    RO = "N.A.";
                                }

                                if (salary == "0")
                                {
                                    salary = "N.A.";
                                }

                                textBoxUUID.Text = uuid;
                                textBoxRO.Text = RO;
                                textBoxName.Text = name;
                                textBoxSalary.Text = salary;
                                textBoxRole.Text = role;
                                textBoxProjects.Text = project;
                                if (name == "Dummy")
                                {
                                    checkBoxDummy.Checked = true;
                                }
                                else
                                {
                                    checkBoxDummy.Checked = false;
                                }
                                checkBoxPL.Checked = isPL;
                                InitializeMenuTreeView(name);
                            }
                            else
                            {
                                string uuid;
                                string RO;
                                string name = empTreeNode.Employee.Name;
                                string salary = empTreeNode.Employee.Salary.ToString();
                                string project = "No Projects";
                                bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;
                                string role = "";

                                if (empTreeNode.RoleTreeNode.Role != null)
                                {
                                    role = empTreeNode.RoleTreeNode.Role.Name;
                                }

                                if (empTreeNode.Employee.Name == empTreeNode.TreeView.TopNode.Name)
                                {
                                    uuid = empTreeNode.Employee.Name;
                                }
                                else
                                {
                                    uuid = empTreeNode.Employee.UUID;
                                }

                                if (empTreeNode.ParentEmpTreeNode != null)
                                {
                                    RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                                }
                                else
                                {
                                    RO = "N.A.";
                                }

                                if (salary == "0")
                                {
                                    salary = "N.A.";
                                }

                                textBoxUUID.Text = uuid;
                                textBoxRO.Text = RO;
                                textBoxName.Text = name;
                                textBoxSalary.Text = salary;
                                textBoxRole.Text = role;
                                textBoxProjects.Text = project;
                                if (name == "Dummy")
                                {
                                    checkBoxDummy.Checked = true;
                                }
                                else
                                {
                                    checkBoxDummy.Checked = false;
                                }
                                checkBoxPL.Checked = isPL;
                                InitializeMenuTreeView(name);
                            }
                        }
                    }
                    else
                    {
                        if (empTreeNode.ProjectListEmp.Count > 0)
                        {
                            string uuid;
                            string RO;
                            string name = empTreeNode.Employee.Name;
                            string salary = empTreeNode.Employee.Salary.ToString();
                            string project = "";
                            for (int i = 0; i < empTreeNode.ProjectListEmp.Count; i++)
                            {
                                if (empTreeNode.ProjectListEmp[i] != null)
                                {
                                    if ((empTreeNode.ProjectListEmp.Count - i) > 1)
                                    {
                                        project += empTreeNode.ProjectListEmp[i].Name + ", ";
                                    }
                                    else
                                    {
                                        project += empTreeNode.ProjectListEmp[i].Name;
                                    }
                                }
                            }
                            bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;
                            string role = "";

                            if (empTreeNode.RoleTreeNode.Role != null)
                            {
                                role = empTreeNode.RoleTreeNode.Role.Name;
                            }

                            if (empTreeNode.Employee.Name == empTreeNode.TreeView.TopNode.Name)
                            {
                                uuid = empTreeNode.Employee.Name;
                            }
                            else
                            {
                                uuid = empTreeNode.Employee.UUID;
                            }

                            if (empTreeNode.ParentEmpTreeNode != null)
                            {
                                RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                            }
                            else
                            {
                                RO = "N.A.";
                            }

                            if (salary == "0")
                            {
                                salary = "N.A.";
                            }

                            textBoxUUID.Text = uuid;
                            textBoxRO.Text = RO;
                            textBoxName.Text = name;
                            textBoxSalary.Text = salary;
                            textBoxRole.Text = role;
                            textBoxProjects.Text = project;
                            if (name == "Dummy")
                            {
                                checkBoxDummy.Checked = true;
                            }
                            else
                            {
                                checkBoxDummy.Checked = false;
                            }
                            checkBoxPL.Checked = isPL;
                            InitializeMenuTreeView(name);
                        }
                        else
                        {
                            string uuid;
                            string RO;
                            string name = empTreeNode.Employee.Name;
                            string salary = empTreeNode.Employee.Salary.ToString();
                            string project = "No Projects";
                            bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;
                            string role = "";

                            if (empTreeNode.RoleTreeNode.Role != null)
                            {
                                role = empTreeNode.RoleTreeNode.Role.Name;
                            }

                            if (empTreeNode.Employee.Name == empTreeNode.TreeView.TopNode.Name)
                            {
                                uuid = empTreeNode.Employee.Name;
                            }
                            else
                            {
                                uuid = empTreeNode.Employee.UUID;
                            }

                            if (empTreeNode.ParentEmpTreeNode != null)
                            {
                                RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                            }
                            else
                            {
                                RO = "N.A.";
                            }

                            if (salary == "0")
                            {
                                salary = "N.A.";
                            }

                            textBoxUUID.Text = uuid;
                            textBoxRO.Text = RO;
                            textBoxName.Text = name;
                            textBoxSalary.Text = salary;
                            textBoxRole.Text = role;
                            textBoxProjects.Text = project;
                            if (name == "Dummy")
                            {
                                checkBoxDummy.Checked = true;
                            }
                            else
                            {
                                checkBoxDummy.Checked = false;
                            }
                            checkBoxPL.Checked = isPL;
                            InitializeMenuTreeView(name);
                        }
                    }
                }
            }
        }

        public void InitializeMenuTreeView(string empName)
        {
            // Create the ContextMenuStrip.
            empMenu = new ContextMenuStrip();
            if (empName != null)
            {
                TreeNode selectedTreeNode = treeViewEmployee.SelectedNode;
                EmployeeTreeNode selectedEmpTreeNode = (EmployeeTreeNode)selectedTreeNode;
                TreeNode rootNode = treeViewEmployee.SelectedNode;
                while (rootNode.Parent != null)
                {
                    rootNode = rootNode.Parent;
                }
                if (treeViewEmployee.SelectedNode == rootNode)
                {
                    //Create menu item.
                    ToolStripMenuItem addLabel = new ToolStripMenuItem();
                    addLabel.Text = "Add Employee";
                    /*ToolStripMenuItem swapLabel = new ToolStripMenuItem();
                    swapLabel.Text = "Swap Employee";*/
                    //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                    empMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                    //Add the menu items to the menu.
                    empMenu.Items.AddRange(new ToolStripMenuItem[] { addLabel });
                }
                else
                {
                    if (selectedEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes.Count > 0)
                    {
                        if (selectedEmpTreeNode.RoleTreeNodes != null)
                        {
                            if (selectedEmpTreeNode.RoleTreeNodes[1] == null)
                            {
                                //Create menu item.
                                ToolStripMenuItem addLabel = new ToolStripMenuItem();
                                addLabel.Text = "Add Employee";

                                ToolStripMenuItem editLabel = new ToolStripMenuItem();
                                editLabel.Text = "Edit Employee";
                                ToolStripItem editEmp = new ToolStripMenuItem();
                                editEmp.Click += MenuClicked;
                                editEmp.Text = "Edit Employee Details";
                                ToolStripItem changeRoleRO = new ToolStripMenuItem();
                                changeRoleRO.Click += MenuClicked;
                                changeRoleRO.Text = "Change Role / Reporting Officer";
                                editLabel.DropDownItems.Add(editEmp);
                                editLabel.DropDownItems.Add(changeRoleRO);

                                ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                                removeLabel.Text = "Remove Employee";

                                ToolStripMenuItem swapLabel = new ToolStripMenuItem();
                                swapLabel.Text = "Swap Employee";
                                //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                                empMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                                //Add the menu items to the menu.
                                empMenu.Items.AddRange(new ToolStripMenuItem[] { addLabel, editLabel, removeLabel, swapLabel });
                            }
                            else
                            {
                                //Create menu item.
                                ToolStripMenuItem addLabel = new ToolStripMenuItem();
                                addLabel.Text = "Add Employee";

                                ToolStripMenuItem editLabel = new ToolStripMenuItem();
                                editLabel.Text = "Edit Employee";
                                ToolStripItem editEmp = new ToolStripMenuItem();
                                editEmp.Click += MenuClicked;
                                editEmp.Text = "Edit Employee Details";
                                editLabel.DropDownItems.Add(editEmp);

                                ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                                removeLabel.Text = "Remove Employee";

                                ToolStripMenuItem swapLabel = new ToolStripMenuItem();
                                swapLabel.Text = "Swap Employee";
                                //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                                empMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                                //Add the menu items to the menu.
                                empMenu.Items.AddRange(new ToolStripMenuItem[] { addLabel, editLabel, removeLabel, swapLabel });
                            }
                        }
                        else
                        {
                            //Create menu item.
                            ToolStripMenuItem addLabel = new ToolStripMenuItem();
                            addLabel.Text = "Add Employee";

                            ToolStripMenuItem editLabel = new ToolStripMenuItem();
                            editLabel.Text = "Edit Employee";
                            ToolStripItem editEmp = new ToolStripMenuItem();
                            editEmp.Click += MenuClicked;
                            editEmp.Text = "Edit Employee Details";
                            ToolStripItem changeRoleRO = new ToolStripMenuItem();
                            changeRoleRO.Click += MenuClicked;
                            changeRoleRO.Text = "Change Role / Reporting Officer";
                            editLabel.DropDownItems.Add(editEmp);
                            editLabel.DropDownItems.Add(changeRoleRO);

                            ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                            removeLabel.Text = "Remove Employee";

                            ToolStripMenuItem swapLabel = new ToolStripMenuItem();
                            swapLabel.Text = "Swap Employee";
                            //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                            empMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                            //Add the menu items to the menu.
                            empMenu.Items.AddRange(new ToolStripMenuItem[] { addLabel, editLabel, removeLabel, swapLabel });
                        }
                    }
                    else
                    {
                        if (selectedEmpTreeNode.RoleTreeNodes != null)
                        {
                            if (selectedEmpTreeNode.RoleTreeNodes[1] != null)
                            {
                                //Create menu item.
                                ToolStripMenuItem editLabel = new ToolStripMenuItem();
                                editLabel.Text = "Edit Employee";
                                ToolStripItem editEmp = new ToolStripMenuItem();
                                editEmp.Click += MenuClicked;
                                editEmp.Text = "Edit Employee Details";
                                editLabel.DropDownItems.Add(editEmp);

                                ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                                removeLabel.Text = "Remove Employee";

                                ToolStripMenuItem swapLabel = new ToolStripMenuItem();
                                swapLabel.Text = "Swap Employee";
                                //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                                empMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                                //Add the menu items to the menu.
                                empMenu.Items.AddRange(new ToolStripMenuItem[] { editLabel, removeLabel, swapLabel });
                            }
                        }
                        else
                        {
                            //Create menu item.
                            ToolStripMenuItem editLabel = new ToolStripMenuItem();
                            editLabel.Text = "Edit Employee";
                            ToolStripItem editEmp = new ToolStripMenuItem();
                            editEmp.Click += MenuClicked;
                            editEmp.Text = "Edit Employee Details";
                            ToolStripItem changeRoleRO = new ToolStripMenuItem();
                            changeRoleRO.Click += MenuClicked;
                            changeRoleRO.Text = "Change Role / Reporting Officer";
                            editLabel.DropDownItems.Add(editEmp);
                            editLabel.DropDownItems.Add(changeRoleRO);

                            ToolStripMenuItem removeLabel = new ToolStripMenuItem();
                            removeLabel.Text = "Remove Employee";

                            ToolStripMenuItem swapLabel = new ToolStripMenuItem();
                            swapLabel.Text = "Swap Employee";
                            //Reference: https://stackoverflow.com/questions/5789023/how-to-respond-to-a-contextmenustrip-item-click
                            empMenu.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);

                            //Add the menu items to the menu.
                            empMenu.Items.AddRange(new ToolStripMenuItem[] { editLabel, removeLabel, swapLabel });
                        }
                    }
                }
            }

            // Set the ContextMenuStrip property to the ContextMenuStrip.
            this.treeViewEmployee.ContextMenuStrip = empMenu;
        }

        private void MenuClicked(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            if (item != null)
            {
                if (item.Text == "Edit Employee Details")
                {
                    if (_currentSelectedNode != null)
                    {
                        EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                        string uuid = empTreeNode.Employee.UUID;
                        string RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                        string name = empTreeNode.Employee.Name;
                        string salary = empTreeNode.Employee.Salary.ToString();
                        string role = empTreeNode.RoleTreeNode.Role.Name;
                        string parentSalary = empTreeNode.ParentEmpTreeNode.Employee.Salary.ToString();

                        EditEmployee ee = new EditEmployee(uuid, RO, name, salary, role, parentSalary, _currentSelectedNode);
                        ee.EditEmployeeCallBack = EditEmpCallBackFn;
                        ee.ShowDialog();
                    }
                }
                else if (item.Text == "Change Role / Reporting Officer")
                {
                    if (_currentSelectedNode != null)
                    {
                        EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                        string uuid = empTreeNode.Employee.UUID;
                        string RO = empTreeNode.ParentEmpTreeNode.Employee.Name;
                        string name = empTreeNode.Employee.Name;
                        string salary = empTreeNode.Employee.Salary.ToString();
                        string role = empTreeNode.RoleTreeNode.Role.Name;

                        TreeNode rootNode = this.treeViewEmployee.TopNode;
                        ChangeRoleRO cr = new ChangeRoleRO(_currentSelectedNode, uuid, RO, name, salary, role, rootNode);
                        cr.ChangeRoleROCallBack = ChangeRoleROCallBackFn;
                        cr.ShowDialog();
                    }
                }
            }
        }

        public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            if (item != null)
            {
                _currentSelectedNode = treeViewEmployee.SelectedNode;
                if (item.Text == "Add Employee")
                {
                    if (_currentSelectedNode != null)
                    {
                        EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                        string RO;
                        if (empTreeNode.ParentEmpTreeNode != null)
                        {
                            RO = empTreeNode.Employee.Name;
                        }
                        else
                        {
                            RO = _rootEmp.Employee.Name;
                        }

                        AddEmployee ae = new AddEmployee(_currentSelectedNode, RO);
                        ae.AddEmployeeCallBack = AddEmployeeCallBackFn;
                        ae.ShowDialog();
                    }
                }
                else if (item.Text == "Remove Employee")
                {
                    if (_currentSelectedNode != null)
                    {
                        DeleteEmpTreeNode(_currentSelectedNode);
                    }
                }
                else if (item.Text == "Swap Employee")
                {
                    if (_currentSelectedNode != null)
                    {
                        EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                        TreeNodeCollection treeView = this.treeViewEmployee.Nodes;
                        TreeNode rootNode = treeViewEmployee.SelectedNode;
                        TreeNode[] treeViewArr = new TreeNode[treeView.Count];
                        this.treeViewEmployee.Nodes.CopyTo(treeViewArr, 0);
                        this.treeViewEmployee.Nodes.Clear();
                        while (rootNode.Parent != null)
                        {
                            rootNode = rootNode.Parent;
                        }
                        ReplaceEmployee re = new ReplaceEmployee(treeViewArr, empTreeNode);
                        re.ReplaceEmployeeCallBack = ReplaceEmpCallBackFn;
                        re.ShowDialog();
                    }
                    this.treeViewEmployee.Nodes.Add(empManager.EmpTreeStructure);
                    this.treeViewEmployee.ExpandAll();
                }
            }
        }

        private void AddEmployeeCallBackFn(string name, int salary, TreeNode TreeNode)
        {
            textBoxConsole.Clear();
            RoleTreeNode roleTreeNode = (RoleTreeNode)TreeNode;
            _emp = new Employee(name, salary);
            EmployeeTreeNode tempEmp = new EmployeeTreeNode(_emp, roleTreeNode);
            EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
            tempEmp.Text = tempEmp.Employee.Name + " - " + tempEmp.RoleTreeNode.Role.Name + " (S$" + tempEmp.Employee.Salary + ")";
            if (empTreeNode.RoleTreeNode.Role.IsPL)
            {
                tempEmp.ProjectListEmp = empTreeNode.ProjectListEmp;
            }
            empTreeNode.AddChildEmpTreeNode(tempEmp);
            textBoxConsole.Text = "Employee Added:\r\nName: " + name + "\r\nSalary: " + salary.ToString() + "\r\nRole: " + roleTreeNode.Role.Name + "\r\n";
        }

        private void EditEmpCallBackFn(string newEmpName, int newSalary)
        {
            textBoxConsole.Clear();
            textBoxConsole.Text = "Employee Edited:\r\nName: " + newEmpName + "\r\nSalary: " + newSalary.ToString() + "\r\n";
            EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
            empTreeNode.UpdateEmpTreeNode(newEmpName, newSalary, empTreeNode.RoleTreeNode.Role.IsPL);
            if (empTreeNode.RoleTreeNodes != null)
            {
                if (empTreeNode.RoleTreeNodes[1] != null)
                {
                    empTreeNode.Text = empTreeNode.Employee.Name + " - " + empTreeNode.RoleTreeNodes[0].Role.Name + ", " + empTreeNode.RoleTreeNodes[1].Role.Name + " (S$" + empTreeNode.Employee.Salary + ")";
                }
            }
            else
            {
                empTreeNode.Text = empTreeNode.Employee.Name + " - " + empTreeNode.RoleTreeNode.Role.Name + " (S$" + empTreeNode.Employee.Salary + ")";
            }
            textBoxName.Text = newEmpName;
            textBoxSalary.Text = newSalary.ToString();

            List<EmployeeTreeNode> empTreeNodes = new List<EmployeeTreeNode>();
            EmployeeTreeNode rootNode = (EmployeeTreeNode)this.treeViewEmployee.TopNode;
            empTreeNodes = rootNode.SearchByEmployeeUUID(empTreeNode.Employee.UUID, ref empTreeNodes);
            rootNode.UpdateNodes(empTreeNodes, empTreeNode);
        }

        private void DeleteEmpTreeNode(TreeNode selectedTreeNode)
        {
            EmployeeTreeNode selectedEmpTreeNode = (EmployeeTreeNode)selectedTreeNode;
            List<EmployeeTreeNode> childTreeNode = selectedEmpTreeNode.ChildEmpTreeNodes;
            TreeNode rootNode = this.treeViewEmployee.TopNode;

            if (selectedEmpTreeNode.ChildEmpTreeNodes.Count == 0)
            {
                if (selectedEmpTreeNode.ProjectListEmp.Count > 0)
                {
                    if (CheckAfterDelete(selectedEmpTreeNode))
                    {
                        DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "Confirm removal of employee? Click OK to proceed.", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.OK)
                        {
                            selectedEmpTreeNode.DeleteEmpTreeNode(rootNode, selectedEmpTreeNode);
                            selectedEmpTreeNode.ParentEmpTreeNode.ChildEmpTreeNodes.Remove(selectedEmpTreeNode);
                            selectedEmpTreeNode = null;
                            this.treeViewEmployee.Nodes.Remove(selectedTreeNode);
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "The employee can only be removed if there are no subordinates, no assigned projects or if after removal will still remain a full team. Would you like to swap the employee with another first?", "Execute Employee Swap", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.OK)
                        {
                            if (selectedEmpTreeNode != null)
                            {
                                TreeNodeCollection treeView = this.treeViewEmployee.Nodes;
                                TreeNode rootEmpNode = treeViewEmployee.SelectedNode;
                                TreeNode[] treeViewArr = new TreeNode[treeView.Count];
                                this.treeViewEmployee.Nodes.CopyTo(treeViewArr, 0);
                                this.treeViewEmployee.Nodes.Clear();
                                while (rootEmpNode.Parent != null)
                                {
                                    rootEmpNode = rootEmpNode.Parent;
                                }
                                ReplaceEmployee re = new ReplaceEmployee(treeViewArr, selectedEmpTreeNode);
                                re.ReplaceEmployeeCallBack = ReplaceEmpCallBackFn;
                                re.ShowDialog();
                            }
                            this.treeViewEmployee.Nodes.Add(empManager.EmpTreeStructure);
                            this.treeViewEmployee.ExpandAll();
                        }
                        else
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "Confirm removal of employee? Click OK to proceed.", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.OK)
                    {
                        selectedEmpTreeNode.DeleteEmpTreeNode(rootNode, selectedEmpTreeNode);
                        selectedEmpTreeNode.ParentEmpTreeNode.ChildEmpTreeNodes.Remove(selectedEmpTreeNode);
                        selectedEmpTreeNode = null;
                        this.treeViewEmployee.Nodes.Remove(selectedTreeNode);
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(new Form { TopMost = true }, "The employee can only be removed if there are no subordinates, no assigned projects or if after removal will still remain a full team. Would you like to swap the employee with another first?", "Execute Employee Swap", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    if (selectedEmpTreeNode != null)
                    {
                        TreeNodeCollection treeView = this.treeViewEmployee.Nodes;
                        TreeNode rootEmpNode = treeViewEmployee.SelectedNode;
                        TreeNode[] treeViewArr = new TreeNode[treeView.Count];
                        this.treeViewEmployee.Nodes.CopyTo(treeViewArr, 0);
                        this.treeViewEmployee.Nodes.Clear();
                        while (rootEmpNode.Parent != null)
                        {
                            rootEmpNode = rootEmpNode.Parent;
                        }
                        ReplaceEmployee re = new ReplaceEmployee(treeViewArr, selectedEmpTreeNode);
                        re.ReplaceEmployeeCallBack = ReplaceEmpCallBackFn;
                        re.ShowDialog();
                    }
                    this.treeViewEmployee.Nodes.Add(empManager.EmpTreeStructure);
                    this.treeViewEmployee.ExpandAll();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private bool CheckAfterDelete(EmployeeTreeNode nodeToDelete)
        {
            bool canDelete = true;
            if (nodeToDelete.ParentEmpTreeNode != null)
            {
                List<RoleTreeNode> roleTreeNodes = new List<RoleTreeNode>();
                if (nodeToDelete.RoleTreeNodes == null)
                {
                    for (int i = 0; i < nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes.Count; i++)
                    {
                        if (nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes[i].Employee.UUID != nodeToDelete.Employee.UUID)
                        {
                            roleTreeNodes.Add(nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes[i].RoleTreeNode);
                        }
                    }
                    for (int j = 0; j < nodeToDelete.ParentEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes.Count; j++)
                    {
                        if (!roleTreeNodes.Contains(nodeToDelete.ParentEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes[j]))
                        {
                            canDelete = false;
                        }
                    }
                }
                else
                {
                    List<RoleTreeNode> tempRoleTreeNodes = new List<RoleTreeNode>();
                    for (int i = 0; i < nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes.Count; i++)
                    {
                        if (nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes[i].Employee.UUID != nodeToDelete.Employee.UUID)
                        {
                            roleTreeNodes.Add(nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes[i].RoleTreeNode);
                        }
                        else
                        {
                            tempRoleTreeNodes.Add(nodeToDelete.ParentEmpTreeNode.ChildEmpTreeNodes[i].RoleTreeNode);
                        }
                    }
                    if (tempRoleTreeNodes[0] == tempRoleTreeNodes[1])
                    {
                        roleTreeNodes.Add(tempRoleTreeNodes[0]);
                    }
                    else
                    {
                        if (tempRoleTreeNodes[0] != nodeToDelete.RoleTreeNode)
                        {
                            roleTreeNodes.Add(tempRoleTreeNodes[0]);
                        }
                        else if (tempRoleTreeNodes[1] != nodeToDelete.RoleTreeNode)
                        {
                            roleTreeNodes.Add(tempRoleTreeNodes[1]);
                        }
                    }
                    for (int j = 0; j < nodeToDelete.ParentEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes.Count; j++)
                    {
                        if (!roleTreeNodes.Contains(nodeToDelete.ParentEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes[j]))
                        {
                            canDelete = false;
                        }
                    }
                }
            }
            return canDelete;
        }

        private void ReplaceEmpCallBackFn(EmployeeTreeNode empNodeToReplace, EmployeeTreeNode selectedEmpNode)
        {
            RoleTreeNode tempRoleTreeNode;
            EmployeeTreeNode tempEmpTreeNode = new EmployeeTreeNode();

            tempRoleTreeNode = new RoleTreeNode(empNodeToReplace.RoleTreeNode.Role);
            tempRoleTreeNode.ParentRoleTreeNode = empNodeToReplace.RoleTreeNode.ParentRoleTreeNode;
            tempRoleTreeNode.Role = empNodeToReplace.RoleTreeNode.Role;
            tempRoleTreeNode.ChildRoleTreeNodes = empNodeToReplace.RoleTreeNode.ChildRoleTreeNodes;
            tempEmpTreeNode.Employee = empNodeToReplace.Employee;

            tempEmpTreeNode = new EmployeeTreeNode(tempEmpTreeNode.Employee, tempRoleTreeNode);
            tempEmpTreeNode.ParentEmpTreeNode = empNodeToReplace.ParentEmpTreeNode;
            tempEmpTreeNode.ChildEmpTreeNodes = empNodeToReplace.ChildEmpTreeNodes;
            tempEmpTreeNode.RoleTreeNode = empNodeToReplace.RoleTreeNode;

            textBoxConsole.Clear();
            textBoxConsole.Text = "Employees Swapped\r\n";
            selectedEmpNode.SwapTreeNodes(empNodeToReplace, selectedEmpNode);
            selectedEmpNode.SwapTreeNodes(selectedEmpNode, tempEmpTreeNode);
        }

        private void ChangeRoleROCallBackFn(string newEmpName, int newSalary, EmployeeTreeNode newEmpTreeNode, bool isDummy)
        {
            textBoxConsole.Clear();
            Employee newEmp = newEmpTreeNode.Employee;
            RoleTreeNode[] newEmpRoleTreeNodeArr = newEmpTreeNode.RoleTreeNodes;
            RoleTreeNode newEmpRoleTreeNode = new RoleTreeNode();
            EmployeeTreeNode copyEmpTreeNode = new EmployeeTreeNode(newEmp, newEmpRoleTreeNodeArr);
            for (int i = 0; i < newEmpTreeNode.RoleTreeNodes.Length; i++)
            {
                for (int j = 0; j < newEmpTreeNode.ParentEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes.Count; j++)
                {
                    if (newEmpTreeNode.ParentEmpTreeNode.RoleTreeNode.ChildRoleTreeNodes[j].Role.Name == newEmpTreeNode.RoleTreeNodes[i].Role.Name)
                    {
                        newEmpTreeNode.RoleTreeNode = newEmpTreeNode.RoleTreeNodes[i];
                        newEmpRoleTreeNode = newEmpTreeNode.RoleTreeNodes[i];
                    }
                }
            }
            copyEmpTreeNode.RoleTreeNode = newEmpRoleTreeNode;
            copyEmpTreeNode.Text = copyEmpTreeNode.Employee.Name + " - " + copyEmpTreeNode.RoleTreeNodes[0].Role.Name + ", " + copyEmpTreeNode.RoleTreeNodes[1].Role.Name + " (S$" + copyEmpTreeNode.Employee.Salary + ")";
            newEmpTreeNode.ParentEmpTreeNode.AddChildEmpTreeNode(copyEmpTreeNode);

            List<EmployeeTreeNode> empTreeNodes = new List<EmployeeTreeNode>();
            EmployeeTreeNode rootNode = (EmployeeTreeNode)this.treeViewEmployee.TopNode;
            empTreeNodes = rootNode.SearchByEmployeeUUID(copyEmpTreeNode.Employee.UUID, ref empTreeNodes);
            rootNode.UpdateNodes(empTreeNodes, copyEmpTreeNode);

            textBoxConsole.Text = "Employee Changed!";
        }

        private void PrintRoleTreeFromSelectedNode(RoleTreeNode roleTreeNode, string indent, bool last)
        {
            RoleTreeNode tree = roleTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                numberOfChildNodes = tree.ChildRoleTreeNodes.Count;
            }

            Debug.Write(indent);//You can delete this statement to check the effects.
            if (last)
            {   //The following code was done through trial and error
                Debug.Write("+-");//You can delete this statement to check the effects.
                indent += " ";//You can delete this statement to check the effects.
            }
            else
            {   //The following code was done through trial and error
                Debug.Write("+-");//You can delete this statement to check the effects.
                indent += "| ";//You can delete this statement to check the effects.
            }

            if (tree != null)
            {
                Debug.WriteLine(tree.Role.Name);
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the PrintTree method
                PrintRoleTreeFromSelectedNode(tree.ChildRoleTreeNodes[i], indent, i == numberOfChildNodes - 1);
            }//End of for loop
        }//End of PrintTree

        private void PrintEmpTreeFromSelectedNode(EmployeeTreeNode empTreeNode, string indent, bool last)
        {
            EmployeeTreeNode tree = empTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                numberOfChildNodes = tree.ChildEmpTreeNodes.Count;
            }

            Debug.Write(indent);//You can delete this statement to check the effects.
            if (last)
            {   //The following code was done through trial and error
                Debug.Write("+-");//You can delete this statement to check the effects.
                indent += " ";//You can delete this statement to check the effects.
            }
            else
            {   //The following code was done through trial and error
                Debug.Write("+-");//You can delete this statement to check the effects.
                indent += "| ";//You can delete this statement to check the effects.
            }

            if (tree != null)
            {
                Debug.WriteLine(tree.Employee.Name);
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the PrintTree method
                PrintEmpTreeFromSelectedNode(tree.ChildEmpTreeNodes[i], indent, i == numberOfChildNodes - 1);
            }//End of for loop
        }//End of PrintTree

        public void buttonExpand_Click(object sender, EventArgs e)
        {
            this.treeViewEmployee.ExpandAll();
        }

        public void buttonCollapse_Click(object sender, EventArgs e)
        {
            this.treeViewEmployee.CollapseAll();
        }

        public void buttonReset_Click(object sender, EventArgs e)
        {
            this.treeViewEmployee.Nodes.Clear();
            EmployeeTreeNode newEmpRootNode = CreateRootEmpNode();
            if (newEmpRootNode != null)
            {
                newEmpRootNode.Text = newEmpRootNode.Employee.Name + " - " + newEmpRootNode.RoleTreeNode.Role.Name + " (S$" + newEmpRootNode.Employee.Salary + ")";
                this.treeViewEmployee.Nodes.Add(newEmpRootNode);
                empManager = new DataManager(newEmpRootNode);
                MessageBox.Show("Tree View was reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        public void buttonSave_Click(object sender, EventArgs e)
        {
            TreeNodeCollection nodes = this.treeViewEmployee.Nodes;
            EmployeeTreeNode rootEmpTreeNode = null;
            if (nodes.Count > 0)
            {
                // Select the root node
                rootEmpTreeNode = (EmployeeTreeNode)nodes[0];
            }
            rootEmpTreeNode.SaveToFileBinary();
        }

        public void buttonLoad_Click(object sender, EventArgs e)
        {
            treeViewEmployee.Nodes.Clear();
            empManager.LoadEmpData();
            if (empManager.EmpTreeStructure != null)
            {
                EmployeeTreeNode empTreeStructure = empManager.EmpTreeStructure;
                empTreeStructure.Name = empTreeStructure.Employee.Name;
                treeViewEmployee.Nodes.Add(empTreeStructure);
                empManager = new DataManager(empTreeStructure);
                this.treeViewEmployee.ExpandAll();
            }
            else
            {
                MessageBox.Show("No file to load. Save tree view to file first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.treeViewEmployee.Nodes.Add(_rootEmp);
                empManager = new DataManager(_rootEmp);
                return;
            }
            treeViewEmployee.ExpandAll();
        }
    }
}
