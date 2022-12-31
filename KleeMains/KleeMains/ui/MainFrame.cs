using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KleeMains
{
    public partial class MainFrame : Form
    {
        //boiler plate code

        bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private Character currentChar = null;
        private Party currentParty = null;
        int currentCharIndex = 0;
        bool selectingChars = false;
     

        //to save mem, set party images as vers and only change them when switching

        List<System.Drawing.Image> buttomImages = new List<Image>(4);
        List<System.Drawing.Image> charImages = new List<Image>(4);


        public MainFrame()
        {
            InitializeComponent();
            for(int i  = 0; i < 4; i++)
            {
                buttomImages.Add(null);
                charImages.Add(null);
            }
            currentParty = Party.getCurrentParty();



            updateUI(true);

            
            




        }

        private void MainFrame_Load(object sender, EventArgs e)
        {

        }

           //Toolbar slide
        private void ToolBar_MouseDown(object sender, EventArgs e)
        {
            //Console.Write("started Dragging");
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;


        }

        private void ToolBar_MouseUp(object sender, EventArgs e)
        {
            dragging = false;



        }

        private void ToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //Console.Write("Dragging");
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        //Toolbar slide end

        private void openCharSeletion(int index)
        {
            CharSelection charSelection = new CharSelection(index,this);
           
            //pass a flag for which switch is

            charSelection.Show();
            

        }

        public void updateUI(bool hardUpdate)
        {
            selectingChars = false;
            if (hardUpdate)
            {
                for (int i = 0; i < 4; i++)
                {
                    buttomImages[i] = (System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) +
                   @"/Resources/Characters/" + currentParty.getCharacters()[i].getName() + "/" + currentParty.getCharacters()[i].getName() + "_Thumb.png"));
                    charImages[i] = (System.Drawing.Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) +
                   @"/Resources/Characters/" + currentParty.getCharacters()[i].getName() + "/" + currentParty.getCharacters()[i].getName() + "_Card.png"));


                }

                C0_Button.BackgroundImage = buttomImages[0];
                C1_Button.BackgroundImage = buttomImages[1];
                C2_Button.BackgroundImage = buttomImages[2];
                C3_Button.BackgroundImage = buttomImages[3];
            }

            this.charSpriteUIImage.Image = charImages[currentCharIndex];

            this.partyNameUIText.Text = currentParty.getPartyName();
            
            this.currentChar = currentParty.getCharacters()[currentCharIndex];
            this.charNameUIText.Text = separateWords(currentChar.getName());
            this.charTitleUIText.Text = currentChar.getTitle();
            this.charBaseATKUIText.Text = currentChar.getbaseATK().ToString();
            this.charBaseHPUIText.Text = currentChar.getbaseHP().ToString();
            this.charBaseDEFUIText.Text = currentChar.getbaseDEF().ToString();
            this.charBestWeaponText.Text =  separateWords(currentChar.getWeapon().getName());
            this.charCommonMaterialsText.Text = separateWords(currentChar.getCommonT1().ToString()); //nao cabe + "/" + separateWords(currentChar.getCommonT2()) + "/" + separateWords(currentChar.getCommonT3());
            this.charCollectableMaterialsText.Text = separateWords(currentChar.getCollactable().ToString());
            this.charTalentMaterialsText.Text = separateWords(currentChar.getTalent().ToString());
            this.charAscensionBonusText.Text = separateWords(currentChar.getAscensionBonus());

            this.elementalResUIText.Text = "";
            

            for (int i = 0; i < currentParty.getElementalRes().Count; i++)
            {
                
                

                this.elementalResUIText.Text += currentParty.getElementalRes()[i].ToString();
                if (i == currentParty.getElementalRes().Count - 1) { break; }
                this.elementalResUIText.Text += "/";

            }


            
            changeBG();

       }

       
       

    

        private void C0_Switch_Click(object sender, EventArgs e)
        {
            if(selectingChars == true)
            {
                return;
            }
            selectingChars = true;
            openCharSeletion(0);
            currentCharIndex = 0;

        }
        private void C1_Switch_Click(object sender, EventArgs e)
        {
            if (selectingChars == true)
            {
                return;
            }
            selectingChars = true;
            openCharSeletion(1);
            currentCharIndex = 1;
        }
        private void C2_Switch_Click(object sender, EventArgs e)
        {
            if (selectingChars == true)
            {
                return;
            }
            selectingChars = true;
            openCharSeletion(2);
            currentCharIndex = 2;
        }
        private void C3_Switch_Click(object sender, EventArgs e)
        {
            if (selectingChars == true)
            {
                return;
            }
            selectingChars = true;
            openCharSeletion(3);
            currentCharIndex = 3;

        }

        private void C0_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = currentParty.getCharacters()[0];
            currentCharIndex = 0;

            updateUI(false);

        }

        private void C1_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = currentParty.getCharacters()[1];
            currentCharIndex = 1;

            updateUI(false);
        }

        private void C2_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = currentParty.getCharacters()[2];
            currentCharIndex = 2;

            updateUI(false);
        }

        private void C3_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = currentParty.getCharacters()[3];
            currentCharIndex = 3;

            updateUI(false);
        }


   




        //back front end functions


        //changes all colors to match char
        private void changeBG()
        {
            switch (this.currentChar.getElement())
            {
                case Elements.Cryo:
                    this.BackColor = System.Drawing.Color.SkyBlue;
                    break;
                case Elements.Pyro:
                    this.BackColor = System.Drawing.Color.Maroon;
                    break;
                case Elements.Hydro:
                    this.BackColor = System.Drawing.Color.DarkBlue;
                    break;
                case Elements.Electro:
                    this.BackColor = System.Drawing.Color.DarkViolet;
                    break;
                case Elements.Anemo:
                    this.BackColor = System.Drawing.Color.MediumAquamarine;
                    break;
                case Elements.Geo:
                    this.BackColor = System.Drawing.Color.DarkGoldenrod;
                    break;
                case Elements.Dendro:
                    //to do
                    //to do
                    break;
                default:
                    break;
            }
        }

        private static string separateWords(string str)
        {
            string buffer = "";
            for(int i  = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str, i) && i != 0)
                {
                    buffer += " ";
                }
                buffer += str[i];
            }

            return buffer;

        }

        private void partyStatsHelpUIButton_Click(object sender, EventArgs e)
        {
            ElementGuide elementGuide = new ElementGuide();
            elementGuide.Show();


        }

        private void generatePartyReportButtonUI_Click(object sender, EventArgs e)
        {
            currentParty.generatePartyReport();
            MessageBox.Show("Party Report successfully generated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }







}
