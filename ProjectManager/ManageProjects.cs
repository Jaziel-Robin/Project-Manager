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
    public partial class ManageProjects : Form
    {
        private RoleTreeNode _rootRole;
        private EmployeeTreeNode _rootEmp;
        private RoleTreeNode _roleTreeStructure;
        private Employee _emp;
        private TreeNode _currentSelectedNode;
        private ListViewItem _currentSelectedListViewItem;
        // Declare the ContextMenuStrip
        //Reference: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-attach-a-shortcut-menu-to-a-treeview-node?view=netframeworkdesktop-4.8
        private ContextMenuStrip empMenu;
        private List<Project> _projectsList = new List<Project>();
        DataManager roleManager;
        DataManager empManager;

        public ManageProjects()
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

        private void ManageProjects_Load(object sender, EventArgs e)
        {
            comboBoxMode.SelectedItem = "View";
            CreateListViewColumns();

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

        private void CreateListViewColumns()
        {
            listViewProject.View = View.Details;
            listViewProject.Columns.Add("UUID", 48);
            listViewProject.Columns.Add("Project Name", 103);
            listViewProject.Columns.Add("Revenue", 70);
            listViewProject.Columns.Add("Team Leader", (listViewProject.Width - 48 - 103 - 74));
            listViewProject.FullRowSelect = true;
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedItem == "View")
            {
                textBoxAddPN.Enabled = false;
                textBoxAddRevenue.Enabled = false;
                comboBoxAddTL.Enabled = false;
                buttonAddSearchForTeams.Enabled = false;
                buttonCancel.Enabled = false;
                buttonConfirmAdd.Enabled = false;

                textBoxUUID.Enabled = false;
                textBoxViewEditPN.Enabled = false;
                textBoxViewEditRevenue.Enabled = false;
                comboBoxViewEditTL.Enabled = false;
                buttonViewEditSearchForTeams.Enabled = false;
                buttonConfirmEdit.Enabled = false;
                buttonDelete.Enabled = false;

                textBoxAddPN.Text = "";
                textBoxAddRevenue.Text = "";
                comboBoxAddTL.Items.Clear();

                textBoxUUID.Text = "";
                textBoxViewEditPN.Text = "";
                textBoxViewEditRevenue.Text = "";
                comboBoxViewEditTL.Items.Clear();

                if (this.treeViewEmployee.TopNode != null)
                {
                    ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
                }
            }
            else if (comboBoxMode.SelectedItem == "Add")
            {
                textBoxAddPN.Enabled = true;
                textBoxAddRevenue.Enabled = true;
                comboBoxAddTL.Enabled = false;
                buttonAddSearchForTeams.Enabled = true;
                buttonCancel.Enabled = true;
                buttonConfirmAdd.Enabled = true;

                textBoxUUID.Enabled = false;
                textBoxViewEditPN.Enabled = false;
                textBoxViewEditRevenue.Enabled = false;
                comboBoxViewEditTL.Enabled = false;
                buttonViewEditSearchForTeams.Enabled = false;
                buttonConfirmEdit.Enabled = false;
                buttonDelete.Enabled = false;

                textBoxAddPN.Text = "";
                textBoxAddRevenue.Text = "";
                comboBoxAddTL.Items.Clear();

                textBoxUUID.Text = "";
                textBoxViewEditPN.Text = "";
                textBoxViewEditRevenue.Text = "";
                comboBoxViewEditTL.Items.Clear();

                if (this.treeViewEmployee.TopNode != null)
                {
                    ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
                }
            }
            else if (comboBoxMode.SelectedItem == "Edit")
            {
                textBoxAddPN.Enabled = false;
                textBoxAddRevenue.Enabled = false;
                comboBoxAddTL.Enabled = false;
                buttonAddSearchForTeams.Enabled = false;
                buttonCancel.Enabled = false;
                buttonConfirmAdd.Enabled = false;

                textBoxUUID.Enabled = false;
                textBoxViewEditPN.Enabled = true;
                textBoxViewEditRevenue.Enabled = true;
                comboBoxViewEditTL.Enabled = false;
                buttonViewEditSearchForTeams.Enabled = true;
                buttonConfirmEdit.Enabled = true;
                buttonDelete.Enabled = true;

                textBoxAddPN.Text = "";
                textBoxAddRevenue.Text = "";
                comboBoxAddTL.Items.Clear();

                textBoxUUID.Text = "";
                textBoxViewEditPN.Text = "";
                textBoxViewEditRevenue.Text = "";
                comboBoxViewEditTL.Items.Clear();

                if (this.treeViewEmployee.TopNode != null)
                {
                    ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
                }
            }
        }

        private void buttonAddSearchForTeams_Click(object sender, EventArgs e)
        {
            string revenueStr = textBoxAddRevenue.Text;
            int revenue = 0;

            try
            {
                revenue = int.Parse(revenueStr);
            }
            catch (FormatException Ex)
            {
                if (revenueStr == "" || revenueStr == null)
                {
                    MessageBox.Show("Please enter revenue!");
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter an integer!");
                    return;
                }
            }

            TreeNode rootNode = this.treeViewEmployee.TopNode;
            EmployeeTreeNode empRootNode = (EmployeeTreeNode)rootNode;
            List<EmployeeTreeNode> empTreeNodes = new List<EmployeeTreeNode>();
            List<EmployeeTreeNode> empNodesWithinRevenue = new List<EmployeeTreeNode>();

            empTreeNodes = empRootNode.SearchEmpWithRole(empRootNode, "Project Leader", empTreeNodes);
            for (int i = 0; i < empTreeNodes.Count; i++)
            {
                List<int> parentEmpSalaries = new List<int>();
                int totalSalary = 0;

                int childEmpSalaries = GetTotalSalaryOfChildren(empTreeNodes[i]);
                totalSalary += childEmpSalaries;
                parentEmpSalaries = GetTotalSalaryOfParents(empTreeNodes[i], parentEmpSalaries);

                for (int j = 0; j < parentEmpSalaries.Count; j++)
                {
                    totalSalary += parentEmpSalaries[j];
                }

                if (totalSalary <= revenue)
                {
                    empNodesWithinRevenue.Add(empTreeNodes[i]);
                }
            }

            if (empNodesWithinRevenue.Count == 0)
            {
                ChangeHighlightedNodes(rootNode);
                MessageBox.Show("No employees found!");
            }
            else
            {
                ChangeHighlightedNodes(rootNode);
                for (int i = 0; i < empNodesWithinRevenue.Count; i++)
                {
                    if (empNodesWithinRevenue[i].ProjectListEmp.Count == 0)
                    {
                        empNodesWithinRevenue[i].BackColor = Color.Yellow;
                    }
                }
            }

            comboBoxAddTL.Items.Clear();
            for (int i = 0; i < empNodesWithinRevenue.Count; i++)
            {
                if (empNodesWithinRevenue[i].ProjectListEmp.Count == 0)
                {
                    comboBoxAddTL.Items.Add(empNodesWithinRevenue[i].Employee.Name);
                }
            }
            comboBoxAddTL.Enabled = true;
        }

        private void textBoxAddRevenue_TextChanged(object sender, EventArgs e)
        {
            comboBoxAddTL.Items.Clear();
            comboBoxAddTL.Enabled = false;
        }

        private void ChangeHighlightedNodes(TreeNode rootNode)
        {
            foreach(TreeNode childNode in rootNode.Nodes)
            {
                rootNode.BackColor = Color.White;
                childNode.BackColor = Color.White;
                ChangeHighlightedNodes(childNode);
            }
        }

        private int GetTotalSalaryOfChildren(EmployeeTreeNode empTreeNode)
        {
            int childEmpSalaries = 0;
            if (empTreeNode.ChildEmpTreeNodes != null)
            {
                for (int i = 0; i < empTreeNode.ChildEmpTreeNodes.Count; i++)
                {
                    childEmpSalaries += empTreeNode.ChildEmpTreeNodes[i].Employee.Salary;
                }
            }
            return childEmpSalaries;
        }

        private List<int> GetTotalSalaryOfParents(EmployeeTreeNode empTreeNode, List<int> parentEmpSalaries)
        {
            if (empTreeNode.ParentEmpTreeNode != null)
            {
                if (empTreeNode.ParentEmpTreeNode.RoleTreeNode.Role.Name != null)
                {
                    parentEmpSalaries.Add(empTreeNode.Employee.Salary);
                    GetTotalSalaryOfParents(empTreeNode.ParentEmpTreeNode, parentEmpSalaries);
                }
            }
            return parentEmpSalaries;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
            comboBoxMode.SelectedItem = "View";
        }

        private void buttonConfirmAdd_Click(object sender, EventArgs e)
        {
            ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
            string projectName = textBoxAddPN.Text;
            string revenueStr = textBoxAddRevenue.Text;
            int revenue = 0;
            string teamLeaderName = comboBoxAddTL.Text;

            if (projectName == "" || projectName == null)
            {
                MessageBox.Show("Please enter name!");
                return;
            }

            try
            {
                revenue = int.Parse(revenueStr);
            }
            catch (FormatException Ex)
            {
                if (revenueStr == "" || revenueStr == null)
                {
                    MessageBox.Show("Please enter revenue!");
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter an integer!");
                    return;
                }
            }

            if (teamLeaderName == "" || teamLeaderName == null)
            {
                MessageBox.Show("Please select a team leader!");
                return;
            }

            EmployeeTreeNode rootEmpNode = (EmployeeTreeNode)this.treeViewEmployee.TopNode;
            List<EmployeeTreeNode> foundNode = new List<EmployeeTreeNode>();
            foundNode = rootEmpNode.SearchEmpWithName(rootEmpNode, teamLeaderName, "Project Leader", foundNode);
            Project project = new Project(projectName, revenue, foundNode[0]);
            _projectsList.Add(project);

            // 0 because I assume that all employee names are unique and therefore get back one empTreeNode in foundNode.
            foundNode[0].ProjectListEmp.Add(project);
            SetProjectsForChildren(foundNode[0], project);
            SetProjectsForParents(foundNode[0], project);

            textBoxAddPN.Text = "";
            textBoxAddRevenue.Text = "";
            comboBoxAddTL.Items.Clear();
            textBoxConsole.Text = "Project Added:\r\nName: " + project.Name + "\r\nRevenue: $" + project.Revenue + "\r\nTeam Leader: " + project.TeamLeader.Employee.Name + "\r\n";

            string[] projectDetailsArr = { project.UUID, project.Name, "S$" + project.Revenue.ToString(), project.TeamLeader.Employee.Name };
            ListViewItem listViewItem = new ListViewItem(projectDetailsArr);
            listViewProject.Items.Add(listViewItem);

            comboBoxMode.SelectedItem = "View";
        }

        private void SetProjectsForChildren(EmployeeTreeNode empTreeNode, Project project)
        {
            if (empTreeNode.ChildEmpTreeNodes != null)
            {
                for (int i = 0; i < empTreeNode.ChildEmpTreeNodes.Count; i++)
                {
                    empTreeNode.ChildEmpTreeNodes[i].ProjectListEmp.Add(project);
                }
            }
        }

        private void SetProjectsForParents(EmployeeTreeNode empTreeNode, Project project)
        {
            if (empTreeNode.ParentEmpTreeNode != (EmployeeTreeNode)this.treeViewEmployee.TopNode)
            {
                if (empTreeNode.ParentEmpTreeNode.RoleTreeNode.Role.Name != null)
                {
                    empTreeNode.ParentEmpTreeNode.ProjectListEmp.Add(project);
                    SetProjectsForParents(empTreeNode.ParentEmpTreeNode, project);
                }
            }
        }

        private void listViewProject_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _currentSelectedListViewItem = e.Item;
            if (_currentSelectedListViewItem != null)
            {
                textBoxUUID.Text = _currentSelectedListViewItem.SubItems[0].Text;
                textBoxViewEditPN.Text = _currentSelectedListViewItem.SubItems[1].Text;
                textBoxViewEditRevenue.Text = _currentSelectedListViewItem.SubItems[2].Text.Remove(0, 2);
                comboBoxViewEditTL.Items.Clear();
                if (!comboBoxViewEditTL.Items.Contains(_currentSelectedListViewItem.SubItems[3].Text))
                {
                    comboBoxViewEditTL.Items.Add(_currentSelectedListViewItem.SubItems[3].Text);
                }
                comboBoxViewEditTL.SelectedItem = _currentSelectedListViewItem.SubItems[3].Text;
            }
        }

        private void buttonViewEditSearchForTeams_Click(object sender, EventArgs e)
        {
            string uuid = textBoxUUID.Text;
            string revenueStr = textBoxViewEditRevenue.Text;
            int revenue = 0;

            try
            {
                revenue = int.Parse(revenueStr);
            }
            catch (FormatException Ex)
            {
                if (revenueStr == "" || revenueStr == null)
                {
                    MessageBox.Show("Please enter revenue!");
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter an integer!");
                    return;
                }
            }

            TreeNode rootNode = this.treeViewEmployee.TopNode;
            EmployeeTreeNode empRootNode = (EmployeeTreeNode)rootNode;
            List<EmployeeTreeNode> empTreeNodes = new List<EmployeeTreeNode>();
            List<EmployeeTreeNode> empNodesWithinRevenue = new List<EmployeeTreeNode>();

            empTreeNodes = empRootNode.SearchEmpWithRole(empRootNode, "Project Leader", empTreeNodes);
            for (int i = 0; i < empTreeNodes.Count; i++)
            {
                List<int> parentEmpSalaries = new List<int>();
                int totalSalary = 0;

                int childEmpSalaries = GetTotalSalaryOfChildren(empTreeNodes[i]);
                totalSalary += childEmpSalaries;
                parentEmpSalaries = GetTotalSalaryOfParents(empTreeNodes[i], parentEmpSalaries);

                for (int j = 0; j < parentEmpSalaries.Count; j++)
                {
                    totalSalary += parentEmpSalaries[j];
                }

                if (totalSalary <= revenue)
                {
                    empNodesWithinRevenue.Add(empTreeNodes[i]);
                }
            }

            if (empNodesWithinRevenue.Count == 0)
            {
                ChangeHighlightedNodes(rootNode);
                MessageBox.Show("No employees found!");
            }
            else
            {
                ChangeHighlightedNodes(rootNode);
                for (int i = 0; i < empNodesWithinRevenue.Count; i++)
                {
                    foreach (Project project in empNodesWithinRevenue[i].ProjectListEmp)
                    {
                        if (project.UUID == uuid)
                        {
                            empNodesWithinRevenue[i].BackColor = Color.Yellow;
                        }
                    }
                    if (empNodesWithinRevenue[i].ProjectListEmp.Count == 0)
                    {
                        empNodesWithinRevenue[i].BackColor = Color.Yellow;
                    }
                }
            }

            comboBoxViewEditTL.Items.Clear();
            for (int i = 0; i < empNodesWithinRevenue.Count; i++)
            {
                foreach (Project project in empNodesWithinRevenue[i].ProjectListEmp)
                {
                    if (project.UUID == uuid)
                    {
                        comboBoxViewEditTL.Items.Add(empNodesWithinRevenue[i].Employee.Name);
                    }
                }
                if (empNodesWithinRevenue[i].ProjectListEmp.Count == 0)
                {
                    comboBoxViewEditTL.Items.Add(empNodesWithinRevenue[i].Employee.Name);
                }
            }
            comboBoxViewEditTL.Enabled = true;
        }

        private void textBoxViewEditRevenue_TextChanged(object sender, EventArgs e)
        {
            comboBoxViewEditTL.Items.Clear();
            comboBoxViewEditTL.Enabled = false;
        }

        private void buttonConfirmEdit_Click(object sender, EventArgs e)
        {
            ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
            string uuid = textBoxUUID.Text;
            string projectName = textBoxViewEditPN.Text;
            string revenueStr = textBoxViewEditRevenue.Text;
            int revenue = 0;
            string teamLeaderName = comboBoxViewEditTL.Text;

            if (projectName == "" || projectName == null)
            {
                MessageBox.Show("Please enter name!");
                return;
            }

            try
            {
                revenue = int.Parse(revenueStr);
            }
            catch (FormatException Ex)
            {
                if (revenueStr == "" || revenueStr == null)
                {
                    MessageBox.Show("Please enter revenue!");
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter an integer!");
                    return;
                }
            }

            if (teamLeaderName == "" || teamLeaderName == null)
            {
                MessageBox.Show("Please select a team leader!");
                return;
            }

            EmployeeTreeNode rootEmpNode = (EmployeeTreeNode)this.treeViewEmployee.TopNode;
            List<EmployeeTreeNode> foundNode = new List<EmployeeTreeNode>();
            foundNode = rootEmpNode.SearchEmpWithName(rootEmpNode, teamLeaderName, "Project Leader", foundNode);
            EmployeeTreeNode prevEmpTreeNodeWithProject = GetTeamLeader(uuid);
            Project project = prevEmpTreeNodeWithProject.ProjectListEmp[0];
            prevEmpTreeNodeWithProject.ProjectListEmp.Clear();
            RemoveProjectsForChildren(prevEmpTreeNodeWithProject);
            RemoveProjectForParents(prevEmpTreeNodeWithProject, uuid);
            project.Name = projectName;
            project.Revenue = revenue;
            // 0 because I assume that all employee names are unique and therefore get back one empTreeNode in foundNode.
            project.TeamLeader = foundNode[0];
            foundNode[0].ProjectListEmp.Add(project);
            SetProjectsForChildren(foundNode[0], project);
            SetProjectsForParents(foundNode[0], project);
            textBoxConsole.Text = "Existing Project Edited:\r\nName: " + project.Name + "\r\nRevenue: $" + project.Revenue + "\r\nTeam Leader: " + project.TeamLeader.Employee.Name + "\r\n";

            ListViewItem tempListViewItem = new ListViewItem();
            for (int i = 0; i < listViewProject.Items.Count; i++)
            {
                if (listViewProject.Items[i].Text == uuid)
                {
                    tempListViewItem = listViewProject.Items[i];
                }
            }
            tempListViewItem.SubItems[1].Text = projectName;
            tempListViewItem.SubItems[2].Text = "S$" + revenueStr;
            tempListViewItem.SubItems[3].Text = teamLeaderName;
            comboBoxMode.SelectedItem = "View";
        }

        private void RemoveProjectsForChildren(EmployeeTreeNode empTreeNode)
        {
            if (empTreeNode.ChildEmpTreeNodes != null)
            {
                for (int i = 0; i < empTreeNode.ChildEmpTreeNodes.Count; i++)
                {
                    for ( int j = 0; j < empTreeNode.ChildEmpTreeNodes[i].ProjectListEmp.Count; j++)
                    {
                        empTreeNode.ChildEmpTreeNodes[i].ProjectListEmp.Remove(empTreeNode.ChildEmpTreeNodes[i].ProjectListEmp[j]);
                    }
                }
            }
        }

        private void RemoveProjectForParents(EmployeeTreeNode empTreeNode, string uuid)
        {
            if (empTreeNode.ParentEmpTreeNode != (EmployeeTreeNode)this.treeViewEmployee.TopNode)
            {
                if (empTreeNode.ParentEmpTreeNode.RoleTreeNode.Role.Name != null)
                {
                    for (int i = 0; i < empTreeNode.ParentEmpTreeNode.ProjectListEmp.Count; i++)
                    {
                        if (empTreeNode.ParentEmpTreeNode.ProjectListEmp[i] != null)
                        {
                            if (empTreeNode.ParentEmpTreeNode.ProjectListEmp[i].UUID == uuid)
                            {
                                empTreeNode.ParentEmpTreeNode.ProjectListEmp.Remove(empTreeNode.ParentEmpTreeNode.ProjectListEmp[i]);
                            }
                        }
                    }
                    RemoveProjectForParents(empTreeNode.ParentEmpTreeNode, uuid);
                }
            }
        }

        private EmployeeTreeNode GetTeamLeader(string uuid)
        {
            for (int i = 0; i < _projectsList.Count; i++)
            {
                if (_projectsList[i].UUID == uuid)
                {
                    return _projectsList[i].TeamLeader;
                }
            }
            return null;
        }

        public void buttonExpand_Click(object sender, EventArgs e)
        {
            this.treeViewEmployee.ExpandAll();
            /*EmployeeTreeNode x = (EmployeeTreeNode)this.treeViewEmployee.SelectedNode;
            PrintEmpTreeFromSelectedNode(x, " ", false);*/
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
                listViewProject.Items.Clear();
                textBoxConsole.Text = "";
                comboBoxMode.SelectedItem = "View";
                MessageBox.Show("Form was reset!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            rootEmpTreeNode.ProjectList = _projectsList;
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
                _projectsList = empManager.EmpTreeStructure.ProjectList;
            }
            else
            {
                MessageBox.Show("No file to load. Save tree view to file first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.treeViewEmployee.ExpandAll();

            listViewProject.Clear();
            CreateListViewColumns();
            for (int i = 0; i < _projectsList.Count; i++)
            {
                string[] projectDetailsArr = { _projectsList[i].UUID, _projectsList[i].Name, "S$" + _projectsList[i].Revenue.ToString(), _projectsList[i].TeamLeader.Employee.Name };
                ListViewItem listViewItem = new ListViewItem(projectDetailsArr);
                listViewProject.Items.Add(listViewItem);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ChangeHighlightedNodes(this.treeViewEmployee.TopNode);
            string uuid = textBoxUUID.Text;
            Project projectWithUUID;
            EmployeeTreeNode empWithProject = new EmployeeTreeNode();
            int projectIndex = 0;

            if (uuid == "" || uuid == null)
            {
                MessageBox.Show("Please select a project to delete!");
                return;
            }

            for (int i = 0; i < _projectsList.Count; i++)
            {
                if (_projectsList[i].UUID == uuid)
                {
                    projectWithUUID = _projectsList[i];
                    empWithProject = projectWithUUID.TeamLeader;
                    projectIndex = i;
                    break;
                }
            }

            RemoveProjectsForChildren(empWithProject);
            RemoveProjectForParents(empWithProject, uuid);
            empWithProject.ProjectListEmp.Remove(_projectsList[projectIndex]);
            textBoxConsole.Text = "Project Deleted:\r\nName: " + _projectsList[projectIndex].Name + "\r\nRevenue: $" + _projectsList[projectIndex].Revenue + "\r\nTeam Leader: " + _projectsList[projectIndex].TeamLeader.Employee.Name + "\r\n";
            for (int i = 0; i < listViewProject.Items.Count; i++)
            {
                if (listViewProject.Items[i].Text == uuid)
                {
                    listViewProject.Items.Remove(listViewProject.Items[i]);
                }
            }
            _projectsList.Remove(_projectsList[projectIndex]);
            comboBoxMode.SelectedItem = "View";
        }
    }
}
