namespace TmLms.API
{
    partial class PokemonAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonAPI));
            this.pokemonLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.statsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.backBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pokemonLayoutPanel
            // 
            this.pokemonLayoutPanel.BackColor = System.Drawing.Color.Lime;
            this.pokemonLayoutPanel.Location = new System.Drawing.Point(486, 188);
            this.pokemonLayoutPanel.Name = "pokemonLayoutPanel";
            this.pokemonLayoutPanel.Size = new System.Drawing.Size(301, 236);
            this.pokemonLayoutPanel.TabIndex = 0;
            // 
            // imageLayoutPanel
            // 
            this.imageLayoutPanel.BackColor = System.Drawing.Color.Lime;
            this.imageLayoutPanel.Location = new System.Drawing.Point(217, 175);
            this.imageLayoutPanel.Name = "imageLayoutPanel";
            this.imageLayoutPanel.Size = new System.Drawing.Size(166, 217);
            this.imageLayoutPanel.TabIndex = 1;
            // 
            // statsLayoutPanel
            // 
            this.statsLayoutPanel.BackColor = System.Drawing.Color.Lime;
            this.statsLayoutPanel.Location = new System.Drawing.Point(106, 183);
            this.statsLayoutPanel.Name = "statsLayoutPanel";
            this.statsLayoutPanel.Size = new System.Drawing.Size(112, 178);
            this.statsLayoutPanel.TabIndex = 2;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.backBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backBtn.Location = new System.Drawing.Point(497, 445);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(74, 48);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.nextBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextBtn.Location = new System.Drawing.Point(572, 445);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(73, 48);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // PokemonAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 607);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.statsLayoutPanel);
            this.Controls.Add(this.imageLayoutPanel);
            this.Controls.Add(this.pokemonLayoutPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(772, 630);
            this.Name = "PokemonAPI";
            this.Text = "PokemonAPI";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel pokemonLayoutPanel;
        private FlowLayoutPanel imageLayoutPanel;
        private FlowLayoutPanel statsLayoutPanel;
        public Button backBtn;
        public Button nextBtn;
    }
}