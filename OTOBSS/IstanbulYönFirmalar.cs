using OTOBSS.Ağrı_Dağı_Efsanesi;
using OTOBSS.Biz_Turizm;
using OTOBSS.Gözler_Turizm;
using OTOBSS.Gün_Işığı_Turizm;
using OTOBSS.Öz_Canlar_Turizm;
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
    public partial class IstanbulYönFirmalar : Form
    {
        public IstanbulYönFirmalar()
        {
            InitializeComponent();
        }

        private void IstanbulYönFirmalar_Load(object sender, EventArgs e)
        {

            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];
             //Kalkış istanbul için
             if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Ankara")
            {
                lbl_saatGünIsigi.Text = "11:00";
                lbl_yönGünIsigi.Text = "Esenler Otogarı>Aşti Otogar";
                lbl_ücretGünIsigi.Text = "600 TL";

                lbl_saatGözler.Text = "12:30";
                lbl_yönGözler.Text = "Alibeyköy Otogarı>Aşti Otogar";
                lbl_ücretGözler.Text = "700 TL";

                lbl_saatBiz.Text = "14:30";
                lbl_yönBiz.Text = "Esenler Otogarı>Aşti Otogar";
                lbl_ücretBiz.Text = "450 TL";

                lbl_saatAgri.Text = "10:00";
                lbl_yönAgri.Text = "Esenler Otogarı>Aşti Otogar";
                lbl_ücretAgri.Text = "500 TL";

                lbl_saatÖzcanlar.Text = "11:00";
                lbl_yönÖzcanlar.Text = "Alibeyköy Otogarı>Aşti Otogar";
                lbl_ücretÖzcanlar.Text = "250 TL";


            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "İzmir")
            {
                lbl_saatGünIsigi.Text = "10:00";
                lbl_yönGünIsigi.Text = "Esenler Otogarı>İzmir Otogar";
                lbl_ücretGünIsigi.Text = "600 TL";

                lbl_saatGözler.Text = "09:30";
                lbl_yönGözler.Text = "Alibeyköy Otogarı>İzmir Otogar";
                lbl_ücretGözler.Text = "700 TL";

                lbl_saatBiz.Text = "08:30";
                lbl_yönBiz.Text = "Esenler Otogarı>İzmir Otogar";
                lbl_ücretBiz.Text = "450 TL";

                lbl_saatAgri.Text = "07:00";
                lbl_yönAgri.Text = "Esenler Otogarı>İzmir Otogar";
                lbl_ücretAgri.Text = "500 TL";

                lbl_saatÖzcanlar.Text = "11:00";
                lbl_yönÖzcanlar.Text = "Alibeyköy Otogarı>İzmir Otogar";
                lbl_ücretÖzcanlar.Text = "250 TL";


            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Bursa")
            {
                lbl_saatGünIsigi.Text = "15:00";
                lbl_yönGünIsigi.Text = "Esenler Otogarı>Bursa Otogar";
                lbl_ücretGünIsigi.Text = "600 TL";

                lbl_saatGözler.Text = "16:30";
                lbl_yönGözler.Text = "Alibeyköy Otogarı>Bursa Otogar";
                lbl_ücretGözler.Text = "700 TL";

                lbl_saatBiz.Text = "14:30";
                lbl_yönBiz.Text = "Esenler Otogarı>Bursa Otogar";
                lbl_ücretBiz.Text = "450 TL";

                lbl_saatAgri.Text = "12:50";
                lbl_yönAgri.Text = "Esenler Otogarı>Bursa Otogar";
                lbl_ücretAgri.Text = "500 TL";

                lbl_saatÖzcanlar.Text = "13:40";
                lbl_yönÖzcanlar.Text = "Alibeyköy Otogarı>Bursa Otogar";
                lbl_ücretÖzcanlar.Text = "300 TL";


            }

        }

        private void btn_günIsigi_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Ankara")
            {
                KoltuklarGünIsigiIstAnk koltuklarGünIsigiIstAnk = new KoltuklarGünIsigiIstAnk();
                koltuklarGünIsigiIstAnk.Show();
            }
            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "İzmir")
            {
                KoltuklarGünIsigiIstIzm koltuklarGünIsigiIstIzm = new KoltuklarGünIsigiIstIzm();
                koltuklarGünIsigiIstIzm.Show();

            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Bursa")
            {
                KoltuklarGünIsigiIstBur koltuklarGünIsigiIstBur = new KoltuklarGünIsigiIstBur();
                koltuklarGünIsigiIstBur.Show();

            }
        }

        private void btn_gözler_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Ankara")
            {
                KoltuklarGözlerIstAnk koltuklarGözlerIstAnk = new KoltuklarGözlerIstAnk();
                koltuklarGözlerIstAnk.Show();
            }
            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "İzmir")
            {
                KoltuklarGözlerIstIzm koltuklarGözlerIstIzm = new KoltuklarGözlerIstIzm();
                koltuklarGözlerIstIzm.Show();

            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Bursa")
            {
                KoltuklarGözlerIstBur koltuklarGözlerIstBur = new KoltuklarGözlerIstBur();
                koltuklarGözlerIstBur.Show();

            }

        
        }

        private void btn_biz_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Ankara")
            {
                KoltuklarBizIstAnk koltuklarBizIstAnk = new KoltuklarBizIstAnk();
                koltuklarBizIstAnk.Show();
            }
            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "İzmir")
            {
                KoltuklarBizIstIzm koltuklarBizIstIzm = new KoltuklarBizIstIzm();
                koltuklarBizIstIzm.Show();

            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Bursa")
            {
                KoltuklarBizIstBur koltuklarBizIstBur = new KoltuklarBizIstBur();
                koltuklarBizIstBur.Show();

            }

        }

        private void btn_agri_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Ankara")
            {
                KoltuklarAgriIstAnk koltuklarAgriIstAnk = new KoltuklarAgriIstAnk();
                koltuklarAgriIstAnk.Show();
            }
            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "İzmir")
            {
                KoltuklarAgriIstIzm koltuklarAgriIstIzm = new KoltuklarAgriIstIzm();
                koltuklarAgriIstIzm.Show();

            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Bursa")
            {
                KoltuklarAgriIstBur koltuklarAgriIstBur = new KoltuklarAgriIstBur();
                koltuklarAgriIstBur.Show();

            }
        }

        private void btn_özCanlar_Click(object sender, EventArgs e)
        {
            Form frm = (Form)Application.OpenForms["Form1"];
            ComboBox cmbKalkis = (ComboBox)frm.Controls["cmb_kalkisNoktasi"];
            ComboBox cmbVaris = (ComboBox)frm.Controls["cmb_varisNoktasi"];

            if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Ankara")
            {
                KoltuklarOzcanlarIstAnk koltuklarOzcanlarIstAnk = new KoltuklarOzcanlarIstAnk();
                koltuklarOzcanlarIstAnk.Show();
            }
            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "İzmir")
            {
                KoltuklarOzcanlarIstIzm koltuklarOzcanlarIstIzm = new KoltuklarOzcanlarIstIzm();
                koltuklarOzcanlarIstIzm.Show();

            }

            else if (cmbKalkis.Text == "İstanbul" && cmbVaris.Text == "Bursa")
            {
                KoltuklarOzcanlarIstBur koltuklarOzcanlarIstBur = new KoltuklarOzcanlarIstBur();
                koltuklarOzcanlarIstBur.Show();

            }
        }
    }
}
