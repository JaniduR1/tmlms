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
            this.quizCodeTxtBox = new System.Windows.Forms.TextBox();
            this.quizCodeLbl = new System.Windows.Forms.Label();
            this.moduleLbl = new System.Windows.Forms.Label();
            this.addQuestionsBtn = new System.Windows.Forms.Button();
            this.quizTypeComboBox = new System.Windows.Forms.ComboBox();
            this.quizTypeLbl = new System.Windows.Forms.Label();
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.finishQuizBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsPanel
            // 
            this.questionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionsPanel.Location = new System.Drawing.Point(214, 0);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(1006, 593);
            this.questionsPanel.TabIndex = 0;
            // 
            // quizCodeTxtBox
            // 
            this.quizCodeTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quizCodeTxtBox.Location = new System.Drawing.Point(12, 49);
            this.quizCodeTxtBox.Name = "quizCodeTxtBox";
            this.quizCodeTxtBox.Size = new System.Drawing.Size(196, 31);
            this.quizCodeTxtBox.TabIndex = 1;
            // 
            // quizCodeLbl
            // 
            this.quizCodeLbl.AutoSize = true;
            this.quizCodeLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quizCodeLbl.Location = new System.Drawing.Point(69, 21);
            this.quizCodeLbl.Name = "quizCodeLbl";
            this.quizCodeLbl.Size = new System.Drawing.Size(95, 25);
            this.quizCodeLbl.TabIndex = 2;
            this.quizCodeLbl.Text = "Quiz Code";
            // 
            // moduleLbl
            // 
            this.moduleLbl.AutoSize = true;
            this.moduleLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleLbl.Location = new System.Drawing.Point(69, 105);
            this.moduleLbl.Name = "moduleLbl";
            this.moduleLbl.Size = new System.Drawing.Size(73, 25);
            this.moduleLbl.TabIndex = 4;
            this.moduleLbl.Text = "Module";
            // 
            // addQuestionsBtn
            // 
            this.addQuestionsBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addQuestionsBtn.Location = new System.Drawing.Point(12, 196);
            this.addQuestionsBtn.Name = "addQuestionsBtn";
            this.addQuestionsBtn.Size = new System.Drawing.Size(196, 41);
            this.addQuestionsBtn.TabIndex = 5;
            this.addQuestionsBtn.Text = "Add Questions";
            this.addQuestionsBtn.UseVisualStyleBackColor = true;
            this.addQuestionsBtn.Click += new System.EventHandler(this.addQuestionsBtn_Click);
            // 
            // quizTypeComboBox
            // 
            this.quizTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quizTypeComboBox.FormattingEnabled = true;
            this.quizTypeComboBox.Location = new System.Drawing.Point(12, 400);
            this.quizTypeComboBox.Name = "quizTypeComboBox";
            this.quizTypeComboBox.Size = new System.Drawing.Size(196, 33);
            this.quizTypeComboBox.TabIndex = 6;
            this.quizTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.quizTypeComboBox_SelectedIndexChanged);
            // 
            // quizTypeLbl
            // 
            this.quizTypeLbl.AutoSize = true;
            this.quizTypeLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quizTypeLbl.Location = new System.Drawing.Point(69, 372);
            this.quizTypeLbl.Name = "quizTypeLbl";
            this.quizTypeLbl.Size = new System.Drawing.Size(90, 25);
            this.quizTypeLbl.TabIndex = 7;
            this.quizTypeLbl.Text = "Quiz Type";
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(12, 133);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(196, 33);
            this.moduleComboBox.TabIndex = 8;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // finishQuizBtn
            // 
            this.finishQuizBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.finishQuizBtn.Location = new System.Drawing.Point(12, 497);
            this.finishQuizBtn.Name = "finishQuizBtn";
            this.finishQuizBtn.Size = new System.Drawing.Size(196, 41);
            this.finishQuizBtn.TabIndex = 9;
            this.finishQuizBtn.Text = "Finish Quiz";
            this.finishQuizBtn.UseVisualStyleBackColor = true;
            this.finishQuizBtn.Click += new System.EventHandler(this.finishQuizBtn_Click);
            // 
            // CreateTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 594);
            this.Controls.Add(this.finishQuizBtn);
            this.Controls.Add(this.moduleComboBox);
            this.Controls.Add(this.quizTypeLbl);
            this.Controls.Add(this.quizTypeComboBox);
            this.Controls.Add(this.addQuestionsBtn);
            this.Controls.Add(this.moduleLbl);
            this.Controls.Add(this.quizCodeLbl);
            this.Controls.Add(this.quizCodeTxtBox);
            this.Controls.Add(this.questionsPanel);
            this.MaximumSize = new System.Drawing.Size(1237, 641);
            this.MinimumSize = new System.Drawing.Size(1237, 641);
            this.Name = "CreateTests";
            this.Text = "CreateTests";
            this.Load += new System.EventHandler(this.CreateTests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel questionsPanel;
        private TextBox quizCodeTxtBox;
        private Label quizCodeLbl;
        private Label moduleLbl;
        private Button addQuestionsBtn;
        private ComboBox quizTypeComboBox;
        private Label quizTypeLbl;
        private ComboBox moduleComboBox;
        private Button finishQuizBtn;
    }
}