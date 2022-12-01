namespace TmLms
{
    partial class CreateTests
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
            this.questionsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.quizTypes = new System.Windows.Forms.ComboBox();
            this.selectQuizType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsPanel
            // 
            this.questionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsPanel.Location = new System.Drawing.Point(231, 0);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(835, 549);
            this.questionsPanel.TabIndex = 0;
            // 
            // quizTypes
            // 
            this.quizTypes.FormattingEnabled = true;
            this.quizTypes.Location = new System.Drawing.Point(12, 12);
            this.quizTypes.Name = "quizTypes";
            this.quizTypes.Size = new System.Drawing.Size(213, 28);
            this.quizTypes.TabIndex = 0;
            // 
            // selectQuizType
            // 
            this.selectQuizType.Location = new System.Drawing.Point(49, 89);
            this.selectQuizType.Name = "selectQuizType";
            this.selectQuizType.Size = new System.Drawing.Size(138, 49);
            this.selectQuizType.TabIndex = 1;
            this.selectQuizType.Text = "Select";
            this.selectQuizType.UseVisualStyleBackColor = true;
            this.selectQuizType.Click += new System.EventHandler(this.selectQuizType_Click);
            // 
            // CreateTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 550);
            this.Controls.Add(this.selectQuizType);
            this.Controls.Add(this.quizTypes);
            this.Controls.Add(this.questionsPanel);
            this.MinimumSize = new System.Drawing.Size(1083, 597);
            this.Name = "CreateTests";
            this.Text = "CreateTests";
            this.Load += new System.EventHandler(this.CreateTests_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel questionsPanel;
        private ComboBox quizTypes;
        private Button selectQuizType;
    }
}