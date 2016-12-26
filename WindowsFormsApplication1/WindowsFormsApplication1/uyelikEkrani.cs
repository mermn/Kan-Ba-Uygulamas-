using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class uyelikEkrani : Form
    {
        int sayac = 0;
        public uyelikEkrani()
        {
            InitializeComponent();
            comboBox1.Items.Add("0 RH +");
            comboBox1.Items.Add("0 RH -");
            comboBox1.Items.Add("A RH +");
            comboBox1.Items.Add("A RH -");
            comboBox1.Items.Add("B RH +");
            comboBox1.Items.Add("B RH -");
            comboBox1.Items.Add("AB- RH +");
            comboBox1.Items.Add("AB+ RH -");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        //TELEFON KONTROL YERİ
        private bool IsPhoneNumber(string input)
        {
            string pattern = @"^(0(\d{3}) (\d{3}) (\d{2}) (\d{2}))$";
            Match match = Regex.Match(input, pattern, RegexOptions.IgnoreCase);

            return match.Success;
        }

        //EMAİL KONTROL YERİ
        static bool EmailKontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }




        //BUTTONA BASTIKTAN SONRA YAPILICAK İŞLEMLER
        String cs = @"Data Source=yazilim.database.windows.net;Initial Catalog=MyDatabase;Integrated Security=False;User ID=ali;Password=Qwe123qwe;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void button2_Click(object sender, EventArgs e)
        {
            //SİFRE KONTROL YERİ
            if(tbSifre.Text!=tbSifreD.Text)
            {
                MessageBox.Show("Şifreleriniz Uyuşmamaktadır.");
            }
            else
            {
                sayac++;
            }


            //EMAİL KONTROL YERİ
            bool kontrol = EmailKontrol(tbMail.Text);

            if (kontrol == true)
            {
                sayac++;
            }
            else
            {
                MessageBox.Show("Mail Adresi Formatınız Yanlış");
                tbMail.Clear();
                return;
            }

            //EMAİL CONFİRM
            if(tbMail.Text!=tbMailC.Text)
            {
                MessageBox.Show("Mail adresleriniz uyuşmamaktadır");
                tbMailC.Clear();
                return;
            }
            else
            {
                sayac++;
            }

            //TELEFON KONTROL YERİ
            if (IsPhoneNumber(tbTelNo.Text))
            {
                sayac++;
            }
            else
            {
                MessageBox.Show("Telefon numarası: 0XXX XXX XX XX formatında olmalı.");
                tbTelNo.Clear();
                return;
            }

            //TC KİMLİK KONTROL YERİ
            string tckimlik;
            try
            {
                tckimlik = tbTCKimlik.Text;
                int index = 0;
                int toplam = 0;
                foreach (char n in tckimlik)
                {
                    if (index < 10)
                    {
                        toplam += Convert.ToInt32(char.ToString(n));
                    }
                    index++;
                }
                if (toplam % 10 == Convert.ToInt32(tckimlik[10].ToString()))
                {
                    sayac++;
                }
                else
                {
                    MessageBox.Show("Geçersiz Tc Kimlik Numarası");
                    tbTCKimlik.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Tc kimlik numarası 11 haneli değil");
                tbTCKimlik.Clear();
            }
            if(sayac==5)
            {
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("insert into tbl_uye values (@TC,@Ad,@Tel,@email,@password,@kan)", con);
                    cmd.Parameters.AddWithValue("@TC", tbTCKimlik.Text);
                    cmd.Parameters.AddWithValue("@Ad", tbAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@email", tbMail.Text);
                    cmd.Parameters.AddWithValue("@password", tbSifre.Text);
                    cmd.Parameters.AddWithValue("@Tel", tbTelNo.Text);
                    cmd.Parameters.AddWithValue("@kan", comboBox1.Text);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;

                    if (count == 1)
                    {
                        MessageBox.Show("Giriş Başarısız!");
                        this.Hide();
                        
                    }
                    else
                    {
                        MessageBox.Show("Giriş Başarılı!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //Rastgele Kod Üretme
                Random rastgele = new Random();
                int kod = rastgele.Next(10000000, 99999999);
                //Kodu .txt dosyasına yazma
                try
                {
                    Directory.CreateDirectory("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1");
                }
                catch(Exception)
                {
                    MessageBox.Show("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1\\dosya.txt oluşturma işlemi gerçekleşemedi. Sorun için dosyanın bulunduğu dosya konumunu kontrol ediniz.");
                }
                StreamWriter SW = new StreamWriter("C:\\Users\\Erman\\Desktop\\WindowsFormsApplication1\\dosya.txt");
                SW.WriteLine(kod);
                SW.Close();





                var fromAddress = new MailAddress("kanbagislama@gmail.com", "Kan Bağışla");
                var toAddress = new MailAddress(tbMail.Text, "Sayın Kullanıcı");
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
                using (var message = new MailMessage("kanbagislama@gmail.com", tbMail.Text)
                {
                    Subject = "Mail doğrulama işlemini yapınız",
                    Body = "\n\nTC Kimlik Numaranız : " + tbTCKimlik.Text + "\nAdınız , Soyadınız : " + tbAdSoyad.Text + "\nTelefon Numaranız : " + tbTelNo.Text + "\nŞifreniz : " + tbSifre.Text + "\nKan Grubunuz : " + comboBox1.Text+"\n\n\n Doğrulama Kodunuz : "+kod
                })
                {
                    smtp.Send(message);
                }




                MessageBox.Show("Mailinizi doğrulayınız.");
                mailDogrula maildogrula = new mailDogrula();
                maildogrula.Show();
               // this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
