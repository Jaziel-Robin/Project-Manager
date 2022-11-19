namespace ProjectManager
{
    partial class ReplaceEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmployeeToReplace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProjects = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxRO = new System.Windows.Forms.TextBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee List";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "You are replacing";
            // 
            // textBoxEmployeeToReplace
            // 
            this.textBoxEmployeeToReplace.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxEmployeeToReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmployeeToReplace.Enabled = false;
            this.textBoxEmployeeToReplace.Location = new System.Drawing.Point(149, 55);
            this.textBoxEmployeeToReplace.Name = "textBoxEmployeeToReplace";
            this.textBoxEmployeeToReplace.Size = new System.Drawing.Size(331, 20);
            this.textBoxEmployeeToReplace.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Select employee node to replace with:";
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(14, 145);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(410, 398);
            this.treeViewEmployee.TabIndex = 11;
            this.treeViewEmployee.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmployee_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxProjects);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxRole);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxSalary);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxRO);
            this.groupBox1.Controls.Add(this.buttonSwap);
            this.groupBox1.Controls.Add(this.textBoxUUID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(445, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 408);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // textBoxProjects
            // 
            this.textBoxProjects.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProjects.Enabled = false;
            this.textBoxProjects.Location = new System.Drawing.Point(190, 291);
            this.textBoxProjects.Name = "textBoxProjects";
            this.textBoxProjects.Size = new System.Drawing.Size(198, 20);
            this.textBoxProjects.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(24, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Projects";
            // 
            // textBoxRole
            // 
            this.textBoxRole.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRole.Enabled = false;
            this.textBoxRole.Location = new System.Drawing.Point(190, 252);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(198, 20);
            this.textBoxRole.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(24, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Role";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalary.Enabled = false;
            this.textBoxSalary.Location = new System.Drawing.Point(190, 213);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(198, 20);
            this.textBoxSalary.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Salary (S$)";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(190, 174);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 20);
            this.textBoxName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // textBoxRO
            // 
            this.textBoxRO.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRO.Enabled = false;
            this.textBoxRO.Location = new System.Drawing.Point(190, 135);
            this.textBoxRO.Name = "textBoxRO";
            this.textBoxRO.Size = new System.Drawing.Size(198, 20);
            this.textBoxRO.TabIndex = 4;
            // 
            // buttonSwap
            // 
            this.buttonSwap.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSwap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSwap.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSwap.Location = new System.Drawing.Point(112, 343);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(191, 36);
            this.buttonSwap.TabIndex = 13;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = false;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(190, 97);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(198, 20);
            this.textBoxUUID.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Reporting Officer";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "UUID";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(144, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Replace With";
            // 
            // ReplaceEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEmployeeToReplace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReplaceEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace_Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReplaceEmployee_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmployeeToReplace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRO;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.TextBox textBoxProjects;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label7;
    }
}