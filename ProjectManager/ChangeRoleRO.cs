using ProjectManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager
{
    internal partial class ChangeRoleRO : Form
    {
        public delegate void ChangeRoleRODelegate(string newEmpName, int newSalary, EmployeeTreeNode newEmpTreeNode, bool isDummy);
        public ChangeRoleRODelegate ChangeRoleROCallBack;
        // private List<RoleTreeNode> _dropDownRoles;
        // private RoleTreeNode _roleTreeStructure;
        private EmployeeTreeNode _dropDownEmp;
        private EmployeeTreeNode _selectedEmpNode;
        private List<string> _roleNames = new List<string>();
        private List<EmployeeTreeNode> _empTreeNodes = new List<EmployeeTreeNode>();
        private List<RoleTreeNode> _roleTreeNodes = new List<RoleTreeNode>();
        private EmployeeTreeNode _empTreeStructure;

        public ChangeRoleRO()
        {
            InitializeComponent();
        }

        public ChangeRoleRO(TreeNode selectedTreeNode, string uuid, string RO, string name, string salary, string role, TreeNode rootNode)
        {
            InitializeComponent();
            EmployeeTreeNode empTreeNode = (EmployeeTreeNode)selectedTreeNode;
            _selectedEmpNode = empTreeNode;
            _empTreeStructure = (EmployeeTreeNode)rootNode;

            GetEmpTreeNodes(_empTreeStructure);
            GetRoleNames(_empTreeNodes);
            if (empTreeNode.ParentEmpTreeNode != null)
            {
                EmployeeTreeNode parentEmpTreeNode = empTreeNode.ParentEmpTreeNode;
                _dropDownEmp = parentEmpTreeNode;
                comboBoxRO.Items.Add(parentEmpTreeNode.Employee.Name);
            }

            for (int i = 0; i < _roleNames.Count; i++)
            {
                if (!comboBoxRole.Items.Contains(_roleNames[i]))
                {
                    if (!(_roleNames[i] == rootNode.TreeView.TopNode.Name))
                    {
                        comboBoxRole.Items.Add(_roleNames[i]);
                    }
                }
            }

            textBoxUUID.Text = uuid;
            comboBoxRO.Text = _dropDownEmp.Employee.Name;
            textBoxName.Text = name;
            textBoxSalary.Text = salary;
            comboBoxRole.Text = role;
            if (name == "Dummy")
            {
                checkBoxDummy.Checked = true;
            }
            else
            {
                checkBoxDummy.Checked = false;
            }
        }

        private void GetEmpTreeNodes(EmployeeTreeNode empTreeNode)
        {
            EmployeeTreeNode tree = empTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                if (tree.ChildEmpTreeNodes != null)
                {
                    numberOfChildNodes = tree.ChildEmpTreeNodes.Count;
                    _empTreeNodes.Add(tree);
                }
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the GetEmpTreeNodes method
                GetEmpTreeNodes(tree.ChildEmpTreeNodes[i]);
            }//End of for loop
        }//End of GetEmpTreeNodes

        private void GetRoleNames(List<EmployeeTreeNode> empTreeNodes)
        {
            for (int i = 0; i < empTreeNodes.Count; i++)
            {
                _roleTreeNodes.Add(empTreeNodes[i].RoleTreeNode);
                if (!_roleNames.Contains(empTreeNodes[i].RoleTreeNode.Role.Name))
                {
                    if (empTreeNodes[i].RoleTreeNode.Role.Name == _empTreeStructure.TreeView.TopNode.Name)
                    {
                        _roleNames.Add(empTreeNodes[i].RoleTreeNode.Role.Name);
                    }
                    else
                    {
                        _roleNames.Add(empTreeNodes[i].RoleTreeNode.Role.Name);
                    }
                }
            }
        }//End of GetRoleNames

        private void comboBoxRole_Click(object sender, EventArgs e)
        {
            comboBoxRO.Items.Clear();
        }

        private void comboBoxRO_Click(object sender, EventArgs e)
        {
            string newRole = comboBoxRole.SelectedItem.ToString();
            List<EmployeeTreeNode> empWithRole = GetEmpTreeNodes(newRole);

            for (int i = 0; i < empWithRole.Count; i++)
            {
                if (empWithRole[i] != null)
                {
                    if (!comboBoxRO.Items.Contains(empWithRole[i].Employee.Name))
                    {
                        comboBoxRO.Items.Add(empWithRole[i].Employee.Name);
                    }
                }
            }
        }

        private List<EmployeeTreeNode> GetEmpTreeNodes(string newRole)
        {
            List<EmployeeTreeNode> empTreeNodes = new List<EmployeeTreeNode>();
            for (int i = 0; i < _empTreeNodes.Count; i++)
            {
                /*if (_empTreeNodes[i].RoleTreeNode.Role.Name == newRole)
                {
                    empTreeNodes.Add(_empTreeNodes[i]);
                }*/
                if (_empTreeNodes[i].RoleTreeNode != null)
                {
                    if (_empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes.Count > 0)
                    {
                        for (int j = 0; j < _empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes.Count; j++)
                        {
                            if (_empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes[j].Role.Name == newRole)
                            {
                                empTreeNodes.Add(_empTreeNodes[i]);
                            }
                        }
                    }
                }
            }
            return empTreeNodes;
        }

        public RoleTreeNode SearchRoleUsingEmpNameAndRoleName(string empName, string roleName)
        {
            RoleTreeNode roleTreeNode = new RoleTreeNode();
            for (int i = 0; i < _empTreeNodes.Count; i++)
            {
                if (_empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes.Count > 0)
                {
                    for (int j = 0; j < _empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes.Count; j++)
                    {
                        if (_empTreeNodes[i].Employee.Name == empName && _empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes[j].Role.Name == roleName)
                        {
                            roleTreeNode = _empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes[j];
                        }
                    }
                }
            }
            return roleTreeNode;
        }

        public EmployeeTreeNode SearchEmpUsingEmpNameAndRoleName(string empName, string roleName)
        {
            EmployeeTreeNode empTreeNode = new EmployeeTreeNode();
            for (int i = 0; i < _empTreeNodes.Count; i++)
            {
                if (_empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes.Count > 0)
                {
                    for (int j = 0; j < _empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes.Count; j++)
                    {
                        if (_empTreeNodes[i].Employee.Name == empName && _empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes[j].Role.Name == roleName)
                        {
                            empTreeNode = _empTreeNodes[i];
                        }
                    }
                }
            }
            return empTreeNode;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string salaryStr = textBoxSalary.Text;
            int salary;
            string roleName = (string)comboBoxRole.SelectedItem;
            string empROName = (string)comboBoxRO.SelectedItem;
            bool isDummy = checkBoxDummy.Checked;

            try
            {
                salary = int.Parse(textBoxSalary.Text);
            }
            catch (FormatException Ex)
            {
                MessageBox.Show("Employee salary is not a number!");
                return;
            }

            if (salary <= 0)
            {
                MessageBox.Show("Employee salary is 0 or less.", "Invalid Employee Salary");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Employee name is empty!");
                return;
            }

            if (roleName == "" || roleName == null)
            {
                MessageBox.Show("Role cannot be empty!");
                return;
            }

            if (empROName == "" || empROName == null)
            {
                MessageBox.Show("Reporting Officer cannot be empty!");
                return;
            }

            Employee selectedEmp = _selectedEmpNode.Employee;
            RoleTreeNode newRoleTreeNode = new RoleTreeNode();
            EmployeeTreeNode newEmpTreeNode = new EmployeeTreeNode();
            RoleTreeNode[] roleTreeNodeArr = new RoleTreeNode[2];

            newEmpTreeNode.Employee = selectedEmp;
            newEmpTreeNode.ChildEmpTreeNodes = new List<EmployeeTreeNode>();
            newEmpTreeNode.RoleTreeNode = _selectedEmpNode.RoleTreeNode;
            RoleTreeNode foundRole = SearchRoleUsingEmpNameAndRoleName(empROName, roleName);
            newRoleTreeNode = foundRole;
            EmployeeTreeNode foundEmp = SearchEmpUsingEmpNameAndRoleName(empROName, roleName);
            newEmpTreeNode.ParentEmpTreeNode = foundEmp;
            roleTreeNodeArr[0] = _selectedEmpNode.RoleTreeNode;
            roleTreeNodeArr[1] = newRoleTreeNode;
            newEmpTreeNode.RoleTreeNodes = roleTreeNodeArr;

            newEmpTreeNode.Text = newEmpTreeNode.Employee.Name + " - " + newEmpTreeNode.RoleTreeNodes[0].Role.Name + ", " + newEmpTreeNode.RoleTreeNodes[1].Role.Name + " (S$" + newEmpTreeNode.Employee.Salary + ")";
            newEmpTreeNode.Name = newEmpTreeNode.Employee.Name + " - " + newEmpTreeNode.RoleTreeNodes[0].Role.Name + ", " + newEmpTreeNode.RoleTreeNodes[1].Role.Name + " (S$" + newEmpTreeNode.Employee.Salary + ")";
            ChangeRoleROCallBack(name, salary, newEmpTreeNode, isDummy);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
