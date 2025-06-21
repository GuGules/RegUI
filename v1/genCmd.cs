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
    public partial class genCmd : Form
    {
        public string image;
        private string cmd = "docker run ";

        public genCmd(string hr, string rName, string t)
        {
            InitializeComponent();
            image = hr.Substring(hr.IndexOf("://") + 3) + rName + ":" + t;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (backgrdActivityCbx.Checked)
            {
                cmd += "-d ";
            }
            if (localDir.Text != "" && containerDir.Text != "")
            {
                cmd += "-v " + localDir.Text + ":" + containerDir.Text + " ";
            }
            if (localPort.Text != "" && containerPort.Text != "")
            {
                cmd += "-p " + localPort.Text + ":" + containerPort.Text + " ";
            }
            if (nameTbx.Text != "")
            {
                cmd += "--name " + nameTbx.Text + " ";
            }
            cmd += image;
            cmdBox.Text = cmd;
        }

        private void genCmd_Load(object sender, EventArgs e)
        {
            imgLbl.Text += image;
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)cmd);
        }
    }
}
