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
    public partial class EditEmployee : Form
    {
        public delegate void EditEmployeeDelegate(string newEmpName, int newSalary);
        public EditEmployeeDelegate EditEmployeeCallBack;
        private int _parentSalary;
        private EmployeeTreeNode _currentSelectedNode;

        public EditEmployee()
        {
            InitializeComponent();
        }

        public EditEmployee(string uuid, string RO, string name, string salary, string role, string parentSalary, TreeNode currentSelectedNode)
        {
            InitializeComponent();
            _currentSelectedNode = (EmployeeTreeNode)currentSelectedNode;
            this._parentSalary = int.Parse(parentSalary);
            textBoxUUID.Text = uuid;
            textBoxRO.Text = RO;
            textBoxName.Text = name;
            textBoxSalary.Text = salary;
            textBoxRole.Text = role;
            if (name == "Dummy")
            {
                textBoxName.Enabled = false;
                checkBoxDummy.Checked = true;
            }
        }

        private void checkBoxDummy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDummy.Checked == true)
            {
                textBoxName.Text = "Dummy";
                textBoxName.Enabled = false;
            }
            else
            {
                textBoxName.Text = "";
                textBoxName.Enabled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string salaryStr = textBoxSalary.Text;
            int salary;
            bool isDummy = checkBoxDummy.Checked;

            try
            {
                salary = int.Parse(textBoxSalary.Text);
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

            if (salary > _parentSalary && _parentSalary != 0)
            {
                MessageBox.Show("Employee salary should not be higher than reporting officer's salary.");
                return;
            }

            for (int i = 0; i < _currentSelectedNode.ChildEmpTreeNodes.Count; i++)
            {
                if (_currentSelectedNode.ChildEmpTreeNodes[i].RoleTreeNodes == null && salary < _currentSelectedNode.ChildEmpTreeNodes[i].Employee.Salary)
                {
                    MessageBox.Show("Employee salary should not be lower than the highest salary of children nodes.");
                    return;
                }
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
            EditEmployeeCallBack(name, salary);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
