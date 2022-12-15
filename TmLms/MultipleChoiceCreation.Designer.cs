namespace TmLms
{
    partial class MultipleChoiceCreation
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
            this.questionTxtBox = new System.Windows.Forms.TextBox();
            this.ans2TxtBox = new System.Windows.Forms.TextBox();
            this.ans3TxtBox = new System.Windows.Forms.TextBox();
            this.ans4TxtBox = new System.Windows.Forms.TextBox();
            this.correctAnswerTxtBox = new System.Windows.Forms.TextBox();
            this.Question = new System.Windows.Forms.Label();
            this.correctAnswerLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTxtBox
            // 
            this.questionTxtBox.Location = new System.Drawing.Point(169, 57);
            this.questionTxtBox.Name = "questionTxtBox";
            this.questionTxtBox.Size = new System.Drawing.Size(545, 27);
            this.questionTxtBox.TabIndex = 0;
            // 
            // ans2TxtBox
            // 
            this.ans2TxtBox.Location = new System.Drawing.Point(169, 266);
            this.ans2TxtBox.Name = "ans2TxtBox";
            this.ans2TxtBox.Size = new System.Drawing.Size(395, 27);
            this.ans2TxtBox.TabIndex = 1;
            // 
            // ans3TxtBox
            // 
            this.ans3TxtBox.Location = new System.Drawing.Point(169, 333);
            this.ans3TxtBox.Name = "ans3TxtBox";
            this.ans3TxtBox.Size = new System.Drawing.Size(395, 27);
            this.ans3TxtBox.TabIndex = 2;
            // 
            // ans4TxtBox
            // 
            this.ans4TxtBox.Location = new System.Drawing.Point(169, 393);
            this.ans4TxtBox.Name = "ans4TxtBox";
            this.ans4TxtBox.Size = new System.Drawing.Size(395, 27);
            this.ans4TxtBox.TabIndex = 3;
            // 
            // correctAnswerTxtBox
            // 
            this.correctAnswerTxtBox.Location = new System.Drawing.Point(169, 141);
            this.correctAnswerTxtBox.Name = "correctAnswerTxtBox";
            this.correctAnswerTxtBox.Size = new System.Drawing.Size(395, 27);
            this.correctAnswerTxtBox.TabIndex = 4;
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Question.Location = new System.Drawing.Point(72, 53);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(91, 28);
            this.Question.TabIndex = 5;
            this.Question.Text = "Question";
            // 
            // correctAnswerLbl
            // 
            this.correctAnswerLbl.AutoSize = true;
            this.correctAnswerLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctAnswerLbl.Location = new System.Drawing.Point(19, 141);
            this.correctAnswerLbl.Name = "correctAnswerLbl";
            this.correctAnswerLbl.Size = new System.Drawing.Size(144, 28);
            this.correctAnswerLbl.TabIndex = 6;
            this.correctAnswerLbl.Text = "Correct Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ans 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(103, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ans 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(103, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ans 4";
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Location = new System.Drawing.Point(740, 186);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(118, 66);
            this.addQuestionBtn.TabIndex = 10;
            this.addQuestionBtn.Text = "Add Question";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            this.addQuestionBtn.Click += new System.EventHandler(this.addQuestionBtn_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(740, 361);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(118, 59);
            this.finishBtn.TabIndex = 11;
            this.finishBtn.Text = "Finish";
            this.finishBtn.UseVisualStyleBackColor = true;
            this.finishBtn.Click += new System.EventHandler(this.finishBtn_Click);
            // 
            // MultipleChoiceCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.addQuestionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.correctAnswerLbl);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.correctAnswerTxtBox);
            this.Controls.Add(this.ans4TxtBox);
            this.Controls.Add(this.ans3TxtBox);
            this.Controls.Add(this.ans2TxtBox);
            this.Controls.Add(this.questionTxtBox);
            this.Name = "MultipleChoiceCreation";
            this.Text = "MultipleChoiceCreation";
            this.Load += new System.EventHandler(this.MultipleChoiceCreation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox questionTxtBox;
        private TextBox ans2TxtBox;
        private TextBox ans3TxtBox;
        private TextBox ans4TxtBox;
        private TextBox correctAnswerTxtBox;
        private Label Question;
        private Label correctAnswerLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addQuestionBtn;
        private Button finishBtn;
    }
}