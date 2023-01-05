namespace TmLms
{
    partial class GradeStudents
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
            this.label1 = new System.Windows.Forms.Label();
            this.qCodeComboBox = new System.Windows.Forms.ComboBox();
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.answerFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.totalMarksLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stuIndexComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Module";
            // 
            // qCodeComboBox
            // 
            this.qCodeComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qCodeComboBox.FormattingEnabled = true;
            this.qCodeComboBox.Location = new System.Drawing.Point(321, 119);
            this.qCodeComboBox.Name = "qCodeComboBox";
            this.qCodeComboBox.Size = new System.Drawing.Size(200, 36);
            this.qCodeComboBox.TabIndex = 2;
            this.qCodeComboBox.SelectedIndexChanged += new System.EventHandler(this.qCodeComboBox_SelectedIndexChanged);
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(35, 119);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(219, 36);
            this.moduleComboBox.TabIndex = 3;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // answerFlowPanel
            // 
            this.answerFlowPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.answerFlowPanel.Location = new System.Drawing.Point(0, 189);
            this.answerFlowPanel.Name = "answerFlowPanel";
            this.answerFlowPanel.Size = new System.Drawing.Size(1033, 416);
            this.answerFlowPanel.TabIndex = 4;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.totalMarksLbl);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.stuIndexComboBox);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.submitBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.moduleComboBox);
            this.topPanel.Controls.Add(this.qCodeComboBox);
            this.topPanel.Location = new System.Drawing.Point(0, -4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1033, 198);
            this.topPanel.TabIndex = 0;
            // 
            // totalMarksLbl
            // 
            this.totalMarksLbl.AutoSize = true;
            this.totalMarksLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalMarksLbl.Location = new System.Drawing.Point(969, 18);
            this.totalMarksLbl.Name = "totalMarksLbl";
            this.totalMarksLbl.Size = new System.Drawing.Size(40, 46);
            this.totalMarksLbl.TabIndex = 8;
            this.totalMarksLbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(337, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mark Student Answers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(631, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Index";
            // 
            // stuIndexComboBox
            // 
            this.stuIndexComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stuIndexComboBox.FormattingEnabled = true;
            this.stuIndexComboBox.Location = new System.Drawing.Point(595, 119);
            this.stuIndexComboBox.Name = "stuIndexComboBox";
            this.stuIndexComboBox.Size = new System.Drawing.Size(200, 36);
            this.stuIndexComboBox.TabIndex = 5;
            this.stuIndexComboBox.SelectedIndexChanged += new System.EventHandler(this.stuIndexComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(373, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quiz Code";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(893, 118);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(116, 36);
            this.submitBtn.TabIndex = 0;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(822, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total Marks";
            // 
            // GradeStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 605);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.answerFlowPanel);
            this.Name = "GradeStudents";
            this.Text = "GradeStudents";
            this.Load += new System.EventHandler(this.GradeStudents_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private ComboBox qCodeComboBox;
        private ComboBox moduleComboBox;
        private FlowLayoutPanel answerFlowPanel;
        private Panel topPanel;
        private Label label2;
        private Label label4;
        private ComboBox stuIndexComboBox;
        private Label label3;
        private Button submitBtn;
        private Label totalMarksLbl;
        private Label label5;
    }
}