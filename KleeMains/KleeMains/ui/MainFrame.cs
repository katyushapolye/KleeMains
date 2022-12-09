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

        public MainFrame()
        {
            InitializeComponent();
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
    }

           //Toolbar slide end
}
