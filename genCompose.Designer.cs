namespace RegUI
{
    partial class genCompose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genCompose));
            outputPage = new TabPage();
            copyBtn = new Button();
            saveFileBtn = new Button();
            composeFileEditor = new RichTextBox();
            setupPage = new TabPage();
            srvcLbl = new Label();
            servicesListBox = new ListBox();
            genBtn = new Button();
            tbcGenCompose = new TabControl();
            volumePage = new TabPage();
            nextBtn = new Button();
            outputPage.SuspendLayout();
            setupPage.SuspendLayout();
            tbcGenCompose.SuspendLayout();
            volumePage.SuspendLayout();
            SuspendLayout();
            // 
            // outputPage
            // 
            outputPage.Controls.Add(copyBtn);
            outputPage.Controls.Add(saveFileBtn);
            outputPage.Controls.Add(composeFileEditor);
            outputPage.Location = new Point(4, 24);
            outputPage.Name = "outputPage";
            outputPage.Padding = new Padding(3);
            outputPage.Size = new Size(752, 572);
            outputPage.TabIndex = 1;
            outputPage.Text = "Génération du docker compose";
            outputPage.UseVisualStyleBackColor = true;
            // 
            // copyBtn
            // 
            copyBtn.Location = new Point(41, 10);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(27, 23);
            copyBtn.TabIndex = 2;
            copyBtn.Text = "🗒️";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // saveFileBtn
            // 
            saveFileBtn.Location = new Point(8, 10);
            saveFileBtn.Name = "saveFileBtn";
            saveFileBtn.Size = new Size(27, 23);
            saveFileBtn.TabIndex = 2;
            saveFileBtn.Text = "💾";
            saveFileBtn.UseVisualStyleBackColor = true;
            saveFileBtn.Click += saveFileBtn_Click;
            // 
            // composeFileEditor
            // 
            composeFileEditor.Location = new Point(0, 45);
            composeFileEditor.Name = "composeFileEditor";
            composeFileEditor.Size = new Size(749, 521);
            composeFileEditor.TabIndex = 1;
            composeFileEditor.Text = "";
            // 
            // setupPage
            // 
            setupPage.Controls.Add(srvcLbl);
            setupPage.Controls.Add(servicesListBox);
            setupPage.Controls.Add(genBtn);
            setupPage.Location = new Point(4, 24);
            setupPage.Name = "setupPage";
            setupPage.Padding = new Padding(3);
            setupPage.Size = new Size(752, 572);
            setupPage.TabIndex = 0;
            setupPage.Text = "Configuration des services";
            setupPage.UseVisualStyleBackColor = true;
            // 
            // srvcLbl
            // 
            srvcLbl.AutoSize = true;
            srvcLbl.Location = new Point(7, 16);
            srvcLbl.Name = "srvcLbl";
            srvcLbl.Size = new Size(58, 15);
            srvcLbl.TabIndex = 2;
            srvcLbl.Text = "Services : ";
            // 
            // servicesListBox
            // 
            servicesListBox.FormattingEnabled = true;
            servicesListBox.ItemHeight = 15;
            servicesListBox.Location = new Point(7, 43);
            servicesListBox.Name = "servicesListBox";
            servicesListBox.Size = new Size(332, 259);
            servicesListBox.TabIndex = 1;
            // 
            // genBtn
            // 
            genBtn.Location = new Point(652, 541);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(93, 25);
            genBtn.TabIndex = 0;
            genBtn.Text = "Générer";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += nxtBtn0_Click;
            // 
            // tbcGenCompose
            // 
            tbcGenCompose.Controls.Add(volumePage);
            tbcGenCompose.Controls.Add(setupPage);
            tbcGenCompose.Controls.Add(outputPage);
            tbcGenCompose.Location = new Point(1, 2);
            tbcGenCompose.Name = "tbcGenCompose";
            tbcGenCompose.SelectedIndex = 0;
            tbcGenCompose.Size = new Size(760, 600);
            tbcGenCompose.TabIndex = 0;
            // 
            // volumePage
            // 
            volumePage.Controls.Add(nextBtn);
            volumePage.Location = new Point(4, 24);
            volumePage.Name = "volumePage";
            volumePage.Padding = new Padding(3);
            volumePage.Size = new Size(752, 572);
            volumePage.TabIndex = 2;
            volumePage.Text = "Configuration des volumes";
            volumePage.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(652, 541);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(93, 25);
            nextBtn.TabIndex = 1;
            nextBtn.Text = "Suivant";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // genCompose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 608);
            Controls.Add(tbcGenCompose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "genCompose";
            Text = "Generation de Docker-Compose";
            Load += genCompose_Load;
            outputPage.ResumeLayout(false);
            setupPage.ResumeLayout(false);
            setupPage.PerformLayout();
            tbcGenCompose.ResumeLayout(false);
            volumePage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage outputPage;
        private Button copyBtn;
        private Button saveFileBtn;
        private RichTextBox composeFileEditor;
        private TabPage setupPage;
        private Button genBtn;
        private TabControl tbcGenCompose;
        private Label srvcLbl;
        private ListBox servicesListBox;
        private TabPage volumePage;
        private Button nextBtn;
    }
}