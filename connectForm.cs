namespace RegUI
{
    public partial class connectForm : Form
    {
        public connectForm()
        {
            InitializeComponent();
        }

        private void connectForm_Load(object sender, EventArgs e)
        {
            errorMessageLabel.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usernameTbx.Text) && !string.IsNullOrWhiteSpace(PasswordTbx.Text))
            {
                // Affichage message tentative de connexion
                errorMessageLabel.Text = "Tentative de connexion...";
                errorMessageLabel.Show();
                errorMessageLabel.ForeColor = Color.Black;


            }
            else
            {
                errorMessageLabel.Text = "Veuillez renseigner un nom d'utilisateur et un mot de passe.";
                errorMessageLabel.Show();
                errorMessageLabel.ForeColor = Color.Red;
            }
        }
    }
}
