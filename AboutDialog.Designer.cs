namespace fPlayer_2
{
    partial class AboutDialog
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.appLogo = new System.Windows.Forms.PictureBox();
            this.appVer = new Label2();
            this.apiimplver = new Label2();
            this.copyInfo = new Label2();
            this.facebookIcon = new System.Windows.Forms.PictureBox();
            this.twitterIcon = new System.Windows.Forms.PictureBox();
            this.webIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appLogo
            // 
            resources.ApplyResources(this.appLogo, "appLogo");
            this.appLogo.Name = "appLogo";
            this.appLogo.TabStop = false;
            // 
            // appVer
            // 
            resources.ApplyResources(this.appVer, "appVer");
            this.appVer.ForeColor = System.Drawing.Color.Black;
            this.appVer.Name = "appVer";
            // 
            // apiimplver
            // 
            resources.ApplyResources(this.apiimplver, "apiimplver");
            this.apiimplver.ForeColor = System.Drawing.Color.Black;
            this.apiimplver.Name = "apiimplver";
            // 
            // copyInfo
            // 
            resources.ApplyResources(this.copyInfo, "copyInfo");
            this.copyInfo.ForeColor = System.Drawing.Color.Black;
            this.copyInfo.Name = "copyInfo";
            this.copyInfo.UseMnemonic = false;
            // 
            // facebookIcon
            // 
            resources.ApplyResources(this.facebookIcon, "facebookIcon");
            this.facebookIcon.BackColor = System.Drawing.Color.Transparent;
            this.facebookIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.facebookIcon.Name = "facebookIcon";
            this.facebookIcon.TabStop = false;
            this.facebookIcon.Click += new System.EventHandler(this.facebookIcon_Click);
            this.facebookIcon.MouseEnter += new System.EventHandler(this.facebookIcon_MouseEnter);
            this.facebookIcon.MouseLeave += new System.EventHandler(this.facebookIcon_MouseLeave);
            // 
            // twitterIcon
            // 
            resources.ApplyResources(this.twitterIcon, "twitterIcon");
            this.twitterIcon.BackColor = System.Drawing.Color.Transparent;
            this.twitterIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twitterIcon.Name = "twitterIcon";
            this.twitterIcon.TabStop = false;
            this.twitterIcon.Click += new System.EventHandler(this.twitterIcon_Click);
            this.twitterIcon.MouseEnter += new System.EventHandler(this.twitterIcon_MouseEnter);
            this.twitterIcon.MouseLeave += new System.EventHandler(this.twitterIcon_MouseLeave);
            // 
            // webIcon
            // 
            resources.ApplyResources(this.webIcon, "webIcon");
            this.webIcon.BackColor = System.Drawing.Color.Transparent;
            this.webIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.webIcon.Name = "webIcon";
            this.webIcon.TabStop = false;
            this.webIcon.Click += new System.EventHandler(this.webIcon_Click);
            this.webIcon.MouseEnter += new System.EventHandler(this.webIcon_MouseEnter);
            this.webIcon.MouseLeave += new System.EventHandler(this.webIcon_MouseLeave);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // AboutDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webIcon);
            this.Controls.Add(this.twitterIcon);
            this.Controls.Add(this.facebookIcon);
            this.Controls.Add(this.copyInfo);
            this.Controls.Add(this.apiimplver);
            this.Controls.Add(this.appVer);
            this.Controls.Add(this.appLogo);
            this.Name = "AboutDialog";
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox appLogo;
        private Label2 appVer;
        private Label2 apiimplver;
        private Label2 copyInfo;
        private System.Windows.Forms.PictureBox facebookIcon;
        private System.Windows.Forms.PictureBox twitterIcon;
        private System.Windows.Forms.PictureBox webIcon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
