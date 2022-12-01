namespace MultipleChoice
{
    partial class UserControl1
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
            this.multipleChoiceQLbl = new System.Windows.Forms.Label();
            this.ans1RBtn = new System.Windows.Forms.RadioButton();
            this.ans2RBtn = new System.Windows.Forms.RadioButton();
            this.ans3RBtn = new System.Windows.Forms.RadioButton();
            this.ans4RBtn = new System.Windows.Forms.RadioButton();
            this.submitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // multipleChoiceQLbl
            // 
            this.multipleChoiceQLbl.AutoSize = true;
            this.multipleChoiceQLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multipleChoiceQLbl.Location = new System.Drawing.Point(52, 46);
            this.multipleChoiceQLbl.Name = "multipleChoiceQLbl";
            this.multipleChoiceQLbl.Size = new System.Drawing.Size(158, 25);
            this.multipleChoiceQLbl.TabIndex = 0;
            this.multipleChoiceQLbl.Text = "Question Label";
            // 
            // ans1RBtn
            // 
            this.ans1RBtn.AutoSize = true;
            this.ans1RBtn.Location = new System.Drawing.Point(57, 176);
            this.ans1RBtn.Name = "ans1RBtn";
            this.ans1RBtn.Size = new System.Drawing.Size(103, 20);
            this.ans1RBtn.TabIndex = 1;
            this.ans1RBtn.TabStop = true;
            this.ans1RBtn.Text = "radioButton1";
            this.ans1RBtn.UseVisualStyleBackColor = true;
            // 
            // ans2RBtn
            // 
            this.ans2RBtn.AutoSize = true;
            this.ans2RBtn.Location = new System.Drawing.Point(57, 244);
            this.ans2RBtn.Name = "ans2RBtn";
            this.ans2RBtn.Size = new System.Drawing.Size(103, 20);
            this.ans2RBtn.TabIndex = 2;
            this.ans2RBtn.TabStop = true;
            this.ans2RBtn.Text = "radioButton2";
            this.ans2RBtn.UseVisualStyleBackColor = true;
            // 
            // ans3RBtn
            // 
            this.ans3RBtn.AutoSize = true;
            this.ans3RBtn.Location = new System.Drawing.Point(57, 312);
            this.ans3RBtn.Name = "ans3RBtn";
            this.ans3RBtn.Size = new System.Drawing.Size(103, 20);
            this.ans3RBtn.TabIndex = 4;
            this.ans3RBtn.TabStop = true;
            this.ans3RBtn.Text = "radioButton3";
            this.ans3RBtn.UseVisualStyleBackColor = true;
            // 
            // ans4RBtn
            // 
            this.ans4RBtn.AutoSize = true;
            this.ans4RBtn.Location = new System.Drawing.Point(57, 380);
            this.ans4RBtn.Name = "ans4RBtn";
            this.ans4RBtn.Size = new System.Drawing.Size(103, 20);
            this.ans4RBtn.TabIndex = 3;
            this.ans4RBtn.TabStop = true;
            this.ans4RBtn.Text = "radioButton4";
            this.ans4RBtn.UseVisualStyleBackColor = true;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(342, 462);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(130, 48);
            this.submitBtn.TabIndex = 5;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.ans3RBtn);
            this.Controls.Add(this.ans4RBtn);
            this.Controls.Add(this.ans2RBtn);
            this.Controls.Add(this.ans1RBtn);
            this.Controls.Add(this.multipleChoiceQLbl);
            this.MaximumSize = new System.Drawing.Size(835, 549);
            this.MinimumSize = new System.Drawing.Size(835, 549);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(835, 549);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label multipleChoiceQLbl;
        private System.Windows.Forms.RadioButton ans1RBtn;
        private System.Windows.Forms.RadioButton ans2RBtn;
        private System.Windows.Forms.RadioButton ans3RBtn;
        private System.Windows.Forms.RadioButton ans4RBtn;
        private System.Windows.Forms.Button submitBtn;
    }
}
