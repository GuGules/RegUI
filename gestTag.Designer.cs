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
            button1 = new Button();
            button2 = new Button();
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
            // button1
            // 
            button1.Location = new Point(337, 38);
            button1.Name = "button1";
            button1.Size = new Size(187, 23);
            button1.TabIndex = 2;
            button1.Text = "Copier commande docker run";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(337, 67);
            button2.Name = "button2";
            button2.Size = new Size(187, 23);
            button2.TabIndex = 3;
            button2.Text = "Supprimer l'image tag";
            button2.UseVisualStyleBackColor = true;
            // 
            // gestTag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 499);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
    }
}