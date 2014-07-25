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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.songtitle = new Label2();
            this.songAlbum = new Label2();
            this.songArtist = new Label2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(250, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
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
            this.songtitle.Size = new System.Drawing.Size(239, 32);
            this.songtitle.TabIndex = 3;
            this.songtitle.Text = "song";
            this.songtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.songAlbum.Size = new System.Drawing.Size(239, 19);
            this.songAlbum.TabIndex = 2;
            this.songAlbum.Text = "Album";
            this.songAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.songArtist.Size = new System.Drawing.Size(239, 32);
            this.songArtist.TabIndex = 1;
            this.songArtist.Text = "Artist";
            this.songArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nowPlayingOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.songtitle);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.pictureBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "nowPlayingOverlay";
            this.Size = new System.Drawing.Size(400, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 songArtist;
        private Label2 songAlbum;
        private Label2 songtitle;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
