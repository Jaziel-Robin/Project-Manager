using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Classes
{
    [Serializable]
    internal class Role
    {
        private string _uuid; // Role UUID
        private string _name; // Role Name
        private bool _isPL;
        private RoleTreeNode _container; // References the RoleTreeNode object that contains the role

        public Role()
        {
        }

        public Role(string name, bool isPL)
        {
            this._uuid = General.GenerateUUID();
            this._name = name;
            this._isPL = isPL;
        } // End of constructor

        public string UUID
        {
            get { return _uuid; }
            set { _uuid = value; }
        } // End of UUID property

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } // End of Name property

        public bool IsPL
        {
            get { return _isPL; }
            set { _isPL = value; }
        } // End of isPL property

        public RoleTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        } // End of Container property
    } // End of Role class
} // End of namespace

