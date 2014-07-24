namespace fPlayer_2
{
    partial class SongsListItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongsListItem));
            this.songTitle = new System.Windows.Forms.Label();
            this.songInfo = new System.Windows.Forms.Label();
            this.songLength = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // songTitle
            // 
            this.songTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitle.Location = new System.Drawing.Point(17, 0);
            this.songTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(380, 32);
            this.songTitle.TabIndex = 0;
            this.songTitle.Text = "TITLE";
            this.songTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songTitle.DoubleClick += new System.EventHandler(this.songTitle_DoubleClick);
            // 
            // songInfo
            // 
            this.songInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songInfo.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfo.Location = new System.Drawing.Point(17, 32);
            this.songInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songInfo.Name = "songInfo";
            this.songInfo.Size = new System.Drawing.Size(380, 16);
            this.songInfo.TabIndex = 1;
            this.songInfo.Text = "INFO";
            this.songInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songInfo.DoubleClick += new System.EventHandler(this.songInfo_DoubleClick);
            // 
            // songLength
            // 
            this.songLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.songLength.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLength.Location = new System.Drawing.Point(406, 0);
            this.songLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songLength.Name = "songLength";
            this.songLength.Size = new System.Drawing.Size(42, 48);
            this.songLength.TabIndex = 2;
            this.songLength.Text = "--:--";
            this.songLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.songLength.DoubleClick += new System.EventHandler(this.songLength_DoubleClick);
            // 
            // menuButton
            // 
            this.menuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuButton.Location = new System.Drawing.Point(449, 0);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(48, 48);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.menuButton.TabIndex = 10;
            this.menuButton.TabStop = false;
            this.menuButton.Tag = "B";
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SongsListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.songLength);
            this.Controls.Add(this.songInfo);
            this.Controls.Add(this.songTitle);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SongsListItem";
            this.Size = new System.Drawing.Size(500, 48);
            this.Click += new System.EventHandler(this.SongsListItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SongsListItem_Paint);
            this.MouseHover += new System.EventHandler(this.SongsListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label songTitle;
        private System.Windows.Forms.Label songInfo;
        private System.Windows.Forms.Label songLength;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer timer;
    }
}
