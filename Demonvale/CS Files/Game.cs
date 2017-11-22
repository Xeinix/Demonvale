using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Demonvale.Windows_Forms;

namespace Demonvale
{
    static class Game
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            msg("Demonvale Launcher Running");
            Application.Run(new Launcher());

            
        }



        #region Cutom MSG
        static void msg(string m = "")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(m);
        }
#endregion
    }
}
