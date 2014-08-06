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
using System.IO;
namespace fPlayer_2
{
    public partial class libraryEditor : UserControl
    {
        public static string AppFolder=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MSS Software & Services\\urMusik\\2.1\\";
        public libraryEditor()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderBox.Items.Add(folderBrowserDialog.SelectedPath);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            folderBox.Items.Remove(folderBox.SelectedItem);
        }

        public Player getParentPlayer(Control c)
        {
            if (c==null) {
                return null;
            } else if (c is Player) {
                return (Player)c;
            }
            else
            {
                return getParentPlayer(c.Parent);
            }
        }

        public Player getParentPlayer()
        {
            return getParentPlayer(this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            loadFolders();
            Player p = getParentPlayer();
            if (p != null)
            {
                p.songsLabel2_Click(p, e);
            }
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            saveFolders();
            Player p = getParentPlayer();
            if (p!=null) p.reloadAll();
        }

        public string arrayToString(ListBox.ObjectCollection items)
        {
            String str = "";
            foreach (String k in items) {
                str=str+k+"\r\n";
            }
            return str;
        }

        public void stringToArray(string data,ref ListBox lb)
        {
            foreach (string k in data.Replace("\r", "").Split('\n'))
            {
                if (k != "") lb.Items.Add(k);
            }
        }

        public void loadFolders()
        {
            folderBox.Items.Clear();
            if (File.Exists(AppFolder + "\\library.lib"))
            {
                stringToArray(File.ReadAllText(AppFolder + "library.lib"), ref folderBox);
            }
        }

        public void saveFolders()
        {

            Directory.Delete(AppFolder + "\\hashes\\",true);
            Directory.CreateDirectory(AppFolder + "\\hashes\\");
            File.WriteAllText(AppFolder + "library.lib", arrayToString(folderBox.Items));
            
        }

        

        private void libraryEditor_Load(object sender, EventArgs e)
        {
            loadFolders();
        }
    }
}
