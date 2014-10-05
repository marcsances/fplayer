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
using System.Globalization;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace fPlayer_2
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
        public static string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\MSS Software & Services\\urMusik\\2.1\\";
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            if (Directory.Exists(AppFolder) && File.Exists(AppFolder + "\\langoverride"))
            {
                switch (File.ReadAllText(AppFolder + "\\langoverride"))
                {
                    case "en":
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                        break;
                    case "es":
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                        break;
                    case "ca":
                        Thread.CurrentThread.CurrentCulture = new CultureInfo("ca-ES");
                        Thread.CurrentThread.CurrentUICulture = new CultureInfo("ca-ES");
                        break;
                }
            }
			Application.Run(new Player());
		}
		
	}
}
