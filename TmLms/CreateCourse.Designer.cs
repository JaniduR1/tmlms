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
            this.SuspendLayout();
            // 
            // instructorMember
            // 
            this.instructorMember.AutoSize = true;
            this.instructorMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructorMember.Location = new System.Drawing.Point(28, 42);
            this.instructorMember.Name = "instructorMember";
            this.instructorMember.Size = new System.Drawing.Size(161, 28);
            this.instructorMember.TabIndex = 0;
            this.instructorMember.Text = "Course Instructor";
            // 
            // courseInstructorTxtbox
            // 
            this.courseInstructorTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseInstructorTxtbox.Location = new System.Drawing.Point(212, 42);
            this.courseInstructorTxtbox.Name = "courseInstructorTxtbox";
            this.courseInstructorTxtbox.Size = new System.Drawing.Size(229, 34);
            this.courseInstructorTxtbox.TabIndex = 1;
            this.courseInstructorTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // availableModules
            // 
            this.availableModules.FormattingEnabled = true;
            this.availableModules.Location = new System.Drawing.Point(619, 46);
            this.availableModules.Name = "availableModules";
            this.availableModules.Size = new System.Drawing.Size(241, 28);
            this.availableModules.TabIndex = 2;
            // 
            // addModulesLbl
            // 
            this.addModulesLbl.AutoSize = true;
            this.addModulesLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModulesLbl.Location = new System.Drawing.Point(628, 9);
            this.addModulesLbl.Name = "addModulesLbl";
            this.addModulesLbl.Size = new System.Drawing.Size(220, 28);
            this.addModulesLbl.TabIndex = 3;
            this.addModulesLbl.Text = "Add Modules To Course";
            // 
            // addModuleBtn
            // 
            this.addModuleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModuleBtn.Location = new System.Drawing.Point(691, 80);
            this.addModuleBtn.Name = "addModuleBtn";
            this.addModuleBtn.Size = new System.Drawing.Size(94, 36);
            this.addModuleBtn.TabIndex = 4;
            this.addModuleBtn.Text = "Add";
            this.addModuleBtn.UseVisualStyleBackColor = true;
            this.addModuleBtn.Click += new System.EventHandler(this.addModuleBtn_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 518);
            this.Controls.Add(this.addModuleBtn);
            this.Controls.Add(this.addModulesLbl);
            this.Controls.Add(this.availableModules);
            this.Controls.Add(this.courseInstructorTxtbox);
            this.Controls.Add(this.instructorMember);
            this.Name = "CreateCourse";
            this.Text = "CreateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label instructorMember;
        private TextBox courseInstructorTxtbox;
        private Label addModulesLbl;
        private Button addModuleBtn;
        internal ComboBox availableModules;
    }
}