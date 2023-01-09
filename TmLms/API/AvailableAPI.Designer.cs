namespace TmLms.API
{
    partial class AvailableAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableAPI));
            this.pokeAPILbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pokeAPILbl
            // 
            this.pokeAPILbl.AutoSize = true;
            this.pokeAPILbl.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pokeAPILbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pokeAPILbl.Location = new System.Drawing.Point(103, 82);
            this.pokeAPILbl.Name = "pokeAPILbl";
            this.pokeAPILbl.Size = new System.Drawing.Size(98, 27);
            this.pokeAPILbl.TabIndex = 0;
            this.pokeAPILbl.TabStop = true;
            this.pokeAPILbl.Text = "Pokemon";
            this.pokeAPILbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.pokeAPILbl_LinkClicked);
            // 
            // AvailableAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 461);
            this.Controls.Add(this.pokeAPILbl);
            this.MaximumSize = new System.Drawing.Size(685, 508);
            this.MinimumSize = new System.Drawing.Size(685, 508);
            this.Name = "AvailableAPI";
            this.Text = "AvailableAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel pokeAPILbl;
    }
}