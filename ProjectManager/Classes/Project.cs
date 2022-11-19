using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager.Classes
{
    [Serializable]
    internal class Project
    {
        private string _uuid; // Project UUID
        private string _name; // Project Name
        private int _revenue; // Project Revenue
        private EmployeeTreeNode _teamLeader; // Project Leader

        public Project(string name, int revenue, EmployeeTreeNode empTreeNode)
        {
            this._uuid = General.GenerateUUID();
            this._name = name;
            this._revenue = revenue;
            this._teamLeader = empTreeNode;
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

        public int Revenue
        {
            get { return _revenue; }
            set { _revenue = value;  }
        }

        public EmployeeTreeNode TeamLeader
        {
            get { return _teamLeader; }
            set { _teamLeader = value; }
        } // End of TeamLeader property
    } // End of Project class
} // End of namespace
