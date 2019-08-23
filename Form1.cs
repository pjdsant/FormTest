using LikeWater.WinHCtl.WinApi;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private int ConvertMousePointToScreenIndex(Point mousePoint)
        {
            //first get all the screens 
            System.Drawing.Rectangle ret;

            for (int i = 1; i <= Screen.AllScreens.Count(); i++)
            {
                ret = Screen.AllScreens[i - 1].Bounds;
                if (ret.Contains(mousePoint))
                    return i - 1;
            }
            return 0;
        }
        private void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 



            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);

            //txtIniRange.Text = Cursor.Position.X.ToString();
            //txtEndRange.Text = Cursor.Position.Y.ToString();

            int position = ConvertMousePointToScreenIndex(Cursor.Position);

            txtIniRange.Text = position.ToString();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WinApiX winApiX = new WinApiX();

            //label1.Text = winApiX.GetListItem("System Interact", 0, 0);

            winApiX.SetListItem("Sytem Interact", 0, 0);

            Point coordenadas = this.PointToClient(Cursor.Position);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            WinApiX winApiX = new WinApiX();

            //winApiX.SetListItem("System Interact",0,0);

        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveCursor();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
