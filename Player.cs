/*
 * Creado por SharpDevelop.
 * Usuario: Marc
 * Fecha: 07/07/2014
 * Hora: 18:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace fPlayer_2
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public partial class Player : Form
	{
		private bool isMaximized=false;
		private int tabFocused=0;
		public Player()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CloseBoxClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void MaximizeBoxClick(object sender, EventArgs e)
		{
			if (isMaximized) {
				restorestate();
			} else {
				maximize();
			}
			focusMisser.Focus();
		}
		void MinimizeBoxClick(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
			focusMisser.Focus();
		}
		void MaximizeBoxMouseEnter(object sender, EventArgs e)
		{
			maximizeBox.BackColor=Color.FromArgb(255,192,192,0);
		}
		void MaximizeBoxMouseLeave(object sender, EventArgs e)
		{
			maximizeBox.BackColor=Color.Olive;
		}
		void MinimizeBoxMouseEnter(object sender, EventArgs e)
		{
			minimizeBox.BackColor=Color.FromArgb(255,192,192,0);
		}
		void MinimizeBoxMouseLeave(object sender, EventArgs e)
		{
			minimizeBox.BackColor=Color.Olive;
		}
		void CloseBoxMouseEnter(object sender, EventArgs e)
		{
			closeBox.BackColor=Color.Red;
		}
		void CloseBoxMouseLeave(object sender, EventArgs e)
		{
			closeBox.BackColor=Color.FromArgb(255,192,0,0);
		}
		private bool isMouseMovingForm=false;
		private Point lastMousePos;
		void TitlePanelMouseDown(object sender, MouseEventArgs e)
		{
			isMouseMovingForm=true;
			lastMousePos=e.Location;
		}
		void AppTitleMouseDown(object sender, MouseEventArgs e)
		{
			TitlePanelMouseDown(sender,e);
			
		}
		void AppIconMouseDown(object sender, MouseEventArgs e)
		{
			TitlePanelMouseDown(sender,e);
		}
		void AppTitleMouseMove(object sender, MouseEventArgs e)
		{
			if (isMouseMovingForm && this.WindowState==FormWindowState.Normal) {
				    Point p1 = new Point(e.X, e.Y);
                	Point p2 = this.PointToScreen(p1);
                	Point p3 = new Point(p2.X - this.lastMousePos.X,p2.Y - this.lastMousePos.Y);
                	this.Location = p3;
			}
		}
		void AppIconMouseMove(object sender, MouseEventArgs e)
		{
			AppTitleMouseMove(sender,e);
		}
		void TitlePanelMouseMove(object sender, MouseEventArgs e)
		{
			AppTitleMouseMove(sender,e);
		}
		void AppTitleMouseUp(object sender, MouseEventArgs e)
		{
			isMouseMovingForm=false;
			focusMisser.Focus();
		}
		void TitlePanelMouseUp(object sender, MouseEventArgs e)
		{
			AppTitleMouseUp(sender,e);
		}
		void AppIconMouseUp(object sender, MouseEventArgs e)
		{
			AppTitleMouseUp(sender,e);
		}
		void WindowContextMenuOpening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (isMaximized) {
				restoreToolStripMenuItem.Enabled=true;
					maximizeToolStripMenuItem.Enabled=false;
			} else {
				restoreToolStripMenuItem.Enabled=false;
				maximizeToolStripMenuItem.Enabled=true;
			}
			switch (this.WindowState) {
				case FormWindowState.Minimized:
					restoreToolStripMenuItem.Enabled=true;
					maximizeToolStripMenuItem.Enabled=true;
					minimizeToolStripMenuItem.Enabled=false;
					break;
				default:
					minimizeToolStripMenuItem.Enabled=true;
					break;
			}
		}
		void RestoreToolStripMenuItemClick(object sender, EventArgs e)
		{
			restorestate();
			focusMisser.Focus();
		}
		void MinimizeToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
		}
		void MaximizeToolStripMenuItemClick(object sender, EventArgs e)
		{
			maximize();
			focusMisser.Focus();
		}
		void CloseToolStripMenuItemClick(object sender, EventArgs e)
		{
			focusMisser.Focus();
			this.Close();
			
		}
		
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x0313)
			{
				int contMenuX = Cursor.Position.X - this.Location.X;
				int contMenuY = Cursor.Position.Y - this.Location.Y;
				Point contMenuPos = new Point(contMenuX, contMenuY);
				this.windowContextMenu.Show(this, contMenuPos);
			}		
			base.WndProc(ref m);
		}
		private const int WS_DLGFRAME = 0x400000;
		protected override System.Windows.Forms.CreateParams CreateParams {
		get {
			CreateParams cp = base.CreateParams;
			cp.Style = cp.Style - WS_DLGFRAME;
			return cp;
			}
		}
		
		private Point oldpos;
		private Size oldsize;
		void maximize() {
			oldpos=Location;
			oldsize=Size;
			this.Top = 0;
			this.Left = 0;
			this.Height = Screen.PrimaryScreen.WorkingArea.Height;
			this.Width = Screen.PrimaryScreen.WorkingArea.Width;
			isMaximized=true;
			maximizeBox.Text="2";
		}
		
		void restorestate() {
			this.WindowState=FormWindowState.Normal;
			Location=oldpos;
			Size=oldsize;
			isMaximized=false;
			maximizeBox.Text="1";
		}
		void SearchBoxEnter(object sender, EventArgs e)
		{
			if (searchBox.ForeColor==Color.Gray) {
				searchBox.ForeColor=Color.Black;
				searchBox.Font=new Font(searchBox.Font,FontStyle.Regular);
				searchBox.Text="";
			}
		}
		void SearchBoxLeave(object sender, EventArgs e)
		{
			if (searchBox.Text=="") {
				searchBox.ForeColor=Color.Gray;
				searchBox.Font=new Font(searchBox.Font,FontStyle.Italic);
                searchBox.Text = Properties.Resources.string_search;
			}
		}
		void SearchBoxClick(object sender, EventArgs e)
		{
			SearchBoxEnter(sender,e);
		}
		void SearchBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			SearchBoxLeave(sender,e);
		}
		

        private bool isMouseOver(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(Cursor.Position));
        }

        private void focusController_Tick(object sender, EventArgs e)
        {
            Control[] focusableControls = { songsPanel, artistsPanel, albumsPanel, playlistsPanel, nowplayingPanel, aboutPanel, libraryPanel, previousButton, playPauseButton, nextButton, volumeButton, shuffleButton, repeatButton };
            for (int i = 0; i < focusableControls.Length; i++ )
            {
                Control c = focusableControls[i];
                if (isMouseOver(c) && !isHighlighted(c) && Control.MouseButtons!=MouseButtons.Left)
                {
                    doFocusHighlight(c,i);
                }
                else if (!isMouseOver(c) && (c.BackColor!=Color.Teal && c.BackColor!=Color.FromArgb(0,64,64)))
                {
                    unHighlight(c,i);
                }
                else if (isMouseOver(c) && Control.MouseButtons == MouseButtons.Left)
                {
                    doHover(c);
                }
            }
            
        }

        private bool isHighlighted(Control c)
        {
            if (c.Tag==null || c.Tag.ToString() != "B")
            {
                return c.BackColor.Equals(Color.FromArgb(0, 192, 192));
            }
            else
            {
                return c.BackColor.Equals(Color.Gray);
            }
        }
        private void doFocusHighlight(Control c,int i)
        {
            if (c.Tag == null || c.Tag.ToString() != "B")
            {
                if (i != tabFocused)
                {
                    c.BackColor = Color.FromArgb(0, 192, 192);
                }
                else
                {
                    c.BackColor = Color.FromArgb(0, 96, 96);
                }
            }
            else
            {
                c.BackColor = Color.Gray;
            }
        }

        private void unHighlight(Control c,int i)
        {
            if (c.Tag == null || c.Tag.ToString() != "B")
            {
                if (i != tabFocused)
                {
                    c.BackColor = Color.Teal;
                }
                else
                {
                    c.BackColor = Color.FromArgb(0, 64, 64);
                }
            }
            else c.BackColor = Color.Black;
        }

        private void doHover(Control c)
        {
            if (c.Tag == null || c.Tag.ToString() != "B") { c.BackColor = Color.FromArgb(0, 32, 32); } else c.BackColor = Color.LightGray;
        }

       
	}
}
