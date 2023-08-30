using oto.core.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOBSS.Konak_Turizm
{
    public partial class KoltuklarKonakIzmAnk : Form
    {
        OtobüsSistemServis service;
        string koltukN;
        int sonuc;
        MüsteriKayitEkrani müsteriKayitEkran;
        public KoltuklarKonakIzmAnk()
        {
            InitializeComponent();
            müsteriKayitEkran = new MüsteriKayitEkrani();
        }

        private void kol1_Click(object sender, EventArgs e)
        {
            koltukN = kol1.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }
        private void renkDegis(object sender)
        {

            Control ctrl = ((Control)sender);
            switch (ctrl.BackColor.Name)
            {
                case "Red":
                    ctrl.BackColor = Color.Green;
                    break;
                case "Green":
                    ctrl.BackColor = Color.Red;
                    break;

                default:
                    ctrl.BackColor = Color.Green;
                    break;
            }
        }

        private void koltukSorgu(string koltukNum, object sender)
        {



            if (koltukNum.Length == 5)   //Oda numarası tek haneli ise
            {
                char deger = koltukNum[4];
                koltukNum = Convert.ToString(deger);


            }
            else if (koltukNum.Length == 6)   //koltuk numarası iki haneli ise
            {
                char deger1 = koltukNum[4];
                string ikiHane1 = Convert.ToString(deger1);

                char deger2 = koltukNum[5];
                string ikiHane2 = Convert.ToString(deger2);


                koltukNum = ikiHane1 + ikiHane2;
            }

            service = new OtobüsSistemServis();

            sonuc = service.koltukSorgula(koltukNum);

            if (sonuc > 0)
            {

                MessageBox.Show("Bu koltuğa müşteri kayıtlıdır", "Uyarı",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult result = MessageBox.Show("Yeni Kayıt için müşteriyi silmek ister misiniz?", "Soru",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //Müşteri Silme metoduna git
                    müsteriSilme(koltukNum);
                    renkDegis(sender);
                    müsteriKayit(koltukNum, sender);
                    //Kayıttan sonra 
                }
                else
                {
                    this.Close();

                }
            }
            else
            {
                müsteriKayit(koltukNum, sender);

                renkDegis(sender);

            }



        }
        private void müsteriSilme(string koltukNumara)
        {
            DialogResult result = MessageBox.Show("Müşteri silinecektir onaylıyor musunuz?", "Bildirim", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                service = new OtobüsSistemServis();
                int silinmeBilgi = service.müsteriSilinme(koltukNumara);
                if (silinmeBilgi > 0)
                {

                    MessageBox.Show("Müşteri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }
            else
            {
                this.Close();
            }
        }
        private void müsteriKayit(string koltukNom, object sender)
        {

            //Bu kısımda Ankara dan kalkan otobüslerin seçilen koltuğa göre müşteri kayıt ekranına bilgileri
            //aktarıldı

            #region
            Form frmIzmirYön = Application.OpenForms["IzmirYönFirmalar"];
            GroupBox grpKonak = (GroupBox)frmIzmirYön.Controls["grp_konak"];
            //Otobüsler sayfasındaki labeller alındı
            Label lblyönKonak = (Label)grpKonak.Controls["lbl_yönKonak"]; //kalkış-varış yeri
            Label lblkonakIsim = (Label)grpKonak.Controls["lbl_konakIsim"]; //oto ismi
            Label lblsaatKonak = (Label)grpKonak.Controls["lbl_saatKonak"]; //oto saati
            Label lblücretKonak = (Label)grpKonak.Controls["lbl_ücretKonak"];
            Label lblkonakKoltukDurum = (Label)grpKonak.Controls["lbl_konakKoltukDurum"]; //2+1

            //müşteri kayıt ekranına aktarılıyor

            müsteriKayitEkran = new MüsteriKayitEkrani();
            GroupBox grpMüsteriKayit = (GroupBox)müsteriKayitEkran.Controls["grpOtobüsBilgi"];

            GroupBox grpMüsteriBilgi = (GroupBox)müsteriKayitEkran.Controls["grpMüsteriBilgi"];
            Form frm = Application.OpenForms["Form1"];
            DateTimePicker dtp = (DateTimePicker)frm.Controls["dtp_yolculukTarih"];
            ((Label)grpMüsteriBilgi.Controls["lbl_tarihSaat"]).Text = dtp.Text;


            ((Label)grpMüsteriKayit.Controls["lbl_koltukNo"]).Text = koltukNom;
            ((Label)grpMüsteriKayit.Controls["lbl_yön"]).Text = lblyönKonak.Text;
            ((Label)grpMüsteriKayit.Controls["lbl_otoAdi"]).Text = lblkonakIsim.Text;
            ((Label)grpMüsteriKayit.Controls["lbl_kalkisSaati"]).Text = lblsaatKonak.Text;
            ((Label)grpMüsteriKayit.Controls["lbl_ücret"]).Text = lblücretKonak.Text;
            ((Label)grpMüsteriKayit.Controls["lbl_koltukBilgi"]).Text = lblkonakKoltukDurum.Text;
            #endregion        

            müsteriKayitEkran.Show();


        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Koltuklar
        private void kol2_Click(object sender, EventArgs e)
        {
            koltukN = kol2.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol3_Click(object sender, EventArgs e)
        {
            koltukN = kol3.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol4_Click(object sender, EventArgs e)
        {
            koltukN = kol4.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol5_Click(object sender, EventArgs e)
        {
            koltukN = kol5.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol6_Click(object sender, EventArgs e)
        {
            koltukN = kol6.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol7_Click(object sender, EventArgs e)
        {
            koltukN = kol7.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol8_Click(object sender, EventArgs e)
        {
            koltukN = kol8.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol9_Click(object sender, EventArgs e)
        {
            koltukN = kol9.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol10_Click(object sender, EventArgs e)
        {
            koltukN = kol10.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol11_Click(object sender, EventArgs e)
        {
            koltukN = kol11.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol12_Click(object sender, EventArgs e)
        {
            koltukN = kol12.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol13_Click(object sender, EventArgs e)
        {
            koltukN = kol13.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol14_Click(object sender, EventArgs e)
        {
            koltukN = kol14.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol15_Click(object sender, EventArgs e)
        {
            koltukN = kol15.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol16_Click(object sender, EventArgs e)
        {
            koltukN = kol16.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol17_Click(object sender, EventArgs e)
        {
            koltukN = kol17.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol18_Click(object sender, EventArgs e)
        {
            koltukN = kol18.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol19_Click(object sender, EventArgs e)
        {
            koltukN = kol19.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol20_Click(object sender, EventArgs e)
        {
            koltukN = kol20.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol21_Click(object sender, EventArgs e)
        {
            koltukN = kol21.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol22_Click(object sender, EventArgs e)
        {
            koltukN = kol22.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol23_Click(object sender, EventArgs e)
        {
            koltukN = kol23.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol24_Click(object sender, EventArgs e)
        {
            koltukN = kol24.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol25_Click(object sender, EventArgs e)
        {
            koltukN = kol25.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol26_Click(object sender, EventArgs e)
        {
            koltukN = kol26.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol27_Click(object sender, EventArgs e)
        {
            koltukN = kol27.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol28_Click(object sender, EventArgs e)
        {
            koltukN = kol28.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol29_Click(object sender, EventArgs e)
        {
            koltukN = kol29.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol30_Click(object sender, EventArgs e)
        {
            koltukN = kol30.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol31_Click(object sender, EventArgs e)
        {
            koltukN = kol31.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol32_Click(object sender, EventArgs e)
        {
            koltukN = kol32.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol33_Click(object sender, EventArgs e)
        {
            koltukN = kol33.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol34_Click(object sender, EventArgs e)
        {
            koltukN = kol34.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol35_Click(object sender, EventArgs e)
        {
            koltukN = kol35.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol36_Click(object sender, EventArgs e)
        {
            koltukN = kol36.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }

        private void kol37_Click(object sender, EventArgs e)
        {
            koltukN = kol37.Text;
            koltukSorgu(koltukN, sender);
            renkDegis(sender);
        }
#endregion
    }
}
