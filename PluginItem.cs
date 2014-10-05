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
    public partial class PluginItem : UserControl
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
        public Player parent;
        public string getArtistName()
        {
            return pluginname.Text;
        }
        public PluginItem()
        {
            InitializeComponent();
        }
        SelectionMode lastmode = SelectionMode.MODE_UNFOCUSED;
        private void SongsListItem_Paint(object sender, PaintEventArgs e)
        {
        }

        enum SelectionMode
        {
            MODE_UNFOCUSED, MODE_FOCUSED, MODE_ACTIVE, MODE_SELECTED
        }

        private bool isMouseOver(Control c)
        {
            return c.ClientRectangle.Contains(c.PointToClient(Cursor.Position)) && !isMouseOver(parent.bottomPanel,true);
        }

        private bool isMouseOver(Control c, bool overrides)
        {
            return c.ClientRectangle.Contains(c.PointToClient(Cursor.Position));
        }

        private SelectionMode getSelectionMode(Control c)
        {
            if (parentList == null) return SelectionMode.MODE_UNFOCUSED;
            if (this.parentList.Tag.ToString().Split(',').Contains(index.ToString()))
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
        private void toggle()
        {
            if (this.parentList.Tag.ToString().Replace(",,",",").Split(',').Contains(index.ToString()))
            {
                this.parentList.Tag = this.parentList.Tag.ToString().Replace(this.index.ToString(), "").Replace(",,",",");
            }
            else
            {
                this.parentList.Tag = this.parentList.Tag.ToString() + "," + this.index;
            }
            
        }
        private void SongsListItem_Click(object sender, EventArgs e)
        {
            if (this.parentList.Tag.ToString().Replace(",,",",").Split(',').Length <= 2 && Control.ModifierKeys!=Keys.Control) { this.parentList.Tag = this.index; }
            else
            {
                toggle();
                
            }
        }

        private void SongsListItem_MouseHover(object sender, EventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                toggle();
            }
        }
        public event EventHandler OnMenuRequest;

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (!isMultiSelect()) SongsListItem_Click(sender, e);
            if (this.OnMenuRequest!=null) this.OnMenuRequest(this, e);
        }

        private bool isMultiSelect()
        {
            return parentList.Tag.ToString().Replace(",,", ",").Split(',').Length > 2;
        }


        public void setData(string data)
        {
            this.pluginname.Text = data;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (parent != null && parent.isactive)
            {
                SelectionMode newmode = getSelectionMode(this);
                if (lastmode != newmode)
                {
                    switch (newmode)
                    {
                        case SelectionMode.MODE_ACTIVE:
                            this.BackColor = Color.Black;
                            this.ForeColor = Color.Transparent;
                            break;
                        case SelectionMode.MODE_FOCUSED:
                            this.BackColor = Color.LightGray;
                            this.ForeColor = Color.Black;
                            break;
                        case SelectionMode.MODE_UNFOCUSED:
                            this.BackColor = Color.Transparent;
                            this.ForeColor = Color.Black;
                            break;
                        case SelectionMode.MODE_SELECTED:
                            this.BackColor = Color.Teal;
                            this.ForeColor = Color.Transparent;
                            break;
                    }
                    lastmode = newmode;
                }
            }
        }

        

        private void songTitle_Click(object sender, EventArgs e)
        {
            SongsListItem_Click(sender, e);
        }

        private void songInfo_Click(object sender, EventArgs e)
        {
            SongsListItem_Click(sender, e);
        }

        private void songLength_Click(object sender, EventArgs e)
        {
            SongsListItem_Click(sender, e);
        }
        public int CompareTo(object af)
        {
            if (af is PluginItem)
            {
                return this.pluginname.Text.CompareTo(((PluginItem)af).pluginname.Text);
            }
            else return 1;
        }

        private void artist_DoubleClick(object sender, EventArgs e)
        {
            if (this.OnPlayRequest!=null) this.OnPlayRequest(this, e);
        }

        private void ArtistItem_DoubleClick(object sender, EventArgs e)
        {
            if (this.OnPlayRequest != null) this.OnPlayRequest(this, e);
        }
        public event EventHandler OnDeleteRequest;
        private void deletebutton_Click(object sender, EventArgs e)
        {

        }


        public event EventHandler OnPlayRequest;

        private void deletebutton_Click_1(object sender, EventArgs e)
        {
            this.OnDeleteRequest(sender, e);
        }



    }
}
