namespace RegUI
{
    partial class gestTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestTag));
            repoLbl = new Label();
            tagsLB = new ListBox();
            genCmdBtn = new Button();
            rmTagBtn = new Button();
            cmdPullBtn = new Button();
            SuspendLayout();
            // 
            // repoLbl
            // 
            repoLbl.AutoSize = true;
            repoLbl.Location = new Point(8, 11);
            repoLbl.Name = "repoLbl";
            repoLbl.Size = new Size(139, 15);
            repoLbl.TabIndex = 0;
            repoLbl.Text = "Tags pour l'application :  ";
            // 
            // tagsLB
            // 
            tagsLB.FormattingEnabled = true;
            tagsLB.ItemHeight = 15;
            tagsLB.Location = new Point(8, 38);
            tagsLB.Name = "tagsLB";
            tagsLB.Size = new Size(323, 454);
            tagsLB.Sorted = true;
            tagsLB.TabIndex = 1;
            // 
            // genCmdBtn
            // 
            genCmdBtn.Location = new Point(337, 38);
            genCmdBtn.Name = "genCmdBtn";
            genCmdBtn.Size = new Size(187, 23);
            genCmdBtn.TabIndex = 2;
            genCmdBtn.Text = "Générer commande docker run";
            genCmdBtn.UseVisualStyleBackColor = true;
            genCmdBtn.Click += genCmdBtn_Click;
            // 
            // rmTagBtn
            // 
            rmTagBtn.Location = new Point(337, 96);
            rmTagBtn.Name = "rmTagBtn";
            rmTagBtn.Size = new Size(187, 23);
            rmTagBtn.TabIndex = 3;
            rmTagBtn.Text = "Supprimer le tag";
            rmTagBtn.UseVisualStyleBackColor = true;
            rmTagBtn.Click += rmTagBtn_Click;
            // 
            // cmdPullBtn
            // 
            cmdPullBtn.Location = new Point(336, 67);
            cmdPullBtn.Name = "cmdPullBtn";
            cmdPullBtn.Size = new Size(187, 23);
            cmdPullBtn.TabIndex = 2;
            cmdPullBtn.Text = "Copier commande docker pull";
            cmdPullBtn.UseVisualStyleBackColor = true;
            cmdPullBtn.Click += cmdPullBtn_Click;
            // 
            // gestTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 499);
            Controls.Add(rmTagBtn);
            Controls.Add(cmdPullBtn);
            Controls.Add(genCmdBtn);
            Controls.Add(tagsLB);
            Controls.Add(repoLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "gestTag";
            Text = "Gestion des tags";
            Load += gestTag_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label repoLbl;
        private ListBox tagsLB;
        private Button genCmdBtn;
        private Button rmTagBtn;
        private Button cmdPullBtn;
    }
}