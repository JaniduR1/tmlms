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
            this.SuspendLayout();
            // 
            // createModuleBtn
            // 
            this.createModuleBtn.Location = new System.Drawing.Point(11, 54);
            this.createModuleBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createModuleBtn.Name = "createModuleBtn";
            this.createModuleBtn.Size = new System.Drawing.Size(133, 33);
            this.createModuleBtn.TabIndex = 3;
            this.createModuleBtn.Text = "Create Module";
            this.createModuleBtn.UseVisualStyleBackColor = true;
            this.createModuleBtn.Click += new System.EventHandler(this.createModuleBtn_Click);
            // 
            // createCourseBtn
            // 
            this.createCourseBtn.Location = new System.Drawing.Point(11, 12);
            this.createCourseBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createCourseBtn.Name = "createCourseBtn";
            this.createCourseBtn.Size = new System.Drawing.Size(133, 36);
            this.createCourseBtn.TabIndex = 4;
            this.createCourseBtn.Text = "Create Course";
            this.createCourseBtn.UseVisualStyleBackColor = true;
            this.createCourseBtn.Click += new System.EventHandler(this.createCourseBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 531);
            this.Controls.Add(this.createCourseBtn);
            this.Controls.Add(this.createModuleBtn);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);

        }

        #endregion

        public Button createModuleBtn;
        public Button createCourseBtn;
    }
}