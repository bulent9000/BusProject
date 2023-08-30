using OTOBSS.Ecel_Turizm;
using OTOBSS.Ezcan_Turizm;
using OTOBSS.RetroTur;
using OTOBSS.Sirat_Tur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOBSS
{
    public partial class AnkaraYönFirmalar : Form
    {
        
        public AnkaraYönFirmalar()
        {
            InitializeComponent();
           
        }

        private void AnkaraYönFirmalar_Load(object sender, EventArgs e)
        {

            

            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            //Kalkış Ankara için

            if ( cmbKalkis.Text == "Ankara" && cmbVaris.Text== "Bursa") 
            {

                lbl_saatSonTur.Text = "13:00";
                lbl_yönSonTur.Text = "Aşti Otogarı>Bursa Otogar";
                lbl_ücretSonTur.Text = "450 TL";

                lbl_saatRetro.Text = "13:30";
                lbl_yönRetro.Text = "Aşti Otogarı>Bursa Otogar";
                lbl_ücretRetro.Text = "500 TL";

                lbl_saatEzcan.Text = "14:00";
                lbl_yönEzcan.Text = "Aşti Otogarı>Bursa Otogar";
                lbl_ücretEzcan.Text = "400 TL";

                lbl_saatSirat.Text = "14:50";
                lbl_yönSirat.Text = "Aşti Otogarı>Bursa Otogar";
                lbl_ücretSirat.Text = "350 TL";

                lbl_saatEcel.Text = "15:00";
                lbl_yönEcel.Text = "Aşti Otogarı>Bursa Otogar";
                lbl_ücretEcel.Text = "300 TL";

               

            }
            
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İzmir")
            {
                lbl_saatSonTur.Text = "09:00";
                lbl_yönSonTur.Text = "Aşti Otogarı>İzmir Otogar";
                lbl_ücretSonTur.Text = "450 TL";

                lbl_saatRetro.Text = "08:30";
                lbl_yönRetro.Text = "Aşti Otogarı>İzmir Otogar";
                lbl_ücretRetro.Text = "500 TL";

                lbl_saatEzcan.Text = "10:30";
                lbl_yönEzcan.Text = "Aşti Otogarı>İzmir Otogar";
                lbl_ücretEzcan.Text = "400 TL";

                lbl_saatSirat.Text = "11:00";
                lbl_yönSirat.Text = "Aşti Otogarı>İzmir Otogar";
                lbl_ücretSirat.Text = "350 TL";

                lbl_saatEcel.Text = "12:00";
                lbl_yönEcel.Text = "Aşti Otogarı>İzmir Otogar";
                lbl_ücretEcel.Text = "300 TL";


            }

            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İstanbul")
            {
                lbl_saatSonTur.Text = "10:00";
                lbl_yönSonTur.Text = "Aşti Otogarı>Esenler Otogar";
                lbl_ücretSonTur.Text = "500 TL";

                lbl_saatRetro.Text = "11:30";
                lbl_yönRetro.Text = "Aşti Otogarı>Alibeyköy Otogar";
                lbl_ücretRetro.Text = "400 TL";

                lbl_saatEzcan.Text = "12:30";
                lbl_yönEzcan.Text = "Aşti Otogarı>Alibeyköy Otogar";
                lbl_ücretEzcan.Text = "450 TL";

                lbl_saatSirat.Text = "13:00";
                lbl_yönSirat.Text = "Aşti Otogarı>Esenler Otogar";
                lbl_ücretSirat.Text = "400 TL";

                lbl_saatEcel.Text = "14:00";
                lbl_yönEcel.Text = "Aşti Otogarı>Esenler Otogar";
                lbl_ücretEcel.Text = "350 TL";


            }
           
           

            // Kalkış İzmir için
           



        }

        private void btn_sonTur_Click(object sender, EventArgs e) //Son Turizm için yönler
        {
            //Form1 frm = new Form1();
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];
           

            if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "Bursa")
            {
                KoltuklarSonTurAnkBur koltukSonTurAnkBur = new KoltuklarSonTurAnkBur();
                koltukSonTurAnkBur.Show();
            }
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İzmir")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarSonTurAnkIzm koltukSonTurAnkIzm = new KoltuklarSonTurAnkIzm();
                koltukSonTurAnkIzm.Show();

            }

            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İstanbul")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltukSonTurAnkIst koltukSonTurAnkIst = new KoltukSonTurAnkIst();
                koltukSonTurAnkIst.Show();

            }





        }

        private void btn_retro_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "Bursa")
            {
                KoltuklarRetroAnkBur koltukRetroAnkBur = new KoltuklarRetroAnkBur();
                koltukRetroAnkBur.Show();
            }
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İzmir")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarRetroAnkIzm koltukRetroAnkIzm = new KoltuklarRetroAnkIzm();
                koltukRetroAnkIzm.Show();

            }

            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İstanbul")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarRetroAnkIst koltukRetroAnkIst = new KoltuklarRetroAnkIst();
                koltukRetroAnkIst.Show();

            }



        }

        private void btn_ezcan_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "Bursa")
            {
                KoltuklarEzcanAnkBur koltukEzcanAnkBur = new KoltuklarEzcanAnkBur();
                koltukEzcanAnkBur.Show();
            }
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İzmir")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarEzcanAnkIzm koltukEzcanAnkIzm = new KoltuklarEzcanAnkIzm();
                koltukEzcanAnkIzm.Show();

            }

            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İstanbul")  //Ankara-İstanbul yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarEzcanAnkIst koltukEzcanAnkIst = new KoltuklarEzcanAnkIst();
                koltukEzcanAnkIst.Show();

            }

        }

        private void btn_sirat_Click(object sender, EventArgs e)
        {


            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "Bursa")
            {
                KoltuklarSiratAnkBur koltukSiratAnkBur = new KoltuklarSiratAnkBur();
                koltukSiratAnkBur.Show();
            }
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İzmir")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarSiratAnkIzm koltukSiratAnkIzm = new KoltuklarSiratAnkIzm();
                koltukSiratAnkIzm.Show();

            }

            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İstanbul")  //Ankara-İstanbul yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarSiratAnkIst koltukSiratAnkIst = new KoltuklarSiratAnkIst();
                koltukSiratAnkIst.Show();

            }


        }

        private void btn_ecel_Click(object sender, EventArgs e)
        {
            
             
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];
            
            if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "Bursa")
            {
                KoltuklarEcelAnkBur koltukEcelAnkBur = new KoltuklarEcelAnkBur();
                koltukEcelAnkBur.Show();
            }
            
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İzmir")  //Ankara-İzmir yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarEcelAnkIzm koltukEcelAnkIzm = new KoltuklarEcelAnkIzm();
                koltukEcelAnkIzm.Show();

            }
            
            else if (cmbKalkis.Text == "Ankara" && cmbVaris.Text == "İstanbul")  //Ankara-İstanbul yönü için oluşturulacak olan koltuklar sayfasını gösterecek
            {
                KoltuklarEcelAnkIst koltukEcelAnkIst = new KoltuklarEcelAnkIst();
                koltukEcelAnkIst.Show();

            }
             
             
             
             
             


        }
    }
}
