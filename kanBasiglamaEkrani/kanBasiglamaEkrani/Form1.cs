using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanBasiglamaEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region iller
            cbil.Items.Add("01. Adana");
            cbil.Items.Add("02. Adıyaman");
            cbil.Items.Add("03. Afyonkarahisar");
            cbil.Items.Add("04. Ağrı");
            cbil.Items.Add("05. Amasya");
            cbil.Items.Add("06. Ankara");
            cbil.Items.Add("07. Antalya");
            cbil.Items.Add("08. Artvin");
            cbil.Items.Add("09. Aydın");
            cbil.Items.Add("10. Balıkesir");
            cbil.Items.Add("11. Bilecik");
            cbil.Items.Add("12. Bingöl");
            cbil.Items.Add("13. Bitlis");
            cbil.Items.Add("14. Bolu");
            cbil.Items.Add("15. Burdur");
            cbil.Items.Add("16. Bursa");
            cbil.Items.Add("17. Çanakkale");
            cbil.Items.Add("18. Çankırı");
            cbil.Items.Add("19. Çorum");
            cbil.Items.Add("20. Denizli");
            cbil.Items.Add("21. Diyarbakır");
            cbil.Items.Add("22. Edirne");
            cbil.Items.Add("23. Elazığ");
            cbil.Items.Add("24. Erzincan");
            cbil.Items.Add("25. Erzurum");
            cbil.Items.Add("26. Eskişehir");
            cbil.Items.Add("27. Gaziantep");
            cbil.Items.Add("28. Giresun");
            cbil.Items.Add("29. Gümüşhane");
            cbil.Items.Add("30. Hakkari");
            cbil.Items.Add("31. Hatay");
            cbil.Items.Add("32. Isparta");
            cbil.Items.Add("33. Mersin");
            cbil.Items.Add("34. İstanbul");
            cbil.Items.Add("35. İzmir");
            cbil.Items.Add("36. Kars");
            cbil.Items.Add("37. Kastamonu");
            cbil.Items.Add("38. Kayseri");
            cbil.Items.Add("39. Kırklareli");
            cbil.Items.Add("40. Kırşehir");
            cbil.Items.Add("41. Kocaeli");
            cbil.Items.Add("42. Konya");
            cbil.Items.Add("43. Kütahya");
            cbil.Items.Add("44. Malatya");
            cbil.Items.Add("45. Manisa");
            cbil.Items.Add("46. Kahramanmaraş");
            cbil.Items.Add("47. Mardin");
            cbil.Items.Add("48. Muğla");
            cbil.Items.Add("49. Muş");
            cbil.Items.Add("50. Nevşehir");
            cbil.Items.Add("51. Niğde");
            cbil.Items.Add("52. Ordu");
            cbil.Items.Add("53. Rize");
            cbil.Items.Add("54. Sakarya");
            cbil.Items.Add("55. Samsun");
            cbil.Items.Add("56. Siirt");
            cbil.Items.Add("57. Sinop");
            cbil.Items.Add("58. Sivas");
            cbil.Items.Add("59. Tekirdağ");
            cbil.Items.Add("60. Tokat");
            cbil.Items.Add("61. Trabzon");
            cbil.Items.Add("62. Tunceli");
            cbil.Items.Add("63. Şanlıurfa");
            cbil.Items.Add("64. Uşak");
            cbil.Items.Add("65. Van");
            cbil.Items.Add("66. Yozgat");
            cbil.Items.Add("67. Zonguldak");
            cbil.Items.Add("68. Aksaray");
            cbil.Items.Add("69. Bayburt");
            cbil.Items.Add("70. Karaman");
            cbil.Items.Add("71. Kırıkkale");
            cbil.Items.Add("72. Batman");
            cbil.Items.Add("73. Şırnak");
            cbil.Items.Add("74. Bartın");
            cbil.Items.Add("75. Ardahan");
            cbil.Items.Add("76. Iğdır");
            cbil.Items.Add("77. Yalova");
            cbil.Items.Add("78. Karabük");
            cbil.Items.Add("79. Kilis");
            cbil.Items.Add("80. Osmaniye");
            cbil.Items.Add("81. Düzce");
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cbil.Text!="")
            {
                if(cbilce.Text!="")
                {
                    if(cbHastane.Text!="")
                    {
                        MessageBox.Show("Seçim işlemleriniz aşağıdaki gibidir \n\nSeçtiğiniz il              : " + cbil.Text + "\nSeçtiğiniz İlçe          : " + cbilce.Text + "\nSeçtiğiniz Hastane : " + cbHastane.Text);
                        //DB bağlantıları yapılacaktır
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hastane bilgilerini giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("İlçe ve hastane bilgilerini giriniz.");
                }
            }
            else
            {
                MessageBox.Show("İl, ilçe ve hastane bilgilerini giriniz.");
            }
        }

        private void cbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbilce.Items.Clear();
            cbHastane.Items.Clear();
            cbHastane.Enabled = true;
            #region 01. Adana
            if (cbil.Text == "01. Adana")
            {
                cbilce.Items.Add("01. Aladağ");
                cbilce.Items.Add("02. Ceyhan");
                cbilce.Items.Add("03. Çukurova");
                cbilce.Items.Add("04. Feke");
                cbilce.Items.Add("05. İmamoğlu");
                cbilce.Items.Add("06. Karaisalı");
                cbilce.Items.Add("07. Karataş");
                cbilce.Items.Add("08. Kozan");
                cbilce.Items.Add("09. Pozantı");
                cbilce.Items.Add("10. Saimbeyli");
                cbilce.Items.Add("11. Sarıçam");
                cbilce.Items.Add("12. Seyhan");
                cbilce.Items.Add("13. Tufanbeyli");
                cbilce.Items.Add("14. Yumurtalık");
                cbilce.Items.Add("15. Yüreğir");
            }
            #endregion
            #region 02. Adıyaman
            if (cbil.Text == "02. Adıyaman")
            {
                cbilce.Items.Add("Merkez");
                cbilce.Items.Add("01. Besni");
                cbilce.Items.Add("02. Çelikhan");
                cbilce.Items.Add("03. Gerger");
                cbilce.Items.Add("04. Gölbaşı");
                cbilce.Items.Add("05. Kahta");
                cbilce.Items.Add("06. Samsat");
                cbilce.Items.Add("07. Sincik");
                cbilce.Items.Add("08. Tut");
            }
            #endregion
            #region 03. Afyonkarahisar
            if (cbil.Text == "03. Afyonkarahisar")
            {
                cbilce.Items.Add("Merkez");
                cbilce.Items.Add("01. Başmakçı");
                cbilce.Items.Add("02. Bayat");
                cbilce.Items.Add("03. Bolvadin");
                cbilce.Items.Add("04. Çay");
                cbilce.Items.Add("05. Çobanlar");
                cbilce.Items.Add("06. Dazkırı");
                cbilce.Items.Add("07. Dinar");
                cbilce.Items.Add("08. Emirdağ");
                cbilce.Items.Add("09. Evciler");
                cbilce.Items.Add("10. Hocalar");
                cbilce.Items.Add("11. İhsaniye");
                cbilce.Items.Add("12. İscehisar");
                cbilce.Items.Add("13. Kızılören");
                cbilce.Items.Add("14. Sandıklı");
                cbilce.Items.Add("15. Sinanpaşa");
                cbilce.Items.Add("16. Şuhut");
                cbilce.Items.Add("17. Sultandağı");
            }
            #endregion
        }

        private void cbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void cbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHastane.Items.Clear();
            cbHastane.Enabled = true;
            #region 01. Adana
            if ((cbil.Text == "01. Adana")&&(cbilce.Text == "01. Aladağ"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adana Aladağ ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "02. Ceyhan"))
            {
                cbHastane.Items.Add("CEYHAN DEVLET HASTANESİ");
                cbHastane.Items.Add("ÖZEL CEYHAN ÇINAR HASTANESİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "03. Çukurova"))
            {
                cbHastane.Items.Add("ÖZEL AVRUPA HOSPİTAL ADANA");
                cbHastane.Items.Add("ÖDEL DERMANCAN TIP MERKEZİ");
                cbHastane.Items.Add("ÖDEL ADANA CERRAHİ TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL ADANA ODAK TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL ÇUKUROVA DİYALİZ MERKEZİ");
                cbHastane.Items.Add("ÖZEL RTS SEYHAN DİYALİZ MERKEZİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "04. Feke"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adana Feke ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "05. İmamoğlu"))
            {
                cbHastane.Items.Add("İMAMOĞLU DEVLET HASTANESİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "06. Karaisalı"))
            {
                cbHastane.Items.Add("KARAİSALI DEVLET HASTANESİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "07. Karataş"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adana Karataş ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "08. Kozan"))
            {
                cbHastane.Items.Add("KOZAN DEVLET HASTANESİ");
                cbHastane.Items.Add("ÖZEL KOZAN ORTADOĞU HASTANESİ");
                cbHastane.Items.Add("ÖZEL KALEPARK HASTANESİ");
                cbHastane.Items.Add("ÖZEL KOZAN DİYALİZ MERKEZİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "09. Pozantı"))
            {
                cbHastane.Items.Add("POZANTI 80. YIL DEVLET HASTANESİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "10. Saimbeyli"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adana Saimbeyli ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "11. Sarıçam"))
            {
                cbHastane.Items.Add("ÖZEL BATIKENT TIP MERKEZİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "12. Seyhan"))
            {
                cbHastane.Items.Add("BAŞKENT ÜNİVERSİTESİ SEYHAN HASTANESİ");
                cbHastane.Items.Add("ÇUKUROVA ÜNİVERSİTESİ TIP FAKÜLTESİ BALCALI HASTANESİ");
                cbHastane.Items.Add("ADANA ÇUKUROVA DEVLET HASTANESİ");
                cbHastane.Items.Add("ÖZEL ADANA METRO HASTANESİ");
                cbHastane.Items.Add("ÖZEL ADANA HASTANESİ");
                cbHastane.Items.Add("ÖZEL ACIBADEM ADANA HASTANESİ");
                cbHastane.Items.Add("ÖZEL ORTADOĞU HASTANESİ");
                cbHastane.Items.Add("ÖZEL GÜNEY ADANA HASTANESİ");
                cbHastane.Items.Add("ÖZEL MEDLİNE ADANA HASTANESİ");
                cbHastane.Items.Add("ÖZEL EPC HASTANESİ");
                cbHastane.Items.Add("ÖZEL TÜRKMENBAŞI TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL ADANA YAŞAM TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL HACETTEPELİLER CERRAHİ TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL ÖMÜR TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL HAYAT TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL ADANA ŞİFA TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL SEYHAN TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL FMC ADANA SEYHAN DİYALİZ MERKEZİ");
                cbHastane.Items.Add("ÖZEL ADANA KOÇ DİYALİZ MERKEZİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "13. Tufanbeyli"))
            {
                cbHastane.Items.Add("TUFANBEYLİ DEVLET HASTANESİ");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "14. Yumurtalık"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adana Yumurtalık ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "15. Yüreğir"))
            {
                cbHastane.Items.Add("BAŞKENT ÜNİVERSİTESİ ADANA UYGULAMA VE ARAŞTIRMA MERKEZİ");
                cbHastane.Items.Add("ADANA DEVLET HASTANESİ");
                cbHastane.Items.Add("ADANA NUMUNE EĞİTİM VE ARAŞTIRMA HASTANESİ");
                cbHastane.Items.Add("ÖZEL ALGOMED HASTANESİ");
                cbHastane.Items.Add("ÖZEL ALTINKOZA TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL ÖZÜLKÜ TIP MERKEZI");
                cbHastane.Items.Add("ÖZEL İSA ALATAŞ TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL FMC ADANA YÜREĞİR DİYALİZ MERKEZİ");
            }
            #endregion
            #region 02. Adıyaman
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "Merkez"))
            {
                cbHastane.Items.Add("ADIYAMAN ÜNİVERSİTESİ EĞİTİM VE ARAŞTIRMA HASTANESİ");
                cbHastane.Items.Add("ÖZEL GÖZDE ADIYAMAN HASTANESİ");
                cbHastane.Items.Add("ÖZEL ADIYAMAN PARK HOSPİTAL");
                cbHastane.Items.Add("ÖZEL FMC ADIYAMAN DİYALİZ MERKEZİ");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "01. Besni"))
            {
                cbHastane.Items.Add("BESNİ DEVLET HASTANESİ");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "02. Çelikhan"))
            {
                cbHastane.Items.Add("ÇELİKHAN DEVLET HASTANESİ");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "03. Gerger"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adıyaman Gerger ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "04. Gölbaşı"))
            {
                cbHastane.Items.Add("ADIYAMAN GÖLBAŞI DEVLET HASTANESİ");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "05. Kahta"))
            {
                cbHastane.Items.Add("KAHTA DEVLET HASTANESİ");
                cbHastane.Items.Add("ÖZEL KAHTA PARK MEDİKAL TIP MERKEZİ");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "06. Samsat"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adıyaman Samsat ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "07. Sincik"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Adıyaman Sincik ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "02. Adıyaman") && (cbilce.Text == "08. Tut"))
            {
                cbHastane.Items.Add("TUT DEVLET HASTANESİ");
            }
            #endregion
            #region 03. Afyonkarahisar
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "Merkez"))
            {
                cbHastane.Items.Add("AFYON KOCATEPE ÜNİVERSİTESİ HASTANESİ");
                cbHastane.Items.Add("AFYONKARAHİSAR DEVLET HASTANESİ");
                cbHastane.Items.Add("ÖZEL AFYON FUAR HASTANESİ");
                cbHastane.Items.Add("ÖZEL AFYON PARK HASTANESİ");
                cbHastane.Items.Add("ÖZEL AFYON PARK TIP MERKEZİ");
                cbHastane.Items.Add("ÖZEL AFYON DİYALİZ MERKEZİ");
                cbHastane.Items.Add("ÖZEL AFYONCAN DİYALİZ MERKEZİ");
                cbHastane.Items.Add("ÖZEL UMUT POLİKLİNİĞİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "01. Başmakçı"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Başmakçı ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "02. Bayat"))
            {
                cbHastane.Items.Add("DR. METE TAN BAYAT DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "03. Bolvadin"))
            {
                cbHastane.Items.Add("DR. HALİL İBRAHİM ÖZSOY BOLVADİN DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "04. Çay"))
            {
                cbHastane.Items.Add("ÇAY DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "05. Çobanlar"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Çobanlar ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "06. Dazkırı"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Dazkırı ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "07. Dinar"))
            {
                cbHastane.Items.Add("HAYDARLI DEVLET HASTANESİ");
                cbHastane.Items.Add("DİNAR DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "08. Emirdağ"))
            {
                cbHastane.Items.Add("EMİRDAĞ DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "09. Evciler"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Evciler ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "10. Hocalar"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Hocalar ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "11. İhsaniye"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar İhsaniye ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "12. İscehisar"))
            {
                cbHastane.Items.Add("İSCEHİSAR DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "13. Kızılören"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Kızılören ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "14. Sandıklı"))
            {
                cbHastane.Items.Add("SANDIKLI DEVLET HASTANESİ");
                cbHastane.Items.Add("ÖZEL SANDIKLI DİYALİZ MERKEZİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "15. Sinanpaşa"))
            {
                cbHastane.Items.Add("SİNANPAŞA DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "16. Şuhut"))
            {
                cbHastane.Items.Add("ŞUHUT DEVLET HASTANESİ");
            }
            if ((cbil.Text == "03. Afyonkarahisar") && (cbilce.Text == "17. Sultandağı"))
            {
                cbHastane.Enabled = false;
                MessageBox.Show("Afyonkarahisar Sultandağı ilçesinde hastane veya diğer sağlık kurumu bulunamamıştır.");
            }
            #endregion
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if((cbil.Text=="01. Adana")&&(cbilce.Text=="02. Ceyhan")&&(cbHastane.Text=="CEYHAN DEVLET HASTANESİ"))
            {
                System.Diagnostics.Process.Start("https://www.google.com.tr/maps/place/Ceyhan+Devlet+Hastanesi/@37.0265397,35.8191982,15z/data=!4m5!3m4!1s0x0:0xbf03fead967d4400!8m2!3d37.0265397!4d35.8191982");
                /*
                string il = "Adana";
                string ilce = "Ceyhan";
                string hastane = "CEYHAN DEVLET HASTANESİ";
                StringBuilder add = new StringBuilder("http://maps.google.com/maps?q=");
                add.Append(il);
                add.Append(ilce);
                add.Append(hastane);
                webBrowser1.Navigate(add.ToString());*/
            }
            if ((cbil.Text == "01. Adana") && (cbilce.Text == "02. Ceyhan") && (cbHastane.Text == "ÖZEL CEYHAN ÇINAR HASTANESİ"))
            {
                System.Diagnostics.Process.Start("https://www.google.com.tr/maps/place/%C3%96zel+%C3%87%C4%B1nar+Hastanesi/@37.019269,35.8235179,15z/data=!4m5!3m4!1s0x0:0xe7fe2fbe9f519ad6!8m2!3d37.019269!4d35.8235179");
            }
        }
    }
}
