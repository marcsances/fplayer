/*
 * Created by SharpDevelop.
 * User: Marc
 * Date: 07/07/2014
 * Time: 16:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
