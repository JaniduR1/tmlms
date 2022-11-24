namespace TmLms
{
    partial class ViewModules
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
            this.availableModules = new System.Windows.Forms.ComboBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // availableModules
            // 
            this.availableModules.FormattingEnabled = true;
            this.availableModules.Location = new System.Drawing.Point(112, 25);
            this.availableModules.Name = "availableModules";
            this.availableModules.Size = new System.Drawing.Size(223, 28);
            this.availableModules.TabIndex = 0;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(12, 24);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(94, 29);
            this.selectBtn.TabIndex = 1;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            // 
            // ViewModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.availableModules);
            this.Name = "ViewModules";
            this.Text = "ViewModules";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox availableModules;
        private Button selectBtn;
    }
}