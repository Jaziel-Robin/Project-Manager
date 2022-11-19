using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManager.Classes
{
    [Serializable]
    internal class Employee
    {
        private string _uuid; // Employee UUID
        private string _name; // Employee Name
        private int _salary = 0;
        private EmployeeTreeNode _container; // References the RoleTreeNode object that contains the role

        public Employee()
        {
        }

        public Employee(Employee emp)
        {
            this._uuid = emp._uuid;
            this._name = emp._name;
            this._salary = emp._salary;
        }

        public Employee(string name, int salary)
        {
            this._uuid = General.GenerateUUID();
            this._name = name;
            this._salary = salary;
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

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        } // End of Salary property

        public EmployeeTreeNode Container
        {
            get { return _container; }
            set { _container = value; }
        } // End of Container property
    } // End of Employee class
} // End of namespace
