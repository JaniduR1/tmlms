﻿namespace TmLms
{
    partial class CreateModule
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
            this.moduleNameLbl = new System.Windows.Forms.Label();
            this.moduleCodeLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.moduleDescriptionLbl = new System.Windows.Forms.Label();
            this.moduleDescriptionTxtBox = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creditsDropDown = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.moduleNameTxtBox = new System.Windows.Forms.TextBox();
            this.moduleCodeTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moduleNameLbl
            // 
            this.moduleNameLbl.AutoSize = true;
            this.moduleNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleNameLbl.Location = new System.Drawing.Point(65, 42);
            this.moduleNameLbl.Name = "moduleNameLbl";
            this.moduleNameLbl.Size = new System.Drawing.Size(125, 25);
            this.moduleNameLbl.TabIndex = 2;
            this.moduleNameLbl.Text = "Module Name";
            // 
            // moduleCodeLbl
            // 
            this.moduleCodeLbl.AutoSize = true;
            this.moduleCodeLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleCodeLbl.Location = new System.Drawing.Point(65, 84);
            this.moduleCodeLbl.Name = "moduleCodeLbl";
            this.moduleCodeLbl.Size = new System.Drawing.Size(120, 25);
            this.moduleCodeLbl.TabIndex = 4;
            this.moduleCodeLbl.Text = "Module Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(65, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Of Credits";
            // 
            // moduleDescriptionLbl
            // 
            this.moduleDescriptionLbl.AutoSize = true;
            this.moduleDescriptionLbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moduleDescriptionLbl.Location = new System.Drawing.Point(65, 191);
            this.moduleDescriptionLbl.Name = "moduleDescriptionLbl";
            this.moduleDescriptionLbl.Size = new System.Drawing.Size(168, 25);
            this.moduleDescriptionLbl.TabIndex = 6;
            this.moduleDescriptionLbl.Text = "Module Description";
            // 
            // moduleDescriptionTxtBox
            // 
            this.moduleDescriptionTxtBox.Location = new System.Drawing.Point(284, 192);
            this.moduleDescriptionTxtBox.Name = "moduleDescriptionTxtBox";
            this.moduleDescriptionTxtBox.Size = new System.Drawing.Size(238, 138);
            this.moduleDescriptionTxtBox.TabIndex = 10;
            this.moduleDescriptionTxtBox.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(284, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(238, 30);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Module Code";
            // 
            // creditsDropDown
            // 
            this.creditsDropDown.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.creditsDropDown.FormattingEnabled = true;
            this.creditsDropDown.Items.AddRange(new object[] {
            "TWENTY (20)",
            "FORTY (40)",
            "SIXTY (60)"});
            this.creditsDropDown.Location = new System.Drawing.Point(284, 344);
            this.creditsDropDown.Name = "creditsDropDown";
            this.creditsDropDown.Size = new System.Drawing.Size(238, 31);
            this.creditsDropDown.TabIndex = 15;
            this.creditsDropDown.SelectedIndexChanged += new System.EventHandler(this.creditsDropDown_SelectedIndexChanged);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(347, 429);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(133, 49);
            this.submitBtn.TabIndex = 17;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // moduleNameTxtBox
            // 
            this.moduleNameTxtBox.Location = new System.Drawing.Point(284, 43);
            this.moduleNameTxtBox.Name = "moduleNameTxtBox";
            this.moduleNameTxtBox.Size = new System.Drawing.Size(238, 27);
            this.moduleNameTxtBox.TabIndex = 18;
            // 
            // moduleCodeTxtBox
            // 
            this.moduleCodeTxtBox.Location = new System.Drawing.Point(284, 85);
            this.moduleCodeTxtBox.Name = "moduleCodeTxtBox";
            this.moduleCodeTxtBox.Size = new System.Drawing.Size(238, 27);
            this.moduleCodeTxtBox.TabIndex = 19;
            // 
            // CreateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 533);
            this.Controls.Add(this.moduleCodeTxtBox);
            this.Controls.Add(this.moduleNameTxtBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.creditsDropDown);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.moduleDescriptionTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moduleDescriptionLbl);
            this.Controls.Add(this.moduleCodeLbl);
            this.Controls.Add(this.moduleNameLbl);
            this.Name = "CreateModule";
            this.Text = "CreateModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label moduleNameLbl;
        private Label moduleCodeLbl;
        private Label label1;
        private Label moduleDescriptionLbl;
        private RichTextBox moduleDescriptionTxtBox;
        private TextBox textBox2;
        private Label label3;
        private ComboBox creditsDropDown;
        private Button submitBtn;
        private TextBox moduleNameTxtBox;
        private TextBox moduleCodeTxtBox;
    }
}