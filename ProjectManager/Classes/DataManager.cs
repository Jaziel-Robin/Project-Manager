using System;
using System.Collections.Generic;
using System.Diagnostics;
//namespace for file io
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

//namespace the the Application class
using System.Windows.Forms;

namespace ProjectManager.Classes
{
    [Serializable]
    internal class DataManager
    //******************************** IMPORTANT *********************************************
    //About DataManager
    //You should manage all the employee data, role data and project data by applying code
    //in this DataManager instead of having seperate RoleManager, EmployeeManager and ProjectManager class
    //****************************************************************************************
    {
        RoleTreeNode _roleTreeStructure;
        EmployeeTreeNode _empTreeStructure;
        private string _filePath; // Saved data file path
        public DataManager(RoleTreeNode defaultRoleRootNode)
        {
            // _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Data.dat";
            _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\RoleData.dat";
            _roleTreeStructure = defaultRoleRootNode;
        }

        public DataManager(EmployeeTreeNode defaultEmpRootNode)
        {
            _filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\EmpData.dat";
            _empTreeStructure = defaultEmpRootNode;
        }

        public RoleTreeNode RoleTreeStructure
        {
            get { return _roleTreeStructure; }
            set { _roleTreeStructure = value; }
        }

        public EmployeeTreeNode EmpTreeStructure
        {
            get { return _empTreeStructure; }
            set { _empTreeStructure = value; }
        }

        public void SaveRoleData()
        {
            this.RoleTreeStructure.SaveToFileBinary();
        } // End of SaveRoleData

        public RoleTreeNode LoadRoleData()
        {
            if (this.RoleTreeStructure != null)
            {
                this.RoleTreeStructure = this.RoleTreeStructure.ReadFromFileBinary();
                if (this.RoleTreeStructure != null)
                {
                    // Rebuilding the Text and Nodes property of EACH RoleTreeNode object
                    this.RoleTreeStructure.RebuildTreeNodes();
                    return this.RoleTreeStructure;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        } // End of LoadRoleData method

        public void SaveEmpData()
        {
            this.EmpTreeStructure.SaveToFileBinary();
        } // End of SaveEmpData

        public EmployeeTreeNode LoadEmpData()
        {
            if (this.EmpTreeStructure != null)
            {
                this.EmpTreeStructure = this.EmpTreeStructure.ReadFromFileBinary();
                if (this.EmpTreeStructure != null)
                {
                    // Rebuilding the Text and Nodes property of EACH EmployeeTreeNode object
                    this.EmpTreeStructure.RebuildTreeNodes();
                    return this.EmpTreeStructure;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        } // End of LoadEmpData method
    } // End of class DataManager
} // End of namespace
