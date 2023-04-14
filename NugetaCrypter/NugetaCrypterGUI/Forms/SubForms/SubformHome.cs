using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NugetaCrypterGUI.Forms.SubForms
{
    public partial class SubformHome : Form
    {
        public SubformHome()
        {
            InitializeComponent();
        }

        private void SubformHome_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
