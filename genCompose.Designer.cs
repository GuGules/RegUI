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
            composeFileEditor = new RichTextBox();
            saveFileBtn = new Button();
            copyBtn = new Button();
            setupPage = new TabPage();
            nxtBtn0 = new Button();
            tbcGenCompose = new TabControl();
            servicesListBox = new ListBox();
            srvcLbl = new Label();
            outputPage.SuspendLayout();
            setupPage.SuspendLayout();
            tbcGenCompose.SuspendLayout();
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
            // composeFileEditor
            // 
            composeFileEditor.Location = new Point(0, 45);
            composeFileEditor.Name = "composeFileEditor";
            composeFileEditor.Size = new Size(749, 521);
            composeFileEditor.TabIndex = 1;
            composeFileEditor.Text = "";
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
            // setupPage
            // 
            setupPage.Controls.Add(srvcLbl);
            setupPage.Controls.Add(servicesListBox);
            setupPage.Controls.Add(nxtBtn0);
            setupPage.Location = new Point(4, 24);
            setupPage.Name = "setupPage";
            setupPage.Padding = new Padding(3);
            setupPage.Size = new Size(752, 572);
            setupPage.TabIndex = 0;
            setupPage.Text = "Choix des services";
            setupPage.UseVisualStyleBackColor = true;
            // 
            // nxtBtn0
            // 
            nxtBtn0.Location = new Point(636, 540);
            nxtBtn0.Name = "nxtBtn0";
            nxtBtn0.Size = new Size(93, 25);
            nxtBtn0.TabIndex = 0;
            nxtBtn0.Text = "Générer";
            nxtBtn0.UseVisualStyleBackColor = true;
            nxtBtn0.Click += nxtBtn0_Click;
            // 
            // tbcGenCompose
            // 
            tbcGenCompose.Controls.Add(setupPage);
            tbcGenCompose.Controls.Add(outputPage);
            tbcGenCompose.Location = new Point(1, 2);
            tbcGenCompose.Name = "tbcGenCompose";
            tbcGenCompose.SelectedIndex = 0;
            tbcGenCompose.Size = new Size(760, 600);
            tbcGenCompose.TabIndex = 0;
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
            // srvcLbl
            // 
            srvcLbl.AutoSize = true;
            srvcLbl.Location = new Point(7, 16);
            srvcLbl.Name = "srvcLbl";
            srvcLbl.Size = new Size(58, 15);
            srvcLbl.TabIndex = 2;
            srvcLbl.Text = "Services : ";
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
            ResumeLayout(false);
        }

        #endregion

        private TabPage outputPage;
        private Button copyBtn;
        private Button saveFileBtn;
        private RichTextBox composeFileEditor;
        private TabPage setupPage;
        private Button nxtBtn0;
        private TabControl tbcGenCompose;
        private Label srvcLbl;
        private ListBox servicesListBox;
    }
}