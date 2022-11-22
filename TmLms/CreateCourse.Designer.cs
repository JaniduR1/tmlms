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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // instructorMember
            // 
            this.instructorMember.AutoSize = true;
            this.instructorMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructorMember.Location = new System.Drawing.Point(24, 32);
            this.instructorMember.Name = "instructorMember";
            this.instructorMember.Size = new System.Drawing.Size(130, 21);
            this.instructorMember.TabIndex = 0;
            this.instructorMember.Text = "Course Instructor";
            // 
            // courseInstructorTxtbox
            // 
            this.courseInstructorTxtbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseInstructorTxtbox.Location = new System.Drawing.Point(186, 32);
            this.courseInstructorTxtbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseInstructorTxtbox.Name = "courseInstructorTxtbox";
            this.courseInstructorTxtbox.Size = new System.Drawing.Size(201, 29);
            this.courseInstructorTxtbox.TabIndex = 1;
            this.courseInstructorTxtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // availableModules
            // 
            this.availableModules.FormattingEnabled = true;
            this.availableModules.Location = new System.Drawing.Point(542, 34);
            this.availableModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.availableModules.Name = "availableModules";
            this.availableModules.Size = new System.Drawing.Size(211, 23);
            this.availableModules.TabIndex = 2;
            // 
            // addModulesLbl
            // 
            this.addModulesLbl.AutoSize = true;
            this.addModulesLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModulesLbl.Location = new System.Drawing.Point(550, 7);
            this.addModulesLbl.Name = "addModulesLbl";
            this.addModulesLbl.Size = new System.Drawing.Size(174, 21);
            this.addModulesLbl.TabIndex = 3;
            this.addModulesLbl.Text = "Add Modules To Course";
            // 
            // addModuleBtn
            // 
            this.addModuleBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addModuleBtn.Location = new System.Drawing.Point(605, 60);
            this.addModuleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addModuleBtn.Name = "addModuleBtn";
            this.addModuleBtn.Size = new System.Drawing.Size(82, 27);
            this.addModuleBtn.TabIndex = 4;
            this.addModuleBtn.Text = "Add";
            this.addModuleBtn.UseVisualStyleBackColor = true;
            this.addModuleBtn.Click += new System.EventHandler(this.addModuleBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addModuleBtn);
            this.Controls.Add(this.addModulesLbl);
            this.Controls.Add(this.availableModules);
            this.Controls.Add(this.courseInstructorTxtbox);
            this.Controls.Add(this.instructorMember);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private Button button1;
    }
}