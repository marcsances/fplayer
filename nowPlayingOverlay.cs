/*
 * This file is part of fPlayer.

    fPlayer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    LibAP is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with libAP.  If not, see <http://www.gnu.org/licenses/>.
 * */
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
            if (albumBack != null && albumBack.Size.Width > 1) this.pictureBox.Image = albumBack;
            else this.pictureBox.Image = this.pictureBox.ErrorImage;
        }
        public event EventHandler onSaveAsNewListOptionClicked;
        private void savel_Click(object sender, EventArgs e)
        {
            if (this.onSaveAsNewListOptionClicked != null) this.onSaveAsNewListOptionClicked(sender, e);
        }

        private void savel_MouseEnter(object sender, EventArgs e)
        {
            savel.BackColor = Color.LightGray;
        }

        private void savel_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void savel_MouseLeave(object sender, EventArgs e)
        {
            savel.BackColor = Color.White;
        }
    }
}
