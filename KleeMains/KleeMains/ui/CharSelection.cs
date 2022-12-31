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
    public partial class CharSelection : Form
    {
        Party currentParty = null;
        List<Button> charButtons = new List<Button>();
        MainFrame parent = null;
        int indexParty = 0;
       
        
                
        public CharSelection(int index,MainFrame parent)
        {
            this.currentParty = Party.getCurrentParty();
            InitializeComponent();
            this.parent = parent;
            indexParty = index;

            


            
        }

        void selectChar(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if(!currentParty.changeCharacter(Program.characters[b.TabIndex], indexParty))
            {
                Console.WriteLine("Failed to change character");
                MessageBox.Show("Failed to Change Character, The Party Cannot have Duplicate Characters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            parent.updateUI(true);

           
            
            this.Close();



        }
    }
}
