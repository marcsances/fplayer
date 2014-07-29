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
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.songInfo = new Label2();
            this.songTitle = new Label2();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
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
            this.menuButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuButton_MouseDown);
            this.menuButton.MouseEnter += new System.EventHandler(this.menuButton_MouseEnter);
            this.menuButton.MouseLeave += new System.EventHandler(this.menuButton_MouseLeave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // songInfo
            // 
            this.songInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songInfo.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songInfo.Location = new System.Drawing.Point(17, 32);
            this.songInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songInfo.Name = "songInfo";
            this.songInfo.Size = new System.Drawing.Size(431, 16);
            this.songInfo.TabIndex = 1;
            this.songInfo.Text = "INFO";
            this.songInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songInfo.Click += new System.EventHandler(this.songInfo_Click);
            this.songInfo.DoubleClick += new System.EventHandler(this.songInfo_DoubleClick);
            this.songInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songInfo_MouseDown);
            // 
            // songTitle
            // 
            this.songTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitle.Location = new System.Drawing.Point(17, 0);
            this.songTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(431, 32);
            this.songTitle.TabIndex = 0;
            this.songTitle.Text = "TITLE";
            this.songTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songTitle.Click += new System.EventHandler(this.songTitle_Click);
            this.songTitle.DoubleClick += new System.EventHandler(this.songTitle_DoubleClick);
            this.songTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.songTitle_MouseDown);
            // 
            // SongsListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.songInfo);
            this.Controls.Add(this.songTitle);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SongsListItem";
            this.Size = new System.Drawing.Size(500, 48);
            this.Click += new System.EventHandler(this.SongsListItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SongsListItem_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SongsListItem_MouseDown);
            this.MouseHover += new System.EventHandler(this.SongsListItem_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 songTitle;
        private Label2 songInfo;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.PictureBox menuButton;
    }
}
