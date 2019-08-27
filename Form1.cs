using LikeWater.WinHCtl.WinApi;
using RegMan.Resource;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;



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

            /*

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            Cursor.Clip = new Rectangle(this.Location, this.Size);

            //txtIniRange.Text = Cursor.Position.X.ToString();
            //txtEndRange.Text = Cursor.Position.Y.ToString();

            int position = ConvertMousePointToScreenIndex(Cursor.Position);

            txtIniRange.Text = position.ToString();
            */
        }

        private void Button1_Click(object sender, EventArgs e)
        {   /*
            // WinApiX winApiX = new WinApiX();
            //label1.Text = winApiX.GetListItem("System Interact", 0, 0);
            //winApiX.SetListItem("Sytem Interact", 0, 0);
            //Point coordenadas = this.PointToClient(Cursor.Position);
            */
            /*
            UserApi userApi = new UserApi();

            RegistryManager registryManager = new RegistryManager();

            var idxLBPhoneFour = registryManager.ReadRegistryValue("idxLBPhoneFour");
            var mainTitle = registryManager.ReadRegistryValue("mainTitle");

            userApi.SetListItem(mainTitle, int.Parse(idxLBPhoneFour), 0);

            */

            var phone1 = "011993947240";
            var phone2 = "011993947240";
            var phone3 = "118882929";
            var phone4 = "0210010101";
           
            if (phone1.Substring(0, 1) == "0") { phone1 = phone1.Substring(1, phone1.Length - 1); }
            if (phone2.Substring(0, 1) == "0") { phone2 = phone2.Substring(1, phone2.Length - 1); }
            if (phone3.Substring(0, 1) == "0") { phone3 = phone3.Substring(1, phone3.Length - 1); }
            if (phone4.Substring(0, 1) == "0") { phone4 = phone4.Substring(1, phone4.Length - 1); }

            var phones = phone1 + "," + phone2 + "," + phone3 + "," + phone4;

            //phones = "";

            /*
            if (phones.Equals("") || phones == null)
            {
                MessageBox.Show("phones = vazio");
            }
            else
            {
                MessageBox.Show("phones = " + phones);
            }
            */

            RegistryManager registryManager = new RegistryManager();

            string GetDataToday()
            {
                try
                {
                    var dateToday = DateTime.Now.ToShortDateString();
                    //return DateTime.ParseExact(dateToday, "yyyy-MM-dd", CultureInfo.CurrentCulture).ToString("yyyyMMdd");

                    string date = DateTime.Now.ToString("yyyyMMdd", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

                    return date;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GetDataToday --> " + ex.Message.ToString());
                    throw;
                }
            }

            string dataPasta = GetDataToday();

            MessageBox.Show(dataPasta);

            int qtdephone = Regex.Matches(phones, phone1).Count;

            List<string> uniqueValues = phones.ToLower().Split(',').Distinct().ToList();
            string UniqueString = string.Join(",", uniqueValues);
           

            if (phones.Contains(phone1))
            {
                MessageBox.Show( "Qtde " + qtdephone.ToString()  + " result: " + UniqueString);
            }else
            {
                MessageBox.Show("NAO Encontrei o telefone em telefones");
            }
            
            /*
            
            WinApiX winApiX = new WinApiX();

            label1.Text = winApiX.GetPhonesGEO();

            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            const string accountSid = "ACb44a91d23fd2b59cfb2b3b4d6fd42a2a";
            const string authToken = "f694e70d32483fe6259a3fbaffabc9b5";

            string output = textBox1.Text;

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
            body: output,
            from: new Twilio.Types.PhoneNumber("+5543933007225"),
            to: new Twilio.Types.PhoneNumber("+5511962155461")
        );

            label1.Text = message.Sid;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //WinApiX winApiX = new WinApiX();

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

        private void Button3_Click(object sender, EventArgs e)
        {
            WinApiX winApiX = new WinApiX();
            var phones = winApiX.GetPhonesGEO();

            lblComercial.Text = "";
            label1.Text = "";

            var labelCom = winApiX.GetTextFields();

            lblComercial.Text = labelCom;
           
            label1.Text = phones;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
