/*****************************************************************************************************************************************************
**					                                            SAKARYA ÜNİVERSİTESİ                                                                **
**				                                     BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                                      **
**				                                           BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                           **
**				                                          NESNEYE DAYALI PROGRAMLAMA DERSİ                                                          **
**					                                         2019-2020 BAHAR DÖNEMİ                                                                 **
**	                                                                                                                                                **
**				                                            ÖDEV NUMARASI..........: Proje Ödevi                                                              **
**				                                            ÖĞRENCİ ADI............: MERT SIĞIRCI                                                   **
**				                                            ÖĞRENCİ NUMARASI.......: B191210078                                                     **
**                                                          DERSİN ALINDIĞI GRUP...: 1/A                                                            **
*****************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Atık_Oyunu
{
    public partial class Form1 : Form
    {
        CamBardak bardak;
        CamSise sise;
        Dergi dergi;
        Gazete gazete;
        Domates domates;
        Salatalik salatalik;
        KolaKutusu kolaKutusu;
        SalcaKutusu salcaKutusu;

        OrganikAtikKutusu organikAtikKutusu;
        MetalAtikKutusu metalAtikKutusu;
        KagitAtikKutusu kagitAtikKutusu;
        CamAtikKutusu camAtikKutusu;

        int puan = 0;
        string yol;


        public Form1()
        {
            InitializeComponent();

            organikBosaltButton.Enabled = false;
            metalBosaltButton.Enabled = false;
            camBosaltButton.Enabled = false;
            kagitBosaltButton.Enabled = false;

            organikButton.Enabled = false;
            metalButton.Enabled = false;
            camButton.Enabled = false;
            kagitButton.Enabled = false;

            bardak = new CamBardak();
            sise = new CamSise();
            dergi = new Dergi();
            gazete = new Gazete();
            domates = new Domates();
            salatalik = new Salatalik();
            kolaKutusu = new KolaKutusu();
            salcaKutusu = new SalcaKutusu();

            organikAtikKutusu = new OrganikAtikKutusu();
            camAtikKutusu = new CamAtikKutusu();
            kagitAtikKutusu = new KagitAtikKutusu();
            metalAtikKutusu = new MetalAtikKutusu();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timerLabel.Text = "60";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sure = int.Parse(timerLabel.Text);
            sure--;
            timerLabel.Text = Convert.ToString(sure);

            if (int.Parse(timerLabel.Text) == 0) //Süre bittiğinde kullanıcıya bildirim gönderip listboxları, dolu hacimleri, progressbarları, puanı ve sayacı sıfırladık. Ayrıca ekle ve boşalt butonlarını pasifleştirdik. 
            {
                timer1.Stop();


                MessageBox.Show("SÜRENİZ DOLDU. YENİ OYUN BUTONUNA BASARAK TEKRAR OYNAYABİLİRSİNİZ.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Kullanıcının skorunu görebilmesi için uyarıdan sonra değerleri sıfırladık.

                timerLabel.Text = "60";
                puanLabel.Text = "0";

                organikBosaltButton.Enabled = false;
                metalBosaltButton.Enabled = false;
                camBosaltButton.Enabled = false;
                kagitBosaltButton.Enabled = false;
                yeniOyunButton.Enabled = true;

                organikButton.Enabled = false;
                metalButton.Enabled = false;
                camButton.Enabled = false;
                kagitButton.Enabled = false;

                metalListBox.Items.Clear();
                kagitListBox.Items.Clear();
                camListBox.Items.Clear();
                organikListBox.Items.Clear();

                metalProgressBar.Value = 0;
                kagitProgressBar.Value = 0;
                camProgressBar.Value = 0;
                organikProgressBar.Value = 0;

                metalAtikKutusu.DoluHacim = 0;
                kagitAtikKutusu.DoluHacim = 0;
                camAtikKutusu.DoluHacim = 0;
                organikAtikKutusu.DoluHacim = 0;
            }


        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniOyunButton_Click(object sender, EventArgs e)
        {
            puanLabel.Text = "0";
            puanLabel.BackColor = Color.LightSlateGray;

            timerLabel.Text = "60";
            timerLabel.BackColor = Color.LightSlateGray;
            timer1.Start();

            Random random = new Random();           
            yol = random.Next(1, 9) + ".jpg";   // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
            pictureBox1.ImageLocation = yol;         

            organikButton.Enabled = true;
            metalButton.Enabled = true;
            camButton.Enabled = true;
            kagitButton.Enabled = true;

            organikBosaltButton.Enabled = true;
            metalBosaltButton.Enabled = true;
            camBosaltButton.Enabled = true;
            kagitBosaltButton.Enabled = true;
            yeniOyunButton.Enabled = false;
        }

        private void organikButton_Click(object sender, EventArgs e)
        {
            if (yol == "4.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (organikAtikKutusu.Ekle(domates)) //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    organikListBox.Items.Add($@"Domates({domates.Hacim})");
                    puan += domates.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg"; // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    organikProgressBar.Value = organikAtikKutusu.DolulukOrani;
                }
            }

            else if (yol == "7.jpg") //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (organikAtikKutusu.Ekle(salatalik)) //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    organikListBox.Items.Add($@"Salatalık({salatalik.Hacim})");
                    puan += salatalik.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg";  // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    organikProgressBar.Value = organikAtikKutusu.DolulukOrani;
                }
            }
        }

        private void kagitButton_Click(object sender, EventArgs e)
        {
            if (yol == "3.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (kagitAtikKutusu.Ekle(dergi)) //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    kagitListBox.Items.Add($@"Dergi({dergi.Hacim})");
                    puan += dergi.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg";   // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    kagitProgressBar.Value = kagitAtikKutusu.DolulukOrani;
                }    
            }

            else if (yol == "5.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (kagitAtikKutusu.Ekle(gazete))  //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    kagitListBox.Items.Add($@"Gazete({gazete.Hacim})");
                    puan += gazete.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg";  // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    kagitProgressBar.Value = kagitAtikKutusu.DolulukOrani;
                }  
            }
        }

        private void camButton_Click(object sender, EventArgs e)
        {
            if (yol == "1.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (camAtikKutusu.Ekle(bardak)) //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    camListBox.Items.Add($@"Cam Bardak({bardak.Hacim})");
                    puan += bardak.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg"; // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    camProgressBar.Value = camAtikKutusu.DolulukOrani;
                }
            }

            else if (yol == "8.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (camAtikKutusu.Ekle(sise))  //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    camListBox.Items.Add($@"Cam Şişe({sise.Hacim})");
                    puan += sise.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg";  // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    camProgressBar.Value = camAtikKutusu.DolulukOrani;
                }
            }
        }

        private void metalButton_Click(object sender, EventArgs e)
        {
            if (yol == "2.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (metalAtikKutusu.Ekle(kolaKutusu))  //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    metalListBox.Items.Add($@"Cola Kutusu({kolaKutusu.Hacim})");
                    puan += kolaKutusu.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg";  // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    metalProgressBar.Value = metalAtikKutusu.DolulukOrani;
                }    
            }

            else if (yol == "6.jpg")  //Random gelen atığın doğru atık kutusuna atılıp atılmadığını kontrol ettirdik.
            {
                if (metalAtikKutusu.Ekle(salcaKutusu))  //Eklemek için yeterli hacim var mı diye kontrol ettirdik.
                {
                    metalListBox.Items.Add($@"Konserve Kutusu({salcaKutusu.Hacim})");
                    puan += salcaKutusu.Hacim;

                    puanLabel.Text = puan.ToString();

                    Random random = new Random();
                    yol = random.Next(1, 9) + ".jpg";  // Resimlere sayı değeri verdik sonuna ".jpg ekleyerek pictureboxa yerleştirdik"
                    pictureBox1.ImageLocation = yol;

                    metalProgressBar.Value = metalAtikKutusu.DolulukOrani;
                }    
            }
        }

        private void organikBosaltButton_Click(object sender, EventArgs e)
        {
            if (organikAtikKutusu.Bosalt())   //Doluluk %75'e eşit ya da fazla mı diye kontrol ettirdik.
            {
                organikAtikKutusu.DoluHacim = 0;
                organikListBox.Items.Clear();
                organikProgressBar.Value = 0;
                timerLabel.Text = Convert.ToString(int.Parse(timerLabel.Text) + 3);
            }
        }

        private void kagitBosaltButton_Click(object sender, EventArgs e)
        {
            if (kagitAtikKutusu.Bosalt())  //Doluluk %75'e eşit ya da fazla mı diye kontrol ettirdik.
            {
                kagitAtikKutusu.DoluHacim = 0;
                kagitListBox.Items.Clear();
                kagitProgressBar.Value = 0;
                puanLabel.Text = Convert.ToString(int.Parse(puanLabel.Text) + kagitAtikKutusu.BosaltmaPuani);
                timerLabel.Text = Convert.ToString(int.Parse(timerLabel.Text) + 3);
            }
        }

        private void camBosaltButton_Click(object sender, EventArgs e)
        {
            if (camAtikKutusu.Bosalt())  //Doluluk %75'e eşit ya da fazla mı diye kontrol ettirdik.
            {
                camAtikKutusu.DoluHacim = 0;
                camListBox.Items.Clear();
                camProgressBar.Value = 0;
                puanLabel.Text = Convert.ToString(int.Parse(puanLabel.Text) + camAtikKutusu.BosaltmaPuani);
                timerLabel.Text = Convert.ToString(int.Parse(timerLabel.Text) + 3);
            }
        }

        private void metalBosaltButton_Click(object sender, EventArgs e)
        {
            if (metalAtikKutusu.Bosalt())  //Doluluk %75'e eşit ya da fazla mı diye kontrol ettirdik.
            {
                metalAtikKutusu.DoluHacim = 0;
                metalListBox.Items.Clear();
                metalProgressBar.Value = 0;
                puanLabel.Text = Convert.ToString(int.Parse(puanLabel.Text) + metalAtikKutusu.BosaltmaPuani);
                timerLabel.Text = Convert.ToString(int.Parse(timerLabel.Text) + 3);
            }
        }
    }
}
