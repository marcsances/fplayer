namespace fPlayer_2
{
    partial class PluginInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginInstaller));
            this.licenseBox = new System.Windows.Forms.TextBox();
            this.cancelbox = new System.Windows.Forms.Button();
            this.okbox = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label22 = new Label2();
            this.label21 = new Label2();
            this.licenseprehead = new Label2();
            this.extDev = new Label2();
            this.extName = new Label2();
            this.adviceTitle = new Label2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // licenseBox
            // 
            resources.ApplyResources(this.licenseBox, "licenseBox");
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.ReadOnly = true;
            // 
            // cancelbox
            // 
            resources.ApplyResources(this.cancelbox, "cancelbox");
            this.cancelbox.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbox.Name = "cancelbox";
            this.cancelbox.UseVisualStyleBackColor = true;
            this.cancelbox.Click += new System.EventHandler(this.cancelbox_Click);
            // 
            // okbox
            // 
            resources.ApplyResources(this.okbox, "okbox");
            this.okbox.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okbox.Name = "okbox";
            this.okbox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Name = "label22";
            this.label22.UseMnemonic = false;
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Name = "label21";
            // 
            // licenseprehead
            // 
            resources.ApplyResources(this.licenseprehead, "licenseprehead");
            this.licenseprehead.ForeColor = System.Drawing.Color.Black;
            this.licenseprehead.Name = "licenseprehead";
            // 
            // extDev
            // 
            resources.ApplyResources(this.extDev, "extDev");
            this.extDev.ForeColor = System.Drawing.Color.Black;
            this.extDev.Name = "extDev";
            // 
            // extName
            // 
            resources.ApplyResources(this.extName, "extName");
            this.extName.ForeColor = System.Drawing.Color.Black;
            this.extName.Name = "extName";
            // 
            // adviceTitle
            // 
            resources.ApplyResources(this.adviceTitle, "adviceTitle");
            this.adviceTitle.ForeColor = System.Drawing.Color.Black;
            this.adviceTitle.Name = "adviceTitle";
            // 
            // PluginInstaller
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okbox);
            this.Controls.Add(this.cancelbox);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.licenseprehead);
            this.Controls.Add(this.extDev);
            this.Controls.Add(this.extName);
            this.Controls.Add(this.adviceTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PluginInstaller";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.PluginInstaller_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label2 adviceTitle;
        public Label2 extName;
        public Label2 extDev;
        public Label2 licenseprehead;
        private System.Windows.Forms.TextBox licenseBox;
        private System.Windows.Forms.Button cancelbox;
        private System.Windows.Forms.Button okbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Label2 label22;
        public Label2 label21;
    }
}