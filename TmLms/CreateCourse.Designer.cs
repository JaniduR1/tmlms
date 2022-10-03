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
            this.createNewCourseBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.NameOfCourseLbl = new System.Windows.Forms.Label();
            this.courseLevelLbl = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // createNewCourseBtn
            // 
            this.createNewCourseBtn.Location = new System.Drawing.Point(281, 282);
            this.createNewCourseBtn.Name = "createNewCourseBtn";
            this.createNewCourseBtn.Size = new System.Drawing.Size(182, 61);
            this.createNewCourseBtn.TabIndex = 0;
            this.createNewCourseBtn.Text = "Create New Course";
            this.createNewCourseBtn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(205, 29);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // NameOfCourseLbl
            // 
            this.NameOfCourseLbl.AutoSize = true;
            this.NameOfCourseLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameOfCourseLbl.Location = new System.Drawing.Point(37, 27);
            this.NameOfCourseLbl.Name = "NameOfCourseLbl";
            this.NameOfCourseLbl.Size = new System.Drawing.Size(144, 25);
            this.NameOfCourseLbl.TabIndex = 2;
            this.NameOfCourseLbl.Text = "Name Of Course";
            // 
            // courseLevelLbl
            // 
            this.courseLevelLbl.AutoSize = true;
            this.courseLevelLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.courseLevelLbl.Location = new System.Drawing.Point(37, 76);
            this.courseLevelLbl.Name = "courseLevelLbl";
            this.courseLevelLbl.Size = new System.Drawing.Size(111, 25);
            this.courseLevelLbl.TabIndex = 4;
            this.courseLevelLbl.Text = "Course Level";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Level 4",
            "Level 5",
            "Level 6"});
            this.comboBox1.Location = new System.Drawing.Point(186, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(205, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // CreateCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.courseLevelLbl);
            this.Controls.Add(this.NameOfCourseLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.createNewCourseBtn);
            this.Name = "CreateCourse";
            this.Text = "CreateCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button createNewCourseBtn;
        private RichTextBox richTextBox1;
        private Label NameOfCourseLbl;
        private Label courseLevelLbl;
        private ComboBox comboBox1;
    }
}