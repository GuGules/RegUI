namespace RegUI
{
    partial class genServ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genServ));
            tbcGenServ = new TabControl();
            tabPage1 = new TabPage();
            infosGbx = new GroupBox();
            accLbl = new Label();
            regLbl = new Label();
            envVarBtn = new Button();
            btnVol = new Button();
            portAffectationBtn = new Button();
            tagCbx = new ComboBox();
            imageCbx = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dependCbx = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            nameTbx = new TextBox();
            tabPage2 = new TabPage();
            label6 = new Label();
            containerPortInput = new NumericUpDown();
            localPortInput = new NumericUpDown();
            rmAffectation = new Button();
            addAffectation = new Button();
            portsDGV = new DataGridView();
            tabPage3 = new TabPage();
            containerDirTbx = new TextBox();
            localVolTbx = new TextBox();
            label = new Label();
            rmVolume = new Button();
            addVolume = new Button();
            volDGV = new DataGridView();
            tabPage4 = new TabPage();
            label5 = new Label();
            envValueTbx = new TextBox();
            envVarTbx = new TextBox();
            rmEnvVar = new Button();
            addEnvVar = new Button();
            envVarDgv = new DataGridView();
            confirmBtn = new Button();
            cancelBtn = new Button();
            tbcGenServ.SuspendLayout();
            tabPage1.SuspendLayout();
            infosGbx.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)containerPortInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)localPortInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)portsDGV).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volDGV).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)envVarDgv).BeginInit();
            SuspendLayout();
            // 
            // tbcGenServ
            // 
            tbcGenServ.Controls.Add(tabPage1);
            tbcGenServ.Controls.Add(tabPage2);
            tbcGenServ.Controls.Add(tabPage3);
            tbcGenServ.Controls.Add(tabPage4);
            tbcGenServ.Location = new Point(0, 0);
            tbcGenServ.Name = "tbcGenServ";
            tbcGenServ.SelectedIndex = 0;
            tbcGenServ.Size = new Size(423, 493);
            tbcGenServ.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(infosGbx);
            tabPage1.Controls.Add(envVarBtn);
            tabPage1.Controls.Add(btnVol);
            tabPage1.Controls.Add(portAffectationBtn);
            tabPage1.Controls.Add(tagCbx);
            tabPage1.Controls.Add(imageCbx);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dependCbx);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(nameTbx);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(415, 465);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Général";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // infosGbx
            // 
            infosGbx.Controls.Add(accLbl);
            infosGbx.Controls.Add(regLbl);
            infosGbx.Location = new Point(8, 253);
            infosGbx.Name = "infosGbx";
            infosGbx.Size = new Size(398, 206);
            infosGbx.TabIndex = 8;
            infosGbx.TabStop = false;
            infosGbx.Text = "Informations complémentaires";
            // 
            // accLbl
            // 
            accLbl.AutoSize = true;
            accLbl.Location = new Point(11, 70);
            accLbl.Name = "accLbl";
            accLbl.Size = new Size(104, 15);
            accLbl.TabIndex = 0;
            accLbl.Text = "Accès authentifié :";
            // 
            // regLbl
            // 
            regLbl.AutoSize = true;
            regLbl.Location = new Point(11, 31);
            regLbl.Name = "regLbl";
            regLbl.Size = new Size(55, 15);
            regLbl.TabIndex = 0;
            regLbl.Text = "Registre :";
            // 
            // envVarBtn
            // 
            envVarBtn.Location = new Point(6, 224);
            envVarBtn.Name = "envVarBtn";
            envVarBtn.Size = new Size(400, 23);
            envVarBtn.TabIndex = 7;
            envVarBtn.Text = "Gérer les variables d'environnement";
            envVarBtn.UseVisualStyleBackColor = true;
            envVarBtn.Click += envVarBtn_Click;
            // 
            // btnVol
            // 
            btnVol.Location = new Point(6, 195);
            btnVol.Name = "btnVol";
            btnVol.Size = new Size(400, 23);
            btnVol.TabIndex = 7;
            btnVol.Text = "Gérer les volumes";
            btnVol.UseVisualStyleBackColor = true;
            btnVol.Click += btnVol_Click;
            // 
            // portAffectationBtn
            // 
            portAffectationBtn.Location = new Point(8, 166);
            portAffectationBtn.Name = "portAffectationBtn";
            portAffectationBtn.Size = new Size(400, 23);
            portAffectationBtn.TabIndex = 7;
            portAffectationBtn.Text = "Attribuer les ports";
            portAffectationBtn.UseVisualStyleBackColor = true;
            portAffectationBtn.Click += portAffectationBtn_Click;
            // 
            // tagCbx
            // 
            tagCbx.FormattingEnabled = true;
            tagCbx.Location = new Point(113, 128);
            tagCbx.Name = "tagCbx";
            tagCbx.Size = new Size(287, 23);
            tagCbx.TabIndex = 6;
            // 
            // imageCbx
            // 
            imageCbx.FormattingEnabled = true;
            imageCbx.Location = new Point(93, 95);
            imageCbx.Name = "imageCbx";
            imageCbx.Size = new Size(307, 23);
            imageCbx.TabIndex = 6;
            imageCbx.SelectedIndexChanged += imageCbx_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 131);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "--> Tag :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 100);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Image : ";
            // 
            // dependCbx
            // 
            dependCbx.FormattingEnabled = true;
            dependCbx.Location = new Point(93, 54);
            dependCbx.Name = "dependCbx";
            dependCbx.Size = new Size(307, 23);
            dependCbx.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 59);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Dépendance :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom :";
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(54, 12);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(346, 23);
            nameTbx.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(containerPortInput);
            tabPage2.Controls.Add(localPortInput);
            tabPage2.Controls.Add(rmAffectation);
            tabPage2.Controls.Add(addAffectation);
            tabPage2.Controls.Add(portsDGV);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(415, 465);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ports";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 423);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 5;
            label6.Text = ":";
            // 
            // containerPortInput
            // 
            containerPortInput.Location = new Point(194, 420);
            containerPortInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            containerPortInput.Name = "containerPortInput";
            containerPortInput.Size = new Size(69, 23);
            containerPortInput.TabIndex = 3;
            // 
            // localPortInput
            // 
            localPortInput.Location = new Point(105, 420);
            localPortInput.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            localPortInput.Name = "localPortInput";
            localPortInput.Size = new Size(69, 23);
            localPortInput.TabIndex = 3;
            // 
            // rmAffectation
            // 
            rmAffectation.Location = new Point(334, 420);
            rmAffectation.Name = "rmAffectation";
            rmAffectation.Size = new Size(74, 23);
            rmAffectation.TabIndex = 2;
            rmAffectation.Text = "Supprimer";
            rmAffectation.UseVisualStyleBackColor = true;
            rmAffectation.Click += rmAffectation_Click;
            // 
            // addAffectation
            // 
            addAffectation.Location = new Point(266, 420);
            addAffectation.Name = "addAffectation";
            addAffectation.Size = new Size(62, 23);
            addAffectation.TabIndex = 1;
            addAffectation.Text = "Ajouter";
            addAffectation.UseVisualStyleBackColor = true;
            addAffectation.Click += addAffectation_Click;
            // 
            // portsDGV
            // 
            portsDGV.AllowUserToAddRows = false;
            portsDGV.AllowUserToDeleteRows = false;
            portsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            portsDGV.BackgroundColor = SystemColors.ButtonHighlight;
            portsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            portsDGV.Location = new Point(0, 0);
            portsDGV.MultiSelect = false;
            portsDGV.Name = "portsDGV";
            portsDGV.ReadOnly = true;
            portsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            portsDGV.Size = new Size(415, 414);
            portsDGV.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(containerDirTbx);
            tabPage3.Controls.Add(localVolTbx);
            tabPage3.Controls.Add(label);
            tabPage3.Controls.Add(rmVolume);
            tabPage3.Controls.Add(addVolume);
            tabPage3.Controls.Add(volDGV);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(415, 465);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Volumes";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // containerDirTbx
            // 
            containerDirTbx.Location = new Point(144, 429);
            containerDirTbx.Name = "containerDirTbx";
            containerDirTbx.Size = new Size(110, 23);
            containerDirTbx.TabIndex = 9;
            // 
            // localVolTbx
            // 
            localVolTbx.Location = new Point(17, 429);
            localVolTbx.Name = "localVolTbx";
            localVolTbx.Size = new Size(110, 23);
            localVolTbx.TabIndex = 9;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(131, 433);
            label.Name = "label";
            label.Size = new Size(10, 15);
            label.TabIndex = 8;
            label.Text = ":";
            // 
            // rmVolume
            // 
            rmVolume.Location = new Point(328, 429);
            rmVolume.Name = "rmVolume";
            rmVolume.Size = new Size(74, 23);
            rmVolume.TabIndex = 7;
            rmVolume.Text = "Supprimer";
            rmVolume.UseVisualStyleBackColor = true;
            rmVolume.Click += rmVolume_Click;
            // 
            // addVolume
            // 
            addVolume.Location = new Point(260, 429);
            addVolume.Name = "addVolume";
            addVolume.Size = new Size(62, 23);
            addVolume.TabIndex = 6;
            addVolume.Text = "Ajouter";
            addVolume.UseVisualStyleBackColor = true;
            addVolume.Click += addVolume_Click;
            // 
            // volDGV
            // 
            volDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            volDGV.BackgroundColor = SystemColors.ButtonHighlight;
            volDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            volDGV.Location = new Point(3, 3);
            volDGV.MultiSelect = false;
            volDGV.Name = "volDGV";
            volDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            volDGV.Size = new Size(405, 420);
            volDGV.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(envValueTbx);
            tabPage4.Controls.Add(envVarTbx);
            tabPage4.Controls.Add(rmEnvVar);
            tabPage4.Controls.Add(addEnvVar);
            tabPage4.Controls.Add(envVarDgv);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(415, 465);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Variables d'environnement";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 441);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 12;
            label5.Text = "=";
            // 
            // envValueTbx
            // 
            envValueTbx.Location = new Point(139, 437);
            envValueTbx.Name = "envValueTbx";
            envValueTbx.Size = new Size(110, 23);
            envValueTbx.TabIndex = 10;
            // 
            // envVarTbx
            // 
            envVarTbx.Location = new Point(8, 437);
            envVarTbx.Name = "envVarTbx";
            envVarTbx.Size = new Size(110, 23);
            envVarTbx.TabIndex = 11;
            // 
            // rmEnvVar
            // 
            rmEnvVar.Location = new Point(334, 437);
            rmEnvVar.Name = "rmEnvVar";
            rmEnvVar.Size = new Size(74, 23);
            rmEnvVar.TabIndex = 9;
            rmEnvVar.Text = "Supprimer";
            rmEnvVar.UseVisualStyleBackColor = true;
            rmEnvVar.Click += rmEnvVar_Click;
            // 
            // addEnvVar
            // 
            addEnvVar.Location = new Point(266, 437);
            addEnvVar.Name = "addEnvVar";
            addEnvVar.Size = new Size(62, 23);
            addEnvVar.TabIndex = 8;
            addEnvVar.Text = "Ajouter";
            addEnvVar.UseVisualStyleBackColor = true;
            addEnvVar.Click += addEnvVar_Click;
            // 
            // envVarDgv
            // 
            envVarDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            envVarDgv.BackgroundColor = SystemColors.ButtonHighlight;
            envVarDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            envVarDgv.Location = new Point(3, 3);
            envVarDgv.MultiSelect = false;
            envVarDgv.Name = "envVarDgv";
            envVarDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            envVarDgv.Size = new Size(405, 428);
            envVarDgv.TabIndex = 1;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(306, 495);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(106, 23);
            confirmBtn.TabIndex = 1;
            confirmBtn.Text = "Créer le service";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(227, 495);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(73, 23);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // genServ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 528);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(tbcGenServ);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "genServ";
            Text = "Génération d'un service";
            Load += genServ_Load;
            tbcGenServ.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            infosGbx.ResumeLayout(false);
            infosGbx.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)containerPortInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)localPortInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)portsDGV).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volDGV).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)envVarDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGenServ;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox nameTbx;
        private Button confirmBtn;
        private Button cancelBtn;
        private ComboBox dependCbx;
        private Label label2;
        private Label label1;
        private GroupBox infosGbx;
        private Label accLbl;
        private Label regLbl;
        private Button envVarBtn;
        private Button btnVol;
        private Button portAffectationBtn;
        private ComboBox tagCbx;
        private ComboBox imageCbx;
        private Label label4;
        private Label label3;
        private ListBox listVol;
        private Button rmAffectation;
        private Button addAffectation;
        private DataGridView portsDGV;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private NumericUpDown localPortInput;
        private Label label;
        private Button rmVolume;
        private Button addVolume;
        private DataGridView volDGV;
        private Button rmEnvVar;
        private Button addEnvVar;
        private DataGridView envVarDgv;
        private TextBox containerDirTbx;
        private TextBox localVolTbx;
        private Label label5;
        private TextBox envValueTbx;
        private TextBox envVarTbx;
        private NumericUpDown containerPortInput;
    }
}