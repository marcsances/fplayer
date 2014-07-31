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
