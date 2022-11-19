namespace ProjectManager
{
    partial class AddEmployee
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxDummy = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCancel.Location = new System.Drawing.Point(251, 335);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(189, 36);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(227, 127);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxRO
            // 
            this.textBoxRO.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRO.Enabled = false;
            this.textBoxRO.Location = new System.Drawing.Point(227, 83);
            this.textBoxRO.Name = "textBoxRO";
            this.textBoxRO.Size = new System.Drawing.Size(213, 20);
            this.textBoxRO.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(168, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Add Employee";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAdd.Location = new System.Drawing.Point(39, 335);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 36);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxDummy
            // 
            this.checkBoxDummy.AutoSize = true;
            this.checkBoxDummy.Location = new System.Drawing.Point(39, 270);
            this.checkBoxDummy.Name = "checkBoxDummy";
            this.checkBoxDummy.Size = new System.Drawing.Size(126, 24);
            this.checkBoxDummy.TabIndex = 16;
            this.checkBoxDummy.Text = "Dummy Data?";
            this.checkBoxDummy.UseVisualStyleBackColor = true;
            this.checkBoxDummy.CheckedChanged += new System.EventHandler(this.checkBoxDummy_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Reporting Officer";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalary.Location = new System.Drawing.Point(227, 173);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(213, 20);
            this.textBoxSalary.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(39, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Salary (S$)";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(39, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Role";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(227, 214);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(213, 28);
            this.comboBoxRole.TabIndex = 27;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 393);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxRO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxDummy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxDummy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRole;
    }
}