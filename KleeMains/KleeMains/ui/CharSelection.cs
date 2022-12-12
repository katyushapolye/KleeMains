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
            //adding each button to the list
            //syncs button to indexes on the char list

            /*
            for(int i = 0; i < Program.characters.Count; i++)
            {

                Button temp = new System.Windows.Forms.Button();
                temp.Location = new System.Drawing.Point(3*i, 3);
                temp.Name = "button" + i.ToString();
                temp.Size = new System.Drawing.Size(95, 117);
                temp.TabIndex = i;
                temp.Text = "button" + i.ToString();
                temp.UseVisualStyleBackColor = true;

                charButtons.Add(temp);


                

                this.Controls.Add(temp);



            }
            */
            
        }
    }
}
