namespace fPlayer_2
{
    partial class nowPlayingOverlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nowPlayingOverlay));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.songPos = new Label2();
            this.songtitle = new Label2();
            this.songAlbum = new Label2();
            this.songArtist = new Label2();
            this.savel = new Label2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // songPos
            // 
            resources.ApplyResources(this.songPos, "songPos");
            this.songPos.BackColor = System.Drawing.Color.Transparent;
            this.songPos.Name = "songPos";
            // 
            // songtitle
            // 
            resources.ApplyResources(this.songtitle, "songtitle");
            this.songtitle.BackColor = System.Drawing.Color.Transparent;
            this.songtitle.Name = "songtitle";
            // 
            // songAlbum
            // 
            resources.ApplyResources(this.songAlbum, "songAlbum");
            this.songAlbum.BackColor = System.Drawing.Color.Transparent;
            this.songAlbum.Name = "songAlbum";
            // 
            // songArtist
            // 
            resources.ApplyResources(this.songArtist, "songArtist");
            this.songArtist.BackColor = System.Drawing.Color.Transparent;
            this.songArtist.Name = "songArtist";
            // 
            // savel
            // 
            resources.ApplyResources(this.savel, "savel");
            this.savel.BackColor = System.Drawing.Color.White;
            this.savel.Name = "savel";
            this.savel.Click += new System.EventHandler(this.savel_Click);
            // 
            // nowPlayingOverlay
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.savel);
            this.Controls.Add(this.songPos);
            this.Controls.Add(this.songtitle);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.pictureBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "nowPlayingOverlay";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 songArtist;
        private Label2 songAlbum;
        private Label2 songtitle;
        private System.Windows.Forms.PictureBox pictureBox;
        public Label2 songPos;
        private Label2 savel;
    }
}
