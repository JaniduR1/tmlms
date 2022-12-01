namespace TmLms
{
    partial class MainScreen
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
            this.createModuleBtn = new System.Windows.Forms.Button();
            this.createCourseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.viewCoursesBtn = new System.Windows.Forms.Button();
            this.viewModuleBtn = new System.Windows.Forms.Button();
            this.takeTestBtn = new System.Windows.Forms.Button();
            this.createTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createModuleBtn
            // 
            this.createModuleBtn.Location = new System.Drawing.Point(11, 74);
            this.createModuleBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createModuleBtn.Name = "createModuleBtn";
            this.createModuleBtn.Size = new System.Drawing.Size(133, 58);
            this.createModuleBtn.TabIndex = 3;
            this.createModuleBtn.Text = "Add/Delete Modules";
            this.createModuleBtn.UseVisualStyleBackColor = true;
            this.createModuleBtn.Click += new System.EventHandler(this.createModuleBtn_Click);
            // 
            // createCourseBtn
            // 
            this.createCourseBtn.Location = new System.Drawing.Point(11, 12);
            this.createCourseBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createCourseBtn.Name = "createCourseBtn";
            this.createCourseBtn.Size = new System.Drawing.Size(133, 56);
            this.createCourseBtn.TabIndex = 4;
            this.createCourseBtn.Text = "Add/Delete Courses";
            this.createCourseBtn.UseVisualStyleBackColor = true;
            this.createCourseBtn.Click += new System.EventHandler(this.createCourseBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(149, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 545);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // viewCoursesBtn
            // 
            this.viewCoursesBtn.Location = new System.Drawing.Point(11, 270);
            this.viewCoursesBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewCoursesBtn.Name = "viewCoursesBtn";
            this.viewCoursesBtn.Size = new System.Drawing.Size(133, 36);
            this.viewCoursesBtn.TabIndex = 7;
            this.viewCoursesBtn.Text = "View Courses";
            this.viewCoursesBtn.UseVisualStyleBackColor = true;
            // 
            // viewModuleBtn
            // 
            this.viewModuleBtn.Location = new System.Drawing.Point(11, 312);
            this.viewModuleBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.viewModuleBtn.Name = "viewModuleBtn";
            this.viewModuleBtn.Size = new System.Drawing.Size(133, 33);
            this.viewModuleBtn.TabIndex = 6;
            this.viewModuleBtn.Text = "View Module";
            this.viewModuleBtn.UseVisualStyleBackColor = true;
            // 
            // takeTestBtn
            // 
            this.takeTestBtn.Location = new System.Drawing.Point(11, 483);
            this.takeTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.takeTestBtn.Name = "takeTestBtn";
            this.takeTestBtn.Size = new System.Drawing.Size(133, 36);
            this.takeTestBtn.TabIndex = 8;
            this.takeTestBtn.Text = "Tests";
            this.takeTestBtn.UseVisualStyleBackColor = true;
            // 
            // createTestBtn
            // 
            this.createTestBtn.Location = new System.Drawing.Point(11, 191);
            this.createTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createTestBtn.Name = "createTestBtn";
            this.createTestBtn.Size = new System.Drawing.Size(133, 36);
            this.createTestBtn.TabIndex = 9;
            this.createTestBtn.Text = "Create Tests";
            this.createTestBtn.UseVisualStyleBackColor = true;
            this.createTestBtn.Click += new System.EventHandler(this.createTestBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 531);
            this.Controls.Add(this.createTestBtn);
            this.Controls.Add(this.takeTestBtn);
            this.Controls.Add(this.viewCoursesBtn);
            this.Controls.Add(this.viewModuleBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createCourseBtn);
            this.Controls.Add(this.createModuleBtn);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        public Button createModuleBtn;
        public Button createCourseBtn;
        private Label label1;
        public Button viewCoursesBtn;
        public Button viewModuleBtn;
        public Button takeTestBtn;
        public Button createTestBtn;
    }
}