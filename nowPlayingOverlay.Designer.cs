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
            this.songArtist = new System.Windows.Forms.Label();
            this.songAlbum = new System.Windows.Forms.Label();
            this.songtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songArtist
            // 
            this.songArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songArtist.BackColor = System.Drawing.Color.Transparent;
            this.songArtist.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtist.Location = new System.Drawing.Point(4, 99);
            this.songArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(392, 32);
            this.songArtist.TabIndex = 1;
            this.songArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songAlbum
            // 
            this.songAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songAlbum.BackColor = System.Drawing.Color.Transparent;
            this.songAlbum.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songAlbum.Location = new System.Drawing.Point(4, 131);
            this.songAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songAlbum.Name = "songAlbum";
            this.songAlbum.Size = new System.Drawing.Size(392, 19);
            this.songAlbum.TabIndex = 2;
            this.songAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songtitle
            // 
            this.songtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songtitle.BackColor = System.Drawing.Color.Transparent;
            this.songtitle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songtitle.Location = new System.Drawing.Point(4, 0);
            this.songtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songtitle.Name = "songtitle";
            this.songtitle.Size = new System.Drawing.Size(392, 32);
            this.songtitle.TabIndex = 3;
            this.songtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nowPlayingOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.songtitle);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "nowPlayingOverlay";
            this.Size = new System.Drawing.Size(400, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label songArtist;
        private System.Windows.Forms.Label songAlbum;
        private System.Windows.Forms.Label songtitle;
    }
}
