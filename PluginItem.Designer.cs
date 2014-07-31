using System;
namespace fPlayer_2
{
    partial class PluginItem : IComparable
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pluginname = new Label2();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pluginname
            // 
            this.pluginname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginname.Location = new System.Drawing.Point(4, 0);
            this.pluginname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pluginname.Name = "pluginname";
            this.pluginname.Size = new System.Drawing.Size(492, 48);
            this.pluginname.TabIndex = 0;
            this.pluginname.Text = "TITLE";
            this.pluginname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pluginname.Click += new System.EventHandler(this.songTitle_Click);
            this.pluginname.DoubleClick += new System.EventHandler(this.artist_DoubleClick);
            // 
            // PluginItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pluginname);
            this.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PluginItem";
            this.Size = new System.Drawing.Size(500, 48);
            this.Click += new System.EventHandler(this.SongsListItem_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SongsListItem_Paint);
            this.DoubleClick += new System.EventHandler(this.ArtistItem_DoubleClick);
            this.MouseHover += new System.EventHandler(this.SongsListItem_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private Label2 pluginname;
        private System.Windows.Forms.Timer timer;
    }
}
