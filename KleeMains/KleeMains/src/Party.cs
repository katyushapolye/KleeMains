using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleeMains
{
    public class Party
    {

        private static Party currentParty;
        
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

            currentParty = this;


        }

        public List<Elements> getElementalRes()
        {
            int[] aux = new int[]{ 0, 0, 0, 0, 0, 0, 0,0};
            for(int i = 0; i < 4; i++)
            {
                aux[(int)currentParty.characters[i].getElement()]++;
                /*
                switch (currentParty.characters[i].getElement())
                {
                    case Elements.Cryo:
                        aux[0]++;
                        break;
                    case Elements.Pyro:
                        aux[1]++;
                        break;
                    case Elements.Hydro:
                        aux[2]++;
                        break;
                    case Elements.Electro:
                        aux[3]++;
                        break;
                    case Elements.Anemo:
                        aux[4]++;
                        break;
                    case Elements.Geo:
                        aux[5]++;
                        break;
                    case Elements.Dendro:
                        aux[7]++;
                        break;
                    default:
                        break;
                }
                */
            }
            List<Elements> res = new List<Elements>();
            for(int i  = 0; i < 8; i++)
            {
                if (aux[i] >= 2)
                {
                    res.Add((Elements)i);


                }
            }

            return res;


        }


        //passing by ref so no prob
        public static ref Party getCurrentParty()
        {
            return ref currentParty;
        }


        public Report generatePartyReport() {
            

            Report report = new Report(currentParty);

            return report;
       
        }


        public bool changeCharacter(Character character, int index)
        {
            if (index >= 4)
            {
                return false;
            }
            for(int i = 0; i < 4; i++)
            {
                if (currentParty.characters[i].getName() == character.getName())
                {
                    return false;

                }
            }
            currentParty.characters[index] = character;

            return true;
        }

        public ref List<Character> getCharacters()
        {
            return ref currentParty.characters;
        }

        public string getPartyName()
        {
            return currentParty.name;
        }
            
    }



    
}
