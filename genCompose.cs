using RegUI.models;

namespace RegUI
{
    public partial class genCompose : Form
    {

        public string host_registry;

        private List<Service> services = new List<Service>();
        private string generatedText = "";
        private string tab = "  ";
        public genCompose()
        {
            InitializeComponent();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            generatedText = "services:\n";
            // Génération de la partie de gestion des volumes

            foreach (Service s in services)
            {
                generatedText += s.getComposeService();
            }

            generatedText += "volumes:\n";

            foreach (Service s in services)
            {
                foreach (string vol in s.volumes.Keys)
                {
                    if (!vol.StartsWith("./"))
                    {
                        generatedText += tab + vol + ":\n";
                    }
                }
            }

            // Insertion du texte dans l'éditeur
            composeFileEditor.Text = generatedText;

            // Affichage du document généré
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
            servicesListBox.DataSource = services.ToList();
            servicesListBox.DisplayMember = "name";

            ai_prompt.Hide();
            askAIBtn.Hide();
        }
        private void addServBtn_Click(object sender, EventArgs e)
        {
            genServ form = new genServ(host_registry);
            form.services = services;
            form.ShowDialog();
            Service s = form.getService();
            if (s is not null)
            {
                services.Add(s);
                servicesListBox.DataSource = services.ToList();
            }
        }

        private void rmServBtn_Click(object sender, EventArgs e)
        {
            services.RemoveAt(servicesListBox.SelectedIndex);
            servicesListBox.DataSource = services.ToList();
        }
    }
}
