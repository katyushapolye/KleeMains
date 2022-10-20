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
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

  



        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            ReadData(sqlite_conn);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());

            static SQLiteConnection CreateConnection()
            {

                SQLiteConnection sqlite_conn;
                // Create a new database connection:
                sqlite_conn = new SQLiteConnection("Data Source=database.db; Version = 3; New = False; Compress = True; ");
                // Open the connection:
                try
                {
                    sqlite_conn.Open();
                }
                catch (Exception ex)
                {

                }
                return sqlite_conn;
            }




            static void ReadData(SQLiteConnection conn)
            {
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Characters";

                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    for (int i = 0; i < 23; i++)
                    {
                        try
                        {
                            string myreader = sqlite_datareader.GetString(i);
                            Console.WriteLine(myreader);

                        }
                        catch (Exception e)
                        {

                            try
                            {
                                int myreader = sqlite_datareader.GetInt32(i);
                                Console.WriteLine(myreader);
                            }
                            catch (Exception ex)
                            {
                                float myreader = sqlite_datareader.GetFloat(i);
                                Console.WriteLine(myreader);

                            }


                        }

                    }
                };
            
                conn.Close();
            }
        }
    }
}
