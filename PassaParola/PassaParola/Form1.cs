using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Baslama Butonu 
        int soruNo = 0, dogruSayisi = 0, yanlisSayisi = 0;

       

        private void LinkLblBasla_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLblBasla.Text = "SONRAKİ";
            soruNo++;
            this.Text = soruNo.ToString();    // Ekran en soğ kenarında 

            if (soruNo == 1)
            {
                rchSoru.Text = "hgfbsfuhsfpo";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 2)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 3)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }

            if (soruNo == 4)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                rchSoru.Text = "";
                // Soru cevapı dogru oldugu zaman 
                BtnA.BackColor = Color.Yellow;
            }



        }

        // keyDown ozelliği == her hangi bir tusa tıkladıgında 
        private void TxtCevap_KeyDown(object sender, KeyEventArgs e)
        {
            // bu tus enter ise 
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    // Cevap 1
                    case 1:
                        if (TxtCevap.Text == "Devran")
                        {
                            BtnA.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnA.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;

                    // Cevap 2
                    case 2:
                        if (TxtCevap.Text == " fsgv")
                        {
                            BtnB.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnB.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;
                    // Cevap 3
                    case 3:
                        if(TxtCevap.Text == "f")
                        {
                            BtnC.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnC.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;

                    // Cevap 4
                    case 4:
                        if (TxtCevap.Text == "f")
                        {
                            BtnD.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnD.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;

                    // Cevap 5
                    case 5:
                        if (TxtCevap.Text == "f")
                        {
                            BtnE.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnE.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;

                    // Cevap 6
                    case 6:
                        if (TxtCevap.Text == "f")
                        {
                            BtnF.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnF.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;


                    // Cevap 7
                    case 7:
                        if (TxtCevap.Text == "f")
                        {
                            BtnG.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnG.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;

                    // Cevap 8
                    case 8:
                        if (TxtCevap.Text == "f")
                        {
                            BtnH.BackColor = Color.Green;
                            dogruSayisi++;
                            LblDogruSayisi.Text = dogruSayisi.ToString();
                        }
                        else
                        {
                            BtnH.BackColor = Color.Red;
                            yanlisSayisi++;
                            LblYanlisSayisi.Text = yanlisSayisi.ToString();
                        }
                        break;

                }
            }
        }

    }
}
     