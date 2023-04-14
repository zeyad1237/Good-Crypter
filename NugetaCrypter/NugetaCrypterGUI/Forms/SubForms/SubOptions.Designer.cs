namespace NugetaCrypterGUI.Forms.SubForms
{
    partial class SubOptions
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
            this.OptionsGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.batchCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileChooser = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ExtensionsDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.OptionsGroupBox.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.OptionsGroupBox.BorderThickness = 2;
            this.OptionsGroupBox.Controls.Add(this.batchCheck);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.FileChooser);
            this.OptionsGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.OptionsGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 3, 3);
            this.OptionsGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.OptionsGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OptionsGroupBox.ForeColor = System.Drawing.Color.White;
            this.OptionsGroupBox.Location = new System.Drawing.Point(34, 131);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Size = new System.Drawing.Size(533, 159);
            this.OptionsGroupBox.TabIndex = 4;
            this.OptionsGroupBox.Text = "Loader Settings";
            // 
            // batchCheck
            // 
            this.batchCheck.CheckedState.BorderColor = System.Drawing.Color.White;
            this.batchCheck.CheckedState.BorderRadius = 2;
            this.batchCheck.CheckedState.BorderThickness = 0;
            this.batchCheck.CheckedState.FillColor = System.Drawing.Color.White;
            this.batchCheck.Location = new System.Drawing.Point(13, 53);
            this.batchCheck.Name = "batchCheck";
            this.batchCheck.Size = new System.Drawing.Size(25, 25);
            this.batchCheck.TabIndex = 7;
            this.batchCheck.Text = "BatchCheck";
            this.batchCheck.UncheckedState.BorderColor = System.Drawing.Color.White;
            this.batchCheck.UncheckedState.BorderRadius = 2;
            this.batchCheck.UncheckedState.BorderThickness = 1;
            this.batchCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.batchCheck.Click += new System.EventHandler(this.browserCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = ".Bat Loader";
            // 
            // FileChooser
            // 
            this.FileChooser.BorderRadius = 8;
            this.FileChooser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FileChooser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FileChooser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FileChooser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FileChooser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.FileChooser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileChooser.ForeColor = System.Drawing.Color.White;
            this.FileChooser.Location = new System.Drawing.Point(206, 117);
            this.FileChooser.Name = "FileChooser";
            this.FileChooser.Size = new System.Drawing.Size(117, 31);
            this.FileChooser.TabIndex = 6;
            this.FileChooser.Text = "...";
            this.FileChooser.Click += new System.EventHandler(this.FileChooser_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.ExtensionsDropDown);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 3, 3);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(34, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(533, 113);
            this.guna2GroupBox1.TabIndex = 9;
            this.guna2GroupBox1.Text = "Extension Spoofer";
            // 
            // ExtensionsDropDown
            // 
            this.ExtensionsDropDown.BackColor = System.Drawing.Color.Transparent;
            this.ExtensionsDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExtensionsDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExtensionsDropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExtensionsDropDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExtensionsDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExtensionsDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ExtensionsDropDown.ItemHeight = 30;
            this.ExtensionsDropDown.Items.AddRange(new object[] {
            ".sln",
            ".com",
            ".src",
            ".txt",
            ".rtf",
            ".exe"});
            this.ExtensionsDropDown.Location = new System.Drawing.Point(183, 59);
            this.ExtensionsDropDown.Name = "ExtensionsDropDown";
            this.ExtensionsDropDown.Size = new System.Drawing.Size(140, 36);
            this.ExtensionsDropDown.TabIndex = 9;
            this.ExtensionsDropDown.SelectedIndexChanged += new System.EventHandler(this.ExtensionsDropDown_SelectedIndexChanged);
            // 
            // SubOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(605, 323);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.OptionsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubOptions";
            this.Text = "SubOptions";
            this.Load += new System.EventHandler(this.SubOptions_Load);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox OptionsGroupBox;
        private Guna.UI2.WinForms.Guna2Button FileChooser;
        public Guna.UI2.WinForms.Guna2CustomCheckBox batchCheck;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox ExtensionsDropDown;
    }
}