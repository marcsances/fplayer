using System;
namespace fPlayer_2
{
    partial class AlbumItem : IComparable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumItem));
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.albumIcon = new System.Windows.Forms.PictureBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.albumArtist = new Label2();
            this.albumTitle = new Label2();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumIcon)).BeginInit();
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
            // albumIcon
            // 
            this.albumIcon.BackColor = System.Drawing.Color.Transparent;
            this.albumIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("albumIcon.ErrorImage")));
            this.albumIcon.Image = ((System.Drawing.Image)(resources.GetObject("albumIcon.Image")));
            this.albumIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.albumIcon.Location = new System.Drawing.Point(3, 3);
            this.albumIcon.Name = "albumIcon";
            this.albumIcon.Size = new System.Drawing.Size(42, 42);
            this.albumIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumIcon.TabIndex = 11;
            this.albumIcon.TabStop = false;
            this.albumIcon.Tag = "B";
            this.albumIcon.DoubleClick += new System.EventHandler(this.albumIcon_DoubleClick);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // albumArtist
            // 
            this.albumArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumArtist.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumArtist.Location = new System.Drawing.Point(53, 32);
            this.albumArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumArtist.Name = "albumArtist";
            this.albumArtist.Size = new System.Drawing.Size(380, 16);
            this.albumArtist.TabIndex = 1;
            this.albumArtist.Text = "INFO";
            this.albumArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumArtist.Click += new System.EventHandler(this.songInfo_Click);
            this.albumArtist.DoubleClick += new System.EventHandler(this.albumArtist_DoubleClick);
            // 
            // albumTitle
            // 
            this.albumTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumTitle.Location = new System.Drawing.Point(52, 0);
            this.albumTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumTitle.Name = "albumTitle";
            this.albumTitle.Size = new System.Drawing.Size(380, 32);
            this.albumTitle.TabIndex = 0;
            this.albumTitle.Text = "TITLE";
            this.albumTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumTitle.Click += new System.EventHandler(this.songTitle_Click);
            this.albumTitle.DoubleClick += new System.EventHandler(this.albumTitle_DoubleClick);
            // 
            // AlbumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.albumIcon);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.albumArtist);
            this.Controls.Add(this.albumTitle);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlbumItem";
            this.Size = new System.Drawing.Size(500, 48);
            this.Click += new System.EventHandler(this.SongsListItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SongsListItem_Paint);
            this.DoubleClick += new System.EventHandler(this.AlbumItem_DoubleClick);
            this.MouseHover += new System.EventHandler(this.SongsListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 albumTitle;
        private Label2 albumArtist;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.PictureBox menuButton;
        public System.Windows.Forms.PictureBox albumIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
