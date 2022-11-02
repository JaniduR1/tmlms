namespace TmLms
{
    partial class CreateModule
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
            this.moduleNameLbl = new System.Windows.Forms.Label();
            this.moduleCodeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moduleDescriptionLbl = new System.Windows.Forms.Label();
            this.moduleDescriptionTxtBox = new System.Windows.Forms.RichTextBox();
            this.moduleAdminName = new System.Windows.Forms.TextBox();
            this.moduleAdministratorName = new System.Windows.Forms.Label();
            this.creditsDropDown = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.moduleNameTxtBox = new System.Windows.Forms.TextBox();
            this.moduleCodeTxtBox = new System.Windows.Forms.TextBox();
            this.memberNameLbl = new System.Windows.Forms.TextBox();
            this.membersLbl = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.backHomeBtn = new System.Windows.Forms.Button();
            this.memberType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // moduleNameLbl
            // 
            this.moduleNameLbl.AutoSize = true;
            this.moduleNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleNameLbl.Location = new System.Drawing.Point(15, 20);
            this.moduleNameLbl.Name = "moduleNameLbl";
            this.moduleNameLbl.Size = new System.Drawing.Size(125, 25);
            this.moduleNameLbl.TabIndex = 2;
            this.moduleNameLbl.Text = "Module Name";
            // 
            // moduleCodeLbl
            // 
            this.moduleCodeLbl.AutoSize = true;
            this.moduleCodeLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleCodeLbl.Location = new System.Drawing.Point(15, 62);
            this.moduleCodeLbl.Name = "moduleCodeLbl";
            this.moduleCodeLbl.Size = new System.Drawing.Size(120, 25);
            this.moduleCodeLbl.TabIndex = 4;
            this.moduleCodeLbl.Text = "Module Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Of Credits";
            // 
            // moduleDescriptionLbl
            // 
            this.moduleDescriptionLbl.AutoSize = true;
            this.moduleDescriptionLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleDescriptionLbl.Location = new System.Drawing.Point(15, 252);
            this.moduleDescriptionLbl.Name = "moduleDescriptionLbl";
            this.moduleDescriptionLbl.Size = new System.Drawing.Size(168, 25);
            this.moduleDescriptionLbl.TabIndex = 6;
            this.moduleDescriptionLbl.Text = "Module Description";
            // 
            // moduleDescriptionTxtBox
            // 
            this.moduleDescriptionTxtBox.Location = new System.Drawing.Point(234, 253);
            this.moduleDescriptionTxtBox.Name = "moduleDescriptionTxtBox";
            this.moduleDescriptionTxtBox.Size = new System.Drawing.Size(285, 138);
            this.moduleDescriptionTxtBox.TabIndex = 10;
            this.moduleDescriptionTxtBox.Text = "";
            // 
            // moduleAdminName
            // 
            this.moduleAdminName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleAdminName.Location = new System.Drawing.Point(234, 140);
            this.moduleAdminName.Name = "moduleAdminName";
            this.moduleAdminName.Size = new System.Drawing.Size(285, 30);
            this.moduleAdminName.TabIndex = 12;
            this.moduleAdminName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // moduleAdministratorName
            // 
            this.moduleAdministratorName.AutoSize = true;
            this.moduleAdministratorName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleAdministratorName.Location = new System.Drawing.Point(15, 141);
            this.moduleAdministratorName.Name = "moduleAdministratorName";
            this.moduleAdministratorName.Size = new System.Drawing.Size(173, 25);
            this.moduleAdministratorName.TabIndex = 11;
            this.moduleAdministratorName.Text = "Administrator Name";
            // 
            // creditsDropDown
            // 
            this.creditsDropDown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditsDropDown.FormattingEnabled = true;
            this.creditsDropDown.Items.AddRange(new object[] {
            "TWENTY (20)",
            "FORTY (40)",
            "SIXTY (60)"});
            this.creditsDropDown.Location = new System.Drawing.Point(234, 416);
            this.creditsDropDown.Name = "creditsDropDown";
            this.creditsDropDown.Size = new System.Drawing.Size(285, 31);
            this.creditsDropDown.TabIndex = 15;
            this.creditsDropDown.SelectedIndexChanged += new System.EventHandler(this.creditsDropDown_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(187, 475);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(133, 49);
            this.submitBtn.TabIndex = 17;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // moduleNameTxtBox
            // 
            this.moduleNameTxtBox.Location = new System.Drawing.Point(234, 21);
            this.moduleNameTxtBox.Name = "moduleNameTxtBox";
            this.moduleNameTxtBox.Size = new System.Drawing.Size(285, 27);
            this.moduleNameTxtBox.TabIndex = 18;
            // 
            // moduleCodeTxtBox
            // 
            this.moduleCodeTxtBox.Location = new System.Drawing.Point(234, 62);
            this.moduleCodeTxtBox.Name = "moduleCodeTxtBox";
            this.moduleCodeTxtBox.Size = new System.Drawing.Size(285, 27);
            this.moduleCodeTxtBox.TabIndex = 19;
            // 
            // memberNameLbl
            // 
            this.memberNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberNameLbl.Location = new System.Drawing.Point(960, 62);
            this.memberNameLbl.Name = "memberNameLbl";
            this.memberNameLbl.Size = new System.Drawing.Size(133, 30);
            this.memberNameLbl.TabIndex = 20;
            // 
            // membersLbl
            // 
            this.membersLbl.AutoSize = true;
            this.membersLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.membersLbl.Location = new System.Drawing.Point(634, 63);
            this.membersLbl.Name = "membersLbl";
            this.membersLbl.Size = new System.Drawing.Size(87, 25);
            this.membersLbl.TabIndex = 21;
            this.membersLbl.Text = "Members";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.Location = new System.Drawing.Point(885, 99);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(60, 31);
            this.addMemberBtn.TabIndex = 22;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            // 
            // backHomeBtn
            // 
            this.backHomeBtn.Location = new System.Drawing.Point(942, 452);
            this.backHomeBtn.Name = "backHomeBtn";
            this.backHomeBtn.Size = new System.Drawing.Size(142, 69);
            this.backHomeBtn.TabIndex = 24;
            this.backHomeBtn.Text = "Back to Main Screen";
            this.backHomeBtn.UseVisualStyleBackColor = true;
            this.backHomeBtn.Click += new System.EventHandler(this.backHomeBtn_Click);
            // 
            // memberType
            // 
            this.memberType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memberType.FormattingEnabled = true;
            this.memberType.Items.AddRange(new object[] {
            "Admin"});
            this.memberType.Location = new System.Drawing.Point(806, 62);
            this.memberType.Name = "memberType";
            this.memberType.Size = new System.Drawing.Size(76, 31);
            this.memberType.TabIndex = 23;
            // 
            // CreateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 533);
            this.Controls.Add(this.backHomeBtn);
            this.Controls.Add(this.memberType);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.membersLbl);
            this.Controls.Add(this.memberNameLbl);
            this.Controls.Add(this.moduleCodeTxtBox);
            this.Controls.Add(this.moduleNameTxtBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.creditsDropDown);
            this.Controls.Add(this.moduleAdminName);
            this.Controls.Add(this.moduleAdministratorName);
            this.Controls.Add(this.moduleDescriptionTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleDescriptionLbl);
            this.Controls.Add(this.moduleCodeLbl);
            this.Controls.Add(this.moduleNameLbl);
            this.Name = "CreateModule";
            this.Text = "CreateModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label moduleNameLbl;
        private Label moduleCodeLbl;
        private Label label1;
        private Label moduleDescriptionLbl;
        private RichTextBox moduleDescriptionTxtBox;
        private TextBox moduleAdminName;
        private Label moduleAdministratorName;
        private ComboBox creditsDropDown;
        private Button submitBtn;
        private TextBox moduleNameTxtBox;
        private TextBox moduleCodeTxtBox;
        private TextBox memberNameLbl;
        private Label membersLbl;
        private Button addMemberBtn;
        private Button backHomeBtn;
        private ComboBox memberType;
    }
}