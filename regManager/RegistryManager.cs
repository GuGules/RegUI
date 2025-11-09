using Docker.DotNet.Models;
using RegUI.models;
using System;
using System.Security.Policy;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RegUI.regManager;
public partial class RegistryManager : Form
{
    public RegistryManager()
    {
        InitializeComponent();
    }

    private Registry? selectedRegistry = null;
    private List<Registry> registries = Program.registryRepository.getRegistries();
    private void refresh() { registries = Program.registryRepository.getRegistries(); regLbx.DataSource = registries; }
    private void throwError(Exception e)
    {
        MessageBox.Show(
        e.Message,
        "Erreur lors de l'action",
        MessageBoxButtons.OK,
        MessageBoxIcon.Error
    );
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void registryManager_Load(object sender, EventArgs e)
    {
        regLbx.DataSource = registries;
        regLbx.DisplayMember = "Name";

        // Chargement du premier élément si la liste n'est pas vide.

        if (registries.Count > 0)
        {
            selectedRegistry = registries[0];

            nameTbx.Text = selectedRegistry.Name;
            urlTbx.Text = selectedRegistry.Url;
            secChkbx.Checked = selectedRegistry.Secured;

            if (selectedRegistry.Secured)
            {
                usernameTbx.Text = selectedRegistry.Username ?? String.Empty;
                PasswordTbx.Text = selectedRegistry.Password ?? String.Empty;
                usernameTbx.Enabled = true;
                PasswordTbx.Enabled = true;
            }
        }
    }

    private async void createRegistry(object sender, EventArgs e)
    {
        String error = String.Empty;
        string tempUrl = String.Empty;
        HttpClient http = new();
        if (nameTbx.Text == String.Empty) error += "Nom du registre\n";
        if (urlTbx.Text == String.Empty) error += "Url du registre\n";

        // AJOUT AUTO /
        if (!urlTbx.Text.EndsWith('/'))
        {
            urlTbx.Text += "/";
            tempUrl = urlTbx.Text;
        }

        // AJOUT AUTO HTTP / HTTPS
        if (!urlTbx.Text.StartsWith("https://"))
        {
            if (!urlTbx.Text.StartsWith("http://"))
            {
                // Ajout auto HTTP / HTTPS
                try
                {
                    // TEST HTTPS
                    if (Regex.IsMatch("https://" + tempUrl, @"^https?://((localhost:?\d+)|.+\..+)"))
                    {
                        HttpResponseMessage r1 = await http.GetAsync("https://" + tempUrl);
                        if (r1.IsSuccessStatusCode)
                        {
                            tempUrl = "https://" + tempUrl;
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
                        if (Regex.IsMatch("http://" + tempUrl, @"^https?://((localhost:?\d+)|.+\..+)"))
                        {
                            HttpResponseMessage r1 = await http.GetAsync("http://" + tempUrl);
                            if (r1.IsSuccessStatusCode)
                            {
                                tempUrl = "http://" + tempUrl;
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


            if (error != string.Empty)
            {
                throwError(new("Les champs suivants doivent être spécifiées :\n" + error));
            }

            try
            {
                Registry r = new Registry
                {
                    Name = nameTbx.Text,
                    Url = tempUrl,
                    Secured = secChkbx.Checked,
                    Username = usernameTbx.Text,
                    Password = PasswordTbx.Text
                };
                Program.registryRepository.CreateRegistry(r);
                regLbx.SelectedItem = r;
                refresh();
            }
            catch (Exception ex)
            {
                throwError(ex);
            }
        }
    }

    public void editRegistry(object sender, EventArgs e)
    {
        String error = String.Empty;
        if (nameTbx.Text == String.Empty) error += "Nom du registre\n";
        if (urlTbx.Text == String.Empty) error += "Url du registre\n";

        if (error != string.Empty)
        {
            throwError(new("Les champs suivants doivent être spécifiées :\n" + error));
        }

        selectedRegistry.Name = nameTbx.Text;
        selectedRegistry.Url = urlTbx.Text;
        selectedRegistry.Secured = secChkbx.Checked;
        selectedRegistry.Username = usernameTbx.Text;
        selectedRegistry.Password = PasswordTbx.Text;

        try
        {
            Program.registryRepository.updateRegistry(selectedRegistry);
            refresh();
        }
        catch (Exception ex) { throwError(ex); }

    }

    public void onSecuredCheck(object sender, EventArgs e)
    {
        if (secChkbx.Checked)
        {
            usernameTbx.Enabled = true;
            PasswordTbx.Enabled = true;
        }
        else
        {
            usernameTbx.Enabled = false;
            PasswordTbx.Enabled = false;
        }
    }

    private void deleteBtn_Click(object sender, EventArgs e)
    {
        if (selectedRegistry != null)
        {
            try
            {
                Program.registryRepository.deleteRegistry(selectedRegistry);
                refresh();
                regLbx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throwError(ex);
            }
        }
        else
        {
            throwError(new("Un registre doit être sélectionné"));
        }
    }

    private void regLbx_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedRegistry = (Registry)regLbx.SelectedItem;
    }
}
