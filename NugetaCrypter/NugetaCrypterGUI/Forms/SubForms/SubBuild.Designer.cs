namespace NugetaCrypterGUI.Forms.SubForms
{
    partial class SubBuild
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubBuild));
            this.BuildGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.StartBuildBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.payloadText = new Guna.UI2.WinForms.Guna2TextBox();
            this.BuildGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildGroupBox
            // 
            this.BuildGroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.BuildGroupBox.BorderThickness = 2;
            this.BuildGroupBox.Controls.Add(this.StartBuildBtn);
            this.BuildGroupBox.Controls.Add(this.payloadText);
            this.BuildGroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.BuildGroupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 40, 3, 3);
            this.BuildGroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.BuildGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuildGroupBox.ForeColor = System.Drawing.Color.White;
            this.BuildGroupBox.Location = new System.Drawing.Point(36, 83);
            this.BuildGroupBox.Name = "BuildGroupBox";
            this.BuildGroupBox.Size = new System.Drawing.Size(533, 157);
            this.BuildGroupBox.TabIndex = 4;
            this.BuildGroupBox.Text = "Build";
            // 
            // StartBuildBtn
            // 
            this.StartBuildBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.StartBuildBtn.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.StartBuildBtn.Image = ((System.Drawing.Image)(resources.GetObject("StartBuildBtn.Image")));
            this.StartBuildBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.StartBuildBtn.ImageRotate = 0F;
            this.StartBuildBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.StartBuildBtn.Location = new System.Drawing.Point(323, 76);
            this.StartBuildBtn.Name = "StartBuildBtn";
            this.StartBuildBtn.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.StartBuildBtn.Size = new System.Drawing.Size(64, 54);
            this.StartBuildBtn.TabIndex = 8;
            this.StartBuildBtn.Click += new System.EventHandler(this.StartBuildBtn_Click);
            // 
            // payloadText
            // 
            this.payloadText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.payloadText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.payloadText.DefaultText = "";
            this.payloadText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.payloadText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.payloadText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.payloadText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.payloadText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.payloadText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payloadText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.payloadText.ForeColor = System.Drawing.Color.White;
            this.payloadText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.payloadText.Location = new System.Drawing.Point(117, 88);
            this.payloadText.Name = "payloadText";
            this.payloadText.PasswordChar = '\0';
            this.payloadText.PlaceholderText = "Payload Name";
            this.payloadText.SelectedText = "";
            this.payloadText.Size = new System.Drawing.Size(200, 36);
            this.payloadText.TabIndex = 7;
            // 
            // SubBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(605, 323);
            this.Controls.Add(this.BuildGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubBuild";
            this.Text = "SubBuild";
            this.Load += new System.EventHandler(this.SubBuild_Load);
            this.BuildGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox BuildGroupBox;
        private Guna.UI2.WinForms.Guna2ImageButton StartBuildBtn;
        private Guna.UI2.WinForms.Guna2TextBox payloadText;
    }
}