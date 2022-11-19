namespace ProjectManager
{
    partial class EditRole
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
            this.textBoxParent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxProjectLeader = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCancel.Location = new System.Drawing.Point(258, 264);
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
            this.textBoxName.Location = new System.Drawing.Point(234, 124);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(213, 20);
            this.textBoxName.TabIndex = 20;
            // 
            // textBoxParent
            // 
            this.textBoxParent.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxParent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParent.Enabled = false;
            this.textBoxParent.Location = new System.Drawing.Point(234, 166);
            this.textBoxParent.Name = "textBoxParent";
            this.textBoxParent.Size = new System.Drawing.Size(213, 20);
            this.textBoxParent.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Edit Role";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSave.Location = new System.Drawing.Point(46, 264);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(189, 36);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxProjectLeader
            // 
            this.checkBoxProjectLeader.AutoSize = true;
            this.checkBoxProjectLeader.Location = new System.Drawing.Point(46, 204);
            this.checkBoxProjectLeader.Name = "checkBoxProjectLeader";
            this.checkBoxProjectLeader.Size = new System.Drawing.Size(167, 24);
            this.checkBoxProjectLeader.TabIndex = 16;
            this.checkBoxProjectLeader.Text = "Project Leader Role?";
            this.checkBoxProjectLeader.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(46, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Parent Role";
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(234, 86);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(213, 20);
            this.textBoxUUID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "UUID";
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 321);
            this.Controls.Add(this.textBoxUUID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxParent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxProjectLeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "EditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit_Role";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxParent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxProjectLeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.Label label2;
    }
}