namespace fPlayer_2
{
    partial class NothingPlayingMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NothingPlayingMsg));
            this.advice2 = new Label2();
            this.advicetext = new Label2();
            this.SuspendLayout();
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
            // NothingPlayingMsg
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.advice2);
            this.Controls.Add(this.advicetext);
            this.Name = "NothingPlayingMsg";
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 advicetext;
        private Label2 advice2;
    }
}
