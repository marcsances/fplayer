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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace fPlayer_2
{
    public partial class AboutDialog : UserControl
    {
        public AboutDialog()
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

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            appVer.Text = appVer.Text.Replace("%v", Assembly.GetEntryAssembly().GetName().Version.ToString());
            apiimplver.Text = apiimplver.Text.Replace("%a", libap.libAP.LIBAP_API_VER.ToString()).Replace("%imp", libap.libAP.LIBAP_API_IMPL.ToString());
            copyInfo.Text = copyInfo.Text + "\r\n" + libap.libAP.getLicenseInfo();
        }

        private void facebookIcon_MouseEnter(object sender, EventArgs e)
        {
            facebookIcon.BackColor = Color.LightGray;
        }

        private void facebookIcon_MouseLeave(object sender, EventArgs e)
        {
            facebookIcon.BackColor = Color.White;
        }

        private void twitterIcon_MouseEnter(object sender, EventArgs e)
        {
            twitterIcon.BackColor = Color.LightGray;
        }

        private void twitterIcon_MouseLeave(object sender, EventArgs e)
        {
            twitterIcon.BackColor = Color.White;
        }

        private void webIcon_MouseEnter(object sender, EventArgs e)
        {
            webIcon.BackColor = Color.LightGray;
        }

        private void webIcon_MouseLeave(object sender, EventArgs e)
        {
            webIcon.BackColor = Color.White;
        }
    }
}
