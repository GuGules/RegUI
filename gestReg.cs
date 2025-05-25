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
                    MessageBox.Show(host_registry);
                }

                HttpClient http = new HttpClient();
                HttpResponseMessage response = await http.GetAsync(regAdrTbx.Text + "/v2/_catalog");
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
                MessageBox.Show("Veuillez renseigner une URL valide pour le registre \n\nExemple : http[s]://registre.domain.com/", "Adresse de registre invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tagsManBtn_Click(object sender, EventArgs e)
        {
            gestTag nForm = new gestTag(host_registry,repositoriesListBox.SelectedItem.ToString());
            nForm.Show();
        }

        private void gestReg_Load(object sender, EventArgs e)
        {

        }
    }
}
