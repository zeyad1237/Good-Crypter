namespace NugetaCrypterGUI.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPnl = new System.Windows.Forms.Panel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sidePnl = new System.Windows.Forms.FlowLayoutPanel();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.OptionsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.BuildBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTransistion = new System.Windows.Forms.Timer(this.components);
            this.MainDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Rounded = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.topPnl.SuspendLayout();
            this.sidePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.titleLbl);
            this.topPnl.Controls.Add(this.guna2ImageButton1);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.Location = new System.Drawing.Point(202, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(649, 35);
            this.topPnl.TabIndex = 4;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.exitBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.exitBtn.Location = new System.Drawing.Point(601, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(48, 35);
            this.exitBtn.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(46, 8);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(51, 17);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Nugeta";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Location = new System.Drawing.Point(2, 1);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Size = new System.Drawing.Size(38, 33);
            this.guna2ImageButton1.TabIndex = 1;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // sidePnl
            // 
            this.sidePnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.sidePnl.Controls.Add(this.homeBtn);
            this.sidePnl.Controls.Add(this.OptionsBtn);
            this.sidePnl.Controls.Add(this.BuildBtn);
            this.sidePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePnl.Location = new System.Drawing.Point(0, 0);
            this.sidePnl.Name = "sidePnl";
            this.sidePnl.Size = new System.Drawing.Size(202, 360);
            this.sidePnl.TabIndex = 5;
            // 
            // homeBtn
            // 
            this.homeBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.homeBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.CustomImages.ImageOffset = new System.Drawing.Point(8, 0);
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Location = new System.Drawing.Point(3, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(197, 47);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "Home";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.OptionsBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.OptionsBtn.CustomImages.ImageOffset = new System.Drawing.Point(8, 0);
            this.OptionsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OptionsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OptionsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OptionsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OptionsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.OptionsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OptionsBtn.ForeColor = System.Drawing.Color.White;
            this.OptionsBtn.Location = new System.Drawing.Point(3, 56);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Size = new System.Drawing.Size(197, 47);
            this.OptionsBtn.TabIndex = 3;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // BuildBtn
            // 
            this.BuildBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.BuildBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BuildBtn.CustomImages.ImageOffset = new System.Drawing.Point(8, 0);
            this.BuildBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BuildBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BuildBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BuildBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BuildBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.BuildBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BuildBtn.ForeColor = System.Drawing.Color.White;
            this.BuildBtn.Location = new System.Drawing.Point(3, 109);
            this.BuildBtn.Name = "BuildBtn";
            this.BuildBtn.Size = new System.Drawing.Size(197, 47);
            this.BuildBtn.TabIndex = 4;
            this.BuildBtn.Text = "Build";
            this.BuildBtn.Click += new System.EventHandler(this.BuildBtn_Click);
            // 
            // sidebarTransistion
            // 
            this.sidebarTransistion.Interval = 10;
            this.sidebarTransistion.Tick += new System.EventHandler(this.sidebarTransistion_Tick);
            // 
            // MainDrag
            // 
            this.MainDrag.DockIndicatorTransparencyValue = 0.6D;
            this.MainDrag.TargetControl = this.topPnl;
            this.MainDrag.UseTransparentDrag = true;
            // 
            // Rounded
            // 
            this.Rounded.BorderRadius = 10;
            this.Rounded.TargetControl = this;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.rightPanel.Location = new System.Drawing.Point(803, 34);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(48, 415);
            this.rightPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 360);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.sidePnl);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.sidePnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private Guna.UI2.WinForms.Guna2ControlBox exitBtn;
        private System.Windows.Forms.Label titleLbl;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.FlowLayoutPanel sidePnl;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button OptionsBtn;
        private Guna.UI2.WinForms.Guna2Button BuildBtn;
        private System.Windows.Forms.Timer sidebarTransistion;
        private Guna.UI2.WinForms.Guna2DragControl MainDrag;
        private Guna.UI2.WinForms.Guna2Elipse Rounded;
        private Guna.UI2.WinForms.Guna2Panel rightPanel;
    }
}