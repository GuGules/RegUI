namespace RegUI
{
    partial class newVolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newVolume));
            confirmBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            dirTbx = new TextBox();
            nameTbx = new TextBox();
            SuspendLayout();
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(68, 72);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(102, 28);
            confirmBtn.TabIndex = 0;
            confirmBtn.Text = "Valider";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(176, 72);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(102, 28);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Annuler";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Nom du volume :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Direction : ";
            // 
            // dirTbx
            // 
            dirTbx.Location = new Point(115, 40);
            dirTbx.Name = "dirTbx";
            dirTbx.Size = new Size(226, 23);
            dirTbx.TabIndex = 2;
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(115, 11);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(226, 23);
            nameTbx.TabIndex = 2;
            // 
            // newVolume
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 111);
            Controls.Add(nameTbx);
            Controls.Add(dirTbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "newVolume";
            Text = "Ajouter un volume";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button confirmBtn;
        private Button cancelBtn;
        private Label label1;
        private Label label2;
        private TextBox dirTbx;
        private TextBox nameTbx;
    }
}