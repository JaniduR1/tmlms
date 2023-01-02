namespace TmLms.TestViewUC

{
    partial class TakeEQ
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(433, 35);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.questionLbl.MaximumSize = new System.Drawing.Size(1572, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(180, 35);
            this.questionLbl.TabIndex = 8;
            this.questionLbl.Text = "Question Text";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextBox.Location = new System.Drawing.Point(17, 107);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(969, 402);
            this.answerTextBox.TabIndex = 10;
            // 
            // submitAnsBtn
            // 
            this.submitAnsBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitAnsBtn.Location = new System.Drawing.Point(471, 517);
            this.submitAnsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(125, 59);
            this.submitAnsBtn.TabIndex = 14;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            // 
            // TakeEQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1006, 593);
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "TakeEQ";
            this.Size = new System.Drawing.Size(1006, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button submitAnsBtn;
    }
}
