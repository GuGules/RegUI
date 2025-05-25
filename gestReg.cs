using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using RegUI.models;

namespace RegUI
{
    public partial class gestReg : Form
    {
        public gestReg()
        {
            InitializeComponent();
        }

        private string host_registry;

        private async void fetchBtn_Click(object sender, EventArgs e)
        {
            if (regAdrTbx.Text != "" & (regAdrTbx.Text.StartsWith("http://") || regAdrTbx.Text.StartsWith("https://")))
            {
                if (!regAdrTbx.Text.EndsWith('/'))
                {
                    regAdrTbx.Text += "/";
                    host_registry = regAdrTbx.Text;
                }

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(regAdrTbx.Text + "/v2/_catalog");
                if (response.IsSuccessStatusCode)
                {
                    string stringRes = await response.Content.ReadAsStringAsync();
                    var catalog = JsonSerializer.Deserialize<CatalogResponse>(stringRes);

                    if (catalog != null && catalog.repositories != null)
                    {
                        repositoriesListBox.Items.Clear();
                        foreach (var repo in catalog.repositories)
                        {
                            repositoriesListBox.Items.Add(repo);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("RegUI n'est pas parvenue à se connecter au registre Docker", "Problème de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner une URL valide pour le registre \n\nExemple : http[s]://registre.domain.com/", "Adresse de registre invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tagsManBtn_Click(object sender, EventArgs e)
        {
            if (host_registry != null)
            {
                if (repositoriesListBox.SelectedItem != null)
                {
                    gestTag nForm = new gestTag(host_registry, repositoriesListBox.SelectedItem.ToString());
                    nForm.Show();
                }
                else
                {
                    MessageBox.Show("Aucun repository n'a été sélectionné", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Aucun registre docker n'a été spécifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gestReg_Load(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité en cours de développement", "A venir...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
