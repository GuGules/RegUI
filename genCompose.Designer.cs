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
            textBox1 = new TextBox();
            askAIBtn = new Button();
            copyBtn = new Button();
            saveFileBtn = new Button();
            composeFileEditor = new RichTextBox();
            setupPage = new TabPage();
            srvcLbl = new Label();
            servicesListBox = new ListBox();
            addServBtn = new Button();
            rmServBtn = new Button();
            genBtn = new Button();
            tbcGenCompose = new TabControl();
            outputPage.SuspendLayout();
            setupPage.SuspendLayout();
            tbcGenCompose.SuspendLayout();
            SuspendLayout();
            // 
            // outputPage
            // 
            outputPage.Controls.Add(textBox1);
            outputPage.Controls.Add(askAIBtn);
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
            // textBox1
            // 
            textBox1.Location = new Point(8, 540);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(630, 23);
            textBox1.TabIndex = 4;
            // 
            // askAIBtn
            // 
            askAIBtn.Location = new Point(644, 540);
            askAIBtn.Name = "askAIBtn";
            askAIBtn.Size = new Size(102, 23);
            askAIBtn.TabIndex = 3;
            askAIBtn.Text = "Demander à l'IA";
            askAIBtn.UseVisualStyleBackColor = true;
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
            composeFileEditor.Size = new Size(749, 489);
            composeFileEditor.TabIndex = 1;
            composeFileEditor.Text = "";
            // 
            // setupPage
            // 
            setupPage.Controls.Add(srvcLbl);
            setupPage.Controls.Add(servicesListBox);
            setupPage.Controls.Add(addServBtn);
            setupPage.Controls.Add(rmServBtn);
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
            srvcLbl.Location = new Point(7, 3);
            srvcLbl.Name = "srvcLbl";
            srvcLbl.Size = new Size(58, 15);
            srvcLbl.TabIndex = 2;
            srvcLbl.Text = "Services : ";
            // 
            // servicesListBox
            // 
            servicesListBox.FormattingEnabled = true;
            servicesListBox.ItemHeight = 15;
            servicesListBox.Location = new Point(7, 28);
            servicesListBox.Name = "servicesListBox";
            servicesListBox.Size = new Size(376, 529);
            servicesListBox.TabIndex = 1;
            // 
            // addServBtn
            // 
            addServBtn.Location = new Point(389, 28);
            addServBtn.Name = "addServBtn";
            addServBtn.Size = new Size(356, 25);
            addServBtn.TabIndex = 0;
            addServBtn.Text = "Ajouter un service";
            addServBtn.UseVisualStyleBackColor = true;
            addServBtn.Click += addServBtn_Click;
            // 
            // rmServBtn
            // 
            rmServBtn.Location = new Point(389, 59);
            rmServBtn.Name = "rmServBtn";
            rmServBtn.Size = new Size(356, 25);
            rmServBtn.TabIndex = 0;
            rmServBtn.Text = "Supprimer un service";
            rmServBtn.UseVisualStyleBackColor = true;
            rmServBtn.Click += rmServBtn_Click;
            // 
            // genBtn
            // 
            genBtn.Location = new Point(389, 90);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(356, 25);
            genBtn.TabIndex = 0;
            genBtn.Text = "Générer";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
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
            outputPage.PerformLayout();
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
        private Button genBtn;
        private TabControl tbcGenCompose;
        private Label srvcLbl;
        private ListBox servicesListBox;
        private Button addServBtn;
        private Button rmServBtn;
        private TextBox textBox1;
        private Button askAIBtn;
    }
}