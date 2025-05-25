using RegUI.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegUI
{
    public partial class gestTag : Form
    {
        private string repoName;
        private string host_registry;
        public gestTag(string registry,string rName)
        {
            InitializeComponent();
            repoName = rName;
            host_registry = registry;
        }

        private async void gestTag_Load(object sender, EventArgs e)
        {
            repoLbl.Text += repoName;

            // Chargement des tags

            HttpClient http = new HttpClient();
            HttpResponseMessage response = await http.GetAsync(host_registry + "v2/" + repoName + "/tags/list");
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
    }
}
