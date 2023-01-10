namespace TmLms.OtherUCs
{
    partial class PokemonHeightWeight
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
            this.label1 = new System.Windows.Forms.Label();
            this.heightLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // heightLbl
            // 
            this.heightLbl.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heightLbl.Location = new System.Drawing.Point(24, 42);
            this.heightLbl.Name = "heightLbl";
            this.heightLbl.Size = new System.Drawing.Size(112, 33);
            this.heightLbl.TabIndex = 1;
            this.heightLbl.Text = "label2";
            this.heightLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight:";
            // 
            // weightLbl
            // 
            this.weightLbl.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weightLbl.Location = new System.Drawing.Point(29, 181);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(112, 33);
            this.weightLbl.TabIndex = 3;
            this.weightLbl.Text = "label2";
            this.weightLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PokemonHeightWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heightLbl);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(164, 217);
            this.MinimumSize = new System.Drawing.Size(164, 217);
            this.Name = "PokemonHeightWeight";
            this.Size = new System.Drawing.Size(164, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label heightLbl;
        private Label label3;
        private Label weightLbl;
    }
}
