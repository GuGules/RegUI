using RegUI.models.APIConnector.Registry;
using RegUI.regManager;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RegUI
{
    public partial class gestReg : Form
    {
        /*
            * Classe principale de l'application
            * Permet la gestion d'un registre docker
            * 
            * Auteur : Jules PILLOT
            */
        public gestReg()
        {
            InitializeComponent();
        }

        private string host_registry;
        private HttpClient http = new HttpClient();

        private Boolean URI_isOK(string url)
        {
            /*
             * Fonction qui vérifie la bonne construction de l'URL
             * Entrée : une chaine de caractère (url)
             * Sortie : un booléen qui indique la bonne construction de l'URL
             */

            return Regex.IsMatch(url, @"^https?://((localhost:?\d+)|.+\..+)");
        }

        private async void loadRegistry()
        {
            if (URI_isOK(host_registry))
            {
                // Chargement de la liste des repositories
                HttpResponseMessage response = await http.GetAsync(host_registry + "/v2/_catalog");
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
            }
        }

        private async void connectRegistry(object? sender = null, EventArgs? e = null)
        {
            if (regAdrTbx.Text != "")
            {
                // AJOUT AUTO /
                if (!regAdrTbx.Text.EndsWith('/'))
                {
                    regAdrTbx.Text += "/";
                    host_registry = regAdrTbx.Text;
                }

                // AJOUT AUTO HTTP / HTTPS
                if (!regAdrTbx.Text.StartsWith("https://"))
                {
                    if (!regAdrTbx.Text.StartsWith("http://"))
                    {
                        // Ajout auto HTTP / HTTPS
                        try
                        {
                            // TEST HTTPS
                            if (URI_isOK("https://" + host_registry))
                            {
                                HttpResponseMessage r1 = await http.GetAsync("https://" + host_registry);
                                if (r1.IsSuccessStatusCode)
                                {
                                    host_registry = "https://" + host_registry;
                                }
                                else
                                {
                                    MessageBox.Show("Le registre a refusé la connexion", "Connexion refusée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("L'url n'est pas valide", "URL invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            try
                            {
                                // TEST HTTP
                                if (URI_isOK("http://" + host_registry))
                                {
                                    HttpResponseMessage r1 = await http.GetAsync("http://" + host_registry);
                                    if (r1.IsSuccessStatusCode)
                                    {
                                        host_registry = "http://" + host_registry;
                                        MessageBox.Show("Le registre ne dispose de certificat SSL permettant une connexion HTTP sécurisée", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le registre a refusé la connexion", "Connexion refusée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("L'url n'est pas valide", "URL invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Impossible de se connecter au registre", "Problème de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    loadRegistry();
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

        private void delBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité en cours de développement", "A venir...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void regAdrTbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                connectRegistry();
            }
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genComposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (host_registry != null)
            {
                genCompose gcp = new genCompose();
                gcp.host_registry = host_registry;
                gcp.Show();
            }
        }

        private void regManagerStripMenu_Click(object sender, EventArgs e)
        {
            RegistryManager r = new();
            r.Show();
        }

        private void seConnecterÀUnRegistreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrySelector r = new();
            r.ShowDialog();
            if (r.closeCode == 0)
            {
                host_registry = r.getSelectedRegistryUrl();
                regAdrTbx.Text = host_registry;
                loadRegistry();
            }
        }
    }
}
