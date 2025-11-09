using RegUI.models;

namespace RegUI.regManager;
public partial class RegistrySelector : Form
{
    private Registry selectedRegistry;
    private List<Registry> registries;
    public int closeCode;

    public RegistrySelector()
    {
        InitializeComponent();
        registries = Program.registryRepository.getRegistries();
    }

    private void RegistrySelector_Load(object sender, EventArgs e)
    {
        regCbx.DataSource = registries;
        regCbx.DisplayMember = "Name";
        regCbx.SelectedIndex = 0;
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        closeCode = 1;
        this.Close();
    }

    private void selectRegistry(object sender, EventArgs e)
    {
        if (regCbx.SelectedIndex != -1)
        {
            selectedRegistry = registries[regCbx.SelectedIndex];
            this.Close();
        } else
        {
            MessageBox.Show(
                "Un registre doit être sélectionné pour poursuivre.",
                "Erreur de sélection",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

    public string getSelectedRegistryUrl()
    {
        if (selectedRegistry != null)
        {
            return selectedRegistry.Url;
        } else
        {
            return String.Empty;
        }
    }
}
