using NugetaCrypterGUI.Forms.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NugetaCrypterGUI.Forms
{
    public partial class MainForm : Form
    {
        struct SubForms
        {
            public static SubformHome subhome;
            public static SubOptions suboptions;
            public static SubBuild subbuild;
        }
        public MainForm()
        {
            InitializeComponent();
            mdiProp();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(44, 49, 58);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            sidebarTransistion.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTransistion_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidePnl.Width -= 10;
                if (sidePnl.Width <= 64)
                {
                    sidebarExpand = false;
                    sidebarTransistion.Stop();
                }
            }
            else
            {
                sidePnl.Width += 10;
                if (sidePnl.Width >= 202)
                {
                    sidebarExpand = true;
                    sidebarTransistion.Stop();
                }
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (SubForms.subhome == null)
            {
                SubForms.subhome = new SubformHome();
                SubForms.subhome.FormClosed += subHome_FormClosed;
                SubForms.subhome.MdiParent = this;
                SubForms.subhome.Dock = DockStyle.Fill;
                SubForms.subhome.Show();
            }
            else
            {
                try
                {
                    try
                    {
                        SubForms.subhome.Activate();
                    }
                    catch { }
                }
                catch { }
            }
        }
        private void subHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            SubForms.subhome = null;
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SubForms.suboptions == null)
                {
                    SubForms.suboptions = new SubOptions();
                    SubForms.suboptions.FormClosed += subOptions_FormClosed;
                    SubForms.suboptions.MdiParent = this;
                    SubForms.suboptions.Dock = DockStyle.Fill;
                    SubForms.suboptions.Show();
                }
                else
                {
                    SubForms.suboptions.Activate();
                }
            }
            catch (Exception E) { Console.WriteLine(E.Message); }
        }
        private void subOptions_FormClosed(object sender, FormClosedEventArgs e)
        {
            SubForms.suboptions = null;
        }

        private void BuildBtn_Click(object sender, EventArgs e)
        {
            if (SubForms.subbuild == null)
            {
                SubForms.subbuild = new SubBuild();
                SubForms.subbuild.FormClosed += subBuild_FormClosed;
                SubForms.subbuild.MdiParent = this;
                SubForms.subbuild.Dock = DockStyle.Fill;
                SubForms.subbuild.Show();
            }
            else
            {
                try
                {
                    SubForms.subbuild.Activate();
                }
                catch { }
            }
        }
        private void subBuild_FormClosed(object sender, FormClosedEventArgs e)
        {
            SubForms.suboptions = null;
        }
    }
}
