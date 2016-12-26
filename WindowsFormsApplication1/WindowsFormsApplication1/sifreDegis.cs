using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class sifreDegis : Form
    {
        public sifreDegis()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbEskiSifre.Text.Length>=17)
            {
                MessageBox.Show("Giriş Yaptığınız Eski Şifre 16 Haneden büyüktür !");
                tbEskiSifre.Clear();
            }
            else
            {
                if(tbYeniSifre.Text.Length>=17)
                {
                    MessageBox.Show("Giriş Yaptığınız Yeni Şifre 16 Haneden büyüktür !");
                    tbYeniSifre.Clear();
                }
                else
                {
                    if(tbYeniSifreD.Text.Length>=17)
                    {
                        MessageBox.Show("Giriş Yaptığınız Doğrulama Şifresi 16 Haneden büyüktür !");
                        tbYeniSifreD.Clear();
                    }
                    else
                    {
                        if (tbYeniSifre.Text != tbYeniSifreD.Text)
                        {
                            MessageBox.Show("Yeni Girdiğiniz Şifreler Uyuşmamaktadır !\nLütfen Şifrenizin Doğruluğunu Kontrol Ediniz.");
                            tbYeniSifre.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Şifreniz Başarıyla Değiştirilmiştir.");
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
