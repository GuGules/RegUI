using System.Text.Json;
using RegUI.models;

namespace RegUI
{
    public partial class gestTag : Form
    {
        private string repoName;
        private string host_registry;
        private HttpClient http = new HttpClient();
        public gestTag(string registry, string rName)
        {
            InitializeComponent();
            repoName = rName;
            host_registry = registry;
        }

        public async void loadTags()
        {
            // Chargement des tags
            HttpResponseMessage response = await http.GetAsync(host_registry + "v2/" + repoName + "/tags/list");

            if (response.IsSuccessStatusCode)
            {
                string stringRes = await response.Content.ReadAsStringAsync();
                var repo = JsonSerializer.Deserialize<TagsResponse>(stringRes);

                if (repo != null && repo.tags != null)
                {
                    tagsLB.Items.Clear();
                    foreach (var tag in repo.tags)
                    {
                        tagsLB.Items.Add(tag);
                    }
                }
            }
            else
            {
                MessageBox.Show("Il y eu un problème avec la connexion au registre Docker", "Problème de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void gestTag_Load(object sender, EventArgs e)
        {
            repoLbl.Text += repoName;
            loadTags();
        }

        private async void rmTagBtn_Click(object sender, EventArgs e)
        {
            if (tagsLB.SelectedItem.ToString() != null)
            {
                http.DefaultRequestHeaders.Add("Accept", "application/vnd.docker.distribution.manifest.v2+json");
                http.DefaultRequestHeaders.Add("Accept", "application/vnd.oci.image.manifest.v1+json");
                var fRep = await http.GetAsync(host_registry + "v2/" + repoName + "/manifests/" + tagsLB.SelectedItem);
                if (fRep.IsSuccessStatusCode)
                {
                    var digest = fRep.Headers.GetValues("Docker-Content-Digest").ToList();
                    if (digest[0] != null && digest[0] != "")
                    {
                        var rep = MessageBox.Show("Êtes-vous certains de confirmer la suppression de " + repoName + ":" + tagsLB.SelectedItem, "Confirmation nécessaire", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rep.ToString() == "Yes")
                        {
                            var sup = await http.DeleteAsync(host_registry + "v2/" + repoName + "/manifests/" + digest[0]);
                            if (sup.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Opération réalisée avec succès !", "Succès de l'opération", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadTags();
                            }
                            else
                            {
                                MessageBox.Show("Quelque chose s'est mal déroulé...\n\n Veuillez réessayer plus tard.", "Echec de l'opération", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Opération annulée", "Annulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Il y a eu un problème avec la connexion au registre Docker", "Problème de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Aucun tag n'a été sélectionné", "Problème de tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmdPullBtn_Click(object sender, EventArgs e)
        {
            if (tagsLB.SelectedItem.ToString() != null)
            {
                // Insertion de la commande docker dans le presse-papier

                string textData = "docker pull " + host_registry.Substring(host_registry.IndexOf("://") + 3) + repoName + ":" + tagsLB.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.Text, (Object)textData);
            }
            else
            {
                MessageBox.Show("Aucun tag n'a été sélectionné", "Problème de tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void genCmdBtn_Click(object sender, EventArgs e)
        {
            if (tagsLB.SelectedItem.ToString() != null)
            {
                genCmd frm0 = new genCmd(this.host_registry,repoName,tagsLB.SelectedItem.ToString());
                frm0.ShowDialog();
            }
            else
            {
                MessageBox.Show("Aucun tag n'a été sélectionné", "Problème de tag", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
