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
    internal class RoleTreeNode : TreeNode, ISerializable
    {
        private RoleTreeNode _parentRoleTreeNode; // RoleTreeNode type object which describes the "Parent"
        private Role _role; // To hold the Role object which describes one role information
        private List<RoleTreeNode> _children; //A collection of RoleTreeNode type objects which describes the "Children"

        public RoleTreeNode(Role role)
        {
            _parentRoleTreeNode = null;
            _role = role;
            _children = new List<RoleTreeNode>();
            this.Text = role.Name;
        } // End of constructor

        public RoleTreeNode()
        {
        }

        public RoleTreeNode ParentRoleTreeNode
        {
            get { return _parentRoleTreeNode; }
            set { _parentRoleTreeNode = value; }
        }

        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }
        public List<RoleTreeNode> ChildRoleTreeNodes
        {
            get { return _children; }
            set { _children = value; }
        }

        public void AddChildRoleTreeNode(RoleTreeNode roleNode)
        {
            roleNode.ParentRoleTreeNode = this;
            _children.Add(roleNode);
            this.Nodes.Add(roleNode);
        } // End of AddChildRoleTreeNode method

        public void UpdateRoleTreeNode(string newRoleName, bool isPL)
        {
            this.Text = newRoleName;
            this.Role.Name = newRoleName;
            this.Role.IsPL = isPL;
        }

        public bool HasGrandChildren(RoleTreeNode selectedRoleNode, int depthRemainder)
        {
            if (depthRemainder <= 0)
            {
                return true;
            }
            if (selectedRoleNode != null && selectedRoleNode.ChildRoleTreeNodes != null && selectedRoleNode.ChildRoleTreeNodes.Count > 0)
            {
                for (int i = 0; i < selectedRoleNode.ChildRoleTreeNodes.Count; i++)
                {
                    RoleTreeNode ChildNode = selectedRoleNode.ChildRoleTreeNodes[i];
                    if (HasGrandChildren(ChildNode, depthRemainder - 1))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // When you work on File IO operations, TreeNode class is [not serializable]
        // As a result the following three methods were defined to support the
        // reconstruction of all the TreeNode objects within each RoleTreeNode type objects
        // Each developer usually has their own technique to reconstruct the TreeNode objects
        public void RebuildTreeNodes()
        {
            this.Text = this.Role.Name;
            if (this.ChildRoleTreeNodes.Count > 0)
            {
                int i;
                for (i = 0; i < this.ChildRoleTreeNodes.Count; i++)
                {
                    this.Nodes.Add(this.ChildRoleTreeNodes[i]);
                    this.ChildRoleTreeNodes[i].ParentRoleTreeNode = this;
                    this.ChildRoleTreeNodes[i].RebuildTreeNodes();
                }
            }

        } // End of RebuildTreeNodes
        // File IO Functions ----------------------------------------------------------------------------------------------

        public void SaveToFileBinary()
        {
            try
            {
                string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\RoleData.dat";
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

        public RoleTreeNode ReadFromFileBinary()
        {
            try
            {
                string filepath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\RoleData.dat";
                Stream stream = new FileStream(@filepath, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                RoleTreeNode root = null;
                if (stream.Length != 0)
                {
                    root = (RoleTreeNode)bf.Deserialize(stream);
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

        } // End of ReadFromFileBinary

        // [ SERIALIZE ]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //add the required data to file
            info.AddValue("Role", _role);
            info.AddValue("ChildrenRoleTreeNodes", _children);
            info.AddValue("ParentRoleTreeNode", _parentRoleTreeNode);

        } // End of GetObjectData [ SERIALIZE ]
        // [DESERIALIZE]
        protected RoleTreeNode(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");
            this.Role = (Role)info.GetValue("Role", typeof(Role));
            this.ChildRoleTreeNodes = (List<RoleTreeNode>)info.GetValue("ChildrenRoleTreeNodes", typeof(List<RoleTreeNode>));
            this.ParentRoleTreeNode = (RoleTreeNode)info.GetValue("ParentRoleTreeNode", typeof(RoleTreeNode));
        } // End of RoleTreeNode [ DESERIALIZE ]

        // End Of File IO Functions ---------------------------------------------------------------------------------------
    } // End of RoleTreeNode class
} // End of namespace
