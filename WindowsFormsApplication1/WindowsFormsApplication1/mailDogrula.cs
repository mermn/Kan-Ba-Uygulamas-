using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class mailDogrula : Form
    {

        public string tc
        {
            set { lblTCKimlik.Text = value; }
        }
        public string mail
        {
            set { lblMail.Text = value; }
        }
        public string sifre
        {
            set { lblSifre.Text = value; }
        }
        public string kan
        {
            set { lblComboBox1.Text = value; }
        }
        public string ad
        {
            set { lblAdSoyad.Text = value; }
        }
        public string tel
        {
            set { lblTelNo.Text = value; }
        }

        public mailDogrula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyelikEkrani uyelikEkrani = new uyelikEkrani();
            uyelikEkrani.Show();
            this.Close();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            


            StreamReader SR = new StreamReader("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1\\dosya.txt");
            string sifre = SR.ReadLine();
            SR.Close();
            
            if (sifre == textBox1.Text)
            {
                MessageBox.Show("Üyelik İşlemleriniz Tamamlanmıştır !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Kod Hatalıdır !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mail = lblMail.Text;
            string TC = lblTCKimlik.Text;
            string ad = lblAdSoyad.Text;
            string sifre2 = lblSifre.Text;
            string kan = lblComboBox1.Text;
            string telefon = lblTelNo.Text;
            //Rastgele Kod Üretme
            Random rastgele = new Random();
            int kod = rastgele.Next(10000000, 99999999);
            //Kodu .txt dosyasına yazma
            try
            {
                Directory.CreateDirectory("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1");
            }
            catch (Exception)
            {
                MessageBox.Show("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1\\dosya.txt oluşturma işlemi gerçekleşemedi. Sorun için dosyanın bulunduğu dosya konumunu kontrol ediniz.");
            }
            StreamWriter SW = new StreamWriter("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1\\dosya.txt");
            SW.WriteLine(kod);
            SW.Close();





            var fromAddress = new MailAddress("kanbagislama@gmail.com", "Kan Bağışla");
            var toAddress = new MailAddress(mail, "Sayın Kullanıcı");
            const string fromPassword = "kan159bagis753;";
            const string subject = "Mail doğrulama işlemini yapınız";
            const string body = "I don't wan't your body, i don't wan't nobody baby :)";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("kanbagislama@gmail.com", "kan159bagis753;")
            };
            using (var message = new MailMessage("kanbagislama@gmail.com", mail)
            {
                Subject = "Mail doğrulama işlemini yapınız",
                Body = "\n\nTC Kimlik Numaranız : " + TC + "\nAdınız , Soyadınız : " + ad + "\nTelefon Numaranız : " + telefon + "\nŞifreniz : " + sifre2 + "\nKan Grubunuz : " + kan + "\n\n\n Doğrulama Kodunuz : " + kod
            })
            {
                smtp.Send(message);
            }




            MessageBox.Show("Mailinizi doğrulayınız.");
            //mailDogrula maildogrula = new mailDogrula();
            //maildogrula.Show();
            // this.Hide();
        }
    }
}
