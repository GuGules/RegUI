namespace RegUI
{
    partial class connectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connectForm));
            connectBtn = new Button();
            label1 = new Label();
            usernameTbx = new TextBox();
            label2 = new Label();
            PasswordTbx = new TextBox();
            closeBtn = new Button();
            errorMessageLabel = new Label();
            SuspendLayout();
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(69, 107);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(90, 23);
            connectBtn.TabIndex = 0;
            connectBtn.Text = "Se Connecter";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 21);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom d'utilisateur :";
            // 
            // usernameTbx
            // 
            usernameTbx.Location = new Point(115, 17);
            usernameTbx.Name = "usernameTbx";
            usernameTbx.Size = new Size(179, 23);
            usernameTbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "Mot de passe : ";
            // 
            // PasswordTbx
            // 
            PasswordTbx.Location = new Point(115, 48);
            PasswordTbx.Name = "PasswordTbx";
            PasswordTbx.PasswordChar = '●';
            PasswordTbx.Size = new Size(179, 23);
            PasswordTbx.TabIndex = 2;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(165, 107);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(90, 23);
            closeBtn.TabIndex = 0;
            closeBtn.Text = "Fermer";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // errorMessageLabel
            // 
            errorMessageLabel.AutoSize = true;
            errorMessageLabel.ForeColor = Color.Black;
            errorMessageLabel.Location = new Point(0, 89);
            errorMessageLabel.Name = "errorMessageLabel";
            errorMessageLabel.Size = new Size(78, 15);
            errorMessageLabel.TabIndex = 3;
            errorMessageLabel.Text = "errorMessage";
            errorMessageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // connectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 137);
            Controls.Add(errorMessageLabel);
            Controls.Add(PasswordTbx);
            Controls.Add(usernameTbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(closeBtn);
            Controls.Add(connectBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "connectForm";
            Text = "Se connecter à un registre";
            Load += connectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectBtn;
        private Label label1;
        private TextBox usernameTbx;
        private Label label2;
        private TextBox PasswordTbx;
        private Button closeBtn;
        private Label errorMessageLabel;
    }
}