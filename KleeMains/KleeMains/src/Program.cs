using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; 

using System.Data.SQLite;

using System.Runtime.InteropServices;


namespace KleeMains
{



    static class Program
    {
        /*
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        */
        public static List<Character> characters;
        


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //AllocConsole(); //debug only
            Database db = new Database("database.db");
            characters =  db.getAllCharacters();
            Party p = new Party();
            
            
            

          







            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
            

        }

        public static Character findCharinMemory(string name)
        {
            for (int i = 0; i < characters.Count; i++)
            {

                if (characters[i].getName() == name)
                {
                    return characters[i];
                }
            }

            return null;
        }
    }
}
