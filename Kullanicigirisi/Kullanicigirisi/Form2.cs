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

namespace Kullanicigirisi
{
    public partial class Form2 : Form
    {
        int sayac = 0;
        static bool EmailKontrol(string inputEmail)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            return (new Regex(strRegex)).IsMatch(inputEmail);
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        String cs = @"Data Source=yazilim.database.windows.net;Initial Catalog=MyDatabase;Integrated Security=False;User ID=ali;Password=Qwe123qwe;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void button1_Click(object sender, EventArgs e)
        {
            //SİFRE KONTROL YERİ
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Şifreleriniz Uyuşmamaktadır.");
            }
            else
            {
                sayac++;
            }


            //EMAİL KONTROL YERİ
            bool kontrol = EmailKontrol(textBox2.Text);

            if (kontrol == true)
            {
                sayac++;
            }
            else
            {
                MessageBox.Show("Mail Adresi Formatınız Yanlış");
                textBox2.Clear();
                return;
            }
            //TC KİMLİK KONTROL YERİ
            string tckimlik;
            try
            {
                tckimlik = textBox1.Text;
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
                    textBox1.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Tc kimlik numarası 11 haneli değil");
                textBox1.Clear();
            }
            if (sayac == 3)
            {
                try
                {
                    //Create SqlConnection
                    SqlConnection con = new SqlConnection(cs);
                    SqlCommand cmd = new SqlCommand("update tbl_uye set password=@password where TC=@TC", con);
                    cmd.Parameters.AddWithValue("@TC", textBox1.Text);
                    cmd.Parameters.AddWithValue("@password", textBox3.Text);
                    con.Open();
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    MessageBox.Show("İşlem Başarılı.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}