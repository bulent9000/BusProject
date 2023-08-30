using OTOBSS.Ata_Turizm;
using OTOBSS.Deniz_Mavisi;
using OTOBSS.Konak_Turizm;
using OTOBSS.Sürat_Turizm;
using OTOBSS.Tatilya_Tur;
using OTOBSS.Uçar_Turizm;
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
    public partial class IzmirYönFirmalar : Form
    {
        public IzmirYönFirmalar()
        {
            InitializeComponent();
        }

        private void IzmirYönFirmalar_Load(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

             if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Ankara")
            {
                lbl_saatDenizMavisi.Text = "12:00";
                lbl_yönDenizMavisi.Text = "İzmir Otogarı>Aşti Otogar";
                lbl_ücretDenizMavisi.Text = "750 TL";

                lbl_saatTatilya.Text = "13:30";
                lbl_yönTatilya.Text = "İzmir Otogarı>Aşti Otogar";
                lbl_ücretTatilya.Text = "850 TL";

                lbl_saatSürat.Text = "11:00";
                lbl_yönSürat.Text = "İzmir Otogarı>Aşti Otogar";
                lbl_ücretSürat.Text = "700 TL";

                lbl_saatKonak.Text = "10:50";
                lbl_yönKonak.Text = "İzmir Otogarı>Aşti Otogar";
                lbl_ücretKonak.Text = "600 TL";

                lbl_saatAta.Text = "12:00";
                lbl_yönAta.Text = "İzmir Otogarı>Aşti Otogar";
                lbl_ücretAta.Text = "700 TL";


            }

            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "İstanbul")
            {
                lbl_saatDenizMavisi.Text = "15:00";
                lbl_yönDenizMavisi.Text = "İzmir Otogarı>Alibeyköy Otogar";
                lbl_ücretDenizMavisi.Text = "800 TL";

                lbl_saatTatilya.Text = "14:30";
                lbl_yönTatilya.Text = "İzmir Otogarı>Esenler Otogar";
                lbl_ücretTatilya.Text = "750 TL";

                lbl_saatSürat.Text = "12:30";
                lbl_yönSürat.Text = "İzmir Otogarı>Esenler Otogar";
                lbl_ücretSürat.Text = "650 TL";

                lbl_saatKonak.Text = "14:00";
                lbl_yönKonak.Text = "İzmir Otogarı>Esenler Otogar";
                lbl_ücretKonak.Text = "750 TL";

                lbl_saatAta.Text = "13:00";
                lbl_yönAta.Text = "İzmir Otogarı>Alibeyköy Otogar";
                lbl_ücretAta.Text = "700 TL";


            }
            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Bursa")
            {
                lbl_saatDenizMavisi.Text = "12:30";
                lbl_yönDenizMavisi.Text = "İzmir Otogarı>Bursa Otogar";
                lbl_ücretDenizMavisi.Text = "450 TL";

                lbl_saatTatilya.Text = "13:30";
                lbl_yönTatilya.Text = "İzmir Otogarı>Bursa Otogar";
                lbl_ücretTatilya.Text = "500 TL";

                lbl_saatSürat.Text = "14:00";
                lbl_yönSürat.Text = "İzmir Otogarı>Bursa Otogar";
                lbl_ücretSürat.Text = "400 TL";

                lbl_saatKonak.Text = "15:00";
                lbl_yönKonak.Text = "İzmir Otogarı>Bursa Otogar";
                lbl_ücretKonak.Text = "500 TL";

                lbl_saatAta.Text = "16:00";
                lbl_yönAta.Text = "İzmir Otogarı>Bursa Otogar";
                lbl_ücretAta.Text = "350 TL";


            }


        }

        private void btn_deniz_Click(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Ankara")
            {
                KoltuklarDenizMavisiIzmAnk koltuklarDenizMavisiIzmAnk = new KoltuklarDenizMavisiIzmAnk();
                koltuklarDenizMavisiIzmAnk.Show();
            }
            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Bursa")
            {
                KoltuklarDenizMavisiIzmBur koltuklarDenizMavisiIzmBur = new KoltuklarDenizMavisiIzmBur();
                koltuklarDenizMavisiIzmBur.Show();

            }

            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarDenizMavisiIzmIst koltuklarDenizMavisiIzmIst = new KoltuklarDenizMavisiIzmIst();
                koltuklarDenizMavisiIzmIst.Show();

            }


        }

        private void btn_tatilya_Click(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Ankara")
            {
                KoltuklarTatilyaIzmAnk koltuklarTatilyaIzmAnk = new KoltuklarTatilyaIzmAnk();
                koltuklarTatilyaIzmAnk.Show();
            }
            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Bursa")
            {
                KoltuklarTatilyaIzmBur koltuklarTatilyaIzmBur = new KoltuklarTatilyaIzmBur();
                koltuklarTatilyaIzmBur.Show();

            }

            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarTatilyaIzmIst koltuklarTatilyaIzmIst = new KoltuklarTatilyaIzmIst();
                koltuklarTatilyaIzmIst.Show();

            }





        }

        private void btn_sürat_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Ankara")
            {
                KoltuklarSüratIzmAnk koltuklarSüratIzmAnk = new KoltuklarSüratIzmAnk();
                koltuklarSüratIzmAnk.Show();
            }
            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Bursa")
            {
                KoltuklarSüratIzmBur koltuklarSüratIzmBur = new KoltuklarSüratIzmBur();
                koltuklarSüratIzmBur.Show();

            }

            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarSüratIzmIst koltuklarSüratIzmIst = new KoltuklarSüratIzmIst();
                koltuklarSüratIzmIst.Show();

            }
        }

        private void btn_konak_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Ankara")
            {
                KoltuklarKonakIzmAnk koltuklarKonakIzmAnk = new KoltuklarKonakIzmAnk();
                koltuklarKonakIzmAnk.Show();
            }
            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Bursa")
            {
                KoltuklarKonakIzmBur koltuklarKonakIzmBur = new KoltuklarKonakIzmBur();
                koltuklarKonakIzmBur.Show();

            }

            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarKonakIzmIst koltuklarKonakIzmIst = new KoltuklarKonakIzmIst();
                koltuklarKonakIzmIst.Show();

            }
        }

        private void btn_ata_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Ankara")
            {
                KoltuklarAtaIzmAnk koltuklarAtaIzmAnk = new KoltuklarAtaIzmAnk();
                koltuklarAtaIzmAnk.Show();
            }
            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "Bursa")
            {
                KoltuklarAtaIzmBur koltuklarAtaIzmBur = new KoltuklarAtaIzmBur();
                koltuklarAtaIzmBur.Show();

            }

            else if (cmbKalkis.Text == "İzmir" && cmbVaris.Text == "İstanbul")
            {
                KoltuklarAtaIzmIst koltuklarAtaIzmIst = new KoltuklarAtaIzmIst();
                koltuklarAtaIzmIst.Show();

            }
        }
    }
}
