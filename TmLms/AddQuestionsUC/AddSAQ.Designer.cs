﻿namespace TmLms.AddQuestionsUC
{
    partial class AddSAQ
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
            this.saqLbl = new System.Windows.Forms.Label();
            this.answerTxtBox = new System.Windows.Forms.TextBox();
            this.answerLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestionBtn.Location = new System.Drawing.Point(489, 489);
            this.addQuestionBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(192, 59);
            this.addQuestionBtn.TabIndex = 31;
            this.addQuestionBtn.Text = "Add Question";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            this.addQuestionBtn.Click += new System.EventHandler(this.addQuestionBtn_Click);
            // 
            // saqLbl
            // 
            this.saqLbl.AutoSize = true;
            this.saqLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saqLbl.Location = new System.Drawing.Point(365, 22);
            this.saqLbl.Name = "saqLbl";
            this.saqLbl.Size = new System.Drawing.Size(326, 32);
            this.saqLbl.TabIndex = 30;
            this.saqLbl.Text = "Short Answer Question";
            // 
            // answerTxtBox
            // 
            this.answerTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTxtBox.Location = new System.Drawing.Point(237, 250);
            this.answerTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.answerTxtBox.Multiline = true;
            this.answerTxtBox.Name = "answerTxtBox";
            this.answerTxtBox.Size = new System.Drawing.Size(686, 209);
            this.answerTxtBox.TabIndex = 29;
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerLbl.Location = new System.Drawing.Point(96, 334);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(78, 25);
            this.answerLbl.TabIndex = 28;
            this.answerLbl.Text = "Answer";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(83, 154);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(91, 25);
            this.questionLbl.TabIndex = 27;
            this.questionLbl.Text = "Question";
            // 
            // questionTxtBox
            // 
            this.questionTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTxtBox.Location = new System.Drawing.Point(237, 124);
            this.questionTxtBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questionTxtBox.Multiline = true;
            this.questionTxtBox.Name = "questionTxtBox";
            this.questionTxtBox.Size = new System.Drawing.Size(686, 96);
            this.questionTxtBox.TabIndex = 26;
            // 
            // AddSAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.saqLbl);
            this.Controls.Add(this.answerTxtBox);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.questionTxtBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1006, 593);
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "AddSAQ";
            this.Size = new System.Drawing.Size(1006, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.Label saqLbl;
        private System.Windows.Forms.TextBox answerTxtBox;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox questionTxtBox;
    }
}
