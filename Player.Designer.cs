/*
 * Creado por SharpDevelop.
 * Usuario: Marc
 * Fecha: 07/07/2014
 * Hora: 18:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace fPlayer_2
{
	partial class Player
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.repeatButton = new System.Windows.Forms.PictureBox();
            this.shuffleButton = new System.Windows.Forms.PictureBox();
            this.volumeButton = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.PictureBox();
            this.playPauseButton = new System.Windows.Forms.PictureBox();
            this.previousButton = new System.Windows.Forms.PictureBox();
            this.tracklength = new System.Windows.Forms.Label();
            this.trackpos = new System.Windows.Forms.Label();
            this.trackbarProgress = new System.Windows.Forms.Panel();
            this.trackbarBack = new System.Windows.Forms.Panel();
            this.songinfo = new System.Windows.Forms.Label();
            this.songname = new System.Windows.Forms.Label();
            this.songalbum = new System.Windows.Forms.PictureBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.windowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBox = new System.Windows.Forms.Label();
            this.maximizeBox = new System.Windows.Forms.Label();
            this.minimizeBox = new System.Windows.Forms.Label();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.appTitle = new System.Windows.Forms.Label();
            this.mainSidebar = new System.Windows.Forms.Panel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.libraryIcon = new System.Windows.Forms.PictureBox();
            this.libraryLabel = new System.Windows.Forms.Label();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutIcon = new System.Windows.Forms.PictureBox();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.nowplayingPanel = new System.Windows.Forms.Panel();
            this.nowplayingIcon = new System.Windows.Forms.PictureBox();
            this.nowplayingLabel = new System.Windows.Forms.Label();
            this.playlistsPanel = new System.Windows.Forms.Panel();
            this.playlistsIcon = new System.Windows.Forms.PictureBox();
            this.playlistsLabel = new System.Windows.Forms.Label();
            this.albumsPanel = new System.Windows.Forms.Panel();
            this.albumsIcon = new System.Windows.Forms.PictureBox();
            this.albumsLabel = new System.Windows.Forms.Label();
            this.artistsPanel = new System.Windows.Forms.Panel();
            this.artistsIcon = new System.Windows.Forms.PictureBox();
            this.artistsLabel = new System.Windows.Forms.Label();
            this.songsPanel = new System.Windows.Forms.Panel();
            this.songsIcon = new System.Windows.Forms.PictureBox();
            this.songsLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mainPane = new System.Windows.Forms.Panel();
            this.contentPane = new System.Windows.Forms.Panel();
            this.contentPaneTitle = new System.Windows.Forms.Label();
            this.focusMisser = new System.Windows.Forms.Button();
            this.focusController = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songalbum)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.windowContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.mainSidebar.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libraryIcon)).BeginInit();
            this.aboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutIcon)).BeginInit();
            this.nowplayingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nowplayingIcon)).BeginInit();
            this.playlistsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playlistsIcon)).BeginInit();
            this.albumsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsIcon)).BeginInit();
            this.artistsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsIcon)).BeginInit();
            this.songsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.songsIcon)).BeginInit();
            this.mainPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Black;
            this.bottomPanel.Controls.Add(this.repeatButton);
            this.bottomPanel.Controls.Add(this.shuffleButton);
            this.bottomPanel.Controls.Add(this.volumeButton);
            this.bottomPanel.Controls.Add(this.nextButton);
            this.bottomPanel.Controls.Add(this.playPauseButton);
            this.bottomPanel.Controls.Add(this.previousButton);
            this.bottomPanel.Controls.Add(this.tracklength);
            this.bottomPanel.Controls.Add(this.trackpos);
            this.bottomPanel.Controls.Add(this.trackbarProgress);
            this.bottomPanel.Controls.Add(this.trackbarBack);
            this.bottomPanel.Controls.Add(this.songinfo);
            this.bottomPanel.Controls.Add(this.songname);
            this.bottomPanel.Controls.Add(this.songalbum);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            // 
            // repeatButton
            // 
            resources.ApplyResources(this.repeatButton, "repeatButton");
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.TabStop = false;
            this.repeatButton.Tag = "B";
            // 
            // shuffleButton
            // 
            resources.ApplyResources(this.shuffleButton, "shuffleButton");
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.TabStop = false;
            this.shuffleButton.Tag = "B";
            // 
            // volumeButton
            // 
            resources.ApplyResources(this.volumeButton, "volumeButton");
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.TabStop = false;
            this.volumeButton.Tag = "B";
            // 
            // nextButton
            // 
            resources.ApplyResources(this.nextButton, "nextButton");
            this.nextButton.Name = "nextButton";
            this.nextButton.TabStop = false;
            this.nextButton.Tag = "B";
            // 
            // playPauseButton
            // 
            resources.ApplyResources(this.playPauseButton, "playPauseButton");
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.TabStop = false;
            this.playPauseButton.Tag = "B";
            // 
            // previousButton
            // 
            resources.ApplyResources(this.previousButton, "previousButton");
            this.previousButton.Name = "previousButton";
            this.previousButton.TabStop = false;
            this.previousButton.Tag = "B";
            // 
            // tracklength
            // 
            resources.ApplyResources(this.tracklength, "tracklength");
            this.tracklength.ForeColor = System.Drawing.Color.White;
            this.tracklength.Name = "tracklength";
            // 
            // trackpos
            // 
            resources.ApplyResources(this.trackpos, "trackpos");
            this.trackpos.ForeColor = System.Drawing.Color.White;
            this.trackpos.Name = "trackpos";
            // 
            // trackbarProgress
            // 
            this.trackbarProgress.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.trackbarProgress, "trackbarProgress");
            this.trackbarProgress.Name = "trackbarProgress";
            // 
            // trackbarBack
            // 
            resources.ApplyResources(this.trackbarBack, "trackbarBack");
            this.trackbarBack.BackColor = System.Drawing.Color.White;
            this.trackbarBack.Name = "trackbarBack";
            // 
            // songinfo
            // 
            resources.ApplyResources(this.songinfo, "songinfo");
            this.songinfo.ForeColor = System.Drawing.Color.White;
            this.songinfo.Name = "songinfo";
            // 
            // songname
            // 
            resources.ApplyResources(this.songname, "songname");
            this.songname.ForeColor = System.Drawing.Color.White;
            this.songname.Name = "songname";
            // 
            // songalbum
            // 
            resources.ApplyResources(this.songalbum, "songalbum");
            this.songalbum.Name = "songalbum";
            this.songalbum.TabStop = false;
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titlePanel.ContextMenuStrip = this.windowContextMenu;
            this.titlePanel.Controls.Add(this.closeBox);
            this.titlePanel.Controls.Add(this.maximizeBox);
            this.titlePanel.Controls.Add(this.minimizeBox);
            this.titlePanel.Controls.Add(this.appIcon);
            this.titlePanel.Controls.Add(this.appTitle);
            resources.ApplyResources(this.titlePanel, "titlePanel");
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlePanelMouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitlePanelMouseMove);
            this.titlePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitlePanelMouseUp);
            // 
            // windowContextMenu
            // 
            this.windowContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.maximizeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.windowContextMenu.Name = "windowContextMenu";
            resources.ApplyResources(this.windowContextMenu, "windowContextMenu");
            this.windowContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.WindowContextMenuOpening);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            resources.ApplyResources(this.restoreToolStripMenuItem, "restoreToolStripMenuItem");
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.RestoreToolStripMenuItemClick);
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            resources.ApplyResources(this.minimizeToolStripMenuItem, "minimizeToolStripMenuItem");
            this.minimizeToolStripMenuItem.Click += new System.EventHandler(this.MinimizeToolStripMenuItemClick);
            // 
            // maximizeToolStripMenuItem
            // 
            this.maximizeToolStripMenuItem.Name = "maximizeToolStripMenuItem";
            resources.ApplyResources(this.maximizeToolStripMenuItem, "maximizeToolStripMenuItem");
            this.maximizeToolStripMenuItem.Click += new System.EventHandler(this.MaximizeToolStripMenuItemClick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // closeBox
            // 
            resources.ApplyResources(this.closeBox, "closeBox");
            this.closeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBox.ForeColor = System.Drawing.Color.White;
            this.closeBox.Name = "closeBox";
            this.closeBox.Click += new System.EventHandler(this.CloseBoxClick);
            this.closeBox.MouseEnter += new System.EventHandler(this.CloseBoxMouseEnter);
            this.closeBox.MouseLeave += new System.EventHandler(this.CloseBoxMouseLeave);
            // 
            // maximizeBox
            // 
            resources.ApplyResources(this.maximizeBox, "maximizeBox");
            this.maximizeBox.BackColor = System.Drawing.Color.Olive;
            this.maximizeBox.ForeColor = System.Drawing.Color.White;
            this.maximizeBox.Name = "maximizeBox";
            this.maximizeBox.Click += new System.EventHandler(this.MaximizeBoxClick);
            this.maximizeBox.MouseEnter += new System.EventHandler(this.MaximizeBoxMouseEnter);
            this.maximizeBox.MouseLeave += new System.EventHandler(this.MaximizeBoxMouseLeave);
            // 
            // minimizeBox
            // 
            resources.ApplyResources(this.minimizeBox, "minimizeBox");
            this.minimizeBox.BackColor = System.Drawing.Color.Olive;
            this.minimizeBox.ForeColor = System.Drawing.Color.White;
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Click += new System.EventHandler(this.MinimizeBoxClick);
            this.minimizeBox.MouseEnter += new System.EventHandler(this.MinimizeBoxMouseEnter);
            this.minimizeBox.MouseLeave += new System.EventHandler(this.MinimizeBoxMouseLeave);
            // 
            // appIcon
            // 
            this.appIcon.ContextMenuStrip = this.windowContextMenu;
            resources.ApplyResources(this.appIcon, "appIcon");
            this.appIcon.Name = "appIcon";
            this.appIcon.TabStop = false;
            this.appIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppIconMouseDown);
            this.appIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppIconMouseMove);
            this.appIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppIconMouseUp);
            // 
            // appTitle
            // 
            resources.ApplyResources(this.appTitle, "appTitle");
            this.appTitle.ContextMenuStrip = this.windowContextMenu;
            this.appTitle.ForeColor = System.Drawing.Color.White;
            this.appTitle.Name = "appTitle";
            this.appTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppTitleMouseDown);
            this.appTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppTitleMouseMove);
            this.appTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppTitleMouseUp);
            // 
            // mainSidebar
            // 
            this.mainSidebar.BackColor = System.Drawing.Color.Teal;
            this.mainSidebar.Controls.Add(this.libraryPanel);
            this.mainSidebar.Controls.Add(this.aboutPanel);
            this.mainSidebar.Controls.Add(this.nowplayingPanel);
            this.mainSidebar.Controls.Add(this.playlistsPanel);
            this.mainSidebar.Controls.Add(this.albumsPanel);
            this.mainSidebar.Controls.Add(this.artistsPanel);
            this.mainSidebar.Controls.Add(this.songsPanel);
            this.mainSidebar.Controls.Add(this.searchBox);
            resources.ApplyResources(this.mainSidebar, "mainSidebar");
            this.mainSidebar.Name = "mainSidebar";
            // 
            // libraryPanel
            // 
            resources.ApplyResources(this.libraryPanel, "libraryPanel");
            this.libraryPanel.Controls.Add(this.libraryIcon);
            this.libraryPanel.Controls.Add(this.libraryLabel);
            this.libraryPanel.Name = "libraryPanel";
            // 
            // libraryIcon
            // 
            resources.ApplyResources(this.libraryIcon, "libraryIcon");
            this.libraryIcon.Name = "libraryIcon";
            this.libraryIcon.TabStop = false;
            // 
            // libraryLabel
            // 
            resources.ApplyResources(this.libraryLabel, "libraryLabel");
            this.libraryLabel.ForeColor = System.Drawing.Color.White;
            this.libraryLabel.Name = "libraryLabel";
            // 
            // aboutPanel
            // 
            resources.ApplyResources(this.aboutPanel, "aboutPanel");
            this.aboutPanel.Controls.Add(this.aboutIcon);
            this.aboutPanel.Controls.Add(this.aboutLabel);
            this.aboutPanel.Name = "aboutPanel";
            // 
            // aboutIcon
            // 
            resources.ApplyResources(this.aboutIcon, "aboutIcon");
            this.aboutIcon.Name = "aboutIcon";
            this.aboutIcon.TabStop = false;
            // 
            // aboutLabel
            // 
            resources.ApplyResources(this.aboutLabel, "aboutLabel");
            this.aboutLabel.ForeColor = System.Drawing.Color.White;
            this.aboutLabel.Name = "aboutLabel";
            // 
            // nowplayingPanel
            // 
            resources.ApplyResources(this.nowplayingPanel, "nowplayingPanel");
            this.nowplayingPanel.Controls.Add(this.nowplayingIcon);
            this.nowplayingPanel.Controls.Add(this.nowplayingLabel);
            this.nowplayingPanel.Name = "nowplayingPanel";
            // 
            // nowplayingIcon
            // 
            resources.ApplyResources(this.nowplayingIcon, "nowplayingIcon");
            this.nowplayingIcon.Name = "nowplayingIcon";
            this.nowplayingIcon.TabStop = false;
            // 
            // nowplayingLabel
            // 
            resources.ApplyResources(this.nowplayingLabel, "nowplayingLabel");
            this.nowplayingLabel.ForeColor = System.Drawing.Color.White;
            this.nowplayingLabel.Name = "nowplayingLabel";
            // 
            // playlistsPanel
            // 
            resources.ApplyResources(this.playlistsPanel, "playlistsPanel");
            this.playlistsPanel.Controls.Add(this.playlistsIcon);
            this.playlistsPanel.Controls.Add(this.playlistsLabel);
            this.playlistsPanel.Name = "playlistsPanel";
            // 
            // playlistsIcon
            // 
            resources.ApplyResources(this.playlistsIcon, "playlistsIcon");
            this.playlistsIcon.Name = "playlistsIcon";
            this.playlistsIcon.TabStop = false;
            // 
            // playlistsLabel
            // 
            resources.ApplyResources(this.playlistsLabel, "playlistsLabel");
            this.playlistsLabel.ForeColor = System.Drawing.Color.White;
            this.playlistsLabel.Name = "playlistsLabel";
            // 
            // albumsPanel
            // 
            resources.ApplyResources(this.albumsPanel, "albumsPanel");
            this.albumsPanel.Controls.Add(this.albumsIcon);
            this.albumsPanel.Controls.Add(this.albumsLabel);
            this.albumsPanel.Name = "albumsPanel";
            // 
            // albumsIcon
            // 
            resources.ApplyResources(this.albumsIcon, "albumsIcon");
            this.albumsIcon.Name = "albumsIcon";
            this.albumsIcon.TabStop = false;
            // 
            // albumsLabel
            // 
            resources.ApplyResources(this.albumsLabel, "albumsLabel");
            this.albumsLabel.ForeColor = System.Drawing.Color.White;
            this.albumsLabel.Name = "albumsLabel";
            // 
            // artistsPanel
            // 
            resources.ApplyResources(this.artistsPanel, "artistsPanel");
            this.artistsPanel.Controls.Add(this.artistsIcon);
            this.artistsPanel.Controls.Add(this.artistsLabel);
            this.artistsPanel.Name = "artistsPanel";
            // 
            // artistsIcon
            // 
            resources.ApplyResources(this.artistsIcon, "artistsIcon");
            this.artistsIcon.Name = "artistsIcon";
            this.artistsIcon.TabStop = false;
            // 
            // artistsLabel
            // 
            resources.ApplyResources(this.artistsLabel, "artistsLabel");
            this.artistsLabel.ForeColor = System.Drawing.Color.White;
            this.artistsLabel.Name = "artistsLabel";
            // 
            // songsPanel
            // 
            resources.ApplyResources(this.songsPanel, "songsPanel");
            this.songsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.songsPanel.Controls.Add(this.songsIcon);
            this.songsPanel.Controls.Add(this.songsLabel);
            this.songsPanel.Name = "songsPanel";
            // 
            // songsIcon
            // 
            resources.ApplyResources(this.songsIcon, "songsIcon");
            this.songsIcon.Name = "songsIcon";
            this.songsIcon.TabStop = false;
            // 
            // songsLabel
            // 
            resources.ApplyResources(this.songsLabel, "songsLabel");
            this.songsLabel.ForeColor = System.Drawing.Color.White;
            this.songsLabel.Name = "songsLabel";
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Name = "searchBox";
            this.searchBox.TabStop = false;
            this.searchBox.Click += new System.EventHandler(this.SearchBoxClick);
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxEnter);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxLeave);
            this.searchBox.Validating += new System.ComponentModel.CancelEventHandler(this.SearchBoxValidating);
            // 
            // mainPane
            // 
            resources.ApplyResources(this.mainPane, "mainPane");
            this.mainPane.Controls.Add(this.contentPane);
            this.mainPane.Controls.Add(this.contentPaneTitle);
            this.mainPane.Name = "mainPane";
            this.mainPane.Tag = "0";
            // 
            // contentPane
            // 
            resources.ApplyResources(this.contentPane, "contentPane");
            this.contentPane.Name = "contentPane";
            // 
            // contentPaneTitle
            // 
            resources.ApplyResources(this.contentPaneTitle, "contentPaneTitle");
            this.contentPaneTitle.ForeColor = System.Drawing.Color.Black;
            this.contentPaneTitle.Name = "contentPaneTitle";
            // 
            // focusMisser
            // 
            resources.ApplyResources(this.focusMisser, "focusMisser");
            this.focusMisser.Name = "focusMisser";
            this.focusMisser.UseVisualStyleBackColor = true;
            // 
            // focusController
            // 
            this.focusController.Enabled = true;
            this.focusController.Interval = 10;
            this.focusController.Tick += new System.EventHandler(this.focusController_Tick);
            // 
            // Player
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.focusMisser);
            this.Controls.Add(this.mainPane);
            this.Controls.Add(this.mainSidebar);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.bottomPanel);
            this.Name = "Player";
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repeatButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shuffleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPauseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songalbum)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.windowContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.mainSidebar.ResumeLayout(false);
            this.mainSidebar.PerformLayout();
            this.libraryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.libraryIcon)).EndInit();
            this.aboutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aboutIcon)).EndInit();
            this.nowplayingPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nowplayingIcon)).EndInit();
            this.playlistsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playlistsIcon)).EndInit();
            this.albumsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumsIcon)).EndInit();
            this.artistsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.artistsIcon)).EndInit();
            this.songsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.songsIcon)).EndInit();
            this.mainPane.ResumeLayout(false);
            this.mainPane.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button focusMisser;
	    private System.Windows.Forms.ContextMenuStrip windowContextMenu;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem maximizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.Panel libraryPanel;
		private System.Windows.Forms.PictureBox libraryIcon;
		private System.Windows.Forms.Label libraryLabel;
        private System.Windows.Forms.Panel mainPane;
		private System.Windows.Forms.Label contentPaneTitle;
		
		
		private System.Windows.Forms.Label closeBox;
		private System.Windows.Forms.Label maximizeBox;
		private System.Windows.Forms.Label minimizeBox;
		private System.Windows.Forms.PictureBox repeatButton;
		private System.Windows.Forms.PictureBox shuffleButton;
		private System.Windows.Forms.PictureBox volumeButton;
		private System.Windows.Forms.PictureBox nextButton;
		private System.Windows.Forms.PictureBox playPauseButton;
		private System.Windows.Forms.PictureBox previousButton;
		private System.Windows.Forms.Label tracklength;
		private System.Windows.Forms.Label trackpos;
		private System.Windows.Forms.Panel trackbarProgress;
		private System.Windows.Forms.Panel trackbarBack;
		private System.Windows.Forms.Label songinfo;
		private System.Windows.Forms.Label songname;
		private System.Windows.Forms.PictureBox songalbum;
		private System.Windows.Forms.Panel aboutPanel;
		private System.Windows.Forms.PictureBox aboutIcon;
		private System.Windows.Forms.Label aboutLabel;
		private System.Windows.Forms.Panel nowplayingPanel;
		private System.Windows.Forms.PictureBox nowplayingIcon;
		private System.Windows.Forms.Label nowplayingLabel;
		private System.Windows.Forms.Panel playlistsPanel;
		private System.Windows.Forms.PictureBox playlistsIcon;
		private System.Windows.Forms.Label playlistsLabel;
		private System.Windows.Forms.Panel albumsPanel;
		private System.Windows.Forms.PictureBox albumsIcon;
		private System.Windows.Forms.Label albumsLabel;
		private System.Windows.Forms.Panel artistsPanel;
		private System.Windows.Forms.PictureBox artistsIcon;
		private System.Windows.Forms.Label artistsLabel;
		private System.Windows.Forms.Panel songsPanel;
		private System.Windows.Forms.PictureBox songsIcon;
		private System.Windows.Forms.Label songsLabel;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Panel bottomPanel;
		private System.Windows.Forms.Panel mainSidebar;
		private System.Windows.Forms.Label appTitle;
		private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Timer focusController;
        private System.Windows.Forms.Panel contentPane;
	}
}
