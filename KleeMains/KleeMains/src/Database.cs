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
        public Database(string path)
        {
            database = new SQLiteConnection("Data Source=" + path + " ; Version = 3; New = False; Compress = True; ");
            try
            {
                database.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR - FAILED TO OPEN CONNECTION");
            }

        }

        public List<Character> getAllCharacters()
        {
            if (database == null)
            {
                Console.WriteLine("ERROR - NON EXISTING CONNECTION");
                return null;
            }
            SQLiteCommand sqlite_cmd = database.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM CHARACTERS";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<Character> characters = new List<Character>();

            //buffers temps
            List<Object> buffers = new List<Object>();

            int rowcount = 0;

            while (sqlite_datareader.Read())
            {


                //nao muda, ent trava bem
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    buffers.Add(sqlite_datareader[i]);


                }
                
            
                    //enums
                    Enum.TryParse((string)buffers[2], out Elements eA);
                    Enum.TryParse((string)buffers[10], out Character.Roles role);
                    Enum.TryParse((string)buffers[11], out Character.CollectablesMaterials cm);
                    Enum.TryParse((string)buffers[12], out Character.CommonMaterialT1 t1);
                    Enum.TryParse((string)buffers[13], out Character.CommonMaterialT2 t2);
                    Enum.TryParse((string)buffers[14], out Character.CommonMaterialT3 t3);
                    Enum.TryParse((string)buffers[15], out Character.FarmableMaterials fm);
                    Enum.TryParse((string)buffers[16], out Character.TalentMaterials tm);
                    Enum.TryParse((string)buffers[17], out Character.TalentAscensionMaterial talAm);
                    Enum.TryParse((string)buffers[21], out Character.AscensionBonus ascensionBonus);
                    Enum.TryParse((string)buffers[22], out Character.Stats stat);
                characters.Add(

                    new Character(
                        buffers[0].ToString(),//0
                        buffers[1].ToString(),
                        eA,
                        this.getWeapon(buffers[3].ToString()),
                        (bool)buffers[4],
                        Convert.ToInt32(buffers[5].ToString()), //basetk
                        Convert.ToInt32(buffers[6].ToString()), //basedef
                        Convert.ToInt32(buffers[7].ToString()), //baseHP
                        float.Parse(buffers[8].ToString()),//critrate
                        float.Parse(buffers[9].ToString()),//critdmg
                        role,//10
                        cm,
                        t1,
                        t2,
                        t3,
                        fm,
                        tm,
                        talAm,//17
                        float.Parse(buffers[18].ToString()),
                        float.Parse(buffers[19].ToString()),
                        float.Parse(buffers[20].ToString()),
                        ascensionBonus,
                        stat)

                        










                        );

                buffers.Clear();





                

                Console.WriteLine("============");
                rowcount++;









            }




            return characters;
        }

        public Weapon getWeapon(string weaponName)
        {
            if (database == null)
            {
                Console.WriteLine("ERROR - NON EXISTING CONNECTION");
                return null;
            }
            SQLiteCommand sqlite_cmd = database.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM WEAPONS WHERE name = \""  + weaponName + "\"";
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            List<Object> buffers = new List<Object>();

            //nao muda, ent trava bem
            

            while (sqlite_datareader.Read())
            {
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    buffers.Add(sqlite_datareader[i]);



                }

            }

            //parsing enums
            
            Enum.TryParse((string)buffers[2], out Weapon.WeaponType enum1);
            Enum.TryParse((string)buffers[3], out Weapon.WeaponBonusType enum2);

            return new Weapon((string)buffers[0], Convert.ToInt32(buffers[1].ToString()),enum1 ,enum2,float.Parse(buffers[4].ToString()));





        }
    }
}
