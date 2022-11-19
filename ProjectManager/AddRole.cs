using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class AddRole : Form
    {
        public delegate void AddRoleDelegate(string newRoleName, bool isPL);
        public AddRoleDelegate AddRoleCallBack;

        public AddRole()
        {
            InitializeComponent();
        }

        public AddRole(string parentRoleName, bool isPL)
        {
            InitializeComponent();
            textBoxParent.Text = parentRoleName;
            if (isPL)
            {
                checkBoxProjectLeader.Enabled = false;
            }
            else
            {
                checkBoxProjectLeader.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            bool isPL = checkBoxProjectLeader.Checked;
            if (name == "")
            {
                MessageBox.Show("Role name cannot be empty!");
                return;
            }
            AddRoleCallBack(name, isPL);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
