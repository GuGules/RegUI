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
            tbcGenCompose = new TabControl();
            tabPage1 = new TabPage();
            nxtBtn0 = new Button();
            tabPage2 = new TabPage();
            richTextBox1 = new RichTextBox();
            tbcGenCompose.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tbcGenCompose
            // 
            tbcGenCompose.Controls.Add(tabPage1);
            tbcGenCompose.Controls.Add(tabPage2);
            tbcGenCompose.Location = new Point(1, 2);
            tbcGenCompose.Name = "tbcGenCompose";
            tbcGenCompose.SelectedIndex = 0;
            tbcGenCompose.Size = new Size(760, 600);
            tbcGenCompose.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(nxtBtn0);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(752, 572);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Page0";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // nxtBtn0
            // 
            nxtBtn0.Location = new Point(636, 540);
            nxtBtn0.Name = "nxtBtn0";
            nxtBtn0.Size = new Size(93, 25);
            nxtBtn0.TabIndex = 0;
            nxtBtn0.Text = "Suivant";
            nxtBtn0.UseVisualStyleBackColor = true;
            nxtBtn0.Click += nxtBtn0_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(752, 572);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Page1";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(752, 522);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // genCompose
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 603);
            Controls.Add(tbcGenCompose);
            Name = "genCompose";
            Text = "Generation de Docker-Compose";
            tbcGenCompose.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGenCompose;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button nxtBtn0;
        private RichTextBox richTextBox1;
    }
}