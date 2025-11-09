namespace RegUI.regManager;

partial class RegistrySelector
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrySelector));
        regCbx = new ComboBox();
        label1 = new Label();
        closeBtn = new Button();
        selectBtn = new Button();
        SuspendLayout();
        // 
        // regCbx
        // 
        regCbx.FormattingEnabled = true;
        regCbx.Location = new Point(73, 11);
        regCbx.Name = "regCbx";
        regCbx.Size = new Size(336, 23);
        regCbx.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(55, 15);
        label1.TabIndex = 1;
        label1.Text = "Registre :";
        // 
        // closeBtn
        // 
        closeBtn.Location = new Point(232, 44);
        closeBtn.Name = "closeBtn";
        closeBtn.Size = new Size(99, 23);
        closeBtn.TabIndex = 2;
        closeBtn.Text = "Fermer";
        closeBtn.UseVisualStyleBackColor = true;
        closeBtn.Click += closeBtn_Click;
        // 
        // selectBtn
        // 
        selectBtn.Location = new Point(77, 44);
        selectBtn.Name = "selectBtn";
        selectBtn.Size = new Size(148, 23);
        selectBtn.TabIndex = 2;
        selectBtn.Text = "Se connecter au registre";
        selectBtn.UseVisualStyleBackColor = true;
        selectBtn.Click += selectRegistry;
        // 
        // RegistrySelector
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(418, 77);
        Controls.Add(selectBtn);
        Controls.Add(closeBtn);
        Controls.Add(label1);
        Controls.Add(regCbx);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "RegistrySelector";
        Text = "Sélection du registre";
        Load += RegistrySelector_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ComboBox regCbx;
    private Label label1;
    private Button closeBtn;
    private Button selectBtn;
}