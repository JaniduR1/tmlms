namespace TmLms.AddQuestionsUC
{
    partial class AddTFQ
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
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.tfqLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionTxtBox = new System.Windows.Forms.TextBox();
            this.trueRadioBtn = new System.Windows.Forms.RadioButton();
            this.falseRadioBtn = new System.Windows.Forms.RadioButton();
            this.corrAnsT = new System.Windows.Forms.CheckBox();
            this.corrAnsF = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestionBtn.Location = new System.Drawing.Point(421, 457);
            this.addQuestionBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(192, 59);
            this.addQuestionBtn.TabIndex = 37;
            this.addQuestionBtn.Text = "Add Question";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // tfqLbl
            // 
            this.tfqLbl.AutoSize = true;
            this.tfqLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tfqLbl.Location = new System.Drawing.Point(365, 26);
            this.tfqLbl.Name = "tfqLbl";
            this.tfqLbl.Size = new System.Drawing.Size(290, 32);
            this.tfqLbl.TabIndex = 36;
            this.tfqLbl.Text = "True False Question";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(83, 158);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(91, 25);
            this.questionLbl.TabIndex = 33;
            this.questionLbl.Text = "Question";
            // 
            // questionTxtBox
            // 
            this.questionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTxtBox.Location = new System.Drawing.Point(237, 128);
            this.questionTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionTxtBox.Multiline = true;
            this.questionTxtBox.Name = "questionTxtBox";
            this.questionTxtBox.Size = new System.Drawing.Size(686, 96);
            this.questionTxtBox.TabIndex = 32;
            // 
            // trueRadioBtn
            // 
            this.trueRadioBtn.AutoSize = true;
            this.trueRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trueRadioBtn.Location = new System.Drawing.Point(478, 292);
            this.trueRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trueRadioBtn.Name = "trueRadioBtn";
            this.trueRadioBtn.Size = new System.Drawing.Size(74, 29);
            this.trueRadioBtn.TabIndex = 38;
            this.trueRadioBtn.TabStop = true;
            this.trueRadioBtn.Text = "True";
            this.trueRadioBtn.UseVisualStyleBackColor = true;
            // 
            // falseRadioBtn
            // 
            this.falseRadioBtn.AutoSize = true;
            this.falseRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.falseRadioBtn.Location = new System.Drawing.Point(478, 356);
            this.falseRadioBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.falseRadioBtn.Name = "falseRadioBtn";
            this.falseRadioBtn.Size = new System.Drawing.Size(81, 29);
            this.falseRadioBtn.TabIndex = 39;
            this.falseRadioBtn.TabStop = true;
            this.falseRadioBtn.Text = "False";
            this.falseRadioBtn.UseVisualStyleBackColor = true;
            // 
            // corrAnsT
            // 
            this.corrAnsT.AutoSize = true;
            this.corrAnsT.Location = new System.Drawing.Point(567, 297);
            this.corrAnsT.Name = "corrAnsT";
            this.corrAnsT.Size = new System.Drawing.Size(131, 24);
            this.corrAnsT.TabIndex = 40;
            this.corrAnsT.Text = "Correct Answer";
            this.corrAnsT.UseVisualStyleBackColor = true;
            // 
            // corrAnsF
            // 
            this.corrAnsF.AutoSize = true;
            this.corrAnsF.Location = new System.Drawing.Point(567, 361);
            this.corrAnsF.Name = "corrAnsF";
            this.corrAnsF.Size = new System.Drawing.Size(131, 24);
            this.corrAnsF.TabIndex = 41;
            this.corrAnsF.Text = "Correct Answer";
            this.corrAnsF.UseVisualStyleBackColor = true;
            // 
            // AddTFQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.corrAnsF);
            this.Controls.Add(this.corrAnsT);
            this.Controls.Add(this.falseRadioBtn);
            this.Controls.Add(this.trueRadioBtn);
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.tfqLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.questionTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1006, 593);
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "AddTFQ";
            this.Size = new System.Drawing.Size(1006, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.Label tfqLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox questionTxtBox;
        private System.Windows.Forms.RadioButton trueRadioBtn;
        private System.Windows.Forms.RadioButton falseRadioBtn;
        private CheckBox corrAnsT;
        private CheckBox corrAnsF;
    }
}
