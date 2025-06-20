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
    public partial class newVolume : Form
    {
        public string nomVolume;
        public string dir;
        public newVolume()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            nomVolume = nameTbx.Text;
            dir = dirTbx.Text;
            this.Close();
        }
    }
}
