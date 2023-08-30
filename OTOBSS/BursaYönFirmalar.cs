using OTOBSS.Karacabey_Turizm;
using OTOBSS.Kemal_Paşa_Tur;
using OTOBSS.Timsahlar_Turizm;
using OTOBSS.Uçar_Turizm;
using OTOBSS.Yeşiller_Diyarı_Tur;
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
    public partial class BursaYönFirmalar : Form
    {
        public BursaYönFirmalar()
        {
            InitializeComponent();
        }

        private void BursaYönFirmalar_Load(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];



            // Kalkış Bursa için
            if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İstanbul")
            {
                lbl_saatUcar.Text = "16:00";
                lbl_yönUcar.Text = "Bursa Otogarı>Esenler Otogar";
                lbl_ücretUcar.Text = "500 TL";

                lbl_saatTimsahlar.Text = "17:30";
                lbl_yönTimsahlar.Text = "Bursa Otogarı>Alibeyköy Otogar";
                lbl_ücretTimsahlar.Text = "450 TL";

                lbl_saatYesillerDiyari.Text = "13:00";
                lbl_yönYesillerDiyari.Text = "Bursa Otogarı>Esenler Otogar";
                lbl_ücretYesillerDiyari.Text = "450 TL";

                lbl_saatKaracabey.Text = "15:50";
                lbl_yönKaracabey.Text = "Bursa Otogarı>Esenler Otogar";
                lbl_ücretKaracabey.Text = "500 TL";

                lbl_saatKemalPasa.Text = "16:40";
                lbl_yönKemalPasa.Text = "Bursa Otogarı>Alibeyköy Otogar";
                lbl_ücretKemalPasa.Text = "300 TL";


            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "Ankara")
            {
                lbl_saatUcar.Text = "15:00";
                lbl_yönUcar.Text = "Bursa Otogarı>Aşti Otogar";
                lbl_ücretUcar.Text = "600 TL";

                lbl_saatTimsahlar.Text = "16:30";
                lbl_yönTimsahlar.Text = "Bursa Otogarı>Aşti Otogar";
                lbl_ücretTimsahlar.Text = "700 TL";

                lbl_saatYesillerDiyari.Text = "14:30";
                lbl_yönYesillerDiyari.Text = "Bursa Otogarı>Aşti Otogar";
                lbl_ücretYesillerDiyari.Text = "450 TL";

                lbl_saatKaracabey.Text = "12:50";
                lbl_yönKaracabey.Text = "Bursa Otogarı>Aşti Otogar";
                lbl_ücretKaracabey.Text = "500 TL";

                lbl_saatKemalPasa.Text = "13:40";
                lbl_yönKemalPasa.Text = "Bursa Otogarı>Aşti Otogar";
                lbl_ücretKemalPasa.Text = "250 TL";


            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İzmir")
            {
                lbl_saatUcar.Text = "14:00";
                lbl_yönUcar.Text = "Bursa Otogarı>İzmir Otogar";
                lbl_ücretUcar.Text = "550 TL";

                lbl_saatTimsahlar.Text = "15:30";
                lbl_yönTimsahlar.Text = "Bursa Otogarı>İzmir Otogar";
                lbl_ücretTimsahlar.Text = "740 TL";

                lbl_saatYesillerDiyari.Text = "12:30";
                lbl_yönYesillerDiyari.Text = "Bursa Otogarı>İzmir Otogar";
                lbl_ücretYesillerDiyari.Text = "500 TL";

                lbl_saatKaracabey.Text = "13:50";
                lbl_yönKaracabey.Text = "Bursa Otogarı>İzmir Otogar";
                lbl_ücretKaracabey.Text = "600 TL";

                lbl_saatKemalPasa.Text = "14:00";
                lbl_yönKemalPasa.Text = "Bursa Otogarı>İzmir Otogar";
                lbl_ücretKemalPasa.Text = "450 TL";


            }



        }

        private void btn_ucar_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "Ankara")
            {
                KoltuklarUcarBurAnk koltukUcarBurAnk = new KoltuklarUcarBurAnk();
                koltukUcarBurAnk.Show();
            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İzmir")  
            {
                KoltuklarUcarBurIzm koltukUcarBurIzm = new KoltuklarUcarBurIzm();
                koltukUcarBurIzm.Show();

            }

            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İstanbul")  
            {
                KoltuklarUcarBurIst koltukUcarBurIst = new KoltuklarUcarBurIst();
                koltukUcarBurIst.Show();

            }

        }

        private void btn_timsahlar_Click(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "Ankara")
            {
                KoltuklarTimsahlarBurAnk koltukTimsahlarBurAnk = new KoltuklarTimsahlarBurAnk();
                koltukTimsahlarBurAnk.Show();
            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İzmir")
            {
                KoltuklarTimsahlarBurIzm koltukTimsahlarBurIzm = new KoltuklarTimsahlarBurIzm();
                koltukTimsahlarBurIzm.Show();

            }

            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarTimsahlarBurIst koltukTimsahlarBurIst = new KoltuklarTimsahlarBurIst();
                koltukTimsahlarBurIst.Show();

            }



        }

        private void btn_yesiller_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "Ankara")
            {
                KoltuklarYesillerDiyariBurAnk koltukYesillerDiyariBurAnk = new KoltuklarYesillerDiyariBurAnk();
                koltukYesillerDiyariBurAnk.Show();
            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İzmir")
            {
                KoltuklarYesillerDiyariBurIzm koltukYesillerDiyariBurIzm = new KoltuklarYesillerDiyariBurIzm();
                koltukYesillerDiyariBurIzm.Show();

            }

            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarYesillerDiyariBurIst koltukYesillerDiyariBurIst = new KoltuklarYesillerDiyariBurIst();
                koltukYesillerDiyariBurIst.Show();

            }
        }

        private void btn_karacabey_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "Ankara")
            {
                KoltuklarKaracabeyBurAnk koltukKaracabeyBurAnk = new KoltuklarKaracabeyBurAnk();
                koltukKaracabeyBurAnk.Show();
            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İzmir")
            {
                KoltuklarKaracabeyBurIzm koltukKaracabeyBurIzm = new KoltuklarKaracabeyBurIzm();
                koltukKaracabeyBurIzm.Show();

            }

            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarKaracabeyBurIst koltukKaracabeyBurIst = new KoltuklarKaracabeyBurIst();
                koltukKaracabeyBurIst.Show();

            }



        }

        private void btn_kemalPasa_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "Ankara")
            {
                KoltuklarKemalpasaBurAnk koltukKemalpasaBurAnk = new KoltuklarKemalpasaBurAnk();
                koltukKemalpasaBurAnk.Show();
            }
            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İzmir")
            {
                KoltuklarKemalpasaBurIzm koltukKemalpasaBurIzm = new KoltuklarKemalpasaBurIzm();
                koltukKemalpasaBurIzm.Show();

            }

            else if (cmbKalkis.Text == "Bursa" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarKemalpasaBurIst koltukKemalpasaBurIst = new KoltuklarKemalpasaBurIst();
                koltukKemalpasaBurIst.Show();

            }
        }
    }
}
