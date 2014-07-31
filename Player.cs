/*
 * This file is part of fPlayer.

    fPlayer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    fPlayer is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with fPlayer.  If not, see <http://www.gnu.org/licenses/>.
 * */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using libap;
using System.Threading;
using System.Globalization;
using System.Reflection;
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
        public nowPlayingOverlay npo = new nowPlayingOverlay();
        public bool shuffle = false;
        public bool repeat = false;
		public Player()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
            if (!localDataFolderExists())
            {
                Directory.CreateDirectory(AppFolder);
            }
            if (!Directory.Exists(AppFolder+"\\hashes\\")) Directory.CreateDirectory(AppFolder+"\\hashes\\");
            this.mainPane.MouseWheel += new MouseEventHandler(WheelHandler);
            loadPlugins();
		}
        Dictionary<string, IPlugin> _Plugins = new Dictionary<string, IPlugin>();
        public void loadPlugins()
        {
            string[] dllFileNames = null;
            if (Directory.Exists(AppFolder+"\\plugins\\"))
            {
                dllFileNames = Directory.GetFiles(AppFolder + "\\plugins\\", "*.dll");
            }
            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }
            Type pluginType = typeof(IPlugin);
            ICollection<Type> pluginTypes = new List<Type>();
            foreach (Assembly assembly in assemblies)
            {
                if (assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                        {
                            continue;
                        }
                        else
                        {
                            if (type.GetInterface(pluginType.FullName) != null)
                            {
                                pluginTypes.Add(type);
                            }
                        }
                    }
                }
            }
            foreach (Type type in pluginTypes)
            {
                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                _Plugins.Add(plugin.Name, plugin);
            }
            
        }
        
        public splash s;

        public void WheelHandler(object sender, MouseEventArgs e)
        {
            mainPane.AutoScrollOffset = new Point(mainPane.AutoScrollOffset.X, mainPane.AutoScrollOffset.Y + 5 * e.Delta);
        }
      
		void CloseBoxClick(object sender, EventArgs e)
		{
            this.contentPane.Tag = "-1";
			this.Close();
		}
		void MaximizeBoxClick(object sender, EventArgs e)
		{
            this.contentPane.Tag = "-1";
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
            this.contentPane.Tag = "-1";
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
            
	    if (m.Msg == 0x319)   // WM_APPCOMMAND message
	    {
		// extract cmd from LPARAM (as GET_APPCOMMAND_LPARAM macro does)
		int cmd = (int)((uint)m.LParam >> 16 & ~0xf000);
		switch (cmd)
		{
			    case 13:  // APPCOMMAND_MEDIA_STOP constant
                stopanddispose();
				break;
			    case 14:  // APPCOMMAND_MEDIA_PLAY_PAUSE
                playpause();
				break;
			    case 11:  // APPCOMMAND_MEDIA_NEXTTRACK
                next();
				    break;
			    case 12:  // APPCOMMAND_MEDIA_PREVIOUSTRACK
                    prev();
				    break;
			    default:
			    	break;
	        	}
        	}

			if (m.Msg == 0x0313 && (Environment.OSVersion.Version.Major<6 || Environment.OSVersion.Version.Minor==0))
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
            this.Height = SystemInformation.WorkingArea.Height;
            this.Width = SystemInformation.WorkingArea.Width;
            contentPane.Controls.Clear();
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
            this.contentPane.Tag = "-1";
			SearchBoxLeave(sender,e);
		}
		

        public bool isMouseOver(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(Cursor.Position));
        }


        private void focusController_Tick(object sender, EventArgs e)
        {
          
            if (this.isactive)
            {
                Control[] focusableControls = { songsPanel, artistsPanel, albumsPanel, playlistsPanel, nowplayingPanel, libraryPanel, aboutPanel, pluginPanel, previousButton, playPauseButton, nextButton, volumeButton, shuffleButton, repeatButton };
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
                if (isMouseOver(mainPane) && !mainPane.Focused && tabFocused < 5) mainPane.Focus();
            }
            if (shuffle && shuffleButton.BackColor!=Color.White) shuffleButton.BackColor = Color.Green;
            if (repeat && repeatButton.BackColor != Color.White) repeatButton.BackColor = Color.Green;
            if (MouseButtons == MouseButtons.Left && !isMouseOver(volumeButton) && !drags2 && !isMouseOver(volFront) && !isMouseOver(volBack) && !isMouseOver(volVal)) voldefocus();
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

        private void aboutLabel2_Click(object sender, EventArgs e)
        {
            AboutDialog ab = new AboutDialog();
            //  not working correctly: ab.Size = new Size(this.contentPaneTitle.Width, this.Height - this.titlePanel.Height - this.contentPaneTitle.Height - this.bottomPanel.Height - 30);
            contentPane.Controls.Clear();
            contentPane.Controls.Add(ab);
            contentPaneTitle.Text = aboutLabel2.Text;
            tabFocused = 6;
            this.Refresh();
            contentPane.Refresh();
        }

        private void aboutIcon_Click(object sender, EventArgs e)
        {
            aboutLabel2_Click(sender, e);
        }

        private void aboutPanel_Click(object sender, EventArgs e)
        {
            aboutLabel2_Click(sender, e);
        }

        public void songsLabel2_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = songsLabel2.Text;
            contentPane.Controls.Clear();
            tabFocused = 0;
            loadSongsList();
            this.Refresh();
            contentPane.Refresh();
        }

        private void songsIcon_Click(object sender, EventArgs e)
        {
            songsLabel2_Click(sender, e);
        }

        private void songsPanel_Click(object sender, EventArgs e)
        {
            songsLabel2_Click(sender, e);
        }

        private void artistsLabel2_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = artistsLabel2.Text;
            contentPane.Controls.Clear();
            loadArtistsList();
            tabFocused = 1;
            this.Refresh();
            contentPane.Refresh();
        }

        private void artistsIcon_Click(object sender, EventArgs e)
        {
            artistsLabel2_Click(sender, e);
        }

        private void artistsPanel_Click(object sender, EventArgs e)
        {
            artistsLabel2_Click(sender, e);
        }

        private void albumsLabel2_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = albumsLabel2.Text;
            contentPane.Controls.Clear();
            loadAlbumsList();
            tabFocused = 2;
            this.Refresh();
            contentPane.Refresh();
        }

        private void albumsIcon_Click(object sender, EventArgs e)
        {
            albumsLabel2_Click(sender, e);
        }

        private void albumsPanel_Click(object sender, EventArgs e)
        {
            albumsLabel2_Click(sender, e);
        }

        private void playlistsLabel2_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = playlistsLabel2.Text;
            contentPane.Controls.Clear();
            loadPlaylistsList();
            tabFocused = 3;
            this.Refresh();
            contentPane.Refresh();
        }

        private void playlistsIcon_Click(object sender, EventArgs e)
        {
            playlistsLabel2_Click(sender, e);
        }

        private void playlistsPanel_Click(object sender, EventArgs e)
        {
            playlistsLabel2_Click(sender, e);
        }

        private void nowplayingLabel2_Click(object sender, EventArgs e)
        {
            contentPaneTitle.Text = nowplayingLabel2.Text;
            contentPane.Controls.Clear();
            loadNowPlaying();
            tabFocused = 4;
            this.Refresh();
            contentPane.Refresh();
        }

        public void loadNowPlaying()
        {
            contentPane.Tag = "-1";
            if (stack.Count == 0)
            {
                NothingPlayingMsg npm = new NothingPlayingMsg();
                npm.Dock = DockStyle.Fill;
                contentPane.Controls.Add(npm);
            }
            else
            {
                loadStackList();
                npo.Dock = DockStyle.Top;
                npo.onSaveAsNewListOptionClicked += new EventHandler(newListHandler);
                contentPane.Controls.Add(npo);
            }
        }
        public void newListHandler(object sender,EventArgs e) {
            InputDialog ind = new InputDialog();
            ind.parent = this;
            if (ind.ShowDialog() == DialogResult.OK)
            {
                string data = "";
                foreach(AudioFile a in stack) {
                    data = data + a.FileName + "\r\n";
                }
                data = data.Substring(0, data.Length - 4);
                File.WriteAllText(AppFolder + inp + ".m3u", data);
            }
        }
        public void OnStackRequest(object sender, EventArgs e)
        {
            
            SongsListItem sli = getSongsListItem((Control)sender);
            if (sli != null) { quicklistmenu.Tag = stack[safeconvertint32(sli.Tag)].FileName; quicklistmenu.Show(MousePosition); }
        }
        public void loadStackList()
        {
            for (int i = (stack.Count - 1); i >= 0; i--)
            {
                AudioFile f = stack[i];
                SongsListItem sli = new SongsListItem();
                string artist = f.ID3Information.Artist;
                string album = f.ID3Information.Album;
                if (artist.Length < 1) artist = getStr(translations.Text, 0);
                if (album.Length < 1) album = getStr(translations.Text, 1);
                sli.setData(f.ID3Information.Title, artist + " / " + album, getSongLength(f.FileName));
                sli.Dock = DockStyle.Top;
                sli.parentList = contentPane;
                sli.parent = this;
                sli.Tag = i;
                sli.isStack = true;
                sli.OnMenuRequest += new EventHandler(OnStackRequest);
                sli.OnPlaySelected += new EventHandler(OnPlaySelected);
                sli.index = i;
                contentPane.Controls.Add(sli);
            }
        }

        private void nowplayingIcon_Click(object sender, EventArgs e)
        {
            nowplayingLabel2_Click(sender, e);
        }

        private void nowplayingPanel_Click(object sender, EventArgs e)
        {
            nowplayingLabel2_Click(sender, e);
        }

        private void libraryLabel2_Click(object sender, EventArgs e)
        {
            libraryEditor le = new libraryEditor();
            // not working correctly: le.Size = new Size(this.contentPaneTitle.Width, this.Height - this.titlePanel.Height - this.contentPaneTitle.Height - this.bottomPanel.Height - 30);
            contentPaneTitle.Text = libraryLabel2.Text;
            contentPane.Controls.Clear();
            contentPane.Controls.Add(new libraryEditor());
            tabFocused = 5;
        }

        private void libraryIcon_Click(object sender, EventArgs e)
        {
            libraryLabel2_Click(sender, e);
        }

        private void libraryPanel_Click(object sender, EventArgs e)
        {
            libraryLabel2_Click(sender, e);
        }

        bool reversed = false;
        public void loadSongsList()
        {
            contentPane.Controls.Clear();
            if (!reversed) { items.Reverse(); reversed = true; } // Controls are docked from bottom to top, this will correctly sort them
            if (songs.Count != 0) { contentPane.Controls.AddRange(items.ToArray()); }
            else
            {
                NoSongsMsg nsm = new NoSongsMsg();
                nsm.Dock = DockStyle.Fill;
                contentPane.Controls.Add(nsm);
            }
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
                    string artist = f.ID3Information.Artist;
                    string album = f.ID3Information.Album;
                    if (artist.Length <= 1) artist = getStr(this.translations.Text, 0);
                    if (album.Length <= 1) album = getStr(this.translations.Text, 1);
                    sli.setData(f.ID3Information.Title, artist + " / " + album, getSongLength(f.FileName));
                    sli.Dock = DockStyle.Top;
                    sli.parentList = contentPane;
                    sli.parent = this;
                    sli.Tag = f.FileName;
                    sli.OnMenuRequest += new EventHandler(OnMenuRequest);
                    sli.OnPlaySelected += new EventHandler(OnPlaySelected);
                    sli.index = i;
                    sli.ContextMenuStrip = songMenu;
                    i++;
                    items.Add(sli);
                    count++;
                    s.curTask.Text = getStr(s.taskLabels.Text, 1) + " (" + count + ")";
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
            try
            {
                contentPaneTitle.Text = songsLabel2.Text;
                songs = new List<AudioFile>();
                playlists = new List<string>();
                foreach (string q in Directory.GetFiles(AppFolder, "*.m3u")) { playlists.Add(q); }
                s.curTask.Text = getStr(s.taskLabels.Text, 0);
                s.Update();
                count = 0;
                retrieveSongs(s);
                songs.Sort();
                s.curTask.Text = getStr(s.taskLabels.Text, 1);
                s.Update();
                count = 0;
                loadSongsList(s);
                s.curTask.Text = getStr(s.taskLabels.Text, 2);
                loadSongsList();
            }
            catch
            {

            }
            s.Update();
            s.Close();
            
        }

        public string getStr(string str, int pos)
        {
            string[] l10n = str.Split('!');
            if (pos >= 0 && pos < l10n.Length) return l10n[pos]; else return "";
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
            string hash=BitConverter.ToString(System.Security.Cryptography.MD5.Create().ComputeHash(File.OpenRead(k))).Replace("-","").ToLower();;
            
            
                songs.Add(new AudioFile(k));
                count++;
                s.curTask.Text = getStr(s.taskLabels.Text, i) + " (" + count + ")";
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
                if (!sli.isStack) { Play(sli.Tag.ToString()); }
            else {
                try {
                    int pos = -1;
                    if ((sli.Tag is string && sli.Tag.ToString().Length > 0) || sli.Tag is int) { pos = Convert.ToInt32(sli.Tag); } else { pos = 0; }
                    if (pos >= 0 && pos < stack.Count)
                    {
                        sta_pos = pos;
                        playnow();
                    }
                } catch {

                }
            
            }
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
            SongsListItem sli = getSongsListItem((Control)sender);
            if (sli!=null && !sli.isStack) songMenu.Show(MousePosition);
            
        }


        public string getSongLength(string filename)
        {
            return "";
        }

        public void loadArtistsList() {
            if (songs.Count == 0)
            {
                NoSongsMsg nsm = new NoSongsMsg();
                nsm.Dock = DockStyle.Fill;
                contentPane.Controls.Add(nsm); return;
            }
            contentPane.Tag = "-1";
            List<ArtistItem> queriedartists = new List<ArtistItem>();
            int r = 0;
            foreach (AudioFile k in songs)
            {
                bool found = false;
                string artist = k.ID3Information.Artist;
                if (artist.Length < 1) artist = getStr(translations.Text, 0);
                for (int i = 0; i < queriedartists.Count && !found; i++)
                {
                    if (artist == queriedartists[i].getArtistName())
                    {
                        found = true;
                    }
                }

                if (!found)
                {
                    ArtistItem a = new ArtistItem();

                    a.OnMenuRequest += new EventHandler(artistHandler);
                    a.Dock = DockStyle.Top;
                    a.parentList = contentPane;
                    a.parent = this;
                    a.Tag = artist;
                    a.index = r;
                    a.setData(artist);
                    r++;
                    queriedartists.Add(a);
                }
            }
            queriedartists.Sort();
            queriedartists.Reverse();
            contentPane.Controls.AddRange(queriedartists.ToArray());

        }
        public void artistHandler(object sender, EventArgs e)
        {
            addArtist(getArtistItem((Control)sender).Tag.ToString());
        }
        public void addArtist(string artist)
        {
            foreach (AudioFile k in songs)
            {
                if (k.ID3Information.Artist == artist)
                {
                    Stack(k.FileName);
                }
            }
            if (gI() == null || !gI().playing())
            {
                playnow();
            }
        }
        public void loadAlbumsList()
        {
            if (songs.Count == 0)
            {
                NoSongsMsg nsm = new NoSongsMsg();
                nsm.Dock = DockStyle.Fill;
                contentPane.Controls.Add(nsm); return;
            }
            contentPane.Tag = "-1";
            List<AlbumItem> queriedalbums = new List<AlbumItem>();
            int r = 0;
            foreach (AudioFile k in songs)
            {
                bool found = false;
                string album = k.ID3Information.Album;
                if (album.Length < 1) album = getStr(translations.Text, 1);
                for (int i = 0; i < queriedalbums.Count && !found; i++)
                {
                    if (album == queriedalbums[i].getAlbumName())
                    {
                        found = true;
                    }
                }
                
                if (!found)
                {
                    AlbumItem a = new AlbumItem();
                    string artist = k.ID3Information.Artist;
                    if (artist.Length < 1) artist = getStr(translations.Text, 0);


                    a.Tag = album;
                    a.Dock = DockStyle.Top;
                    a.parentList = contentPane;
                    a.parent = this;
                    a.OnMenuRequest += new EventHandler(AlbumHandler);
                    a.OnPlayRequest += new EventHandler(AlbumPlayHandler);
                    a.index = r;
                    a.setData(album, artist, null);
                    r++;
                    queriedalbums.Add(a);
                }
            }
            queriedalbums.Sort();
            queriedalbums.Reverse();
            contentPane.Controls.AddRange(queriedalbums.ToArray());

        }
        public void AlbumPlayHandler(object sender,EventArgs e) {
            stack.Clear();
            sta_pos = 0;
            AlbumHandler(sender,e);
            playnow();
        }


        public void AlbumHandler(object sender, EventArgs e)
        {
            addAlbum(getAlbumItem((Control)sender).Tag.ToString());
        }
        public void addAlbum(string album)
        {
            foreach (AudioFile k in songs)
            {
                if (k.ID3Information.Album == album)
                {
                    Stack(k.FileName);
                }
            }
            if (gI() == null || !gI().playing())
            {
                playnow();
            }
        }
        public Bitmap findAlbumPicture(string f)
        {
            Bitmap b = null;
            int i=0;
            while (b == null && i < songs.Count)
            {
                if (songs[i].ID3Information.Album==f) b = new SongID3(songs[i].FileName).forceLoadImage();
                i++;
            }
            return b;
        }
        public void playlistplayhandler(object sender, EventArgs e)
        {
            stack.Clear();
            playlistslistplayrequest(sender, e);
            sta_pos = 0;
            playnow();
        }
        public void loadPlaylistsList()
        {
            if (Directory.GetFiles(AppFolder, "*.m3u").Length == 0)
            {
                NoListMsg nsm = new NoListMsg();
                nsm.Dock = DockStyle.Fill;
                contentPane.Controls.Add(nsm); return;
            }
            List<PlaylistItem> queriedLists = new List<PlaylistItem>();
            int r = 0;
            foreach (string k in Directory.GetFiles(AppFolder,"*.m3u")) {
                PlaylistItem a = new PlaylistItem();
                   
                    a.Dock = DockStyle.Top;
                    a.parentList = contentPane;
                    a.parent = this;
                    a.Tag = k;
                    a.index = r;
                    a.OnDeleteRequest += new EventHandler(playlistdeletehandler);
                    a.OnMenuRequest += new EventHandler(playlistslistplayrequest);
                    a.OnPlayRequest += new EventHandler(playlistplayhandler);
                    a.setData(libAP.basename(k));
                    r++;
                    queriedLists.Add(a);
            }
            queriedLists.Sort();
            contentPane.Controls.AddRange(queriedLists.ToArray());
        }
        public void playlistdeletehandler(object sender, EventArgs e)
        {
            if (MessageBox.Show(getStr(translations.Text, 2), "fPlayer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { File.Delete(getPlaylistItem((Control)sender).Tag.ToString()); contentPane.Controls.Clear();  loadPlaylistsList(); }
        }
        public ArtistItem getArtistItem(Control c)
        {
            if (c is ArtistItem) return (ArtistItem)c;
            else if (c == null) return null;
            else return getArtistItem(c.Parent);
        }

        public AlbumItem getAlbumItem(Control c)
        {
            if (c is AlbumItem) return (AlbumItem)c;
            else if (c == null) return null;
            else return getAlbumItem(c.Parent);
        }
        public PlaylistItem getPlaylistItem(Control c)
        {
            if (c is PlaylistItem) return (PlaylistItem)c;
            else if (c == null) return null;
            else return getPlaylistItem(c.Parent);
        }
        public void playlistslistplayrequest(object sender, EventArgs e)
        {
            try
            {
                foreach (string k in M3UReader.read(getPlaylistItem((Control)sender).Tag.ToString()))
                {
                    if (File.Exists(k)) Stack(k);
                }

                if (gI() != null || !gI().playing()) { sta_pos = 0; playnow(); }
            }
            catch
            {

            }
        }

        private void Player_Load(object sender, EventArgs e)
        {
            loadSystemData();
        }

       

        public void OnPlaybackFinishedHandler(object sender, EventArgs e)
        {
            next();
        }
        public void LoadInfo()
        {
            string artist = stack[sta_pos].ID3Information.Artist;
            string album = stack[sta_pos].ID3Information.Album;
            if (artist.Length <= 1) artist = getStr(this.translations.Text, 0);
            if (album.Length <= 1) album = getStr(this.translations.Text, 1);
            songname.Text = stack[sta_pos].ID3Information.Title;
            songinfo.Text = artist + " / " + album;
            Bitmap img = new SongID3(stack[sta_pos].FileName).forceLoadImage();
            if (img != null)
            {
                songalbum.Image = img;
            }
            else songalbum.Image = songalbum.ErrorImage;
            npo.updateInfo(img, stack[sta_pos].ID3Information.Title,artist,album);
        }
        public void UpdateInfo()
        {
            UpdateVol(gI().getVolume());
            trackpos.Text = formatMs(getPos());
            tracklength.Text = formatMs(getLength());
            npo.songPos.Text = formatMs(getPos()) + " / " + formatMs(getLength());
            UpdateBar();
        }

        public void UpdateVol(int vol) {
            if (volVal.Text != vol.ToString())
            {
                volVal.Text = vol.ToString();
                volFront.Height = vol;
                volFront.Top = 100 - vol;
                
                volFront.BringToFront();

            }
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
                    if (k.Length > 0) { val = Convert.ToInt32(k); }
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
                    if (k.Length>0) val = Convert.ToInt32(k);
                }
                catch
                {

                }
                if (val >= 0 && val < songs.Count) si.Add(val);

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
            if (tabFocused == 4) { contentPane.Controls.Clear(); loadNowPlaying(); }
        }

        /**
         * Starts playing stack.
         */
        public void playnow()
        {
            int volume = 100;
            if (gI() != null)
            {
                // fix for BTC106: push volume before destroying instance
                volume = gI().getVolume();
            }
            MediaPlayer.getInstance(stack[sta_pos]).OnPlaybackFinished += new EventHandler(OnPlaybackFinishedHandler);
            gI().setVolume(volume); // return volume
            gI().play();
            LoadInfo();
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
                if (shuffle)
                {
                    Random r = new Random(DateTime.Now.Millisecond + DateTime.Now.Second);
                    sta_pos = r.Next(stack.Count);
                }
                else if (!repeat)
                {
                    sta_pos--;
                }
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
            if (shuffle)
            {
                Random r = new Random(DateTime.Now.Millisecond + DateTime.Now.Second);
                sta_pos = r.Next(stack.Count);
            }
            else if (!repeat)
            {
                sta_pos++;
            }
            
            
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
            if (stack.Count.ToString() != stackCount.Text) stackCount.Text = stack.Count.ToString();
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
            this.contentPane.Tag = "-1";
            prev();
        }

        private void playPauseButton_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";
            playpause();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";
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
            if (drags && gI() != null && gI().playing() && isMouseOver(trackbarRegion))
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

        private void Player_ResizeEnd(object sender, EventArgs e)
        {
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

        private void mainSidebar_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void bottomPanel_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void songalbum_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void songname_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void songinfo_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void trackbarBack_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void trackpos_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void tracklength_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void trackbarBack_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";

        }

        private void volumeButton_Click(object sender, EventArgs e)
        {
            if (gI() != null)
            {
                
                volFront.Visible = !volFront.Visible;
                volBack.Visible = !volBack.Visible;
                volVal.Visible = !volVal.Visible;
                volFront.BringToFront();
                volVal.BringToFront();
                UpdateVol(gI().getVolume());
            }
            this.contentPane.Tag = "-1";
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            
            if (shuffle)
            {
                shuffleButton.BackColor = Color.Black;
                shuffle = false;
                this.contentPane.Tag = "-1";

            } else {
                if (repeat)
                {
                    repeat = false;
                    repeatButton.BackColor = Color.Black;
                }
                shuffleButton.BackColor = Color.Green;
            shuffle = true;
            this.contentPane.Tag = "-1";
            }
            
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (repeat)
            {
                repeatButton.BackColor = Color.Black;
                repeat = false;
                this.contentPane.Tag = "-1";
            }
            else
            {
                if (shuffle)
                {
                    shuffle = false;
                    shuffleButton.BackColor = Color.Black;
                }
                repeatButton.BackColor = Color.Green;
                repeat = true;
                this.contentPane.Tag = "-1";
            }
        }

        private void appTitle_Click(object sender, EventArgs e)
        {

            this.contentPane.Tag = "-1";
        }

        private void titlePanel_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";
        }

        private void appIcon_Click(object sender, EventArgs e)
        {
            this.contentPane.Tag = "-1";
        }

        private void trackbarRegion_MouseDown(object sender, MouseEventArgs e)
        {
            trackbarProgress_MouseDown(sender, e);
        }

        private void trackbarRegion_MouseUp(object sender, MouseEventArgs e)
        {
            trackbarProgress_MouseUp(sender, e);
        }

        private void trackbarRegion_MouseMove(object sender, MouseEventArgs e)
        {
            trackbarProgress_MouseMove(sender, e);
        }

        private void addToPlaylistToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            addToPlaylistToolStripMenuItem.DropDownItems.Clear();
            addToPlaylistToolStripMenuItem.DropDownItems.Add(newPlaylistToolStripMenuItem);
            addToPlaylistToolStripMenuItem.DropDownItems.Add(toolStripMenuItem2);
            foreach (string k in Directory.GetFiles(AppFolder, "*.m3u"))
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(libAP.basename(k));
                tsmi.Tag = k;
                tsmi.Click += new EventHandler(tsmiclicked);
                addToPlaylistToolStripMenuItem.DropDownItems.Add(tsmi);
            }
        }
        public void tsmiclicked(object sender, EventArgs e)
        {
            foreach (int k in getSelectedItems()) {
                M3UReader.append(((ToolStripMenuItem)sender).Tag.ToString(), songs[k].FileName);
            }
        }
        public string inp = "";
        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog ip = new InputDialog();
            ip.parent = this;
            if (ip.ShowDialog() == DialogResult.OK && inp!="")
            {
                foreach (int k in getSelectedItems())
                {
                    M3UReader.append(AppFolder + inp + ".m3u", songs[k].FileName);
                }
            }
        }
        public void search(string text)
        {
            tabFocused = -1;
            contentPaneTitle.Text = "\"" + text + "\"";
            contentPane.Controls.Clear();
            loadArray(getSearchResults(text));
        }

        public List<AudioFile> getSearchResults(string text)
        {
            List<AudioFile> l=new List<AudioFile>();
            foreach (AudioFile k in songs)
            {
                if (searchItem(k,text))
                {
                    l.Add(k);
                }
            }
            return l;
        }

        public bool searchItem(AudioFile k, string text)
        {
            string ttl=text.ToLower();
            string tittl = k.ID3Information.Title.ToLower();
            string arttl = k.ID3Information.Artist.ToLower();
            string albtl = k.ID3Information.Album.ToLower();
            return tittl.Contains(text) || arttl.Contains(text) || albtl.Contains(text);
        }

        public void loadArray(List<AudioFile> songs)
        {
            List<Control> items = new List<Control>();
            contentPane.Tag = "-1";
            int i = 0;
            reversed = false;
            count = 0;
            foreach (AudioFile f in songs)
            {

                SongsListItem sli = new SongsListItem();
                string artist = f.ID3Information.Artist;
                string album = f.ID3Information.Album;
                if (artist.Length <= 1) artist = getStr(this.translations.Text, 0);
                if (album.Length <= 1) album = getStr(this.translations.Text, 1);
                sli.setData(f.ID3Information.Title, artist + " / " + album, getSongLength(f.FileName));
                sli.Dock = DockStyle.Top;
                sli.parentList = contentPane;
                sli.parent = this;
                sli.Tag = f.FileName;
                sli.OnMenuRequest += new EventHandler(OnMenuRequest);
                sli.OnPlaySelected += new EventHandler(OnPlaySelected);
                sli.index = i;
                sli.ContextMenuStrip = songMenu;
                i++;
                items.Add(sli);
                count++;
                s.curTask.Text = getStr(s.taskLabels.Text, 1) + " (" + count + ")";
                s.Update();
            }
            items.Reverse();
            reversed = true;
            contentPane.Controls.AddRange(items.ToArray());
        }
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13) search(searchBox.Text);
        }

        private void playToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool found = false;
            while (!found && i < stack.Count)
            {
                if (stack[i].FileName == ((ToolStripMenuItem)sender).GetCurrentParent().Tag.ToString()) { found = true; Play(stack[i].FileName); }
                i++;
            }
        }

        private void removeFromQueueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool found = false;
            while (!found && i < stack.Count)
            {
                if (stack[i].FileName == ((ToolStripMenuItem)sender).GetCurrentParent().Tag.ToString()) { found = true; stack.RemoveAt(i); contentPane.Controls.Clear(); loadNowPlaying(); }
                i++;
            }
        }

        private void nowplayingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Player_FormClosing(object sender, FormClosingEventArgs e)
        {
        }



        public int safeconvertint32(Object data)
        {
            int n = 0;
            if (data is string && ((String)data).Length == 0) return -1;
            try
            {
                n = Convert.ToInt32(data);
                return n;
            }
            catch
            {
                return -1;
            }
        }

        public void scrollTo(int pos)
        {
            mainPane.AutoScrollPosition = new Point(0,pos*48) ;
            Update();
        }


        public void move(int pos)
        {
            if (tabFocused <= 4)
            {
                contentPane.Tag = pos;
            }
            scrollTo(pos);
        }
        

        public void scroll(int offset)
        {
            int curPos=safeconvertint32(contentPane.Tag.ToString());
            int listlen = contentPane.Controls.Count;
            if (tabFocused == 4) { listlen--; } // as Now Playing has the overlay too.
            int newpos = curPos + offset;
            if (newpos < 0)
            {
                newpos = listlen - Math.Abs(newpos);
            }
            if (newpos >= listlen)
            {
                newpos = newpos - listlen;
            }
            move(newpos);
        }


        public void pgUp()
        {
            int itemsInView = (mainPane.Height / new SongsListItem().Height)-1;
            scroll(-itemsInView);
        }

        public void pgDown()
        {
            int itemsInView = (mainPane.Height / new SongsListItem().Height) - 1;
            scroll(itemsInView);
        }

        public int getFirstIndex(string tag)
        {
            int ind=-1;
            int i = 0;
            string[] arr=tag.Split(',');
            while (ind==-1 && i<arr.Length) {
                ind = safeconvertint32(arr[i]);
                i++;
            }
            return ind;
        }

        public void scrollToAlpha(char k)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    scroll(-1);
                    break;
                case Keys.Down:
                    scroll(1);
                    break;
                case Keys.PageUp:
                    pgUp();
                    break;
                case Keys.PageDown:
                    pgDown();
                    break;
                case Keys.Enter:
                    try
                    {
                        switch (tabFocused)
                        {
                            case 0:
                            case 4:
                                OnPlaySelected(contentPane.Controls[contentPane.Controls.Count - 1 - getSelectedItem()], new EventArgs());
                                break;
                            case 1:
                                artistHandler(contentPane.Controls[contentPane.Controls.Count - 1 - getSelectedItem()], new EventArgs());
                                break;
                            case 2:
                                AlbumPlayHandler(contentPane.Controls[contentPane.Controls.Count - 1 - getSelectedItem()], new EventArgs());
                                break;
                            case 3:
                                playlistslistplayrequest(contentPane.Controls[contentPane.Controls.Count - 1 - getSelectedItem()], new EventArgs());
                                break;


                        }
                    }
                    catch { }
                    break;
                default:
                    if (Char.IsLetterOrDigit((char)keyData))
                    {
                        scrollToAlpha((char)keyData);
                    }
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public bool drags2 = false;
        private void volBack_MouseDown(object sender, MouseEventArgs e)
        {
            drags2 = true;
        }

        private void volBack_MouseMove(object sender, MouseEventArgs e)
        {
            if (drags2 && gI() != null && gI().playing() && isMouseOver(volBack))
            {
                int mouseYOnElement = this.volBack.PointToScreen(new Point(0, 0)).Y;
                mouseYOnElement = MousePosition.Y - mouseYOnElement;
                int newVol = 100-mouseYOnElement;
                gI().setVolume(newVol);
            }
        }

        private void volBack_MouseUp(object sender, MouseEventArgs e)
        {
            volBack_MouseMove(sender, e);
            drags2 = false;
        }

        private void volFront_MouseDown(object sender, MouseEventArgs e)
        {
            volBack_MouseDown(sender, e);
        }

        private void volFront_MouseMove(object sender, MouseEventArgs e)
        {
            volBack_MouseMove(sender, e);
        }

        private void volFront_MouseUp(object sender, MouseEventArgs e)
        {
            volBack_MouseUp(sender, e);
        }

        public void voldefocus()
        {
            if (volFront.Visible) volumeButton_Click(this,new EventArgs());
        }

        private void label21_Click(object sender, EventArgs e)
        {
            pluginPanel_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pluginPanel_Click(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void loadExtensionList()
        {
            contentPaneTitle.Text = pluginLabel.Text;
            contentPane.Controls.Clear();
            int i = 0;
            foreach (string k in _Plugins.Keys)
            {
                PluginItem pi = new PluginItem();
                pi.Dock = DockStyle.Top;
                pi.setData(_Plugins[k].Name);
                pi.Dock = DockStyle.Top;
                pi.parentList = contentPane;
                pi.parent = this;
                pi.Tag = k;
                pi.OnPlayRequest += pi_OnPlayRequest;
                pi.index = i;
                i++;
                contentPane.Controls.Add(pi);
            }
        }

        void pi_OnPlayRequest(object sender, EventArgs e)
        {
            contentPane.Controls.Clear();
            contentPaneTitle.Text = _Plugins[((PluginItem)sender).Tag.ToString()].Name;
            contentPane.Controls.Add(_Plugins[((PluginItem)sender).Tag.ToString()].getGUI(this));
        }
        
        private void pluginPanel_Click(object sender, EventArgs e)
        {
            tabFocused = 7;
            loadExtensionList();
        }

	}
}
