using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjectManager
{
    public partial class EditRole : Form
    {
        public delegate void EditRoleDelegate(string newRoleName, bool isPL);
        public EditRoleDelegate EditRoleCallBack;

        public EditRole()
        {
            InitializeComponent();
        }

        public EditRole(string uuid, string name, string parentRoleName, bool isPL, bool hasGrandChildren, bool isParentPL, bool isChildPL, bool canEditRole)
        {
            InitializeComponent();
            textBoxUUID.Text = uuid;
            textBoxName.Text = name;
            textBoxParent.Text = parentRoleName;

            if (hasGrandChildren == true && isParentPL == true)
            {
                checkBoxProjectLeader.Enabled = false;
            }
            else if (hasGrandChildren == true && isParentPL == false)
            {
                checkBoxProjectLeader.Enabled = false;
            }
            else if (hasGrandChildren == false && isParentPL == true)
            {
                checkBoxProjectLeader.Enabled = false;
            }
            else
            {
                if (isChildPL)
                {
                    checkBoxProjectLeader.Enabled = false;
                }
                else
                {
                    if (canEditRole)
                    {
                        checkBoxProjectLeader.Enabled = true;
                        checkBoxProjectLeader.Checked = isPL;
                    }
                    else
                    {
                        checkBoxProjectLeader.Enabled = false;
                        checkBoxProjectLeader.Checked = isPL;
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            bool isPL = checkBoxProjectLeader.Checked;
            if (name == "")
            {
                MessageBox.Show("Role name cannot be empty!");
                return;
            }
            EditRoleCallBack(name, isPL);
            this.DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
