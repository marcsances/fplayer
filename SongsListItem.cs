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
    public partial class SongsListItem : UserControl
    {
        /*
         * Small explanation: parentList will contain the container where the item is on.
         * That container's tag will be a list of the selected items separated by commas.
         * This control detects if list is in multi select mode or not, by checking if there is more than one item on tag.
         * Single selection example: 3
         * Multi selection example: 3,6
         * The index of this control on array is stored at property index. Be careful to correctly set it.
         */
        public int index=0;
        public Control parentList;
        public SongsListItem()
        {
            InitializeComponent();
        }
        SelectionMode lastmode = SelectionMode.MODE_UNFOCUSED;
        private void SongsListItem_Paint(object sender, PaintEventArgs e)
        {
            SelectionMode newmode=getSelectionMode(this);
            if (lastmode != newmode)
            {
                switch (newmode)
                {
                    case SelectionMode.MODE_ACTIVE:
                        this.BackColor = Color.Black;
                        this.ForeColor = Color.White;
                        break;
                    case SelectionMode.MODE_FOCUSED:
                        this.BackColor = Color.LightGray;
                        this.ForeColor = Color.Black;
                        break;
                    case SelectionMode.MODE_UNFOCUSED:
                        this.BackColor = Color.White;
                        this.ForeColor = Color.Black;
                        break;
                    case SelectionMode.MODE_SELECTED:
                        this.BackColor = Color.Teal;
                        this.ForeColor = Color.White;
                        break;
                }
                lastmode = newmode;
            }
            
        }

        enum SelectionMode
        {
            MODE_UNFOCUSED, MODE_FOCUSED, MODE_ACTIVE, MODE_SELECTED
        }

        private bool isMouseOver(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(Cursor.Position));
        }

        private SelectionMode getSelectionMode(Control c)
        {
            if (Convert.ToInt32(this.parentList.Tag.ToString().Split(',').Contains(index.ToString()))==this.index)
            {
                return SelectionMode.MODE_SELECTED;
            }
            if (isMouseOver(c))
            {
                if (Control.MouseButtons == MouseButtons.Left)
                {
                    return SelectionMode.MODE_ACTIVE;
                }
                else
                {
                    return SelectionMode.MODE_FOCUSED;
                }
            }
            else
            {
                return SelectionMode.MODE_UNFOCUSED;
            }
        }

        private void SongsListItem_Click(object sender, EventArgs e)
        {
            if (this.parentList.Tag.ToString().Split(',').Length <= 1) { this.parentList.Tag = this.index; }
            else
            {
                this.parentList.Tag = this.parentList.Tag + "," + this.index;
            }
        }

        private void SongsListItem_MouseHover(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                this.parentList.Tag = this.parentList.Tag + "," + this.index;
            }
        }
        public event EventHandler OnPlaySelected;
        public event EventHandler OnMenuRequest;
        private void songTitle_DoubleClick(object sender, EventArgs e)
        {
            this.OnPlaySelected(sender,e);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            this.OnMenuRequest(sender, e);
        }

        private void songInfo_DoubleClick(object sender, EventArgs e)
        {
            this.OnPlaySelected(sender, e);
        }

        private void songLength_DoubleClick(object sender, EventArgs e)
        {
            this.OnPlaySelected(sender, e);
        }

        public void setData(string title, string info, string length)
        {
            this.songTitle.Text = title;
            this.songInfo.Text = info;
            this.songLength.Text = length;
        }

    }
}
