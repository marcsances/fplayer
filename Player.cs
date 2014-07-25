﻿/*
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
using System.Collections.Generic;
using System.IO;
using libap;
using System.Threading;
namespace fPlayer_2
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public partial class Player : Form
	{
        public static string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MSS Software & Services\\fPlayer\\2.1\\";
		private bool isMaximized=false;
		public int tabFocused=0;
        public List<AudioFile> songs;
        public List<string> playlists;
        public List<Control> items;
        public List<AudioFile> stack=new List<AudioFile>();
        public bool isactive = false;
        public int sta_pos=0;
        int count = 0;
        public bool playglyph = false;
		public Player()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            this.mainPane.MouseWheel += new MouseEventHandler(WheelHandler);
		}
        public splash s;

        public void WheelHandler(object sender, MouseEventArgs e)
        {
            mainPane.AutoScrollOffset = new Point(mainPane.AutoScrollOffset.X, mainPane.AutoScrollOffset.Y + (5 * e.Delta));
        }
        public void ThreadRoutine()
        {
            
            
            
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
			if (isMouseMovingForm && this.WindowState==FormWindowState.Normal && !isMaximized) {
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
            contentPane.Controls.Clear();
			this.Top = 0;
			this.Left = 0;
			this.Height = Screen.PrimaryScreen.WorkingArea.Height;
			this.Width = Screen.PrimaryScreen.WorkingArea.Width;
			isMaximized=true;
			maximizeBox.Text="2";
            Update();
            switch (tabFocused)
            {
                case 0:
                    songsIcon_Click(this, new EventArgs());
                    break;
                case 1:
                    artistsIcon_Click(this, new EventArgs());
                    break;
                case 2:
                    albumsIcon_Click(this, new EventArgs());
                    break;
                case 3:
                    playlistsIcon_Click(this, new EventArgs());
                    break;
                case 4:
                    nowplayingIcon_Click(this, new EventArgs());
                    break;
                case 5:
                    libraryIcon_Click(this, new EventArgs());
                    break;
                case 6:
                    aboutIcon_Click(this, new EventArgs());
                    break;
                    
            }
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
                searchBox.Tag = searchBox.Text;
				searchBox.Text="";
			}
		}
		void SearchBoxLeave(object sender, EventArgs e)
		{
			if (searchBox.Text=="") {
				searchBox.ForeColor=Color.Gray;
				searchBox.Font=new Font(searchBox.Font,FontStyle.Italic);
                searchBox.Text = searchBox.Tag.ToString();
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
            if (this.isactive)
            {
                Control[] focusableControls = { songsPanel, artistsPanel, albumsPanel, playlistsPanel, nowplayingPanel, libraryPanel, aboutPanel, previousButton, playPauseButton, nextButton, volumeButton, shuffleButton, repeatButton };
                for (int i = 0; i < focusableControls.Length; i++)
                {
                    Control c = focusableControls[i];
                    if (isMouseOver(c) && !isHighlighted(c) && Control.MouseButtons != MouseButtons.Left)
                    {
                        doFocusHighlight(c, i);
                    }
                    else if (!isMouseOver(c) && (c.BackColor != Color.Teal && c.BackColor != Color.FromArgb(0, 64, 64)))
                    {
                        unHighlight(c, i);
                    }
                    else if (isMouseOver(c) && Control.MouseButtons == MouseButtons.Left)
                    {
                        doHover(c);
                    }
                    else if (c.BackColor == Color.FromArgb(0, 64, 64) && i != tabFocused)
                    {
                        c.BackColor = Color.Teal;
                    }
                }
                if (isMouseOver(mainPane) && !mainPane.Focused && tabFocused < 4) mainPane.Focus();
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

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            AboutDialog ab = new AboutDialog();
            //  not working correctly: ab.Size = new Size(this.contentPaneTitle.Width, this.Height - this.titlePanel.Height - this.contentPaneTitle.Height - this.bottomPanel.Height - 30);
            contentPane.Controls.Clear();
            contentPane.Controls.Add(ab);
            contentPaneTitle.Text = aboutLabel.Text;
            tabFocused = 6;
        }

        private void aboutIcon_Click(object sender, EventArgs e)
        {
            aboutLabel_Click(sender, e);
        }

        private void aboutPanel_Click(object sender, EventArgs e)
        {
            aboutLabel_Click(sender, e);
        }

        public void songsLabel_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = songsLabel.Text;
            contentPane.Controls.Clear();
            tabFocused = 0;
            loadSongsList();
        }

        private void songsIcon_Click(object sender, EventArgs e)
        {
            songsLabel_Click(sender, e);
        }

        private void songsPanel_Click(object sender, EventArgs e)
        {
            songsLabel_Click(sender, e);
        }

        private void artistsLabel_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = artistsLabel.Text;
            contentPane.Controls.Clear();
            loadArtistsList();
            tabFocused = 1;
        }

        private void artistsIcon_Click(object sender, EventArgs e)
        {
            artistsLabel_Click(sender, e);
        }

        private void artistsPanel_Click(object sender, EventArgs e)
        {
            artistsLabel_Click(sender, e);
        }

        private void albumsLabel_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = albumsLabel.Text;
            contentPane.Controls.Clear();
            loadAlbumsList();
            tabFocused = 2;
        }

        private void albumsIcon_Click(object sender, EventArgs e)
        {
            albumsLabel_Click(sender, e);
        }

        private void albumsPanel_Click(object sender, EventArgs e)
        {
            albumsLabel_Click(sender, e);
        }

        private void playlistsLabel_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = playlistsLabel.Text;
            contentPane.Controls.Clear();
            loadPlaylistsList();
            tabFocused = 3;
        }

        private void playlistsIcon_Click(object sender, EventArgs e)
        {
            playlistsLabel_Click(sender, e);
        }

        private void playlistsPanel_Click(object sender, EventArgs e)
        {
            playlistsLabel_Click(sender, e);
        }

        private void nowplayingLabel_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = nowplayingLabel.Text;
            contentPane.Controls.Clear();
            // TODO: populate content
            tabFocused = 4;
        }

        private void nowplayingIcon_Click(object sender, EventArgs e)
        {
            nowplayingLabel_Click(sender, e);
        }

        private void nowplayingPanel_Click(object sender, EventArgs e)
        {
            nowplayingLabel_Click(sender, e);
        }

        private void libraryLabel_Click(object sender, EventArgs e)
        {
            libraryEditor le = new libraryEditor();
            // not working correctly: le.Size = new Size(this.contentPaneTitle.Width, this.Height - this.titlePanel.Height - this.contentPaneTitle.Height - this.bottomPanel.Height - 30);
            contentPaneTitle.Text = libraryLabel.Text;
            contentPane.Controls.Clear();
            contentPane.Controls.Add(new libraryEditor());
            tabFocused = 5;
        }

        private void libraryIcon_Click(object sender, EventArgs e)
        {
            libraryLabel_Click(sender, e);
        }

        private void libraryPanel_Click(object sender, EventArgs e)
        {
            libraryLabel_Click(sender, e);
        }

        bool reversed = false;
        public void loadSongsList()
        {
            contentPane.Controls.Clear();
            if (!reversed) { items.Reverse(); reversed = true; } // Controls are docked from bottom to top, this will correctly sort them
            contentPane.Controls.AddRange(items.ToArray());
        }

        public void loadSongsList(splash s)
        {
            items = new List<Control>();
            contentPane.Tag = "-1";
            int i = 0;
            reversed = false;
            count = 0;
            foreach (AudioFile f in songs)
            {
                
                SongsListItem sli = new SongsListItem();
                sli.setData(f.ID3Information.Title, f.ID3Information.Artist + " / " + f.ID3Information.Album, getSongLength(f.FileName));
                sli.Dock = DockStyle.Top;
                sli.parentList = contentPane;
                sli.parent = this;
                sli.Tag = f.FileName;
                sli.OnMenuRequest += new EventHandler(OnMenuRequest);
                sli.OnPlaySelected += new EventHandler(OnPlaySelected);
                sli.index = i;
                i++;
                items.Add(sli);
                count++;
                s.curTask.Text = getStr(s.curTask.Tag.ToString(), 1) + " (" + count + ")";
                s.Update();
            }
        }
        public void reloadAll()
        {
            tabFocused = 0;
            loadSystemData();
        }
        public void loadSystemData()
        {
            s = new splash();
            s.Show();
            s.Update();
            songs = new List<AudioFile>();
            playlists = new List<string>();
            foreach (string q in Directory.GetFiles(AppFolder, "*.m3u")) { playlists.Add(q); }
            s.curTask.Text = getStr(s.curTask.Tag.ToString(), 0);
            s.Update();
            count = 0;
            retrieveSongs(s);
            songs.Sort();
            s.curTask.Text = getStr(s.curTask.Tag.ToString(), 1);
            s.Update();
            count = 0;
            loadSongsList(s);
            s.curTask.Text = getStr(s.curTask.Tag.ToString(), 2);
            loadSongsList();
            s.Update();
            s.Close();

        }

        public string getStr(string str, int pos)
        {
            return str.Split('!')[pos];
        }

        public void retrieveSongs(splash s)
        {
            if (!localDataFolderExists())
            {
                Directory.CreateDirectory(AppFolder);
            }
            if (File.Exists(AppFolder + "\\library.lib"))
            {
                foreach (string k in File.ReadAllText(AppFolder + "\\library.lib").Replace("\r", "").Split('\n'))
                {
                    if (k != "" && Directory.Exists(k))
                    {
                        retrieveDir(k, s);
                    }
                }
            }
            
        }

        public void add(string k, splash s, int i)
        {
            songs.Add(new AudioFile(k));
            count++;
            s.curTask.Text = getStr(s.curTask.Tag.ToString(), i) + " (" + count + ")";
            s.Update();
        }

        public void retrieveDir(string dir, splash s)
        {
            string exts = "*.mp3;*.flac;*.wav;*.ogg";
            foreach (string st in exts.Split(';'))
            {
                foreach (string k in Directory.GetFiles(dir, st, SearchOption.AllDirectories))
                {
                    add(k, s, 0);
                }
            }
        }

        public bool localDataFolderExists()
        {
            return Directory.Exists(Application.LocalUserAppDataPath + "\\MSS Software & Services\\fPlayer\\2.1\\");
        }

        public void OnPlaySelected(object sender, EventArgs e)
        {
            SongsListItem sli=(getSongsListItem((Control)sender));
            if (sli!=null) {
            Play(sli.Tag.ToString());
            }
        }

        public SongsListItem getSongsListItem(Control c)
        {
            if (c == null)
            {
                return null;
            }
            else if (c is SongsListItem)
            {
                return (SongsListItem)c;
            }
            else
            {
                return getSongsListItem(c.Parent);
            }
        }

        public void OnMenuRequest(object sender, EventArgs e)
        {
            songMenu.Show(MousePosition);
        }


        public string getSongLength(string filename)
        {
            return "";
        }

        public void loadArtistsList() {

        }

        public void loadAlbumsList()
        {

        }

        public void loadPlaylistsList()
        {

        }

        private void Player_Load(object sender, EventArgs e)
        {
            loadSystemData();
        }

       

        public void OnPlaybackFinishedHandler(object sender, EventArgs e)
        {
            next();
        }

        public void UpdateInfo()
        {
            songname.Text = stack[sta_pos].ID3Information.Title;
            songinfo.Text = stack[sta_pos].ID3Information.Artist + " / " + stack[sta_pos].ID3Information.Album;
            trackpos.Text = formatMs(getPos());
            tracklength.Text = formatMs(getLength());
            UpdateBar();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int si = getSelectedItem();
            if (si!=-1) Play(songs[si].FileName);
        }

        public int getSelectedItem()
        {
            foreach (string k in contentPane.Tag.ToString().Split(','))
            {
                int val = -1;
                try
                {
                    val = Convert.ToInt32(k);
                }
                catch
                {

                }
                if (val >= 0 && val < songs.Count) return val;

            }
            return -1;
        }

        public int[] getSelectedItems()
        {
            List<int> si = new List<int>();
            foreach (string k in contentPane.Tag.ToString().Split(','))
            {
                int val = -1;
                try
                {
                    val = Convert.ToInt32(k);
                }
                catch
                {

                }
                if (val > 0 && val < songs.Count) si.Add(val);

            }
            return si.ToArray();
        }

        /** 
         * Format a millisecond position in mm:ss format.
         */
        public string formatMs(long pos)
        {

            long s=0;
            long m = Math.DivRem(pos/1000, 60, out s);
            return fixedDigit(m) + ":" + fixedDigit(s);
        }

        /**
         * Format a number to have fixed digits.
         * \return a string containing the fixed digits.
         */
        public string fixedDigit(long a) {
            if (a < 10) return "0" + a.ToString(); else return a.ToString();
        }
        /**
         * Updates the progress bar.
         * Length - TrackbarBack.Width
         * Pos - X
         */
        public void UpdateBar()
        {
            if (getLength()>0) trackbarProgress.Width = (int)((getPos() * (long)trackbarBack.Width) / getLength());
        }

        /*-------------------
         * PLAYBACK FUNCTIONS
         *-------------------*/

        /**
         * Shortcut to MediaPlayer.getInstance() for fast coding.
         * \return current MediaPlayer instance, if any.
         */
        public MediaPlayer gI()
        {
            return MediaPlayer.getInstance();
        }
        /**
         * Plays an audio file cleaning stack.
         */
        public void Play(string filename)
        {
            stack.Clear();
            Stack(filename);
            sta_pos = stack.Count - 1;
            playnow();
        }

        /**
         * Stacks an audio file.
         */
        public void Stack(string filename)
        {
            stack.Add(new AudioFile(filename));
        }

        /**
         * Starts playing stack.
         */
        public void playnow()
        {
            MediaPlayer.getInstance(stack[sta_pos]).OnPlaybackFinished += new EventHandler(OnPlaybackFinishedHandler);
            gI().play();
            UpdateInfo();
            if (!playglyph)
            {
                switchglyph();
            }
        }

        public void switchglyph()
        {
            Image tmp = playPauseButton.ErrorImage;
            playPauseButton.ErrorImage = playPauseButton.Image;
            playPauseButton.Image = tmp;
            playglyph = !playglyph;
        }

        /**
         * Switches to previous track if any.
         */
        public void prev()
        {
            stopanddispose();
            sta_pos--;
            if (sta_pos == -1) 
                if (stack.Count != 0) 
                { 
                    sta_pos = stack.Count - 1; 
                    playnow(); 
                } else sta_pos = 0;
            else playnow();
        }

        /**
         * Switches to next track if any.
         */
        public void next()
        {
            stopanddispose();
            sta_pos++;
            if (sta_pos == stack.Count)
            {
                sta_pos = 0;
                if (stack.Count != 0) playnow();
            }
            else playnow();
        }

        /**
         * Stops playback and disposes media player.
         */
        public void stopanddispose()
        {
            if (gI() != null) gI().stop();
            if (gI() != null) gI().Dispose();
        }

        /**
         * Pause playback.
         */
        public void pause()
        {
            if (gI() != null)
            {
                gI().pause();
                if (playglyph)
                {
                    switchglyph();
                }
            }
        }

        /**
         * Resume playback.
         */
        public void resume()
        {
            if (gI() != null)
            {
                gI().play();
                if (!playglyph)
                {
                    switchglyph();
                }
            }
        }

        /**
         * Get position of current audio file.
         * \return the position
         */
        public long getPos()
        {
            if (gI() != null) return gI().getPosition(); else return 0;
        }

        /**
         * Get length of current audio file.
         * \return the length
         */
        public long getLength()
        {
            if (gI() != null) return gI().getLength(); else return 0;
        }

        /**
         * Seek to a position.
         */
        public void seek(long pos)
        {
            if (gI()!=null) gI().seek(pos);
        }

        /**
         * Plays or pauses.
         */
        public void playpause()
        {
            if (gI() != null) gI().playpause();
            switchglyph();
        }

        private void playbackTimer_Tick(object sender, EventArgs e)
        {
            if (gI() != null)
            {
                UpdateInfo();
            }
        }

        private void Player_Activated(object sender, EventArgs e)
        {
            this.isactive = true;
        }

        private void Player_Deactivate(object sender, EventArgs e)
        {
            this.isactive = false;
        }

        private void stackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (int i in getSelectedItems())
            {
                if (songs[i]!=null) Stack(songs[i].FileName);
                if (gI()==null || !gI().playing()) playnow();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            prev();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            playpause();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            next();
        }


        private bool drags = false;
        private void trackbarProgress_MouseDown(object sender, MouseEventArgs e)
        {
            drags = true;
            
        }

        private void trackbarBack_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarProgress_MouseDown(sender, e);
        }

        private void trackbarBack_MouseMove(object sender, MouseEventArgs e)
        {
            if (drags && gI() != null && gI().playing())
            {
                int mouseXOnElement = this.trackbarBack.PointToScreen(new Point(0, 0)).X;
                mouseXOnElement = MousePosition.X - mouseXOnElement;
                long posToSeek = (mouseXOnElement * getLength()) / trackbarBack.Width;
                seek(posToSeek);
            }
        }

        private void trackbarBack_MouseUp(object sender, MouseEventArgs e)
        {
            trackbarBack_MouseMove(sender, e);
            drags = false;
        }

        private void trackbarProgress_MouseMove(object sender, MouseEventArgs e)
        {
            trackbarBack_MouseMove(sender, e);
        }

        private void trackbarProgress_MouseUp(object sender, MouseEventArgs e)
        {
            trackbarBack_MouseUp(sender, e);
        }
	}
}
