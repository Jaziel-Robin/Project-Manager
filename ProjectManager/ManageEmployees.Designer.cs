namespace ProjectManager
{
    partial class ManageEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPL = new System.Windows.Forms.CheckBox();
            this.textBoxProjects = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxDummy = new System.Windows.Forms.CheckBox();
            this.textBoxRO = new System.Windows.Forms.TextBox();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(482, 99);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(901, 637);
            this.treeViewEmployee.TabIndex = 21;
            this.treeViewEmployee.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmployee_AfterSelect);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.Color.SlateGray;
            this.buttonCollapse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapse.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCollapse.Location = new System.Drawing.Point(1253, 38);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(130, 36);
            this.buttonCollapse.TabIndex = 20;
            this.buttonCollapse.Text = "Collapse All";
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpand.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonExpand.Location = new System.Drawing.Point(1108, 39);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(130, 36);
            this.buttonExpand.TabIndex = 19;
            this.buttonExpand.Text = "Expand All";
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(482, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(469, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Right Click to perform actions such as edit, remove or add employees";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(482, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(223, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Employee Node Tree View";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(13, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Console";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxConsole.Location = new System.Drawing.Point(13, 568);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(432, 168);
            this.textBoxConsole.TabIndex = 15;
            this.textBoxConsole.Text = "Each Employee can have maximum 2 employee nodes";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.SlateGray;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonLoad.Location = new System.Drawing.Point(315, 472);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(130, 36);
            this.buttonLoad.TabIndex = 14;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSave.Location = new System.Drawing.Point(166, 472);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 36);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Navy;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonReset.Location = new System.Drawing.Point(13, 472);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 36);
            this.buttonReset.TabIndex = 12;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPL);
            this.groupBox1.Controls.Add(this.textBoxProjects);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxRole);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBoxDummy);
            this.groupBox1.Controls.Add(this.textBoxRO);
            this.groupBox1.Controls.Add(this.textBoxUUID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 435);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxPL
            // 
            this.checkBoxPL.AutoSize = true;
            this.checkBoxPL.Enabled = false;
            this.checkBoxPL.Location = new System.Drawing.Point(262, 338);
            this.checkBoxPL.Name = "checkBoxPL";
            this.checkBoxPL.Size = new System.Drawing.Size(147, 24);
            this.checkBoxPL.TabIndex = 14;
            this.checkBoxPL.Text = "Is Project Leader?";
            this.checkBoxPL.UseVisualStyleBackColor = true;
            // 
            // textBoxProjects
            // 
            this.textBoxProjects.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjects.Enabled = false;
            this.textBoxProjects.Location = new System.Drawing.Point(175, 296);
            this.textBoxProjects.Name = "textBoxProjects";
            this.textBoxProjects.Size = new System.Drawing.Size(213, 20);
            this.textBoxProjects.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(28, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Projects";
            // 
            // textBoxRole
            // 
            this.textBoxRole.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRole.Enabled = false;
            this.textBoxRole.Location = new System.Drawing.Point(175, 253);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(213, 20);
            this.textBoxRole.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Role";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalary.Enabled = false;
            this.textBoxSalary.Location = new System.Drawing.Point(175, 211);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(213, 20);
            this.textBoxSalary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(28, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salary (S$)";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(175, 169);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DarkGray;
            this.label8.Location = new System.Drawing.Point(166, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Read-Only";
            // 
            // checkBoxDummy
            // 
            this.checkBoxDummy.AutoSize = true;
            this.checkBoxDummy.Enabled = false;
            this.checkBoxDummy.Location = new System.Drawing.Point(31, 338);
            this.checkBoxDummy.Name = "checkBoxDummy";
            this.checkBoxDummy.Size = new System.Drawing.Size(126, 24);
            this.checkBoxDummy.TabIndex = 4;
            this.checkBoxDummy.Text = "Dummy Data?";
            this.checkBoxDummy.UseVisualStyleBackColor = true;
            // 
            // textBoxRO
            // 
            this.textBoxRO.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRO.Enabled = false;
            this.textBoxRO.Location = new System.Drawing.Point(175, 129);
            this.textBoxRO.Name = "textBoxRO";
            this.textBoxRO.Size = new System.Drawing.Size(213, 20);
            this.textBoxRO.TabIndex = 4;
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
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reporting Officer";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "UUID";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Employee Node Information";
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 751);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.buttonExpand);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.groupBox1);
            this.Name = "ManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Employees";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxDummy;
        private System.Windows.Forms.TextBox textBoxRO;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxPL;
    }
}