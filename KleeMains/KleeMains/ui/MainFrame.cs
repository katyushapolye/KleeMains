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

        public MainFrame()
        {
            InitializeComponent();
            //initial party, sets images
           
            currentParty = new Party();
            C0_Button.Text = currentParty.getCharacters()[0].getName();
            C1_Button.Text = currentParty.getCharacters()[1].getName();
            C2_Button.Text = currentParty.getCharacters()[2].getName();
            C3_Button.Text = currentParty.getCharacters()[3].getName();
            
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

        private void openCharSeletion()
        {
            CharSelection charSelection = new CharSelection();
            //pass a flag for which switch is

            charSelection.Show();
            

        }

       

    

        private void C0_Switch_Click(object sender, EventArgs e)
        {
            openCharSeletion();

        }

        private void C0_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = this.currentParty.getCharacters()[0];
            this.charNameUIText.Text = this.currentChar.getName();
            this.charTitleUIText.Text = this.currentChar.getTitle();
            //set images
            changeBG();

        }

        private void C1_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = this.currentParty.getCharacters()[1];
            this.charNameUIText.Text = this.currentChar.getName();
            this.charTitleUIText.Text = this.currentChar.getTitle();
            //set images
            changeBG();
        }

        private void C2_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = this.currentParty.getCharacters()[2];
            this.charNameUIText.Text = this.currentChar.getName();
            this.charTitleUIText.Text = this.currentChar.getTitle();
            //set images
            changeBG();
        }

        private void C3_Button_Click(object sender, EventArgs e)
        {
            this.currentChar = this.currentParty.getCharacters()[3];
            this.charNameUIText.Text = this.currentChar.getName();
            this.charTitleUIText.Text = this.currentChar.getTitle();
            //set images
            changeBG();
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
                    this.BackColor = System.Drawing.Color.Firebrick;
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


    }







}
