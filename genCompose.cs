using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegUI
{
    public partial class genCompose : Form
    {
        public genCompose()
        {
            InitializeComponent();
        }

        private void nxtBtn0_Click(object sender, EventArgs e)
        {
            tbcGenCompose.SelectTab(1);
        }
    }
}
