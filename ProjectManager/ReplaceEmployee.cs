using ProjectManager.Classes;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager
{
    internal partial class ReplaceEmployee : Form
    {
        public delegate void ReplaceEmployeeDelegate(EmployeeTreeNode empNodeToReplace, EmployeeTreeNode empTreeNode);
        public ReplaceEmployeeDelegate ReplaceEmployeeCallBack;
        private TreeNode _currentSelectedNode;
        private EmployeeTreeNode _empNodeToReplace;

        public ReplaceEmployee()
        {
            InitializeComponent();
        }

        public ReplaceEmployee(TreeNode[] treeViewArr, EmployeeTreeNode empTreeNode)
        {
            InitializeComponent();
            treeViewEmployee.Nodes.Clear();
            if (treeViewArr != null)
            {
                _empNodeToReplace = empTreeNode;
                this.textBoxEmployeeToReplace.Text = empTreeNode.Employee.Name + " - " + empTreeNode.RoleTreeNode.Role.Name + " (S$" + empTreeNode.Employee.Salary + ")";
                this.treeViewEmployee.Nodes.AddRange(treeViewArr);
                this.treeViewEmployee.ExpandAll();
            }
            else
            {
                MessageBox.Show("No file to load. Save tree view to file first!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string uuid;
                    string RO;
                    string name = empTreeNode.Employee.Name;
                    string salary = empTreeNode.Employee.Salary.ToString();
                    string role = empTreeNode.RoleTreeNode.Role.Name;
                    string project = "No Projects";
                    bool isPL = empTreeNode.RoleTreeNode.Role.IsPL;

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
                }
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (_currentSelectedNode != null)
            {
                EmployeeTreeNode empTreeNode = (EmployeeTreeNode)_currentSelectedNode;
                TreeNode rootNode = treeViewEmployee.SelectedNode;
                while (rootNode.Parent != null)
                {
                    rootNode = rootNode.Parent;
                }
                EmployeeTreeNode rootEmpNode = (EmployeeTreeNode)rootNode;
                if (empTreeNode.Employee.Name == rootNode.Name)
                {
                    MessageBox.Show(new Form { TopMost = true }, "Cannot swap Root Node!", "Restricted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                ReplaceEmployeeCallBack(_empNodeToReplace, empTreeNode);
                this.DialogResult = DialogResult.OK;

                /*string roleName = rootEmpNode.ChildEmpTreeNodes[0].RoleTreeNode.Role.Name;
                string trimmedEmpRoleName = roleName.Replace(" ", "").ToLower();
                string[] empTreeNodeNameArr = EmployeeWithRoleName(empTreeNode, 0, trimmedEmpRoleName);
                string[] _empNodeToReplaceNameArr = EmployeeWithRoleName(_empNodeToReplace, 0, trimmedEmpRoleName);
                if (empTreeNodeNameArr[1] == "-1" || _empNodeToReplaceNameArr[1] == "-1")
                {
                    MessageBox.Show(new Form { TopMost = true }, "Something went wrong. No roles with the name \"" + roleName + "\" found.", "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (empTreeNode.Level == 1)
                {
                    ReplaceEmployeeCallBack(_empNodeToReplace, empTreeNode);
                }
                else if (empTreeNodeNameArr[0] == _empNodeToReplaceNameArr[0])
                {
                    int empTreeNodeLevel = int.Parse(empTreeNodeNameArr[1]) + 1;
                    int _empNodeToReplaceLevel = int.Parse(_empNodeToReplaceNameArr[1]) + 1;
                    string empTreeNodeName = EmpRoleAtLevel(empTreeNode, empTreeNodeLevel);
                    string _empNodeToReplaceName = EmpRoleAtLevel(_empNodeToReplace, _empNodeToReplaceLevel);

                    if (empTreeNodeName == _empNodeToReplaceName)
                    {
                        ReplaceEmployeeCallBack(_empNodeToReplace, empTreeNode);
                    }
                }
                else
                {
                    MessageBox.Show(new Form { TopMost = true }, "Cannot swap employees of different cluster head!", "Restricted", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }*/
            }
        }

        /*private string EmpRoleAtLevel(EmployeeTreeNode empTreeNode, int levels)
        {
            if (levels == 0)
            {
                return empTreeNode.Employee.Name;
            }
            if (empTreeNode != null)
            {
                return EmpRoleAtLevel(empTreeNode.ParentEmpTreeNode, --levels);
            }
            else
            {
                return "";
            }
        }*/

        /*private string[] EmployeeWithRoleName(EmployeeTreeNode empTreeNode, int levels, string roleName)
        {
            if (empTreeNode != null)
            {
                if (empTreeNode.ParentEmpTreeNode != null)
                {
                    for (int i = 0; i < empTreeNode.ParentEmpTreeNode.ChildEmpTreeNodes.Count; i++)
                    {
                        string asdf = empTreeNode.ParentEmpTreeNode.ChildEmpTreeNodes[i].RoleTreeNode.Name;
                        string qwer = asdf.Replace(" ", "").ToLower();
                        if (qwer == roleName)
                        {
                            string[] empTreeNodeArr = { empTreeNode.ParentEmpTreeNode.ChildEmpTreeNodes[i].Employee.Name, levels.ToString() };
                            return empTreeNodeArr;
                        }
                    }
                }

                string trimmedEmpRoleName = empTreeNode.RoleTreeNode.Role.Name.Replace(" ", "").ToLower();
                if (trimmedEmpRoleName == roleName)
                {
                    string[] empTreeNodeArr = { empTreeNode.Employee.Name, levels.ToString() };
                    return empTreeNodeArr;
                }
                return EmployeeWithRoleName(empTreeNode.ParentEmpTreeNode, ++levels, roleName);
            }
            else
            {
                string[] empTreeNodeArr = { "", (-1).ToString() };
                return empTreeNodeArr;
            }
        }*/

        private void ReplaceEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.treeViewEmployee.Nodes.Clear();
        }
    }
}
