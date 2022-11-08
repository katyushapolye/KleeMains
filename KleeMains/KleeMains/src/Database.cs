using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace KleeMains
{
    class Database
    {

        private SQLiteConnection database = null;
        Database(string path)
        {
            database = new SQLiteConnection("Data Source="+path + " ; Version = 3; New = False; Compress = True; ");
            try
            {
                database.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR - FAILED TO OPEN CONNECTION");
            }

        }

        List<Character> getAllCharacters() {
            if(database == null)
            {
                Console.WriteLine("ERROR - NON EXISTING CONNECTION");
                return null;
            }
            SQLiteCommand sqlite_cmd = database.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM CHARACTERS";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<Character> characters = new List<Character>();

            while (sqlite_datareader.Read())
            {
                //nao muda, ent trava bem
                string[] buffers;
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    try
                    {
                        
                        string buffer = sqlite_datareader.GetString(i);

                    }
                    catch (Exception e)
                    {

                        try
                        {
                            int buffer = sqlite_datareader.GetInt32(i);

                        }
                        catch (Exception ex)
                        {
                            float buffer = sqlite_datareader.GetFloat(i);



                        }


                    }

                }
            }




                return null; 
        }



    }
}
