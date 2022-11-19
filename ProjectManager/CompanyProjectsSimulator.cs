/*
Class: DIT/FT/2B21
Admission Number: P2129187
Name: Jaziel Robin Premraj
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class CompanyProjectsSimulator : Form
    {
        public CompanyProjectsSimulator()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployees Employee = new ManageEmployees();
            Employee.MdiParent = this;
            Employee.Show();
        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageProjects Project = new ManageProjects();
            Project.MdiParent = this;
            Project.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoles Role = new ManageRoles();
            Role.MdiParent = this;
            Role.Show();
        }
    }
}
