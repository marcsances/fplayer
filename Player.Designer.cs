﻿/*
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
            this.trackbarProgress = new System.Windows.Forms.Panel();
            this.trackbarBack = new System.Windows.Forms.Panel();
            this.songalbum = new System.Windows.Forms.PictureBox();
            this.trackbarRegion = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.windowContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.mainSidebar = new System.Windows.Forms.Panel();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.libraryIcon = new System.Windows.Forms.PictureBox();
            this.aboutPanel = new System.Windows.Forms.Panel();
            this.aboutIcon = new System.Windows.Forms.PictureBox();
            this.nowplayingPanel = new System.Windows.Forms.Panel();
            this.stackCount = new System.Windows.Forms.Label();
            this.nowplayingIcon = new System.Windows.Forms.PictureBox();
            this.playlistsPanel = new System.Windows.Forms.Panel();
            this.playlistsIcon = new System.Windows.Forms.PictureBox();
            this.albumsPanel = new System.Windows.Forms.Panel();
            this.albumsIcon = new System.Windows.Forms.PictureBox();
            this.artistsPanel = new System.Windows.Forms.Panel();
            this.artistsIcon = new System.Windows.Forms.PictureBox();
            this.songsPanel = new System.Windows.Forms.Panel();
            this.songsIcon = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.mainPane = new System.Windows.Forms.Panel();
            this.contentPane = new System.Windows.Forms.Panel();
            this.focusMisser = new System.Windows.Forms.Button();
            this.focusController = new System.Windows.Forms.Timer(this.components);
            this.songMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.playbackTimer = new System.Windows.Forms.Timer(this.components);
            this.quicklistmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromQueueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volBack = new System.Windows.Forms.Panel();
            this.volFront = new System.Windows.Forms.Panel();
            this.translations = new Label2();
            this.contentPaneTitle = new Label2();
            this.libraryLabel2 = new Label2();
            this.aboutLabel2 = new Label2();
            this.nowplayingLabel2 = new Label2();
            this.playlistsLabel2 = new Label2();
            this.albumsLabel2 = new Label2();
            this.artistsLabel2 = new Label2();
            this.songsLabel2 = new Label2();
            this.closeBox = new Label2();
            this.maximizeBox = new Label2();
            this.minimizeBox = new Label2();
            this.appTitle = new Label2();
            this.tracklength = new Label2();
            this.trackpos = new Label2();
            this.songinfo = new Label2();
            this.songname = new Label2();
            this.volVal = new System.Windows.Forms.Label();
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
            this.songMenu.SuspendLayout();
            this.quicklistmenu.SuspendLayout();
            this.volBack.SuspendLayout();
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
            this.bottomPanel.Controls.Add(this.trackbarRegion);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Click += new System.EventHandler(this.bottomPanel_Click);
            // 
            // repeatButton
            // 
            resources.ApplyResources(this.repeatButton, "repeatButton");
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.TabStop = false;
            this.repeatButton.Tag = "B";
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // shuffleButton
            // 
            resources.ApplyResources(this.shuffleButton, "shuffleButton");
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.TabStop = false;
            this.shuffleButton.Tag = "B";
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // volumeButton
            // 
            resources.ApplyResources(this.volumeButton, "volumeButton");
            this.volumeButton.Name = "volumeButton";
            this.volumeButton.TabStop = false;
            this.volumeButton.Tag = "B";
            this.volumeButton.Click += new System.EventHandler(this.volumeButton_Click);
            // 
            // nextButton
            // 
            resources.ApplyResources(this.nextButton, "nextButton");
            this.nextButton.Name = "nextButton";
            this.nextButton.TabStop = false;
            this.nextButton.Tag = "B";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // playPauseButton
            // 
            resources.ApplyResources(this.playPauseButton, "playPauseButton");
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.TabStop = false;
            this.playPauseButton.Tag = "B";
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // previousButton
            // 
            resources.ApplyResources(this.previousButton, "previousButton");
            this.previousButton.Name = "previousButton";
            this.previousButton.TabStop = false;
            this.previousButton.Tag = "B";
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // trackbarProgress
            // 
            this.trackbarProgress.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.trackbarProgress, "trackbarProgress");
            this.trackbarProgress.Name = "trackbarProgress";
            this.trackbarProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackbarProgress_MouseDown);
            this.trackbarProgress.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackbarProgress_MouseMove);
            this.trackbarProgress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackbarProgress_MouseUp);
            // 
            // trackbarBack
            // 
            resources.ApplyResources(this.trackbarBack, "trackbarBack");
            this.trackbarBack.BackColor = System.Drawing.Color.White;
            this.trackbarBack.Name = "trackbarBack";
            this.trackbarBack.Click += new System.EventHandler(this.trackbarBack_Click);
            this.trackbarBack.Paint += new System.Windows.Forms.PaintEventHandler(this.trackbarBack_Paint);
            this.trackbarBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackbarBack_MouseDown);
            this.trackbarBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackbarBack_MouseMove);
            this.trackbarBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackbarBack_MouseUp);
            // 
            // songalbum
            // 
            resources.ApplyResources(this.songalbum, "songalbum");
            this.songalbum.Name = "songalbum";
            this.songalbum.TabStop = false;
            this.songalbum.Click += new System.EventHandler(this.songalbum_Click);
            // 
            // trackbarRegion
            // 
            resources.ApplyResources(this.trackbarRegion, "trackbarRegion");
            this.trackbarRegion.Name = "trackbarRegion";
            this.trackbarRegion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackbarRegion_MouseDown);
            this.trackbarRegion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackbarRegion_MouseMove);
            this.trackbarRegion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackbarRegion_MouseUp);
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
            this.titlePanel.Click += new System.EventHandler(this.titlePanel_Click);
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
            // appIcon
            // 
            this.appIcon.ContextMenuStrip = this.windowContextMenu;
            this.appIcon.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.appIcon, "appIcon");
            this.appIcon.Name = "appIcon";
            this.appIcon.TabStop = false;
            this.appIcon.Click += new System.EventHandler(this.appIcon_Click);
            this.appIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppIconMouseDown);
            this.appIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppIconMouseMove);
            this.appIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppIconMouseUp);
            // 
            // mainSidebar
            // 
            resources.ApplyResources(this.mainSidebar, "mainSidebar");
            this.mainSidebar.BackColor = System.Drawing.Color.Teal;
            this.mainSidebar.Controls.Add(this.libraryPanel);
            this.mainSidebar.Controls.Add(this.aboutPanel);
            this.mainSidebar.Controls.Add(this.nowplayingPanel);
            this.mainSidebar.Controls.Add(this.playlistsPanel);
            this.mainSidebar.Controls.Add(this.albumsPanel);
            this.mainSidebar.Controls.Add(this.artistsPanel);
            this.mainSidebar.Controls.Add(this.songsPanel);
            this.mainSidebar.Controls.Add(this.searchBox);
            this.mainSidebar.Name = "mainSidebar";
            this.mainSidebar.Click += new System.EventHandler(this.mainSidebar_Click);
            // 
            // libraryPanel
            // 
            resources.ApplyResources(this.libraryPanel, "libraryPanel");
            this.libraryPanel.Controls.Add(this.libraryIcon);
            this.libraryPanel.Controls.Add(this.libraryLabel2);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Click += new System.EventHandler(this.libraryPanel_Click);
            // 
            // libraryIcon
            // 
            resources.ApplyResources(this.libraryIcon, "libraryIcon");
            this.libraryIcon.Name = "libraryIcon";
            this.libraryIcon.TabStop = false;
            this.libraryIcon.Click += new System.EventHandler(this.libraryIcon_Click);
            // 
            // aboutPanel
            // 
            resources.ApplyResources(this.aboutPanel, "aboutPanel");
            this.aboutPanel.Controls.Add(this.aboutIcon);
            this.aboutPanel.Controls.Add(this.aboutLabel2);
            this.aboutPanel.Name = "aboutPanel";
            this.aboutPanel.Click += new System.EventHandler(this.aboutPanel_Click);
            // 
            // aboutIcon
            // 
            resources.ApplyResources(this.aboutIcon, "aboutIcon");
            this.aboutIcon.Name = "aboutIcon";
            this.aboutIcon.TabStop = false;
            this.aboutIcon.Click += new System.EventHandler(this.aboutIcon_Click);
            // 
            // nowplayingPanel
            // 
            resources.ApplyResources(this.nowplayingPanel, "nowplayingPanel");
            this.nowplayingPanel.Controls.Add(this.stackCount);
            this.nowplayingPanel.Controls.Add(this.nowplayingIcon);
            this.nowplayingPanel.Controls.Add(this.nowplayingLabel2);
            this.nowplayingPanel.Name = "nowplayingPanel";
            this.nowplayingPanel.Click += new System.EventHandler(this.nowplayingPanel_Click);
            this.nowplayingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.nowplayingPanel_Paint);
            // 
            // stackCount
            // 
            this.stackCount.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.stackCount, "stackCount");
            this.stackCount.ForeColor = System.Drawing.Color.White;
            this.stackCount.Name = "stackCount";
            // 
            // nowplayingIcon
            // 
            resources.ApplyResources(this.nowplayingIcon, "nowplayingIcon");
            this.nowplayingIcon.Name = "nowplayingIcon";
            this.nowplayingIcon.TabStop = false;
            this.nowplayingIcon.Click += new System.EventHandler(this.nowplayingIcon_Click);
            // 
            // playlistsPanel
            // 
            resources.ApplyResources(this.playlistsPanel, "playlistsPanel");
            this.playlistsPanel.Controls.Add(this.playlistsIcon);
            this.playlistsPanel.Controls.Add(this.playlistsLabel2);
            this.playlistsPanel.Name = "playlistsPanel";
            this.playlistsPanel.Click += new System.EventHandler(this.playlistsPanel_Click);
            // 
            // playlistsIcon
            // 
            resources.ApplyResources(this.playlistsIcon, "playlistsIcon");
            this.playlistsIcon.Name = "playlistsIcon";
            this.playlistsIcon.TabStop = false;
            this.playlistsIcon.Click += new System.EventHandler(this.playlistsIcon_Click);
            // 
            // albumsPanel
            // 
            resources.ApplyResources(this.albumsPanel, "albumsPanel");
            this.albumsPanel.Controls.Add(this.albumsIcon);
            this.albumsPanel.Controls.Add(this.albumsLabel2);
            this.albumsPanel.Name = "albumsPanel";
            this.albumsPanel.Click += new System.EventHandler(this.albumsPanel_Click);
            // 
            // albumsIcon
            // 
            resources.ApplyResources(this.albumsIcon, "albumsIcon");
            this.albumsIcon.Name = "albumsIcon";
            this.albumsIcon.TabStop = false;
            this.albumsIcon.Click += new System.EventHandler(this.albumsIcon_Click);
            // 
            // artistsPanel
            // 
            resources.ApplyResources(this.artistsPanel, "artistsPanel");
            this.artistsPanel.Controls.Add(this.artistsIcon);
            this.artistsPanel.Controls.Add(this.artistsLabel2);
            this.artistsPanel.Name = "artistsPanel";
            this.artistsPanel.Click += new System.EventHandler(this.artistsPanel_Click);
            // 
            // artistsIcon
            // 
            resources.ApplyResources(this.artistsIcon, "artistsIcon");
            this.artistsIcon.Name = "artistsIcon";
            this.artistsIcon.TabStop = false;
            this.artistsIcon.Click += new System.EventHandler(this.artistsIcon_Click);
            // 
            // songsPanel
            // 
            resources.ApplyResources(this.songsPanel, "songsPanel");
            this.songsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.songsPanel.Controls.Add(this.songsIcon);
            this.songsPanel.Controls.Add(this.songsLabel2);
            this.songsPanel.Name = "songsPanel";
            this.songsPanel.Click += new System.EventHandler(this.songsPanel_Click);
            // 
            // songsIcon
            // 
            resources.ApplyResources(this.songsIcon, "songsIcon");
            this.songsIcon.Name = "songsIcon";
            this.songsIcon.TabStop = false;
            this.songsIcon.Click += new System.EventHandler(this.songsIcon_Click);
            // 
            // searchBox
            // 
            resources.ApplyResources(this.searchBox, "searchBox");
            this.searchBox.ForeColor = System.Drawing.Color.Gray;
            this.searchBox.Name = "searchBox";
            this.searchBox.TabStop = false;
            this.searchBox.Tag = "search";
            this.searchBox.Click += new System.EventHandler(this.SearchBoxClick);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.SearchBoxEnter);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            this.searchBox.Leave += new System.EventHandler(this.SearchBoxLeave);
            this.searchBox.Validating += new System.ComponentModel.CancelEventHandler(this.SearchBoxValidating);
            // 
            // mainPane
            // 
            resources.ApplyResources(this.mainPane, "mainPane");
            this.mainPane.Controls.Add(this.translations);
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
            // songMenu
            // 
            this.songMenu.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.songMenu, "songMenu");
            this.songMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stackToolStripMenuItem,
            this.addToPlaylistToolStripMenuItem});
            this.songMenu.Name = "songMenu";
            this.songMenu.ShowImageMargin = false;
            // 
            // playToolStripMenuItem
            // 
            resources.ApplyResources(this.playToolStripMenuItem, "playToolStripMenuItem");
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stackToolStripMenuItem
            // 
            this.stackToolStripMenuItem.Name = "stackToolStripMenuItem";
            resources.ApplyResources(this.stackToolStripMenuItem, "stackToolStripMenuItem");
            this.stackToolStripMenuItem.Click += new System.EventHandler(this.stackToolStripMenuItem_Click);
            // 
            // addToPlaylistToolStripMenuItem
            // 
            this.addToPlaylistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistToolStripMenuItem,
            this.toolStripMenuItem2});
            this.addToPlaylistToolStripMenuItem.Name = "addToPlaylistToolStripMenuItem";
            resources.ApplyResources(this.addToPlaylistToolStripMenuItem, "addToPlaylistToolStripMenuItem");
            this.addToPlaylistToolStripMenuItem.DropDownOpening += new System.EventHandler(this.addToPlaylistToolStripMenuItem_DropDownOpening);
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            resources.ApplyResources(this.newPlaylistToolStripMenuItem, "newPlaylistToolStripMenuItem");
            this.newPlaylistToolStripMenuItem.Click += new System.EventHandler(this.newPlaylistToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // playbackTimer
            // 
            this.playbackTimer.Enabled = true;
            this.playbackTimer.Interval = 1;
            this.playbackTimer.Tick += new System.EventHandler(this.playbackTimer_Tick);
            // 
            // quicklistmenu
            // 
            this.quicklistmenu.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.quicklistmenu, "quicklistmenu");
            this.quicklistmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem1,
            this.removeFromQueueToolStripMenuItem});
            this.quicklistmenu.Name = "songMenu";
            this.quicklistmenu.ShowImageMargin = false;
            // 
            // playToolStripMenuItem1
            // 
            resources.ApplyResources(this.playToolStripMenuItem1, "playToolStripMenuItem1");
            this.playToolStripMenuItem1.Name = "playToolStripMenuItem1";
            this.playToolStripMenuItem1.Click += new System.EventHandler(this.playToolStripMenuItem1_Click);
            // 
            // removeFromQueueToolStripMenuItem
            // 
            this.removeFromQueueToolStripMenuItem.Name = "removeFromQueueToolStripMenuItem";
            resources.ApplyResources(this.removeFromQueueToolStripMenuItem, "removeFromQueueToolStripMenuItem");
            this.removeFromQueueToolStripMenuItem.Click += new System.EventHandler(this.removeFromQueueToolStripMenuItem_Click);
            // 
            // volBack
            // 
            resources.ApplyResources(this.volBack, "volBack");
            this.volBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.volBack.Controls.Add(this.volFront);
            this.volBack.Name = "volBack";
            this.volBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volBack_MouseDown);
            this.volBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volBack_MouseMove);
            this.volBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volBack_MouseUp);
            // 
            // volFront
            // 
            resources.ApplyResources(this.volFront, "volFront");
            this.volFront.BackColor = System.Drawing.Color.Lime;
            this.volFront.Name = "volFront";
            this.volFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.volFront_MouseDown);
            this.volFront.MouseMove += new System.Windows.Forms.MouseEventHandler(this.volFront_MouseMove);
            this.volFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volFront_MouseUp);
            // 
            // translations
            // 
            resources.ApplyResources(this.translations, "translations");
            this.translations.ForeColor = System.Drawing.Color.White;
            this.translations.Name = "translations";
            this.translations.Tag = "";
            // 
            // contentPaneTitle
            // 
            resources.ApplyResources(this.contentPaneTitle, "contentPaneTitle");
            this.contentPaneTitle.ForeColor = System.Drawing.Color.Black;
            this.contentPaneTitle.Name = "contentPaneTitle";
            // 
            // libraryLabel2
            // 
            resources.ApplyResources(this.libraryLabel2, "libraryLabel2");
            this.libraryLabel2.ForeColor = System.Drawing.Color.White;
            this.libraryLabel2.Name = "libraryLabel2";
            this.libraryLabel2.Click += new System.EventHandler(this.libraryLabel2_Click);
            // 
            // aboutLabel2
            // 
            resources.ApplyResources(this.aboutLabel2, "aboutLabel2");
            this.aboutLabel2.ForeColor = System.Drawing.Color.White;
            this.aboutLabel2.Name = "aboutLabel2";
            this.aboutLabel2.Click += new System.EventHandler(this.aboutLabel2_Click);
            // 
            // nowplayingLabel2
            // 
            resources.ApplyResources(this.nowplayingLabel2, "nowplayingLabel2");
            this.nowplayingLabel2.ForeColor = System.Drawing.Color.White;
            this.nowplayingLabel2.Name = "nowplayingLabel2";
            this.nowplayingLabel2.Click += new System.EventHandler(this.nowplayingLabel2_Click);
            // 
            // playlistsLabel2
            // 
            resources.ApplyResources(this.playlistsLabel2, "playlistsLabel2");
            this.playlistsLabel2.ForeColor = System.Drawing.Color.White;
            this.playlistsLabel2.Name = "playlistsLabel2";
            this.playlistsLabel2.Click += new System.EventHandler(this.playlistsLabel2_Click);
            // 
            // albumsLabel2
            // 
            resources.ApplyResources(this.albumsLabel2, "albumsLabel2");
            this.albumsLabel2.ForeColor = System.Drawing.Color.White;
            this.albumsLabel2.Name = "albumsLabel2";
            this.albumsLabel2.Click += new System.EventHandler(this.albumsLabel2_Click);
            // 
            // artistsLabel2
            // 
            resources.ApplyResources(this.artistsLabel2, "artistsLabel2");
            this.artistsLabel2.ForeColor = System.Drawing.Color.White;
            this.artistsLabel2.Name = "artistsLabel2";
            this.artistsLabel2.Click += new System.EventHandler(this.artistsLabel2_Click);
            // 
            // songsLabel2
            // 
            resources.ApplyResources(this.songsLabel2, "songsLabel2");
            this.songsLabel2.ForeColor = System.Drawing.Color.White;
            this.songsLabel2.Name = "songsLabel2";
            this.songsLabel2.Click += new System.EventHandler(this.songsLabel2_Click);
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
            // appTitle
            // 
            resources.ApplyResources(this.appTitle, "appTitle");
            this.appTitle.ContextMenuStrip = this.windowContextMenu;
            this.appTitle.ForeColor = System.Drawing.Color.White;
            this.appTitle.Name = "appTitle";
            this.appTitle.Click += new System.EventHandler(this.appTitle_Click);
            this.appTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AppTitleMouseDown);
            this.appTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AppTitleMouseMove);
            this.appTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AppTitleMouseUp);
            // 
            // tracklength
            // 
            resources.ApplyResources(this.tracklength, "tracklength");
            this.tracklength.ForeColor = System.Drawing.Color.White;
            this.tracklength.Name = "tracklength";
            this.tracklength.Click += new System.EventHandler(this.tracklength_Click);
            // 
            // trackpos
            // 
            resources.ApplyResources(this.trackpos, "trackpos");
            this.trackpos.ForeColor = System.Drawing.Color.White;
            this.trackpos.Name = "trackpos";
            this.trackpos.Click += new System.EventHandler(this.trackpos_Click);
            // 
            // songinfo
            // 
            resources.ApplyResources(this.songinfo, "songinfo");
            this.songinfo.ForeColor = System.Drawing.Color.White;
            this.songinfo.Name = "songinfo";
            this.songinfo.Click += new System.EventHandler(this.songinfo_Click);
            // 
            // songname
            // 
            resources.ApplyResources(this.songname, "songname");
            this.songname.ForeColor = System.Drawing.Color.White;
            this.songname.Name = "songname";
            this.songname.Click += new System.EventHandler(this.songname_Click);
            // 
            // volVal
            // 
            resources.ApplyResources(this.volVal, "volVal");
            this.volVal.BackColor = System.Drawing.Color.Black;
            this.volVal.ForeColor = System.Drawing.Color.White;
            this.volVal.Name = "volVal";
            // 
            // Player
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.volVal);
            this.Controls.Add(this.volBack);
            this.Controls.Add(this.focusMisser);
            this.Controls.Add(this.mainPane);
            this.Controls.Add(this.mainSidebar);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.bottomPanel);
            this.KeyPreview = true;
            this.Name = "Player";
            this.Activated += new System.EventHandler(this.Player_Activated);
            this.Deactivate += new System.EventHandler(this.Player_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Player_FormClosing);
            this.Load += new System.EventHandler(this.Player_Load);
            this.ResizeEnd += new System.EventHandler(this.Player_ResizeEnd);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
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
            this.songMenu.ResumeLayout(false);
            this.quicklistmenu.ResumeLayout(false);
            this.volBack.ResumeLayout(false);
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
		private Label2 libraryLabel2;
        private System.Windows.Forms.Panel mainPane;
		private Label2 contentPaneTitle;
		
		
		private Label2 closeBox;
		private Label2 maximizeBox;
		private Label2 minimizeBox;
		private System.Windows.Forms.PictureBox repeatButton;
		private System.Windows.Forms.PictureBox shuffleButton;
		private System.Windows.Forms.PictureBox volumeButton;
		private System.Windows.Forms.PictureBox nextButton;
		private System.Windows.Forms.PictureBox playPauseButton;
		private System.Windows.Forms.PictureBox previousButton;
		private Label2 tracklength;
        private Label2 trackpos;
		private Label2 songinfo;
		private Label2 songname;
		private System.Windows.Forms.PictureBox songalbum;
		private System.Windows.Forms.Panel aboutPanel;
		private System.Windows.Forms.PictureBox aboutIcon;
		private Label2 aboutLabel2;
		private System.Windows.Forms.Panel nowplayingPanel;
		private System.Windows.Forms.PictureBox nowplayingIcon;
		private Label2 nowplayingLabel2;
		private System.Windows.Forms.Panel playlistsPanel;
		private System.Windows.Forms.PictureBox playlistsIcon;
		private Label2 playlistsLabel2;
		private System.Windows.Forms.Panel albumsPanel;
		private System.Windows.Forms.PictureBox albumsIcon;
		private Label2 albumsLabel2;
		private System.Windows.Forms.Panel artistsPanel;
		private System.Windows.Forms.PictureBox artistsIcon;
		private Label2 artistsLabel2;
		private System.Windows.Forms.Panel songsPanel;
		private System.Windows.Forms.PictureBox songsIcon;
		private Label2 songsLabel2;
		private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel titlePanel;
		private System.Windows.Forms.Panel mainSidebar;
		private Label2 appTitle;
		private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Timer focusController;
        private System.Windows.Forms.Panel contentPane;
        public System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.Timer playbackTimer;
        private System.Windows.Forms.Label stackCount;
        private System.Windows.Forms.Panel trackbarProgress;
        private System.Windows.Forms.Panel trackbarBack;
        private System.Windows.Forms.Panel trackbarRegion;
        private Label2 translations;
        public System.Windows.Forms.ContextMenuStrip songMenu;
        public System.Windows.Forms.ContextMenuStrip quicklistmenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeFromQueueToolStripMenuItem;
        private System.Windows.Forms.Panel volFront;
        public System.Windows.Forms.Panel volBack;
        private System.Windows.Forms.Label volVal;
	}
}
