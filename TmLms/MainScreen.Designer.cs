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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.createModuleBtn = new System.Windows.Forms.Button();
            this.createCourseBtn = new System.Windows.Forms.Button();
            this.takeTestBtn = new System.Windows.Forms.Button();
            this.createTestBtn = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gradeTestBtn = new System.Windows.Forms.Button();
            this.userScreenView = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // createModuleBtn
            // 
            this.createModuleBtn.Location = new System.Drawing.Point(83, 223);
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
            this.createCourseBtn.Location = new System.Drawing.Point(83, 161);
            this.createCourseBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createCourseBtn.Name = "createCourseBtn";
            this.createCourseBtn.Size = new System.Drawing.Size(133, 56);
            this.createCourseBtn.TabIndex = 4;
            this.createCourseBtn.Text = "Add/Delete Courses";
            this.createCourseBtn.UseVisualStyleBackColor = true;
            this.createCourseBtn.Click += new System.EventHandler(this.createCourseBtn_Click);
            // 
            // takeTestBtn
            // 
            this.takeTestBtn.Location = new System.Drawing.Point(83, 449);
            this.takeTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.takeTestBtn.Name = "takeTestBtn";
            this.takeTestBtn.Size = new System.Drawing.Size(133, 36);
            this.takeTestBtn.TabIndex = 8;
            this.takeTestBtn.Text = "Available Tests";
            this.takeTestBtn.UseVisualStyleBackColor = true;
            this.takeTestBtn.Click += new System.EventHandler(this.takeTestBtn_Click);
            // 
            // createTestBtn
            // 
            this.createTestBtn.Location = new System.Drawing.Point(83, 315);
            this.createTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.createTestBtn.Name = "createTestBtn";
            this.createTestBtn.Size = new System.Drawing.Size(133, 36);
            this.createTestBtn.TabIndex = 9;
            this.createTestBtn.Text = "Create Tests";
            this.createTestBtn.UseVisualStyleBackColor = true;
            this.createTestBtn.Click += new System.EventHandler(this.createTestBtn_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(65, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(171, 152);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 10;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.gradeTestBtn);
            this.splitContainer1.Panel1.Controls.Add(this.logoPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.createTestBtn);
            this.splitContainer1.Panel1.Controls.Add(this.createCourseBtn);
            this.splitContainer1.Panel1.Controls.Add(this.takeTestBtn);
            this.splitContainer1.Panel1.Controls.Add(this.createModuleBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel2.Controls.Add(this.userScreenView);
            this.splitContainer1.Size = new System.Drawing.Size(881, 539);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 11;
            // 
            // gradeTestBtn
            // 
            this.gradeTestBtn.Location = new System.Drawing.Point(83, 357);
            this.gradeTestBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gradeTestBtn.Name = "gradeTestBtn";
            this.gradeTestBtn.Size = new System.Drawing.Size(133, 36);
            this.gradeTestBtn.TabIndex = 11;
            this.gradeTestBtn.Text = "Grade Tests";
            this.gradeTestBtn.UseVisualStyleBackColor = true;
            this.gradeTestBtn.Click += new System.EventHandler(this.gradeTestBtn_Click);
            // 
            // userScreenView
            // 
            this.userScreenView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.userScreenView.Location = new System.Drawing.Point(-6, 0);
            this.userScreenView.Name = "userScreenView";
            this.userScreenView.Size = new System.Drawing.Size(590, 540);
            this.userScreenView.TabIndex = 0;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 539);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Button createModuleBtn;
        public Button createCourseBtn;
        public Button takeTestBtn;
        public Button createTestBtn;
        private PictureBox logoPictureBox;
        private SplitContainer splitContainer1;
        public Button gradeTestBtn;
        private FlowLayoutPanel userScreenView;
    }
}