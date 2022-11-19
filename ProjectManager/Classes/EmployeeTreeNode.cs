using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
//System.Windows.Forms namespace must be included so that TreeNode class
//can be recognized by the .NET engine.
using System.Windows.Forms;

namespace ProjectManager.Classes
{
    [Serializable]
    internal class EmployeeTreeNode : TreeNode, ISerializable
    {
        private EmployeeTreeNode _parentEmpTreeNode; // EmpTreeNode type object which describes the "Parent"
        private Employee _emp; // To hold the Employee object which describes one employee information
        private List<EmployeeTreeNode> _children; //A collection of EmployeeTreeNode type objects which describes the "Children"
        private RoleTreeNode _roleTreeNode; // RoleTreeNode type object which describes the EmployeeTreeNode object
        private RoleTreeNode[] _roleTreeNodeArr = new RoleTreeNode[2];
        private List<Project> _projectListEmp = new List<Project>();
        private List<Project> _projectList = new List<Project>();

        public EmployeeTreeNode(Employee employee, RoleTreeNode roleTreeNode)
        {
            _parentEmpTreeNode = null;
            _emp = employee;
            _children = new List<EmployeeTreeNode>();
            _roleTreeNode = roleTreeNode;
            _roleTreeNodeArr = null;
            this.Text = employee.Name;
        } // End of constructor

        public EmployeeTreeNode(Employee employee, RoleTreeNode[] roleTreeNodes)
        {
            _parentEmpTreeNode = null;
            _emp = employee;
            _children = new List<EmployeeTreeNode>();
            _roleTreeNode = this.RoleTreeNode;
            _roleTreeNodeArr = roleTreeNodes;
            this.Text = employee.Name;
        } // End of constructor

        public EmployeeTreeNode(RoleTreeNode roleTreeNode)
        {
            this.RoleTreeNode = roleTreeNode;
        }

        public EmployeeTreeNode()
        {
        }

        public EmployeeTreeNode ParentEmpTreeNode
        {
            get { return _parentEmpTreeNode; }
            set { _parentEmpTreeNode = value; }
        }

        public Employee Employee
        {
            get { return _emp; }
            set { _emp = value; }
        }

        public List<EmployeeTreeNode> ChildEmpTreeNodes
        {
            get { return _children; }
            set { _children = value; }
        }

        public RoleTreeNode RoleTreeNode
        {
            get { return _roleTreeNode; }
            set { _roleTreeNode = value; }
        }

        public RoleTreeNode[] RoleTreeNodes
        {
            get { return _roleTreeNodeArr; }
            set { _roleTreeNodeArr = value; }
        }

        public List<Project> ProjectList
        {
            get { return _projectList; }
            set { _projectList = value; }
        }

        public List<Project> ProjectListEmp
        {
            get { return _projectListEmp; }
            set { _projectListEmp = value; }
        }

        public void AddChildEmpTreeNode(EmployeeTreeNode empNode)
        {
            empNode.ParentEmpTreeNode = this;
            _children.Add(empNode);
            this.Nodes.Add(empNode);
        } // End of AddChildEmpTreeNode method

        public void UpdateEmpTreeNode(string newEmpName, int newSalary, bool isPL)
        {
            this.Text = newEmpName;
            this.Employee.Name = newEmpName;
            this.RoleTreeNode.Role.IsPL = isPL;
            this.Employee.Salary = newSalary;
        }

        public void DeleteEmpTreeNode(TreeNode rootNode, EmployeeTreeNode empTreeNode)
        {
            List<EmployeeTreeNode> foundNode = new List<EmployeeTreeNode>();
            EmployeeTreeNode rootEmpTreeNode = (EmployeeTreeNode)rootNode;
            foundNode = SearchEmpWithUUID(rootEmpTreeNode, empTreeNode.Employee.UUID, foundNode);
            for (int i = 0; i < foundNode.Count; i++)
            {
                if (foundNode[i].RoleTreeNode.Role.Name != empTreeNode.RoleTreeNode.Role.Name)
                {
                    foundNode[i].RoleTreeNodes = null;
                    foundNode[i].Text = foundNode[i].Employee.Name + " - " + foundNode[i].RoleTreeNode.Role.Name + " (S$" + foundNode[i].Employee.Salary + ")";
                }
            }
        }

        public void SwapTreeNodes(EmployeeTreeNode empNodeToReplace, EmployeeTreeNode selectedEmpNode)
        {
            empNodeToReplace.Employee = selectedEmpNode.Employee;

            TreeNode empTreeNodeToReplace = empNodeToReplace;

            if (empNodeToReplace.RoleTreeNodes != null)
            {
                if (empNodeToReplace.RoleTreeNodes[1] != null)
                {
                    selectedEmpNode.Text = selectedEmpNode.Employee.Name + " - " + empNodeToReplace.RoleTreeNodes[0].Role.Name + ", " + empNodeToReplace.RoleTreeNodes[1].Role.Name + " (S$" + empNodeToReplace.Employee.Salary + ")";
                }
            }
            else
            {
                selectedEmpNode.Text = selectedEmpNode.Employee.Name + " - " + empNodeToReplace.RoleTreeNode.Role.Name + " (S$" + empNodeToReplace.Employee.Salary + ")";
            }
            string selectedEmpTreeNodeText = selectedEmpNode.Text;
            empTreeNodeToReplace.Text = selectedEmpTreeNodeText;
        }

        public void UpdateNodes(List<EmployeeTreeNode> empTreeNodes, EmployeeTreeNode empTreeNode)
        {
            for (int i = 0; i < empTreeNodes.Count; i++)
            {
                if (empTreeNodes[i].RoleTreeNodes == null)
                {
                    empTreeNodes[i].Employee = empTreeNodes[i].Employee;
                    empTreeNodes[i].ChildEmpTreeNodes = empTreeNodes[i].ChildEmpTreeNodes;
                    empTreeNodes[i].RoleTreeNode = empTreeNodes[i].RoleTreeNode;
                    empTreeNodes[i].RoleTreeNodes = empTreeNode.RoleTreeNodes;
                    empTreeNodes[i].RoleTreeNode.ParentRoleTreeNode = empTreeNodes[i].RoleTreeNode.ParentRoleTreeNode;
                    empTreeNodes[i].RoleTreeNode.Role = empTreeNodes[i].RoleTreeNode.Role;
                    empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes = empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes;
                    empTreeNodes[i].Text = empTreeNode.Text;
                }
                else
                {
                    empTreeNodes[i].Employee = empTreeNodes[i].Employee;
                    empTreeNodes[i].ChildEmpTreeNodes = empTreeNodes[i].ChildEmpTreeNodes;
                    empTreeNodes[i].RoleTreeNode = empTreeNodes[i].RoleTreeNode;
                    empTreeNodes[i].RoleTreeNodes = empTreeNode.RoleTreeNodes;
                    empTreeNodes[i].RoleTreeNode.ParentRoleTreeNode = empTreeNodes[i].RoleTreeNode.ParentRoleTreeNode;
                    empTreeNodes[i].RoleTreeNode.Role = empTreeNodes[i].RoleTreeNode.Role;
                    empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes = empTreeNodes[i].RoleTreeNode.ChildRoleTreeNodes;
                    empTreeNodes[i].Text = empTreeNode.Text;
                }
            }
        }

        public bool HasGrandChildren(EmployeeTreeNode selectedEmpNode, int depthRemainder)
        {
            if (depthRemainder <= 0)
            {
                return true;
            }
            if (selectedEmpNode != null && selectedEmpNode.ChildEmpTreeNodes != null && selectedEmpNode.ChildEmpTreeNodes.Count > 0)
            {
                for (int i = 0; i < selectedEmpNode.ChildEmpTreeNodes.Count; i++)
                {
                    EmployeeTreeNode ChildNode = selectedEmpNode.ChildEmpTreeNodes[i];
                    if (HasGrandChildren(ChildNode, depthRemainder - 1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public List<EmployeeTreeNode> SearchEmpWithUUID(EmployeeTreeNode rootEmpTreeNode, string uuid, List<EmployeeTreeNode> foundNode)
        {
            EmployeeTreeNode tree = rootEmpTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                if (tree.ChildEmpTreeNodes != null)
                {
                    numberOfChildNodes = tree.ChildEmpTreeNodes.Count;
                }
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the SearchEmpWithUUID method
                if (tree.ChildEmpTreeNodes[i].Employee.UUID == uuid)
                {
                    if (tree.ChildEmpTreeNodes != null)
                    {
                        foundNode.Add(tree.ChildEmpTreeNodes[i]);
                    }
                }
                SearchEmpWithUUID(tree.ChildEmpTreeNodes[i], uuid, foundNode);
            }//End of for loop
            return foundNode;
        }

        public List<EmployeeTreeNode> SearchByEmployeeUUID(string uuid, ref List<EmployeeTreeNode> foundNode)
        {
            int i = 0;
            if (this.ChildEmpTreeNodes != null)
            {
                for (i = 0; i < this.ChildEmpTreeNodes.Count; i++)
                {
                    if (this.ChildEmpTreeNodes[i].Employee.UUID == uuid)
                    {
                        //Base case (Where the method code stops calling itself,
                        //perform action and finally exit). This avoids infinite loop
                        foundNode.Add(this.ChildEmpTreeNodes[i]);
                    }
                    this.ChildEmpTreeNodes[i].SearchByEmployeeUUID(uuid, ref foundNode);
                }
            }
            return foundNode;
        }

        public List<EmployeeTreeNode> SearchEmpWithRole(EmployeeTreeNode rootEmpTreeNode, string name, List<EmployeeTreeNode> foundNode)
        {
            EmployeeTreeNode tree = rootEmpTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                if (tree.ChildEmpTreeNodes != null)
                {
                    numberOfChildNodes = tree.ChildEmpTreeNodes.Count;
                }
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the SearchEmpWithRole method
                if (tree.ChildEmpTreeNodes[i].RoleTreeNode.Role.Name == name)
                {
                    if (tree.ChildEmpTreeNodes != null)
                    {
                        foundNode.Add(tree.ChildEmpTreeNodes[i]);
                    }
                }
                SearchEmpWithRole(tree.ChildEmpTreeNodes[i], name, foundNode);
            }//End of for loop
            return foundNode;
        }

        public List<EmployeeTreeNode> SearchEmpWithName(EmployeeTreeNode rootEmpTreeNode, string name, string roleName, List<EmployeeTreeNode> foundNode)
        {
            EmployeeTreeNode tree = rootEmpTreeNode;
            int numberOfChildNodes = 0;
            if (tree != null)
            {
                if (tree.ChildEmpTreeNodes != null)
                {
                    numberOfChildNodes = tree.ChildEmpTreeNodes.Count;
                }
            }

            for (int i = 0; i < numberOfChildNodes; i++)
            {
                //Keep calling the SearchEmpWithName method
                if (tree.ChildEmpTreeNodes[i].Employee.Name == name && tree.ChildEmpTreeNodes[i].RoleTreeNode.Role.Name == roleName)
                {
                    if (tree.ChildEmpTreeNodes != null)
                    {
                        foundNode.Add(tree.ChildEmpTreeNodes[i]);
                    }
                }
                SearchEmpWithName(tree.ChildEmpTreeNodes[i], name, roleName, foundNode);
            }//End of for loop
            return foundNode;
        }

        // When you work on File IO operations, TreeNode class is [not serializable]
        // As a result the following three methods were defined to support the
        // reconstruction of all the TreeNode objects within each EmployeeTreeNode type objects
        // Each developer usually has their own technique to reconstruct the TreeNode objects
        public void RebuildTreeNodes()
        {
            if (this.RoleTreeNodes != null)
            {
                if (this.RoleTreeNodes[1] != null)
                {
                    this.Text = this.Employee.Name + " - " + this.RoleTreeNodes[0].Role.Name + ", " + this.RoleTreeNodes[1].Role.Name + " (S$" + this.Employee.Salary + ")";
                }
            }
            else
            {
                this.Text = this.Employee.Name + " - " + this.RoleTreeNode.Role.Name + " (S$" + this.Employee.Salary + ")";
            }

            if (this.ChildEmpTreeNodes.Count > 0)
            {
                int i;
                for (i = 0; i < this.ChildEmpTreeNodes.Count; i++)
                {
                    this.Nodes.Add(this.ChildEmpTreeNodes[i]);
                    this.ChildEmpTreeNodes[i].ParentEmpTreeNode = this;
                    this.ChildEmpTreeNodes[i].RebuildTreeNodes();
                }
            }

        } // End of RebuildTreeNodes
        // File IO Functions ----------------------------------------------------------------------------------------------

        public void SaveToFileBinary()
        {
            try
            {
                string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\EmpData.dat";
                BinaryFormatter bf = new BinaryFormatter();
                Stream stream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write);

                bf.Serialize(stream, this);
                stream.Close();

                MessageBox.Show("Company Simulation saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // End of SaveToFileBinary

        public EmployeeTreeNode ReadFromFileBinary()
        {
            try
            {
                string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\EmpData.dat";
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                EmployeeTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (EmployeeTreeNode)bf.Deserialize(stream);
                }
                stream.Close();

                return root;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Unable to find file.");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }// End of ReadFromFileBinary

        // [ SERIALIZE ]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //add the required data to file
            info.AddValue("Emp", _emp);
            info.AddValue("ChildrenEmpTreeNodes", _children);
            info.AddValue("ParentEmpTreeNode", _parentEmpTreeNode);
            info.AddValue("RoleTreeNode", _roleTreeNode);
            info.AddValue("RoleTreeNodes", _roleTreeNodeArr);
            info.AddValue("ProjectListEmp", _projectListEmp);
            info.AddValue("ProjectList", _projectList);

        } // End of GetObjectData [ SERIALIZE ]
        // [DESERIALIZE]
        protected EmployeeTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Employee = (Employee)info.GetValue("Emp", typeof(Employee));
            this.ChildEmpTreeNodes = (List<EmployeeTreeNode>)info.GetValue("ChildrenEmpTreeNodes", typeof(List<EmployeeTreeNode>));
            this.ParentEmpTreeNode = (EmployeeTreeNode)info.GetValue("ParentEmpTreeNode", typeof(EmployeeTreeNode));
            this.RoleTreeNode = (RoleTreeNode)info.GetValue("RoleTreeNode", typeof(RoleTreeNode));
            this.RoleTreeNodes = (RoleTreeNode[])info.GetValue("RoleTreeNodes", typeof(RoleTreeNode[]));
            this.ProjectListEmp = (List<Project>)info.GetValue("ProjectListEmp", typeof(List<Project>));
            this.ProjectList = (List<Project>)info.GetValue("ProjectList", typeof(List<Project>));
        } // End of EmployeeTreeNode [ DESERIALIZE ]

        // End Of File IO Functions ---------------------------------------------------------------------------------------
    } // End of EmployeeTreeNode class
} // End of namespace
