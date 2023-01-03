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
            this.ans4ChkBox = new System.Windows.Forms.CheckBox();
            this.ans3ChkBox = new System.Windows.Forms.CheckBox();
            this.ans2ChkBox = new System.Windows.Forms.CheckBox();
            this.ans1ChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AllowDrop = true;
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(370, 52);
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
            this.submitAnsBtn.Location = new System.Drawing.Point(391, 416);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(125, 47);
            this.submitAnsBtn.TabIndex = 14;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            // 
            // ans4ChkBox
            // 
            this.ans4ChkBox.AutoSize = true;
            this.ans4ChkBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans4ChkBox.Location = new System.Drawing.Point(405, 343);
            this.ans4ChkBox.Margin = new System.Windows.Forms.Padding(4);
            this.ans4ChkBox.Name = "ans4ChkBox";
            this.ans4ChkBox.Size = new System.Drawing.Size(111, 28);
            this.ans4ChkBox.TabIndex = 18;
            this.ans4ChkBox.Text = "checkBox4";
            this.ans4ChkBox.UseVisualStyleBackColor = true;
            // 
            // ans3ChkBox
            // 
            this.ans3ChkBox.AutoSize = true;
            this.ans3ChkBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans3ChkBox.Location = new System.Drawing.Point(405, 278);
            this.ans3ChkBox.Margin = new System.Windows.Forms.Padding(4);
            this.ans3ChkBox.Name = "ans3ChkBox";
            this.ans3ChkBox.Size = new System.Drawing.Size(111, 28);
            this.ans3ChkBox.TabIndex = 17;
            this.ans3ChkBox.Text = "checkBox3";
            this.ans3ChkBox.UseVisualStyleBackColor = true;
            // 
            // ans2ChkBox
            // 
            this.ans2ChkBox.AutoSize = true;
            this.ans2ChkBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans2ChkBox.Location = new System.Drawing.Point(405, 213);
            this.ans2ChkBox.Margin = new System.Windows.Forms.Padding(4);
            this.ans2ChkBox.Name = "ans2ChkBox";
            this.ans2ChkBox.Size = new System.Drawing.Size(111, 28);
            this.ans2ChkBox.TabIndex = 16;
            this.ans2ChkBox.Text = "checkBox2";
            this.ans2ChkBox.UseVisualStyleBackColor = true;
            // 
            // ans1ChkBox
            // 
            this.ans1ChkBox.AutoSize = true;
            this.ans1ChkBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans1ChkBox.Location = new System.Drawing.Point(405, 148);
            this.ans1ChkBox.Margin = new System.Windows.Forms.Padding(4);
            this.ans1ChkBox.Name = "ans1ChkBox";
            this.ans1ChkBox.Size = new System.Drawing.Size(111, 28);
            this.ans1ChkBox.TabIndex = 15;
            this.ans1ChkBox.Text = "checkBox1";
            this.ans1ChkBox.UseVisualStyleBackColor = true;
            // 
            // TakeMCQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ans4ChkBox);
            this.Controls.Add(this.ans3ChkBox);
            this.Controls.Add(this.ans2ChkBox);
            this.Controls.Add(this.ans1ChkBox);
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
        private CheckBox ans4ChkBox;
        private CheckBox ans3ChkBox;
        private CheckBox ans2ChkBox;
        private CheckBox ans1ChkBox;
    }
}
