using ProjectManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class AddEmployee : Form
    {
        public delegate void AddEmployeeDelegate(string name, int salary, TreeNode TreeNode);
        public AddEmployeeDelegate AddEmployeeCallBack;
        private List<RoleTreeNode> _dropDownRoles;
        private RoleTreeNode _selectedRoleNode;
        private EmployeeTreeNode _selectedEmpNode;
        public AddEmployee()
        {
            InitializeComponent();
        }

        public AddEmployee(TreeNode selectedTreeNode, string RO)
        {
            InitializeComponent();
            textBoxRO.Text = RO;
            EmployeeTreeNode empTreeNode = (EmployeeTreeNode)selectedTreeNode;
            _selectedEmpNode = empTreeNode;
            _selectedRoleNode = empTreeNode.RoleTreeNode;
            List<RoleTreeNode> childRoleTreeNodes = empTreeNode.RoleTreeNode.ChildRoleTreeNodes;
            _dropDownRoles = childRoleTreeNodes;
            for (int i = 0; i < childRoleTreeNodes.Count; i++)
            {
                if (!comboBoxRole.Items.Contains(childRoleTreeNodes[i].Role.Name))
                {
                    comboBoxRole.Items.Add(childRoleTreeNodes[i].Role.Name);
                }
            }
        }

        private void checkBoxDummy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDummy.Checked == true)
            {
                textBoxName.Enabled = false;
                textBoxName.Text = "Dummy";
            }
            else
            {
                textBoxName.Enabled = true;
                textBoxName.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string salaryStr = textBoxSalary.Text;
            int salary;
            string roleName = (string)comboBoxRole.SelectedItem;
            bool isDummy = checkBoxDummy.Checked;

            for (int i = 0; i < _dropDownRoles.Count; i++)
            {
                if (_dropDownRoles[i].Role.Name == roleName)
                {
                    _selectedRoleNode = _dropDownRoles[i];
                    break;
                }
            }

            TreeNode selectedTreeNode = _selectedRoleNode;

            try
            {
                salary = int.Parse(salaryStr);
            }
            catch (FormatException Ex)
            {
                MessageBox.Show("Please enter a number!");
                return;
            }

            if (salary <= 0)
            {
                MessageBox.Show("Employee salary must not be 0 or less. Please enter a valid employee salary.", "Invalid Employee Salary");
                return;
            }

            if (salary > _selectedEmpNode.Employee.Salary && _selectedEmpNode.Employee.Salary != 0)
            {
                MessageBox.Show("Employee salary should not be higher than reporting officer's salary.");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("Employee name cannot be empty!");
                return;
            }

            if (name == "Dummy" && isDummy == false)
            {
                MessageBox.Show("Employee name cannot be \"Dummy\" because it is being used to identify dummy tree nodes. Please pick another name.");
                return;
            }

            if (roleName == "" || roleName == null)
            {
                MessageBox.Show("Role name cannot be empty!");
                return;
            }
            AddEmployeeCallBack(name, salary, selectedTreeNode);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
