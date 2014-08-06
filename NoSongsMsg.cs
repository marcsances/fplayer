/*
 * This file is part of urMusik.

    urMusik is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    urMusik is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with urMusik.  If not, see <http://www.gnu.org/licenses/>.
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
    public partial class NoSongsMsg : UserControl
    {
        public NoSongsMsg()
        {
            InitializeComponent();
        }

        private void facebookIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/msssoftwareservices");
        }

        private void twitterIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com/msssoftware");
        }

        private void webIcon_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mss.16mb.com/");
        }
    }
}
