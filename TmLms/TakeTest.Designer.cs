namespace TmLms
{
    partial class TakeTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeTest));
            this.questionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quizComboBox = new System.Windows.Forms.ComboBox();
            this.takeExamLbl = new System.Windows.Forms.Label();
            this.rightArrowPic = new System.Windows.Forms.PictureBox();
            this.leftArrowPic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentIndexTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsPanel
            // 
            this.questionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.questionsPanel.Location = new System.Drawing.Point(0, 226);
            this.questionsPanel.MaximumSize = new System.Drawing.Size(1006, 593);
            this.questionsPanel.MinimumSize = new System.Drawing.Size(1006, 593);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(1006, 593);
            this.questionsPanel.TabIndex = 0;
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(192, 122);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(246, 28);
            this.moduleComboBox.TabIndex = 1;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(575, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Quiz";
            // 
            // quizComboBox
            // 
            this.quizComboBox.FormattingEnabled = true;
            this.quizComboBox.Location = new System.Drawing.Point(506, 122);
            this.quizComboBox.Name = "quizComboBox";
            this.quizComboBox.Size = new System.Drawing.Size(246, 28);
            this.quizComboBox.TabIndex = 3;
            this.quizComboBox.SelectedIndexChanged += new System.EventHandler(this.quizComboBox_SelectedIndexChanged);
            // 
            // takeExamLbl
            // 
            this.takeExamLbl.AutoSize = true;
            this.takeExamLbl.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.takeExamLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.takeExamLbl.Location = new System.Drawing.Point(317, 9);
            this.takeExamLbl.Name = "takeExamLbl";
            this.takeExamLbl.Size = new System.Drawing.Size(255, 45);
            this.takeExamLbl.TabIndex = 5;
            this.takeExamLbl.Text = "        Take Exam";
            // 
            // rightArrowPic
            // 
            this.rightArrowPic.Image = global::TmLms.Properties.Resources.Arrow_R;
            this.rightArrowPic.Location = new System.Drawing.Point(938, 181);
            this.rightArrowPic.Name = "rightArrowPic";
            this.rightArrowPic.Size = new System.Drawing.Size(68, 89);
            this.rightArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rightArrowPic.TabIndex = 7;
            this.rightArrowPic.TabStop = false;
            this.rightArrowPic.Click += new System.EventHandler(this.rightArrowPic_Click);
            // 
            // leftArrowPic
            // 
            this.leftArrowPic.Image = ((System.Drawing.Image)(resources.GetObject("leftArrowPic.Image")));
            this.leftArrowPic.Location = new System.Drawing.Point(0, 181);
            this.leftArrowPic.Name = "leftArrowPic";
            this.leftArrowPic.Size = new System.Drawing.Size(68, 89);
            this.leftArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftArrowPic.TabIndex = 8;
            this.leftArrowPic.TabStop = false;
            this.leftArrowPic.Click += new System.EventHandler(this.leftArrowPic_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(234, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Student Index";
            // 
            // studentIndexTxtBox
            // 
            this.studentIndexTxtBox.Location = new System.Drawing.Point(395, 177);
            this.studentIndexTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.studentIndexTxtBox.Name = "studentIndexTxtBox";
            this.studentIndexTxtBox.Size = new System.Drawing.Size(395, 27);
            this.studentIndexTxtBox.TabIndex = 11;
            // 
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 819);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.studentIndexTxtBox);
            this.Controls.Add(this.rightArrowPic);
            this.Controls.Add(this.leftArrowPic);
            this.Controls.Add(this.takeExamLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quizComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleComboBox);
            this.Controls.Add(this.questionsPanel);
            this.MaximumSize = new System.Drawing.Size(1025, 866);
            this.MinimumSize = new System.Drawing.Size(1025, 866);
            this.Name = "TakeTest";
            this.Text = "TakeTest";
            ((System.ComponentModel.ISupportInitialize)(this.rightArrowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArrowPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel questionsPanel;
        private ComboBox moduleComboBox;
        private Label label1;
        private Label label2;
        private ComboBox quizComboBox;
        private Label takeExamLbl;
        private PictureBox rightArrowPic;
        private PictureBox leftArrowPic;
        private Label label3;
        private TextBox studentIndexTxtBox;
    }
}