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
            this.courseLevelCBox = new System.Windows.Forms.ComboBox();
            this.courseLevelLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructorMember
            // 
            this.instructorMember.AutoSize = true;
            this.instructorMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructorMember.Location = new System.Drawing.Point(27, 132);
            this.instructorMember.Name = "instructorMember";
            this.instructorMember.Size = new System.Drawing.Size(161, 28);
            this.instructorMember.TabIndex = 0;
            this.instructorMember.Text = "Course Instructor";
            // 
            // courseInstructorTxtbox
            // 
            this.courseInstructorTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseInstructorTxtbox.Location = new System.Drawing.Point(213, 129);
            this.courseInstructorTxtbox.Name = "courseInstructorTxtbox";
            this.courseInstructorTxtbox.Size = new System.Drawing.Size(229, 34);
            this.courseInstructorTxtbox.TabIndex = 1;
            this.courseInstructorTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // availableModules
            // 
            this.availableModules.FormattingEnabled = true;
            this.availableModules.Location = new System.Drawing.Point(638, 69);
            this.availableModules.Name = "availableModules";
            this.availableModules.Size = new System.Drawing.Size(241, 28);
            this.availableModules.TabIndex = 2;
            // 
            // addModulesLbl
            // 
            this.addModulesLbl.AutoSize = true;
            this.addModulesLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModulesLbl.Location = new System.Drawing.Point(648, 33);
            this.addModulesLbl.Name = "addModulesLbl";
            this.addModulesLbl.Size = new System.Drawing.Size(220, 28);
            this.addModulesLbl.TabIndex = 3;
            this.addModulesLbl.Text = "Add Modules To Course";
            // 
            // addModuleBtn
            // 
            this.addModuleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModuleBtn.Location = new System.Drawing.Point(710, 104);
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
            this.courseNameTxtBox.Location = new System.Drawing.Point(213, 17);
            this.courseNameTxtBox.Name = "courseNameTxtBox";
            this.courseNameTxtBox.Size = new System.Drawing.Size(229, 34);
            this.courseNameTxtBox.TabIndex = 6;
            // 
            // courseNameLbl
            // 
            this.courseNameLbl.AutoSize = true;
            this.courseNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseNameLbl.Location = new System.Drawing.Point(27, 20);
            this.courseNameLbl.Name = "courseNameLbl";
            this.courseNameLbl.Size = new System.Drawing.Size(129, 28);
            this.courseNameLbl.TabIndex = 5;
            this.courseNameLbl.Text = "Course Name";
            // 
            // courseCodeTxtBox
            // 
            this.courseCodeTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseCodeTxtBox.Location = new System.Drawing.Point(213, 75);
            this.courseCodeTxtBox.Name = "courseCodeTxtBox";
            this.courseCodeTxtBox.Size = new System.Drawing.Size(229, 34);
            this.courseCodeTxtBox.TabIndex = 8;
            // 
            // courseCodeLbl
            // 
            this.courseCodeLbl.AutoSize = true;
            this.courseCodeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseCodeLbl.Location = new System.Drawing.Point(27, 78);
            this.courseCodeLbl.Name = "courseCodeLbl";
            this.courseCodeLbl.Size = new System.Drawing.Size(123, 28);
            this.courseCodeLbl.TabIndex = 7;
            this.courseCodeLbl.Text = "Course Code";
            // 
            // courseLevelCBox
            // 
            this.courseLevelCBox.FormattingEnabled = true;
            this.courseLevelCBox.Location = new System.Drawing.Point(213, 235);
            this.courseLevelCBox.Name = "courseLevelCBox";
            this.courseLevelCBox.Size = new System.Drawing.Size(241, 28);
            this.courseLevelCBox.TabIndex = 9;
            // 
            // courseLevelLbl
            // 
            this.courseLevelLbl.AutoSize = true;
            this.courseLevelLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseLevelLbl.Location = new System.Drawing.Point(27, 235);
            this.courseLevelLbl.Name = "courseLevelLbl";
            this.courseLevelLbl.Size = new System.Drawing.Size(121, 28);
            this.courseLevelLbl.TabIndex = 10;
            this.courseLevelLbl.Text = "Course Level";
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 517);
            this.Controls.Add(this.courseLevelLbl);
            this.Controls.Add(this.courseLevelCBox);
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
        internal ComboBox courseLevelCBox;
        private Label courseLevelLbl;
    }
}