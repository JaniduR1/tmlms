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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quizComboBox = new System.Windows.Forms.ComboBox();
            this.takeExamLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 226);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1006, 593);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1006, 593);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1006, 593);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(21, 161);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(246, 28);
            this.moduleComboBox.TabIndex = 1;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(404, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Quiz";
            // 
            // quizComboBox
            // 
            this.quizComboBox.FormattingEnabled = true;
            this.quizComboBox.Location = new System.Drawing.Point(335, 161);
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
            // TakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 819);
            this.Controls.Add(this.takeExamLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quizComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleComboBox);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1025, 866);
            this.MinimumSize = new System.Drawing.Size(1025, 866);
            this.Name = "TakeTest";
            this.Text = "TakeTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox moduleComboBox;
        private Label label1;
        private Label label2;
        private ComboBox quizComboBox;
        private Label takeExamLbl;
    }
}