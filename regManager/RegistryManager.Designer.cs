namespace RegUI.regManager;

partial class RegistryManager
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistryManager));
        regLbx = new ListBox();
        nameTbx = new TextBox();
        urlTbx = new TextBox();
        usernameTbx = new TextBox();
        PasswordTbx = new TextBox();
        secChkbx = new CheckBox();
        newBtn = new Button();
        editBtn = new Button();
        deleteBtn = new Button();
        closeBtn = new Button();
        SuspendLayout();
        // 
        // regLbx
        // 
        regLbx.FormattingEnabled = true;
        regLbx.ItemHeight = 15;
        regLbx.Location = new Point(12, 12);
        regLbx.Name = "regLbx";
        regLbx.Size = new Size(200, 184);
        regLbx.TabIndex = 0;
        regLbx.SelectedIndexChanged += regLbx_SelectedIndexChanged;
        // 
        // nameTbx
        // 
        nameTbx.Location = new Point(229, 12);
        nameTbx.Name = "nameTbx";
        nameTbx.PlaceholderText = "Name";
        nameTbx.Size = new Size(232, 23);
        nameTbx.TabIndex = 1;
        // 
        // urlTbx
        // 
        urlTbx.Location = new Point(229, 41);
        urlTbx.Name = "urlTbx";
        urlTbx.PlaceholderText = "Url du registre";
        urlTbx.Size = new Size(232, 23);
        urlTbx.TabIndex = 2;
        // 
        // usernameTbx
        // 
        usernameTbx.Enabled = false;
        usernameTbx.Location = new Point(228, 101);
        usernameTbx.Name = "usernameTbx";
        usernameTbx.PlaceholderText = "Nom d'utilisateur";
        usernameTbx.Size = new Size(113, 23);
        usernameTbx.TabIndex = 2;
        // 
        // PasswordTbx
        // 
        PasswordTbx.Enabled = false;
        PasswordTbx.Location = new Point(347, 101);
        PasswordTbx.Name = "PasswordTbx";
        PasswordTbx.PasswordChar = '*';
        PasswordTbx.PlaceholderText = "Mot de passe";
        PasswordTbx.Size = new Size(113, 23);
        PasswordTbx.TabIndex = 2;
        // 
        // secChkbx
        // 
        secChkbx.AutoSize = true;
        secChkbx.CheckAlign = ContentAlignment.MiddleRight;
        secChkbx.Location = new Point(229, 70);
        secChkbx.Name = "secChkbx";
        secChkbx.Size = new Size(123, 19);
        secChkbx.TabIndex = 3;
        secChkbx.Text = "Registre Sécurisé : ";
        secChkbx.UseVisualStyleBackColor = true;
        secChkbx.CheckedChanged += onSecuredCheck;
        // 
        // newBtn
        // 
        newBtn.Location = new Point(227, 142);
        newBtn.Name = "newBtn";
        newBtn.Size = new Size(113, 24);
        newBtn.TabIndex = 4;
        newBtn.Text = "Créer";
        newBtn.UseVisualStyleBackColor = true;
        newBtn.Click += createRegistry;
        // 
        // editBtn
        // 
        editBtn.Location = new Point(346, 142);
        editBtn.Name = "editBtn";
        editBtn.Size = new Size(113, 24);
        editBtn.TabIndex = 4;
        editBtn.Text = "Modifier";
        editBtn.UseVisualStyleBackColor = true;
        // 
        // deleteBtn
        // 
        deleteBtn.Location = new Point(227, 172);
        deleteBtn.Name = "deleteBtn";
        deleteBtn.Size = new Size(113, 24);
        deleteBtn.TabIndex = 4;
        deleteBtn.Text = "Supprimer";
        deleteBtn.UseVisualStyleBackColor = true;
        deleteBtn.Click += deleteBtn_Click;
        // 
        // closeBtn
        // 
        closeBtn.Location = new Point(346, 172);
        closeBtn.Name = "closeBtn";
        closeBtn.Size = new Size(113, 24);
        closeBtn.TabIndex = 4;
        closeBtn.Text = "Fermer";
        closeBtn.UseVisualStyleBackColor = true;
        closeBtn.Click += closeBtn_Click;
        // 
        // RegistryManager
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(471, 206);
        Controls.Add(closeBtn);
        Controls.Add(deleteBtn);
        Controls.Add(editBtn);
        Controls.Add(newBtn);
        Controls.Add(secChkbx);
        Controls.Add(PasswordTbx);
        Controls.Add(usernameTbx);
        Controls.Add(urlTbx);
        Controls.Add(nameTbx);
        Controls.Add(regLbx);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "RegistryManager";
        Text = "Gestion des registres sauvegardés";
        Load += registryManager_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox regLbx;
    private TextBox nameTbx;
    private TextBox urlTbx;
    private TextBox usernameTbx;
    private TextBox PasswordTbx;
    private CheckBox secChkbx;
    private Button newBtn;
    private Button editBtn;
    private Button deleteBtn;
    private Button closeBtn;
}