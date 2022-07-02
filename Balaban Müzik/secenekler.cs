using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;




namespace Balaban_Müzik
{
    public partial class secenekler : Form
    {
        string ProgramAdi = "Balaban Müzik";

        public secenekler()
        {
            InitializeComponent();

       
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                if (key.GetValue(ProgramAdi).ToString() == "\"" + Application.ExecutablePath + "\"")
                {
                    checkBox1.Checked = true;
                }
            }
            catch
            {

            }
        }

        private void secenekler_Load(object sender, EventArgs e)
        {
            string bilgisayarAdi = Dns.GetHostName();
            label5.Text = "Bilgisayar Adı: " + bilgisayarAdi;
            string ipAdresi = Dns.GetHostByName(bilgisayarAdi).AddressList[0].ToString();
            label6.Text = "IP Adresi " + ipAdresi;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (Application.OpenForms[0] == this)//Uygulamanin main form'u
            {
                //uygulamanin ana formunu kapatirsaniz uygulama kapanir, ana formu yeniden baslatmak uygulamayi yeniden baslatmak demektir.
                Application.Restart();
            }
            else
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
        }


        public string PC_NeZamandirAcik()
        {
            String cevap = String.Empty;
            cevap += Convert.ToString(Environment.TickCount / 86400000) + " gün, ";
            cevap += Convert.ToString(Environment.TickCount / 3600000 % 24) + " saat, ";
            cevap += Convert.ToString(Environment.TickCount / 120000 % 60) + " dakika, ";
            cevap += Convert.ToString(Environment.TickCount / 1000 % 60) + " saniye.";
            return cevap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = PC_NeZamandirAcik();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }

    
}
