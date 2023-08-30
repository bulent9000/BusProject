using oto.core.BusinessLogicLayer;
using oto.core.Entities;
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
    public partial class MüsteriKayitEkrani : Form
    {
       
        OtobüsSistemServis Bll;
        public MüsteriKayitEkrani()
        {
            InitializeComponent();
            Bll = new OtobüsSistemServis();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Bll.müsteriKayit();

            Müsteri müsteri = new Müsteri()
            {
                tc_KimlikNo = txt_tcKimlikNo.Text,
                isim = txt_isim.Text,
                soyisim = txt_soyisim.Text,
                telefon_No = txt_telefonNo.Text,
                email = txt_email.Text,
                bilet_AlisTarihi = DateTime.Now,
                ödenecek_Tutar = lbl_ücret.Text,
                yön_Bilgisi = lbl_yön.Text,
                otobüs_Saati = lbl_kalkisSaati.Text,
                otobüs_Adi = lbl_otoAdi.Text,
                koltuk_Bilgisi = lbl_koltukBilgi.Text,
                koltukNo = lbl_koltukNo.Text
            };
            int kayit=Bll.müsteriKayit(müsteri);
            if (kayit > 0)
            {
                MessageBox.Show("Kayıt başarılıdır", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.Close();


            }

            else
            {
                MessageBox.Show("Kayıt başarısızdır.Bilgileri eksiksiz giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }




        }
    }
}
