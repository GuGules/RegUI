using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegUI.models;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace RegUI
{
    public partial class genServ : Form
    {
        private HttpClient http = new HttpClient();

        public string host_reg;
        public Dictionary<string, string> portsAffectations = new Dictionary<string, string>();
        public Dictionary<string, string> volumes = new Dictionary<string, string>();
        public Dictionary<string, string> envVar = new Dictionary<string, string>();

        public Service serv = null;
        public List<Service> services;

        public genServ(string host)
        {
            InitializeComponent();
            host_reg = host;
        }

        private async void fetchRepos()
        {
            HttpResponseMessage response = await http.GetAsync(host_reg + "/v2/_catalog");
            if (response.IsSuccessStatusCode)
            {
                string stringRes = await response.Content.ReadAsStringAsync();
                var catalog = JsonSerializer.Deserialize<CatalogResponse>(stringRes);

                if (catalog != null && catalog.repositories != null)
                {
                    imageCbx.Items.Clear();
                    foreach (var repo in catalog.repositories)
                    {
                        imageCbx.Items.Add(repo);
                    }
                }
            }
        }

        public async void fetchTags()
        {
            
            // Chargement des tags
            HttpResponseMessage response = await http.GetAsync(host_reg + "v2/" + imageCbx.SelectedItem.ToString() + "/tags/list");

            if (response.IsSuccessStatusCode)
            {
                string stringRes = await response.Content.ReadAsStringAsync();
                var repo = JsonSerializer.Deserialize<TagsResponse>(stringRes);

                if (repo != null && repo.tags != null)
                {
                    tagCbx.Items.Clear();
                    foreach (var tag in repo.tags)
                    {
                        tagCbx.Items.Add(tag);
                    }
                }
            }
            else
            {
                MessageBox.Show("Il y eu un problème avec la connexion au registre Docker", "Problème de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genServ_Load(object sender, EventArgs e)
        {
            portsDGV.DataSource = portsAffectations.ToList();
            portsDGV.Columns[0].HeaderText = "Port sur la machine";
            portsDGV.Columns[1].HeaderText = "Port dans le container";

            volDGV.DataSource = volumes.ToList();
            volDGV.Columns[0].HeaderText = "Volume local";
            volDGV.Columns[1].HeaderText = "Répertoire dans le container";

            envVarDgv.DataSource = envVar.ToList();
            envVarDgv.Columns[0].HeaderText = "Variable d'environnement";
            envVarDgv.Columns[1].HeaderText = "Valeur";

            nameTbx.Text = Randomer.genRandomName().ToLower();

            dependCbx.DataSource = services;
            dependCbx.DisplayMember = "name";
            dependCbx.SelectedIndex = -1;

            // gestion des affichages
            regLbl.Text += host_reg;

            fetchRepos();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void portAffectationBtn_Click(object sender, EventArgs e)
        {
            tbcGenServ.SelectTab(1);
        }

        private void btnVol_Click(object sender, EventArgs e)
        {
            tbcGenServ.SelectTab(2);
        }

        private void envVarBtn_Click(object sender, EventArgs e)
        {
            tbcGenServ.SelectTab(3);
        }

        private void addEnvVar_Click(object sender, EventArgs e)
        {
            envVar.Add(envVarTbx.Text.ToUpper(), envValueTbx.Text);
            envVarDgv.DataSource = envVar.ToList();
            envVarTbx.Text = "";
            envValueTbx.Text = "";
        }

        private void addVolume_Click(object sender, EventArgs e)
        {
            volumes.Add(localVolTbx.Text, containerDirTbx.Text);
            volDGV.DataSource = volumes.ToList();
            localVolTbx.Text = "";
            containerDirTbx.Text = "";
        }

        private void addAffectation_Click(object sender, EventArgs e)
        {
            portsAffectations.Add(localPortInput.Value.ToString(), containerPortInput.Value.ToString());
            portsDGV.DataSource = portsAffectations.ToList();
            localPortInput.Value = 0;
            containerPortInput.Value = 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            try
            {
                serv = new Service();
                if (nameTbx.Text != "")
                {
                    serv.name = nameTbx.Text;
                }else
                {
                    throw new Exception("Il manque un nom pour le service");
                }
                if (dependCbx.SelectedIndex != -1)
                {
                    serv.depends = services.ToList()[dependCbx.SelectedIndex];
                }
                serv.portsBinding = portsAffectations;
                serv.envVariables = envVar;
                serv.volumes = volumes;
                if (imageCbx.Text != "")
                {
                    serv.image = imageCbx.Text;
                } else
                {
                    throw new Exception("Aucune image n'a été indiquée");
                }
                if (tagCbx.Text != "")
                {
                    serv.tag = tagCbx.Text;
                } else
                {
                    throw new Exception("Aucune tag n'a été indiqué");
                }
                serv.registry = host_reg;

                // Fermeture de la fenêtre
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Certaines informations sont manquantes : \n"+ex.Message);
            }
        }

        public Service getService()
        {
            return serv;
        }

        private void imageCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchTags();
        }
    }
}