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
            this.appName = new System.Windows.Forms.Label();
            this.appVer = new System.Windows.Forms.Label();
            this.apiimplver = new System.Windows.Forms.Label();
            this.copyInfo = new System.Windows.Forms.Label();
            this.facebookIcon = new System.Windows.Forms.PictureBox();
            this.twitterIcon = new System.Windows.Forms.PictureBox();
            this.webIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitterIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // appLogo
            // 
            resources.ApplyResources(this.appLogo, "appLogo");
            this.appLogo.Name = "appLogo";
            this.appLogo.TabStop = false;
            // 
            // appName
            // 
            resources.ApplyResources(this.appName, "appName");
            this.appName.ForeColor = System.Drawing.Color.Black;
            this.appName.Name = "appName";
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
            this.facebookIcon.Name = "facebookIcon";
            this.facebookIcon.TabStop = false;
            this.facebookIcon.Click += new System.EventHandler(this.facebookIcon_Click);
            // 
            // twitterIcon
            // 
            resources.ApplyResources(this.twitterIcon, "twitterIcon");
            this.twitterIcon.BackColor = System.Drawing.Color.Transparent;
            this.twitterIcon.Name = "twitterIcon";
            this.twitterIcon.TabStop = false;
            this.twitterIcon.Click += new System.EventHandler(this.twitterIcon_Click);
            // 
            // webIcon
            // 
            resources.ApplyResources(this.webIcon, "webIcon");
            this.webIcon.BackColor = System.Drawing.Color.Transparent;
            this.webIcon.Name = "webIcon";
            this.webIcon.TabStop = false;
            this.webIcon.Click += new System.EventHandler(this.webIcon_Click);
            // 
            // AboutDialog
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.webIcon);
            this.Controls.Add(this.twitterIcon);
            this.Controls.Add(this.facebookIcon);
            this.Controls.Add(this.copyInfo);
            this.Controls.Add(this.apiimplver);
            this.Controls.Add(this.appVer);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.appLogo);
            this.Name = "AboutDialog";
            this.Load += new System.EventHandler(this.AboutDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twitterIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox appLogo;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label appVer;
        private System.Windows.Forms.Label apiimplver;
        private System.Windows.Forms.Label copyInfo;
        private System.Windows.Forms.PictureBox facebookIcon;
        private System.Windows.Forms.PictureBox twitterIcon;
        private System.Windows.Forms.PictureBox webIcon;
    }
}
