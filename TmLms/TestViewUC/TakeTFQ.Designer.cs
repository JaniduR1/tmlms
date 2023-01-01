namespace TmLms.TestViewUC
{
    partial class TakeTFQ
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
            this.trueRadioBtn = new System.Windows.Forms.RadioButton();
            this.falseRadioBtn = new System.Windows.Forms.RadioButton();
            this.questionLbl = new System.Windows.Forms.Label();
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trueRadioBtn
            // 
            this.trueRadioBtn.AutoSize = true;
            this.trueRadioBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trueRadioBtn.Location = new System.Drawing.Point(425, 235);
            this.trueRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trueRadioBtn.Name = "trueRadioBtn";
            this.trueRadioBtn.Size = new System.Drawing.Size(123, 28);
            this.trueRadioBtn.TabIndex = 8;
            this.trueRadioBtn.TabStop = true;
            this.trueRadioBtn.Text = "radioButton1";
            this.trueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // falseRadioBtn
            // 
            this.falseRadioBtn.AutoSize = true;
            this.falseRadioBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.falseRadioBtn.Location = new System.Drawing.Point(425, 349);
            this.falseRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.falseRadioBtn.Name = "falseRadioBtn";
            this.falseRadioBtn.Size = new System.Drawing.Size(123, 28);
            this.falseRadioBtn.TabIndex = 9;
            this.falseRadioBtn.TabStop = true;
            this.falseRadioBtn.Text = "radioButton1";
            this.falseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(396, 90);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.questionLbl.MaximumSize = new System.Drawing.Size(1572, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(180, 35);
            this.questionLbl.TabIndex = 2;
            this.questionLbl.Text = "Question Text";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // submitAnsBtn
            // 
            this.submitAnsBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitAnsBtn.Location = new System.Drawing.Point(435, 479);
            this.submitAnsBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(125, 59);
            this.submitAnsBtn.TabIndex = 14;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            // 
            // TakeTFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.falseRadioBtn);
            this.Controls.Add(this.trueRadioBtn);
            this.Controls.Add(this.questionLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1006, 593);
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "TakeTFQ";
            this.Size = new System.Drawing.Size(1006, 593);
            this.Load += new System.EventHandler(this.TakeTFQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton trueRadioBtn;
        private System.Windows.Forms.RadioButton falseRadioBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Button submitAnsBtn;
    }
}
