using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KleeMains
{

    //a classe party gera o report -> la onde fica os calculos e sugestões
    public class Report
    {
       
        int maxPossibleDamage = 0;
        int maxPossibleEM = 0;

        int totalEXPCost = 0;
        int totalMoraCost = 0;
        string SugestionBio = "";



        Dictionary<Character.Roles, int> roles = new Dictionary<Character.Roles, int>();

        Dictionary<Elements,int> elementalResonance = new Dictionary<Elements, int>();
        Dictionary<Elements, int> elementalAligments = new Dictionary<Elements, int>();
        Dictionary<Character.TalentMaterials,int> talentMaterials = new Dictionary<Character.TalentMaterials, int>();
        Dictionary<Character.TalentAscensionMaterial,int> talentMaterialsAscension =  new Dictionary<Character.TalentAscensionMaterial, int>();
        Dictionary<Character.CommonMaterialT1,int> t1Materials = new Dictionary<Character.CommonMaterialT1, int>();
        Dictionary<Character.CommonMaterialT2,int> t2Materials = new Dictionary<Character.CommonMaterialT2, int>();
        Dictionary<Character.CommonMaterialT3,int> t3Materials = new Dictionary<Character.CommonMaterialT3, int>();
        Dictionary<Character.FarmableMaterials,int> farmableMaterials = new Dictionary<Character.FarmableMaterials, int>();
        Dictionary<Character.CollectablesMaterials,int> collectablesMaterials = new Dictionary<Character.CollectablesMaterials, int>();

        public Report(Party party)
        {

            System.IO.StreamWriter file = new System.IO.StreamWriter(party.getPartyName() + "_report.txt");
            //write line
            
            file.WriteLine("Party Report for: " + party.getPartyName());
            file.WriteLine("Total EXP Cards Necessary: 1680" );
            file.WriteLine("Total Mora Cost: 1 680 000");
            file.WriteLine("Max Theoretical DMG: " + 99999.ToString()); //still need to calculate

            for(int i = 0; i < 4; i++)
            {
                if (roles.ContainsKey(party.getCharacters()[i].getRole()))
                {
                    roles[party.getCharacters()[i].getRole()]++;
                }
                else
                {
                    roles.Add(party.getCharacters()[i].getRole(), 1);

                }
                if (elementalAligments.ContainsKey(party.getCharacters()[i].getElement()))
                {
                    elementalAligments[party.getCharacters()[i].getElement()]++;
                }
                else
                {

                    elementalAligments.Add(party.getCharacters()[i].getElement(), 1);
                }
            }


            for (int i = 0; i < party.getElementalRes().Count; i++){
                if (elementalResonance.ContainsKey(party.getElementalRes()[i]))
                {
                    elementalResonance[party.getElementalRes()[i]]++;
                    continue;


                }
                else
                {

                    this.elementalResonance.Add(party.getElementalRes()[i], 1);

                }
            }

            //checking all repeated materials, will have a lot of ifs

            for(int i = 0; i < 4;i++) {

                //Talent normal
                if (talentMaterials.ContainsKey(party.getCharacters()[i].getTalent()))
                {
                    talentMaterials[party.getCharacters()[i].getTalent()]++;


                }
                else
                {
                    talentMaterials.Add(party.getCharacters()[i].getTalent(),1);

                }
                //Talent Ascension

                if (talentMaterialsAscension.ContainsKey(party.getCharacters()[i].getTalentAscension()))
                {
                    talentMaterialsAscension[party.getCharacters()[i].getTalentAscension()]++;


                }
                else
                {
                    talentMaterialsAscension.Add(party.getCharacters()[i].getTalentAscension(), 1);

                }

                //common T1
                if (t1Materials.ContainsKey(party.getCharacters()[i].getCommonT1()))
                {
                    t1Materials[party.getCharacters()[i].getCommonT1()]++;


                }
                else
                {
                   t1Materials.Add(party.getCharacters()[i].getCommonT1(), 1);

                }
                //commom t2

                if (t2Materials.ContainsKey(party.getCharacters()[i].getCommonT2()))
                {
                    t2Materials[party.getCharacters()[i].getCommonT2()]++;


                }
                else
                {
                    t2Materials.Add(party.getCharacters()[i].getCommonT2(), 1);

                }

                //common t3

                if (t3Materials.ContainsKey(party.getCharacters()[i].getCommonT3()))
                {
                    t3Materials[party.getCharacters()[i].getCommonT3()]++;


                }
                else
                {
                    t3Materials.Add(party.getCharacters()[i].getCommonT3(), 1);

                }
                //farmable

                if (farmableMaterials.ContainsKey(party.getCharacters()[i].getFarmable()))
                {
                    farmableMaterials[party.getCharacters()[i].getFarmable()]++;


                }
                else
                {
                   farmableMaterials.Add(party.getCharacters()[i].getFarmable(), 1);

                }

                //collectable
                if (collectablesMaterials.ContainsKey(party.getCharacters()[i].getCollactable()))
                {
                    collectablesMaterials[party.getCharacters()[i].getCollactable()]++;


                }
                else
                {
                    collectablesMaterials.Add(party.getCharacters()[i].getCollactable(), 1);

                }




            }
            file.WriteLine("---STONES: ");
            for (int i = 0; i < elementalAligments.Count; i++)
            {
                file.WriteLine("--" + elementalAligments.Keys.ToArray<Elements>()[i].ToString() +  "Stones");
                file.WriteLine(1 * elementalAligments.Values.ToArray<int>()[i] + " Silver");
                file.WriteLine(9 * elementalAligments.Values.ToArray<int>()[i] + " Fragment");
                file.WriteLine(9 * elementalAligments.Values.ToArray<int>()[i] + " Chunk");
                file.WriteLine(6 * elementalAligments.Values.ToArray<int>()[i] + " Gemstone");



            }


            file.WriteLine("---Farmable Materials:");
            for(int i = 0; i < farmableMaterials.Count; i++)
            {
                file.WriteLine( (46* farmableMaterials.Values.ToArray()[i]).ToString() +  " "  + farmableMaterials.Keys.ToArray()[i].ToString());
            }

            file.WriteLine("---Collectable Materials:");
            for (int i = 0; i < collectablesMaterials.Count; i++)
            {
                file.WriteLine((168 * collectablesMaterials.Values.ToArray()[i]).ToString() + " " +  collectablesMaterials.Keys.ToArray()[i].ToString());
            }

            file.WriteLine("---T1 Materials:");
            for (int i = 0; i < t1Materials.Count; i++)
            {
                file.WriteLine((18 * t1Materials.Values.ToArray()[i]).ToString() + " " + t1Materials.Keys.ToArray()[i].ToString());
            }

            file.WriteLine("---T2 Materials:");
            for (int i = 0; i < t2Materials.Count; i++)
            {
                file.WriteLine((30 * t2Materials.Values.ToArray()[i]).ToString() + " " + t2Materials.Keys.ToArray()[i].ToString());
            }

            file.WriteLine("---T3 Materials:");
            for (int i = 0; i < t3Materials.Count; i++)
            {
                file.WriteLine(( 36* t3Materials.Values.ToArray()[i]).ToString() + " " + t3Materials.Keys.ToArray()[i].ToString());
            }





            //needs farmimg days
            file.WriteLine("---TALENT MATERIALS");
            for (int i = 0; i < talentMaterials.Count; i++)
            {
                file.WriteLine("--" + talentMaterials.Keys.ToArray<Character.TalentMaterials>()[i].ToString());
                file.WriteLine(9 * talentMaterials.Values.ToArray<int>()[i] + " Teachings");
                file.WriteLine(63 * talentMaterials.Values.ToArray<int>()[i] + " Guide");
                file.WriteLine(114 * talentMaterials.Values.ToArray<int>()[i] + " Philosophies");
            }

            file.WriteLine("---DAYS OF THE WEEK"); //SUNDAY = 0
            for (int i = 0; i < talentMaterials.Count; i++)
            {
                switch (talentMaterials.Keys.ToArray<Character.TalentMaterials>()[i])
                {
                    //monday,thurdsday
                    case Character.TalentMaterials.Freedom:
                    case Character.TalentMaterials.Prosperity:
                    case Character.TalentMaterials.Transience:
                    case Character.TalentMaterials.Admonition:
                        file.WriteLine("Farm " + talentMaterials.Keys.ToArray<Character.TalentMaterials>()[i].ToString() + " On Monday/Thursday or Sunday");
                        break;
                    case Character.TalentMaterials.Resistence:
                    case Character.TalentMaterials.Diligence:
                    case Character.TalentMaterials.Elegance:
                    case Character.TalentMaterials.Ingenuity:
                        file.WriteLine("Farm " + talentMaterials.Keys.ToArray<Character.TalentMaterials>()[i].ToString() + " On Tuesday/Friday or Sunday");
                        break;
                    case Character.TalentMaterials.Ballad:
                    case Character.TalentMaterials.Gold:
                    case Character.TalentMaterials.Light:
                    case Character.TalentMaterials.Praxis:
                        file.WriteLine("Farm " + talentMaterials.Keys.ToArray<Character.TalentMaterials>()[i].ToString() + " On Wednesday/Saturday or Sunday");
                        break;

                    default:
                        break;


                }
            }

            file.WriteLine("---Sugestion for Party Composition");

            //Basic Sugestion 

            if(elementalResonance.Count == 0)
            {
                file.WriteLine("No resonance in party, Is this intended?");
            }
            if (roles.ContainsKey(Character.Roles.MainDPS))
            {
                if(roles[Character.Roles.MainDPS] > 1)
                {
                    file.WriteLine("There is more than one MainDPS in the party, is this intended?");

                }
                
            }
            else
            {
                file.WriteLine("There is no MainDPS in the party, is this intended?");
            }



            


            file.Flush();
            file.Close();


            


            




        }









    }
}
