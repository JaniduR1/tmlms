namespace TmLms.TestViewUC
{
    partial class ViewTests
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
            this.givenAnsLbl = new System.Windows.Forms.Label();
            this.givenAnsText = new System.Windows.Forms.RichTextBox();
            this.marksTxtBox = new System.Windows.Forms.TextBox();
            this.markBtn = new System.Windows.Forms.Button();
            this.corrAnsText = new System.Windows.Forms.RichTextBox();
            this.corrAnsLbl = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.RichTextBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // givenAnsLbl
            // 
            this.givenAnsLbl.AutoSize = true;
            this.givenAnsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.givenAnsLbl.Location = new System.Drawing.Point(16, 137);
            this.givenAnsLbl.Name = "givenAnsLbl";
            this.givenAnsLbl.Size = new System.Drawing.Size(130, 28);
            this.givenAnsLbl.TabIndex = 0;
            this.givenAnsLbl.Text = "Given Answer";
            // 
            // givenAnsText
            // 
            this.givenAnsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.givenAnsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.givenAnsText.Location = new System.Drawing.Point(16, 168);
            this.givenAnsText.Name = "givenAnsText";
            this.givenAnsText.Size = new System.Drawing.Size(420, 234);
            this.givenAnsText.TabIndex = 1;
            this.givenAnsText.Text = "";
            // 
            // marksTxtBox
            // 
            this.marksTxtBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marksTxtBox.Location = new System.Drawing.Point(882, 103);
            this.marksTxtBox.Name = "marksTxtBox";
            this.marksTxtBox.Size = new System.Drawing.Size(135, 34);
            this.marksTxtBox.TabIndex = 2;
            // 
            // markBtn
            // 
            this.markBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.markBtn.Location = new System.Drawing.Point(923, 143);
            this.markBtn.Name = "markBtn";
            this.markBtn.Size = new System.Drawing.Size(94, 39);
            this.markBtn.TabIndex = 3;
            this.markBtn.Text = "Mark";
            this.markBtn.UseVisualStyleBackColor = true;
            this.markBtn.Click += new System.EventHandler(this.markBtn_Click);
            // 
            // corrAnsText
            // 
            this.corrAnsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.corrAnsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.corrAnsText.Location = new System.Drawing.Point(458, 168);
            this.corrAnsText.Name = "corrAnsText";
            this.corrAnsText.Size = new System.Drawing.Size(420, 234);
            this.corrAnsText.TabIndex = 4;
            this.corrAnsText.Text = "";
            // 
            // corrAnsLbl
            // 
            this.corrAnsLbl.AutoSize = true;
            this.corrAnsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.corrAnsLbl.Location = new System.Drawing.Point(458, 137);
            this.corrAnsLbl.Name = "corrAnsLbl";
            this.corrAnsLbl.Size = new System.Drawing.Size(144, 28);
            this.corrAnsLbl.TabIndex = 5;
            this.corrAnsLbl.Text = "Correct Answer";
            // 
            // questionText
            // 
            this.questionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionText.Location = new System.Drawing.Point(113, 22);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(858, 53);
            this.questionText.TabIndex = 7;
            this.questionText.Text = "";
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(16, 34);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(91, 28);
            this.questionLbl.TabIndex = 6;
            this.questionLbl.Text = "Question";
            // 
            // ViewTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.corrAnsLbl);
            this.Controls.Add(this.corrAnsText);
            this.Controls.Add(this.markBtn);
            this.Controls.Add(this.marksTxtBox);
            this.Controls.Add(this.givenAnsText);
            this.Controls.Add(this.givenAnsLbl);
            this.MaximumSize = new System.Drawing.Size(1033, 416);
            this.MinimumSize = new System.Drawing.Size(1033, 416);
            this.Name = "ViewTests";
            this.Size = new System.Drawing.Size(1033, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label givenAnsLbl;
        private RichTextBox givenAnsText;
        private TextBox marksTxtBox;
        private Button markBtn;
        private RichTextBox corrAnsText;
        private Label corrAnsLbl;
        private RichTextBox questionText;
        private Label questionLbl;
    }
}
