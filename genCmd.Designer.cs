namespace RegUI
{
    partial class genCmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(genCmd));
            groupBox1 = new GroupBox();
            osDropdown = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            imgLbl = new Label();
            groupBox3 = new GroupBox();
            containerDir = new TextBox();
            localDir = new TextBox();
            label4 = new Label();
            groupBox4 = new GroupBox();
            containerPort = new TextBox();
            localPort = new TextBox();
            label3 = new Label();
            groupBox5 = new GroupBox();
            nameTbx = new TextBox();
            label2 = new Label();
            groupBox6 = new GroupBox();
            backgrdActivityCbx = new CheckBox();
            groupBox7 = new GroupBox();
            submitBtn = new Button();
            cancelBtn = new Button();
            groupBox8 = new GroupBox();
            copyBtn = new Button();
            cmdBox = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(osDropdown);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 47);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Distribution (OS)";
            // 
            // osDropdown
            // 
            osDropdown.FormattingEnabled = true;
            osDropdown.Items.AddRange(new object[] { "Windows", "Linux / Windows (WSL)" });
            osDropdown.Location = new Point(137, 16);
            osDropdown.Name = "osDropdown";
            osDropdown.Size = new Size(170, 23);
            osDropdown.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Système d'exploitation : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(imgLbl);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Image sélectionnée";
            // 
            // imgLbl
            // 
            imgLbl.AutoSize = true;
            imgLbl.Location = new Point(8, 24);
            imgLbl.Name = "imgLbl";
            imgLbl.Size = new Size(118, 15);
            imgLbl.TabIndex = 0;
            imgLbl.Text = "Image sélectionnée : ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(containerDir);
            groupBox3.Controls.Add(localDir);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 122);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 47);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Volumes";
            // 
            // containerDir
            // 
            containerDir.Location = new Point(212, 18);
            containerDir.Name = "containerDir";
            containerDir.Size = new Size(111, 23);
            containerDir.TabIndex = 5;
            // 
            // localDir
            // 
            localDir.Location = new Point(65, 18);
            localDir.Name = "localDir";
            localDir.Size = new Size(111, 23);
            localDir.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 21);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 3;
            label4.Text = ":";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(containerPort);
            groupBox4.Controls.Add(localPort);
            groupBox4.Controls.Add(label3);
            groupBox4.Location = new Point(12, 175);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(395, 47);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Port binding";
            // 
            // containerPort
            // 
            containerPort.Location = new Point(211, 19);
            containerPort.Name = "containerPort";
            containerPort.Size = new Size(111, 23);
            containerPort.TabIndex = 2;
            // 
            // localPort
            // 
            localPort.Location = new Point(64, 19);
            localPort.Name = "localPort";
            localPort.Size = new Size(111, 23);
            localPort.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 22);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 0;
            label3.Text = ":";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(nameTbx);
            groupBox5.Controls.Add(label2);
            groupBox5.Location = new Point(12, 228);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(395, 53);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Nom du container";
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(57, 18);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(332, 23);
            nameTbx.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 21);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Nom : ";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(backgrdActivityCbx);
            groupBox6.Location = new Point(12, 287);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(395, 55);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Détails";
            // 
            // backgrdActivityCbx
            // 
            backgrdActivityCbx.AutoSize = true;
            backgrdActivityCbx.Location = new Point(8, 22);
            backgrdActivityCbx.Name = "backgrdActivityCbx";
            backgrdActivityCbx.Size = new Size(194, 19);
            backgrdActivityCbx.TabIndex = 0;
            backgrdActivityCbx.Text = "Fonctionnement en arrière-plan";
            backgrdActivityCbx.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(submitBtn);
            groupBox7.Controls.Add(cancelBtn);
            groupBox7.Location = new Point(12, 348);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(395, 55);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Validation / Annulation";
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(211, 22);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "Valider";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(90, 22);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(copyBtn);
            groupBox8.Controls.Add(cmdBox);
            groupBox8.Location = new Point(12, 411);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(395, 83);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            groupBox8.Text = "Commande";
            // 
            // copyBtn
            // 
            copyBtn.Location = new Point(366, 22);
            copyBtn.Name = "copyBtn";
            copyBtn.Size = new Size(23, 26);
            copyBtn.TabIndex = 1;
            copyBtn.Text = "🗒️";
            copyBtn.UseVisualStyleBackColor = true;
            copyBtn.Click += copyBtn_Click;
            // 
            // cmdBox
            // 
            cmdBox.Location = new Point(6, 22);
            cmdBox.Name = "cmdBox";
            cmdBox.Size = new Size(356, 53);
            cmdBox.TabIndex = 0;
            cmdBox.Text = "";
            // 
            // genCmd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 498);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "genCmd";
            Text = "Générer commande Docker";
            Load += genCmd_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox osDropdown;
        private Label label1;
        private GroupBox groupBox2;
        private Label imgLbl;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private CheckBox backgrdActivityCbx;
        private GroupBox groupBox7;
        private Button submitBtn;
        private Button cancelBtn;
        private TextBox nameTbx;
        private Label label2;
        private TextBox containerDir;
        private TextBox localDir;
        private Label label4;
        private TextBox containerPort;
        private TextBox localPort;
        private Label label3;
        private GroupBox groupBox8;
        private Button copyBtn;
        private RichTextBox cmdBox;
    }
}