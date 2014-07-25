using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fPlayer_2
{
    public partial class nowPlayingOverlay : UserControl
    {
        public nowPlayingOverlay()
        {
            InitializeComponent();
        }

        public void updateInfo(Bitmap albumBack, string Title, string Artist, string Album)
        {
            this.songtitle.Text = Title;
            this.songArtist.Text = Artist;
            this.songAlbum.Text = Album;
            if (albumBack!=null && albumBack.Size.Width > 1)
            {
                this.BackgroundImage = albumBack;
            }
        }
    }
}
