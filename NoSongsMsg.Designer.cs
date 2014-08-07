namespace fPlayer_2
{
    partial class NoSongsMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoSongsMsg));
            this.licenseinfo = new Label2();
            this.infolibs = new Label2();
            this.advice2 = new Label2();
            this.advicetext = new Label2();
            this.SuspendLayout();
            // 
            // licenseinfo
            // 
            resources.ApplyResources(this.licenseinfo, "licenseinfo");
            this.licenseinfo.BackColor = System.Drawing.Color.Transparent;
            this.licenseinfo.Name = "licenseinfo";
            // 
            // infolibs
            // 
            resources.ApplyResources(this.infolibs, "infolibs");
            this.infolibs.BackColor = System.Drawing.Color.Transparent;
            this.infolibs.Name = "infolibs";
            // 
            // advice2
            // 
            resources.ApplyResources(this.advice2, "advice2");
            this.advice2.BackColor = System.Drawing.Color.Transparent;
            this.advice2.Name = "advice2";
            // 
            // advicetext
            // 
            resources.ApplyResources(this.advicetext, "advicetext");
            this.advicetext.BackColor = System.Drawing.Color.Transparent;
            this.advicetext.Name = "advicetext";
            // 
            // NoSongsMsg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.licenseinfo);
            this.Controls.Add(this.infolibs);
            this.Controls.Add(this.advice2);
            this.Controls.Add(this.advicetext);
            this.DoubleBuffered = true;
            this.Name = "NoSongsMsg";
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 advicetext;
        private Label2 advice2;
        private Label2 infolibs;
        private Label2 licenseinfo;
    }
}
