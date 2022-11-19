namespace ProjectManager
{
    partial class AddRole
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxProjectLeader = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxParent = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parent Role";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // checkBoxProjectLeader
            // 
            this.checkBoxProjectLeader.AutoSize = true;
            this.checkBoxProjectLeader.Location = new System.Drawing.Point(39, 168);
            this.checkBoxProjectLeader.Name = "checkBoxProjectLeader";
            this.checkBoxProjectLeader.Size = new System.Drawing.Size(167, 24);
            this.checkBoxProjectLeader.TabIndex = 8;
            this.checkBoxProjectLeader.Text = "Project Leader Role?";
            this.checkBoxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAdd.Location = new System.Drawing.Point(39, 223);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(189, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(200, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Role";
            // 
            // textBoxParent
            // 
            this.textBoxParent.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxParent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParent.Enabled = false;
            this.textBoxParent.Location = new System.Drawing.Point(227, 84);
            this.textBoxParent.Name = "textBoxParent";
            this.textBoxParent.Size = new System.Drawing.Size(213, 20);
            this.textBoxParent.TabIndex = 11;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(227, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 12;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCancel.Location = new System.Drawing.Point(251, 223);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(189, 36);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 281);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkBoxProjectLeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "AddRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxProjectLeader;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxParent;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCancel;
    }
}