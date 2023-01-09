namespace TmLms.OtherUCs
{
    partial class PokemonNameImage
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
            this.pokemonNameLbl = new System.Windows.Forms.Label();
            this.pokePicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pokePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonNameLbl
            // 
            this.pokemonNameLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pokemonNameLbl.Location = new System.Drawing.Point(3, 3);
            this.pokemonNameLbl.Name = "pokemonNameLbl";
            this.pokemonNameLbl.Size = new System.Drawing.Size(261, 39);
            this.pokemonNameLbl.TabIndex = 0;
            this.pokemonNameLbl.Text = "label1";
            this.pokemonNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pokePicBox
            // 
            this.pokePicBox.Location = new System.Drawing.Point(0, 46);
            this.pokePicBox.Name = "pokePicBox";
            this.pokePicBox.Size = new System.Drawing.Size(268, 185);
            this.pokePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pokePicBox.TabIndex = 1;
            this.pokePicBox.TabStop = false;
            // 
            // PokemonNameImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.pokePicBox);
            this.Controls.Add(this.pokemonNameLbl);
            this.MaximumSize = new System.Drawing.Size(267, 229);
            this.MinimumSize = new System.Drawing.Size(267, 229);
            this.Name = "PokemonNameImage";
            this.Size = new System.Drawing.Size(267, 229);
            ((System.ComponentModel.ISupportInitialize)(this.pokePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label pokemonNameLbl;
        private PictureBox pokePicBox;
    }
}
