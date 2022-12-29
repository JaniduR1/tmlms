namespace TmLms
{
    partial class CreateCourse
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
            this.instructorMember = new System.Windows.Forms.Label();
            this.courseInstructorTxtbox = new System.Windows.Forms.TextBox();
            this.availableModules = new System.Windows.Forms.ComboBox();
            this.addModulesLbl = new System.Windows.Forms.Label();
            this.addModuleBtn = new System.Windows.Forms.Button();
            this.courseNameTxtBox = new System.Windows.Forms.TextBox();
            this.courseNameLbl = new System.Windows.Forms.Label();
            this.courseCodeTxtBox = new System.Windows.Forms.TextBox();
            this.courseCodeLbl = new System.Windows.Forms.Label();
            this.createCourseBtn = new System.Windows.Forms.Button();
            this.chosenModules = new System.Windows.Forms.ListView();
            this.moduleCode = new System.Windows.Forms.ColumnHeader();
            this.moduleName = new System.Windows.Forms.ColumnHeader();
            this.moduleCredits = new System.Windows.Forms.ColumnHeader();
            this.moduleIsCore = new System.Windows.Forms.ColumnHeader();
            this.isCoreCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // instructorMember
            // 
            this.instructorMember.AutoSize = true;
            this.instructorMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructorMember.Location = new System.Drawing.Point(27, 279);
            this.instructorMember.Name = "instructorMember";
            this.instructorMember.Size = new System.Drawing.Size(161, 28);
            this.instructorMember.TabIndex = 0;
            this.instructorMember.Text = "Course Instructor";
            // 
            // courseInstructorTxtbox
            // 
            this.courseInstructorTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseInstructorTxtbox.Location = new System.Drawing.Point(213, 276);
            this.courseInstructorTxtbox.Name = "courseInstructorTxtbox";
            this.courseInstructorTxtbox.Size = new System.Drawing.Size(229, 34);
            this.courseInstructorTxtbox.TabIndex = 1;
            this.courseInstructorTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // availableModules
            // 
            this.availableModules.FormattingEnabled = true;
            this.availableModules.Location = new System.Drawing.Point(920, 72);
            this.availableModules.Name = "availableModules";
            this.availableModules.Size = new System.Drawing.Size(241, 28);
            this.availableModules.TabIndex = 2;
            // 
            // addModulesLbl
            // 
            this.addModulesLbl.AutoSize = true;
            this.addModulesLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModulesLbl.Location = new System.Drawing.Point(930, 36);
            this.addModulesLbl.Name = "addModulesLbl";
            this.addModulesLbl.Size = new System.Drawing.Size(220, 28);
            this.addModulesLbl.TabIndex = 3;
            this.addModulesLbl.Text = "Add Modules To Course";
            // 
            // addModuleBtn
            // 
            this.addModuleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModuleBtn.Location = new System.Drawing.Point(1067, 106);
            this.addModuleBtn.Name = "addModuleBtn";
            this.addModuleBtn.Size = new System.Drawing.Size(94, 36);
            this.addModuleBtn.TabIndex = 4;
            this.addModuleBtn.Text = "Add";
            this.addModuleBtn.UseVisualStyleBackColor = true;
            this.addModuleBtn.Click += new System.EventHandler(this.addModuleBtn_Click);
            // 
            // courseNameTxtBox
            // 
            this.courseNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseNameTxtBox.Location = new System.Drawing.Point(213, 122);
            this.courseNameTxtBox.Name = "courseNameTxtBox";
            this.courseNameTxtBox.Size = new System.Drawing.Size(229, 34);
            this.courseNameTxtBox.TabIndex = 6;
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseNameLbl.Location = new System.Drawing.Point(27, 125);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(129, 28);
            this.courseNameLbl.TabIndex = 5;
            this.courseNameLbl.Text = "Course Name";
            // 
            // courseCodeTxtBox
            // 
            this.courseCodeTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseCodeTxtBox.Location = new System.Drawing.Point(213, 193);
            this.courseCodeTxtBox.Name = "courseCodeTxtBox";
            this.courseCodeTxtBox.Size = new System.Drawing.Size(229, 34);
            this.courseCodeTxtBox.TabIndex = 8;
            // 
            // courseCodeLbl
            // 
            this.courseCodeLbl.AutoSize = true;
            this.courseCodeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseCodeLbl.Location = new System.Drawing.Point(27, 196);
            this.courseCodeLbl.Name = "courseCodeLbl";
            this.courseCodeLbl.Size = new System.Drawing.Size(123, 28);
            this.courseCodeLbl.TabIndex = 7;
            this.courseCodeLbl.Text = "Course Code";
            // 
            // createCourseBtn
            // 
            this.createCourseBtn.Location = new System.Drawing.Point(133, 476);
            this.createCourseBtn.Name = "createCourseBtn";
            this.createCourseBtn.Size = new System.Drawing.Size(141, 47);
            this.createCourseBtn.TabIndex = 11;
            this.createCourseBtn.Text = "Create Course";
            this.createCourseBtn.UseVisualStyleBackColor = true;
            this.createCourseBtn.Click += new System.EventHandler(this.createCourseBtn_Click);
            // 
            // chosenModules
            // 
            this.chosenModules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.moduleCode,
            this.moduleName,
            this.moduleCredits,
            this.moduleIsCore});
            this.chosenModules.Location = new System.Drawing.Point(586, 178);
            this.chosenModules.Name = "chosenModules";
            this.chosenModules.Size = new System.Drawing.Size(575, 366);
            this.chosenModules.TabIndex = 12;
            this.chosenModules.UseCompatibleStateImageBehavior = false;
            this.chosenModules.View = System.Windows.Forms.View.Details;
            // 
            // moduleCode
            // 
            this.moduleCode.Text = "Module Code";
            this.moduleCode.Width = 140;
            // 
            // moduleName
            // 
            this.moduleName.Text = "Module Name";
            this.moduleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moduleName.Width = 170;
            // 
            // moduleCredits
            // 
            this.moduleCredits.Text = "Module Credits";
            this.moduleCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moduleCredits.Width = 120;
            // 
            // moduleIsCore
            // 
            this.moduleIsCore.Text = "Type";
            this.moduleIsCore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moduleIsCore.Width = 140;
            // 
            // isCoreCheckBox
            // 
            this.isCoreCheckBox.AutoSize = true;
            this.isCoreCheckBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isCoreCheckBox.Location = new System.Drawing.Point(920, 116);
            this.isCoreCheckBox.Name = "isCoreCheckBox";
            this.isCoreCheckBox.Size = new System.Drawing.Size(79, 24);
            this.isCoreCheckBox.TabIndex = 13;
            this.isCoreCheckBox.Text = "Is Core";
            this.isCoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 556);
            this.Controls.Add(this.isCoreCheckBox);
            this.Controls.Add(this.chosenModules);
            this.Controls.Add(this.createCourseBtn);
            this.Controls.Add(this.courseCodeTxtBox);
            this.Controls.Add(this.courseCodeLbl);
            this.Controls.Add(this.courseNameTxtBox);
            this.Controls.Add(this.courseNameLbl);
            this.Controls.Add(this.addModuleBtn);
            this.Controls.Add(this.addModulesLbl);
            this.Controls.Add(this.availableModules);
            this.Controls.Add(this.courseInstructorTxtbox);
            this.Controls.Add(this.instructorMember);
            this.Name = "CreateCourse";
            this.Text = "CreateCourse";
            this.Load += new System.EventHandler(this.CreateCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label instructorMember;
        private TextBox courseInstructorTxtbox;
        private Label addModulesLbl;
        private Button addModuleBtn;
        internal ComboBox availableModules;
        private TextBox courseNameTxtBox;
        private Label courseNameLbl;
        private TextBox courseCodeTxtBox;
        private Label courseCodeLbl;
        private Button createCourseBtn;
        private ListView chosenModules;
        private ColumnHeader moduleCode;
        private ColumnHeader moduleName;
        private ColumnHeader moduleCredits;
        private ColumnHeader moduleIsCore;
        private CheckBox isCoreCheckBox;
    }
}