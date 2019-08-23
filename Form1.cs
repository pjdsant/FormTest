using LikeWater.WinHCtl.WinApi;
using System;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WinApiX winApiX = new WinApiX();

            label1.Text = winApiX.GetListItem("System Interact", 0, 0);

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

            label1.Text = winApiX.GetListItem("System Interact", 0, 0);

        }
    }
}
