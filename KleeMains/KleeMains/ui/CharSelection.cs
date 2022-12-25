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
        List<Button> charButtons = new List<Button>();
        
                
        public CharSelection()
        {
            InitializeComponent();
            


            
        }

        void selectChar(object sender, EventArgs e)
        {
            Button b = sender as Button;
            Console.WriteLine(Program.characters[b.TabIndex].getName());


        }
    }
}
