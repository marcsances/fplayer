using System;
namespace fPlayer_2
{
    partial class PlaylistItem : IComparable
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistItem));
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.deletebutton = new System.Windows.Forms.PictureBox();
            this.artist = new Label2();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuButton.Location = new System.Drawing.Point(455, 3);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(42, 42);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 10;
            this.menuButton.TabStop = false;
            this.menuButton.Tag = "B";
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("deletebutton.Image")));
            this.deletebutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deletebutton.Location = new System.Drawing.Point(407, 3);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(42, 42);
            this.deletebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deletebutton.TabIndex = 11;
            this.deletebutton.TabStop = false;
            this.deletebutton.Tag = "B";
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            this.deletebutton.MouseEnter += new System.EventHandler(this.deletebutton_MouseEnter);
            this.deletebutton.MouseLeave += new System.EventHandler(this.deletebutton_MouseLeave);
            // 
            // artist
            // 
            this.artist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.artist.Location = new System.Drawing.Point(4, 0);
            this.artist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artist.Name = "artist";
            this.artist.Size = new System.Drawing.Size(397, 48);
            this.artist.TabIndex = 0;
            this.artist.Text = "TITLE";
            this.artist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.artist.Click += new System.EventHandler(this.songTitle_Click);
            this.artist.DoubleClick += new System.EventHandler(this.artist_DoubleClick);
            // 
            // PlaylistItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.artist);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PlaylistItem";
            this.Size = new System.Drawing.Size(500, 48);
            this.Click += new System.EventHandler(this.SongsListItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SongsListItem_Paint);
            this.DoubleClick += new System.EventHandler(this.ArtistItem_DoubleClick);
            this.MouseHover += new System.EventHandler(this.SongsListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 artist;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.PictureBox menuButton;
        public System.Windows.Forms.PictureBox deletebutton;
    }
}
