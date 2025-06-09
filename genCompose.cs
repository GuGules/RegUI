using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegUI.models;

namespace RegUI
{
    public partial class genCompose : Form
    {

        public string host_registry;

        private List<Volume> volumes = new List<Volume>();
        private List<Service> services = new List<Service> ();
        public genCompose()
        {
            InitializeComponent();
        }

        private void nxtBtn0_Click(object sender, EventArgs e)
        {
            tbcGenCompose.SelectTab(1);
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)composeFileEditor.Text);
        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            Stream flux;
            SaveFileDialog saveComposeFile = new SaveFileDialog();

            // Configuration de la fenêtre
            saveComposeFile.AddExtension = true;
            saveComposeFile.Title = "Enregistrer le fichier docker-compose.yaml";
            saveComposeFile.Filter = "Fichiers yaml (*.yaml)|*.yaml|Tout les fichiers (*.*)|*.*";
            saveComposeFile.FilterIndex = 1;
            saveComposeFile.FileName = "docker-compose.yaml";
            saveComposeFile.RestoreDirectory = true;

            // Traitement de la réponse
            if (saveComposeFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveComposeFile.FileName, composeFileEditor.Text);
                MessageBox.Show("Fichier enregistré");
                this.Close();
            }
        }

        private void genCompose_Load(object sender, EventArgs e)
        {
            Service service = new Service();
            service.name = Randomer.genRandomName();
            service.image = "Odoo";
            service.version = "17.0";
            service.registry = host_registry;

            service.getComposeService();
        }
    }
}
