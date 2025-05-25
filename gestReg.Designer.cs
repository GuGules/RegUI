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
            SuspendLayout();
            // 
            // regAdrTbx
            // 
            regAdrTbx.Location = new Point(12, 12);
            regAdrTbx.Name = "regAdrTbx";
            regAdrTbx.Size = new Size(269, 23);
            regAdrTbx.TabIndex = 0;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(694, 87);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(222, 23);
            delBtn.TabIndex = 2;
            delBtn.Text = "Supprimer un repository";
            delBtn.UseVisualStyleBackColor = true;
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
            fetchBtn.Location = new Point(287, 12);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "gestReg";
            Text = "RegUI";
            Load += gestReg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox regAdrTbx;
        private Button delBtn;
        private Button tagsManBtn;
        private Button fetchBtn;
        private ListBox repositoriesListBox;
    }
}