namespace QuizTypes
{
    partial class TakeMQ
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
            this.submitAnsBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // submitAnsBtn
            // 
            this.submitAnsBtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAnsBtn.Location = new System.Drawing.Point(422, 416);
            this.submitAnsBtn.Name = "submitAnsBtn";
            this.submitAnsBtn.Size = new System.Drawing.Size(125, 47);
            this.submitAnsBtn.TabIndex = 16;
            this.submitAnsBtn.Text = "Submit";
            this.submitAnsBtn.UseVisualStyleBackColor = true;
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(406, 11);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLbl.MaximumSize = new System.Drawing.Size(1258, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(180, 35);
            this.questionLbl.TabIndex = 15;
            this.questionLbl.Text = "Question Text";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(130, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 316);
            this.panel1.TabIndex = 17;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(538, 94);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 316);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // TakeMQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitAnsBtn);
            this.Controls.Add(this.questionLbl);
            this.MaximumSize = new System.Drawing.Size(1006, 593);
            this.MinimumSize = new System.Drawing.Size(1006, 593);
            this.Name = "TakeMQ";
            this.Size = new System.Drawing.Size(1006, 593);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitAnsBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
