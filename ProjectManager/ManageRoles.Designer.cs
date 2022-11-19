namespace ProjectManager
{
    partial class ManageRoles
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxProjectLeader = new System.Windows.Forms.CheckBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.treeViewRole = new System.Windows.Forms.TreeView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxProjectLeader);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.textBoxUUID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(166, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Read-Only";
            // 
            // checkBoxProjectLeader
            // 
            this.checkBoxProjectLeader.AutoSize = true;
            this.checkBoxProjectLeader.Enabled = false;
            this.checkBoxProjectLeader.Location = new System.Drawing.Point(31, 171);
            this.checkBoxProjectLeader.Name = "checkBoxProjectLeader";
            this.checkBoxProjectLeader.Size = new System.Drawing.Size(167, 24);
            this.checkBoxProjectLeader.TabIndex = 4;
            this.checkBoxProjectLeader.Text = "Project Leader Role?";
            this.checkBoxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(175, 129);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(175, 87);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(213, 20);
            this.textBoxUUID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "UUID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Role Node Information";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Navy;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonReset.Location = new System.Drawing.Point(12, 290);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 36);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSave.Location = new System.Drawing.Point(165, 290);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.SlateGray;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonLoad.Location = new System.Drawing.Point(314, 290);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(130, 36);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxConsole.Location = new System.Drawing.Point(12, 386);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(432, 168);
            this.textBoxConsole.TabIndex = 4;
            this.textBoxConsole.Text = "Roles cannot be added if there are projects assigned.\r\nRoles cannot be removed if" +
    " there are employees under it.\r\nOnly one level of role is allowed under a projec" +
    "t leader role.\r\n";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Console";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(481, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Role Node Tree View";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(481, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(439, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Right Click to perform actions such as edit, remove or add roles";
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpand.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonExpand.Location = new System.Drawing.Point(956, 39);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(130, 36);
            this.buttonExpand.TabIndex = 8;
            this.buttonExpand.Text = "Expand All";
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.Color.SlateGray;
            this.buttonCollapse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapse.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCollapse.Location = new System.Drawing.Point(1101, 38);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(130, 36);
            this.buttonCollapse.TabIndex = 9;
            this.buttonCollapse.Text = "Collapse All";
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // treeViewRole
            // 
            this.treeViewRole.Location = new System.Drawing.Point(481, 99);
            this.treeViewRole.Name = "treeViewRole";
            this.treeViewRole.Size = new System.Drawing.Size(750, 455);
            this.treeViewRole.TabIndex = 10;
            this.treeViewRole.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRole_AfterSelect);
            // 
            // ManageRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 566);
            this.Controls.Add(this.treeViewRole);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.buttonExpand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Roles";
            this.Load += new System.EventHandler(this.FormManageRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckBox checkBoxProjectLeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.TreeView treeViewRole;
    }
}
