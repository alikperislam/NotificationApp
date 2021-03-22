using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Notifications_bildirimEkranı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
                                                      // zaten görseli daha öncesinden ayarlardan ekledik.
                                                      // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.

            popp.ContentText = "github.com/alikperislam"; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.DarkGray;
            popp.Image = Properties.Resources.github; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
                                                      // zaten görseli daha öncesinden ayarlardan ekledik.
                                                      // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.

            popp.ContentText = "+ 90 (xxx) xxx xx xx"; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.LightSeaGreen;
            popp.Image = Properties.Resources.wp; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            
            popp.ContentText = "alikperislam"; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.Pink;
            popp.Image = Properties.Resources.insta; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            if (txtIstanbul.Text=="" || txtAnkara.Text=="" || txtIzmir.Text=="" || txtAdana.Text=="" || txtBursa.Text=="" || txtAntalya.Text=="")
            {
                MessageBox.Show("TÜM NÜFUS BİLGİLERİNİ GİRMENİZ GEREKMEKTEDİR !!");
            }
            else
            {
                int ist, ank, iz, bur, ant, ada;

                ist = int.Parse(txtIstanbul.Text);
                ank = int.Parse(txtAnkara.Text);
                iz = int.Parse(txtIzmir.Text);
                ada = int.Parse(txtAdana.Text);
                bur = int.Parse(txtBursa.Text);
                ant = int.Parse(txtAntalya.Text);

                chart1.Series["NÜFUS"].Points.AddXY("İstanbul", ist);
                chart1.Series["NÜFUS"].Points.AddXY("Ankara", ank);
                chart1.Series["NÜFUS"].Points.AddXY("İzmir", iz);
                chart1.Series["NÜFUS"].Points.AddXY("Adana", ada);
                chart1.Series["NÜFUS"].Points.AddXY("Bursa", bur);
                chart1.Series["NÜFUS"].Points.AddXY("Antalya", ant);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            string istan;
            istan = txtIstanbul.Text;
            popp.ContentText ="2020 sayımına göre İstanbul'un nüfusu :"+" "+istan+" olarak ölçülmüştür."; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.DarkViolet;
            popp.Image = Properties.Resources.person; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            string anka;
            anka = txtAnkara.Text;
            popp.ContentText = "2020 sayımına göre Ankara'nın nüfusu :" + " " + anka + " olarak ölçülmüştür."; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.Turquoise;
            popp.Image = Properties.Resources.person; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            string izmi;
            izmi = txtIzmir.Text;
            popp.ContentText = "2020 sayımına göre İzmir'in nüfusu :" + " " + izmi + " olarak ölçülmüştür."; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.Gold;
            popp.Image = Properties.Resources.person; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            string ada;
            ada = txtAdana.Text;
            popp.ContentText = "2020 sayımına göre Adana'nın nüfusu :" + " " + ada + " olarak ölçülmüştür."; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.Salmon;
            popp.Image = Properties.Resources.person; // bir resim girdik properties içerisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            string burr;
            burr = txtBursa.Text;
            popp.ContentText = "2020 sayımına göre Bursa'nın nüfusu :" + " " + burr + " olarak ölçülmüştür."; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.Green;
            popp.Image = Properties.Resources.person; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // projeye install kısmından notification window olarak ekledik indirerekten.
            PopupNotifier popp = new PopupNotifier(); // notification göndercek olan kütüphaneyi import ediyoruz. 
            // zaten görseli daha öncesinden ayarlardan ekledik.
            // popp.TitleText ="İstanbul Nüfusu"; // bildirimin başlığı.
            string antt;
            antt = txtIstanbul.Text;
            popp.ContentText = "2020 sayımına göre Antalya'nın nüfusu :" + " " + antt + " olarak ölçülmüştür."; // bildirim olarak verilecek olan yazı metni.
            popp.BodyColor = Color.OrangeRed;
            popp.Image = Properties.Resources.person; // bir resim girdik properties içeriisine ve properties'a ulaşarak o resmi popup'a aldık.
            popp.Popup();// popup'ı göster anlamında bir method.
        }
    }
}
