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
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

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

  

     

     

     


        private void pictureBox2_MouseDown(object sender, EventArgs e)
        {
            //Console.Write("started Dragging");
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;


        }


        private void pictureBox2_MouseUp(object sender, EventArgs e)
        {
            dragging = false;



        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //Console.Write("Dragging");
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }
    }
}
