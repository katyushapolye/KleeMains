using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleeMains
{
    class Party
    {
        
        string name;
        List<Character> characters;
        int currentCharCount = 0;


        //Only call after the database has ben acessed
        public Party()
        {
            this.currentCharCount = 0;
            this.name = "Default Party";
            this.characters = new List<Character>();
            this.characters.Add(null);
            this.characters.Add(null);
            this.characters.Add(null);
            this.characters.Add(null);
            //inits a party with random chars in their roles
            while(true)
            {
                int i = new Random().Next() % Program.characters.Count;
                if(currentCharCount == 4)
                {
                    break;
                }

                switch (Program.characters[i].getRole())
                {
                    case Character.Roles.MainDPS:
                        if(this.characters[0] != null)
                        {
                            continue;
                        }
                        this.characters[0] = Program.characters[i];
                        this.currentCharCount++;
                        break;
                    case Character.Roles.SubDPS:
                        if (this.characters[1] != null)
                        {
                            continue;
                        }
                        this.characters[1] = Program.characters[i];
                        this.currentCharCount++;
                        break;
                    case Character.Roles.Support:
                        if (this.characters[2] != null)
                        {
                            continue;
                        }
                        this.characters[2] = Program.characters[i];
                        this.currentCharCount++;
                        break;
                    case Character.Roles.Healer:
                        if (this.characters[3] != null)
                        {
                            continue;
                        }
                        this.characters[3] = Program.characters[i];
                        this.currentCharCount++;
                        break;
                    default:
                        break;
                }
                

            }


        }


        Report generatePartyReport() {

            return null;
        }


        bool changeCharacter(Character character, int index)
        {
            return false;
        }

        public List<Character> getCharacters()
        {
            return this.characters;
        }
            
    }



    
}
