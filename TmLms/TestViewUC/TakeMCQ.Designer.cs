namespace TmLms.TestViewUC
{
    partial class TakeMCQ
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
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.ans4RadioBtn = new System.Windows.Forms.RadioButton();
            this.ans3RadioBtn = new System.Windows.Forms.RadioButton();
            this.ans2RadioBtn = new System.Windows.Forms.RadioButton();
            this.ans1RadioBtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AllowDrop = true;
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(370, 43);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.questionLbl.MaximumSize = new System.Drawing.Size(1572, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(180, 35);
            this.questionLbl.TabIndex = 1;
            this.questionLbl.Text = "Question Text";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitAnsBtn
            // 
            this.submitAnsBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitAnsBtn.Location = new System.Drawing.Point(393, 416);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(123, 47);
            this.submitAnsBtn.TabIndex = 14;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            // 
            // ans4RadioBtn
            // 
            this.ans4RadioBtn.AutoSize = true;
            this.ans4RadioBtn.Location = new System.Drawing.Point(393, 332);
            this.ans4RadioBtn.Name = "ans4RadioBtn";
            this.ans4RadioBtn.Size = new System.Drawing.Size(123, 28);
            this.ans4RadioBtn.TabIndex = 26;
            this.ans4RadioBtn.TabStop = true;
            this.ans4RadioBtn.Text = "radioButton4";
            this.ans4RadioBtn.UseVisualStyleBackColor = true;
            // 
            // ans3RadioBtn
            // 
            this.ans3RadioBtn.AutoSize = true;
            this.ans3RadioBtn.Location = new System.Drawing.Point(393, 265);
            this.ans3RadioBtn.Name = "ans3RadioBtn";
            this.ans3RadioBtn.Size = new System.Drawing.Size(123, 28);
            this.ans3RadioBtn.TabIndex = 25;
            this.ans3RadioBtn.TabStop = true;
            this.ans3RadioBtn.Text = "radioButton3";
            this.ans3RadioBtn.UseVisualStyleBackColor = true;
            // 
            // ans2RadioBtn
            // 
            this.ans2RadioBtn.AutoSize = true;
            this.ans2RadioBtn.Location = new System.Drawing.Point(393, 198);
            this.ans2RadioBtn.Name = "ans2RadioBtn";
            this.ans2RadioBtn.Size = new System.Drawing.Size(123, 28);
            this.ans2RadioBtn.TabIndex = 24;
            this.ans2RadioBtn.TabStop = true;
            this.ans2RadioBtn.Text = "radioButton2";
            this.ans2RadioBtn.UseVisualStyleBackColor = true;
            // 
            // ans1RadioBtn
            // 
            this.ans1RadioBtn.AutoSize = true;
            this.ans1RadioBtn.Location = new System.Drawing.Point(393, 131);
            this.ans1RadioBtn.Name = "ans1RadioBtn";
            this.ans1RadioBtn.Size = new System.Drawing.Size(123, 28);
            this.ans1RadioBtn.TabIndex = 23;
            this.ans1RadioBtn.TabStop = true;
            this.ans1RadioBtn.Text = "radioButton1";
            this.ans1RadioBtn.UseVisualStyleBackColor = true;
            // 
            // TakeMCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ans4RadioBtn);
            this.Controls.Add(this.ans3RadioBtn);
            this.Controls.Add(this.ans2RadioBtn);
            this.Controls.Add(this.ans1RadioBtn);
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.questionLbl);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1006, 593);
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "TakeMCQ";
            this.Size = new System.Drawing.Size(1006, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button submitAnsBtn;
        private RadioButton ans4RadioBtn;
        private RadioButton ans3RadioBtn;
        private RadioButton ans2RadioBtn;
        private RadioButton ans1RadioBtn;
    }
}
