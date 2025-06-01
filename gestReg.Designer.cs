namespace RegUI
{
    partial class gestReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestReg));
            regAdrTbx = new TextBox();
            delBtn = new Button();
            tagsManBtn = new Button();
            fetchBtn = new Button();
            repositoriesListBox = new ListBox();
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            fermerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // regAdrTbx
            // 
            regAdrTbx.Location = new Point(12, 26);
            regAdrTbx.Name = "regAdrTbx";
            regAdrTbx.Size = new Size(269, 23);
            regAdrTbx.TabIndex = 0;
            regAdrTbx.KeyDown += regAdrTbx_KeyDown;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(694, 87);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(222, 23);
            delBtn.TabIndex = 2;
            delBtn.Text = "Supprimer un repository";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // tagsManBtn
            // 
            tagsManBtn.Location = new Point(694, 58);
            tagsManBtn.Name = "tagsManBtn";
            tagsManBtn.Size = new Size(222, 23);
            tagsManBtn.TabIndex = 3;
            tagsManBtn.Text = "Afficher les tags";
            tagsManBtn.UseVisualStyleBackColor = true;
            tagsManBtn.Click += tagsManBtn_Click;
            // 
            // fetchBtn
            // 
            fetchBtn.Location = new Point(287, 26);
            fetchBtn.Name = "fetchBtn";
            fetchBtn.Size = new Size(181, 23);
            fetchBtn.TabIndex = 4;
            fetchBtn.Text = "Charger les repositories";
            fetchBtn.UseVisualStyleBackColor = true;
            fetchBtn.Click += fetchBtn_Click;
            // 
            // repositoriesListBox
            // 
            repositoriesListBox.FormattingEnabled = true;
            repositoriesListBox.ItemHeight = 15;
            repositoriesListBox.Location = new Point(12, 58);
            repositoriesListBox.Name = "repositoriesListBox";
            repositoriesListBox.Size = new Size(674, 469);
            repositoriesListBox.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(926, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fermerToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(80, 20);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // fermerToolStripMenuItem
            // 
            fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            fermerToolStripMenuItem.Size = new Size(180, 22);
            fermerToolStripMenuItem.Text = "Fermer";
            fermerToolStripMenuItem.Click += fermerToolStripMenuItem_Click;
            // 
            // gestReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 546);
            Controls.Add(repositoriesListBox);
            Controls.Add(fetchBtn);
            Controls.Add(tagsManBtn);
            Controls.Add(delBtn);
            Controls.Add(regAdrTbx);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "gestReg";
            Text = "RegUI";
            Load += gestReg_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox regAdrTbx;
        private Button delBtn;
        private Button tagsManBtn;
        private Button fetchBtn;
        private ListBox repositoriesListBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem fermerToolStripMenuItem;
    }
}