namespace ProjectManager
{
    partial class ManageProjects
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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeViewEmployee = new System.Windows.Forms.TreeView();
            this.buttonConfirmAdd = new System.Windows.Forms.Button();
            this.buttonAddSearchForTeams = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxAddRevenue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddPN = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAddTL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxViewEditTL = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonConfirmEdit = new System.Windows.Forms.Button();
            this.textBoxViewEditRevenue = new System.Windows.Forms.TextBox();
            this.buttonViewEditSearchForTeams = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxViewEditPN = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.listViewProject = new System.Windows.Forms.ListView();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.SlateGray;
            this.buttonLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLoad.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonLoad.Location = new System.Drawing.Point(320, 14);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(130, 36);
            this.buttonLoad.TabIndex = 17;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonSave.Location = new System.Drawing.Point(171, 14);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 36);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Navy;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonReset.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonReset.Location = new System.Drawing.Point(18, 14);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(130, 36);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.Color.SlateGray;
            this.buttonCollapse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCollapse.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCollapse.Location = new System.Drawing.Point(336, 64);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(127, 32);
            this.buttonCollapse.TabIndex = 22;
            this.buttonCollapse.Text = "Collapse All";
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonExpand.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExpand.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonExpand.Location = new System.Drawing.Point(204, 64);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(127, 32);
            this.buttonExpand.TabIndex = 21;
            this.buttonExpand.Text = "Expand All";
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Employee Tree View";
            // 
            // treeViewEmployee
            // 
            this.treeViewEmployee.Location = new System.Drawing.Point(22, 104);
            this.treeViewEmployee.Name = "treeViewEmployee";
            this.treeViewEmployee.Size = new System.Drawing.Size(736, 624);
            this.treeViewEmployee.TabIndex = 24;
            // 
            // buttonConfirmAdd
            // 
            this.buttonConfirmAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonConfirmAdd.Enabled = false;
            this.buttonConfirmAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmAdd.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonConfirmAdd.Location = new System.Drawing.Point(321, 359);
            this.buttonConfirmAdd.Name = "buttonConfirmAdd";
            this.buttonConfirmAdd.Size = new System.Drawing.Size(130, 36);
            this.buttonConfirmAdd.TabIndex = 28;
            this.buttonConfirmAdd.Text = "Confirm Add";
            this.buttonConfirmAdd.UseVisualStyleBackColor = false;
            this.buttonConfirmAdd.Click += new System.EventHandler(this.buttonConfirmAdd_Click);
            // 
            // buttonAddSearchForTeams
            // 
            this.buttonAddSearchForTeams.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddSearchForTeams.Enabled = false;
            this.buttonAddSearchForTeams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSearchForTeams.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonAddSearchForTeams.Location = new System.Drawing.Point(29, 359);
            this.buttonAddSearchForTeams.Name = "buttonAddSearchForTeams";
            this.buttonAddSearchForTeams.Size = new System.Drawing.Size(176, 36);
            this.buttonAddSearchForTeams.TabIndex = 26;
            this.buttonAddSearchForTeams.Text = "Search For Teams";
            this.buttonAddSearchForTeams.UseVisualStyleBackColor = false;
            this.buttonAddSearchForTeams.Click += new System.EventHandler(this.buttonAddSearchForTeams_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(28, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Team Leader";
            // 
            // textBoxAddRevenue
            // 
            this.textBoxAddRevenue.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxAddRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddRevenue.Enabled = false;
            this.textBoxAddRevenue.Location = new System.Drawing.Point(175, 274);
            this.textBoxAddRevenue.Name = "textBoxAddRevenue";
            this.textBoxAddRevenue.Size = new System.Drawing.Size(272, 20);
            this.textBoxAddRevenue.TabIndex = 11;
            this.textBoxAddRevenue.TextChanged += new System.EventHandler(this.textBoxAddRevenue_TextChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(28, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Revenue(S$)";
            // 
            // textBoxAddPN
            // 
            this.textBoxAddPN.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxAddPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddPN.Enabled = false;
            this.textBoxAddPN.Location = new System.Drawing.Point(175, 232);
            this.textBoxAddPN.Name = "textBoxAddPN";
            this.textBoxAddPN.Size = new System.Drawing.Size(272, 20);
            this.textBoxAddPN.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.IndianRed;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonCancel.Location = new System.Drawing.Point(212, 359);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 36);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(28, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Project Name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Step 3:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Step 2:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Step 1:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(170, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add New Project";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAddTL);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonConfirmAdd);
            this.groupBox1.Controls.Add(this.buttonAddSearchForTeams);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.textBoxAddRevenue);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxAddPN);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(772, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 418);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxAddTL
            // 
            this.comboBoxAddTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddTL.Enabled = false;
            this.comboBoxAddTL.FormattingEnabled = true;
            this.comboBoxAddTL.Location = new System.Drawing.Point(175, 314);
            this.comboBoxAddTL.Name = "comboBoxAddTL";
            this.comboBoxAddTL.Size = new System.Drawing.Size(272, 28);
            this.comboBoxAddTL.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(114, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 26);
            this.label8.TabIndex = 31;
            this.label8.Text = "Click the \"Confirm Add\" button";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 43);
            this.label6.TabIndex = 30;
            this.label6.Text = "Select team leader via the dropdown (Highlighted in Employee Tree View)";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 43);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enter project name and revenue, then click on the \"Search For Teams\" button";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(772, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 27;
            this.label12.Text = "Console";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConsole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxConsole.Location = new System.Drawing.Point(772, 555);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(492, 168);
            this.textBoxConsole.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxViewEditTL);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.buttonConfirmEdit);
            this.groupBox2.Controls.Add(this.textBoxViewEditRevenue);
            this.groupBox2.Controls.Add(this.buttonViewEditSearchForTeams);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.buttonDelete);
            this.groupBox2.Controls.Add(this.textBoxViewEditPN);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBoxUUID);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(1280, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 313);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxViewEditTL
            // 
            this.comboBoxViewEditTL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewEditTL.Enabled = false;
            this.comboBoxViewEditTL.FormattingEnabled = true;
            this.comboBoxViewEditTL.Location = new System.Drawing.Point(175, 204);
            this.comboBoxViewEditTL.Name = "comboBoxViewEditTL";
            this.comboBoxViewEditTL.Size = new System.Drawing.Size(272, 28);
            this.comboBoxViewEditTL.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(28, 207);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 25);
            this.label18.TabIndex = 29;
            this.label18.Text = "Team Leader";
            // 
            // buttonConfirmEdit
            // 
            this.buttonConfirmEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonConfirmEdit.Enabled = false;
            this.buttonConfirmEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonConfirmEdit.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonConfirmEdit.Location = new System.Drawing.Point(210, 251);
            this.buttonConfirmEdit.Name = "buttonConfirmEdit";
            this.buttonConfirmEdit.Size = new System.Drawing.Size(130, 36);
            this.buttonConfirmEdit.TabIndex = 28;
            this.buttonConfirmEdit.Text = "Confirm Edit";
            this.buttonConfirmEdit.UseVisualStyleBackColor = false;
            this.buttonConfirmEdit.Click += new System.EventHandler(this.buttonConfirmEdit_Click);
            // 
            // textBoxViewEditRevenue
            // 
            this.textBoxViewEditRevenue.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxViewEditRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxViewEditRevenue.Enabled = false;
            this.textBoxViewEditRevenue.Location = new System.Drawing.Point(175, 164);
            this.textBoxViewEditRevenue.Name = "textBoxViewEditRevenue";
            this.textBoxViewEditRevenue.Size = new System.Drawing.Size(272, 20);
            this.textBoxViewEditRevenue.TabIndex = 13;
            this.textBoxViewEditRevenue.TextChanged += new System.EventHandler(this.textBoxViewEditRevenue_TextChanged);
            // 
            // buttonViewEditSearchForTeams
            // 
            this.buttonViewEditSearchForTeams.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonViewEditSearchForTeams.Enabled = false;
            this.buttonViewEditSearchForTeams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonViewEditSearchForTeams.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonViewEditSearchForTeams.Location = new System.Drawing.Point(29, 251);
            this.buttonViewEditSearchForTeams.Name = "buttonViewEditSearchForTeams";
            this.buttonViewEditSearchForTeams.Size = new System.Drawing.Size(176, 36);
            this.buttonViewEditSearchForTeams.TabIndex = 26;
            this.buttonViewEditSearchForTeams.Text = "Search For Teams";
            this.buttonViewEditSearchForTeams.UseVisualStyleBackColor = false;
            this.buttonViewEditSearchForTeams.Click += new System.EventHandler(this.buttonViewEditSearchForTeams_Click);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(28, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 25);
            this.label17.TabIndex = 12;
            this.label17.Text = "Revenue (S$)";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.ForeColor = System.Drawing.Color.GhostWhite;
            this.buttonDelete.Location = new System.Drawing.Point(345, 251);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(102, 36);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxViewEditPN
            // 
            this.textBoxViewEditPN.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxViewEditPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxViewEditPN.Enabled = false;
            this.textBoxViewEditPN.Location = new System.Drawing.Point(175, 121);
            this.textBoxViewEditPN.Name = "textBoxViewEditPN";
            this.textBoxViewEditPN.Size = new System.Drawing.Size(272, 20);
            this.textBoxViewEditPN.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(28, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "Project Name";
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUUID.Enabled = false;
            this.textBoxUUID.Location = new System.Drawing.Point(175, 79);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(272, 20);
            this.textBoxUUID.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(28, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 25);
            this.label15.TabIndex = 8;
            this.label15.Text = "UUID";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(170, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "View / Edit Project";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "View",
            "Add",
            "Edit"});
            this.comboBoxMode.Location = new System.Drawing.Point(1603, 22);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(169, 28);
            this.comboBoxMode.TabIndex = 31;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // listViewProject
            // 
            this.listViewProject.HideSelection = false;
            this.listViewProject.Location = new System.Drawing.Point(1280, 459);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(492, 264);
            this.listViewProject.TabIndex = 32;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewProject_ItemSelectionChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(1280, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 25);
            this.label19.TabIndex = 33;
            this.label19.Text = "Project List";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(1539, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 25);
            this.label13.TabIndex = 34;
            this.label13.Text = "Mode:";
            // 
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 751);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.listViewProject);
            this.Controls.Add(this.comboBoxMode);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeViewEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.buttonExpand);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonReset);
            this.Name = "ManageProjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Projects";
            this.Load += new System.EventHandler(this.ManageProjects_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewEmployee;
        private System.Windows.Forms.Button buttonConfirmAdd;
        private System.Windows.Forms.Button buttonAddSearchForTeams;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxAddRevenue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddPN;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonConfirmEdit;
        private System.Windows.Forms.TextBox textBoxViewEditRevenue;
        private System.Windows.Forms.Button buttonViewEditSearchForTeams;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxViewEditPN;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.ListView listViewProject;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxAddTL;
        private System.Windows.Forms.ComboBox comboBoxViewEditTL;
    }
}