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
        public static string AppFolder=Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MSS Software & Services\\fPlayer\\2.1\\";
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
                p.songsLabel_Click(p, e);
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
            if (!localDataFolderExists())
            {
                Directory.CreateDirectory(AppFolder);
            }
            if (File.Exists(AppFolder + "\\library.lib"))
            {
                stringToArray(File.ReadAllText(AppFolder + "library.lib"), ref folderBox);
            }
        }

        public void saveFolders()
        {
            if (!localDataFolderExists())
            {
                Directory.CreateDirectory(AppFolder);
            }
            File.WriteAllText(AppFolder + "library.lib", arrayToString(folderBox.Items));
            
        }

        public bool localDataFolderExists()
        {
            return Directory.Exists(Application.LocalUserAppDataPath + "\\MSS Software & Services\\fPlayer\\2.1\\");
        }

        private void libraryEditor_Load(object sender, EventArgs e)
        {
            loadFolders();
        }
    }
}
