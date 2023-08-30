using oto.core.DatabaseLogicLayer;
using oto.core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oto.core.BusinessLogicLayer
{
    public class OtobüsSistemServis
    {
        SistemKontrolDatabase Dll;
        public SqlCommand cmd;
        public SqlDataReader reader;
        public int returnValue;
        public object obj;
        public List<Sehirler> sehirlerim;
        public Sehirler sehir;
        public List<Müsteri> müsterilerim;
        public string mevcutKoltuk;
        public OtobüsSistemServis()
        {
            Dll = new SistemKontrolDatabase();
        }


        public List<Sehirler> kalkisSehirListe()
        {
            sehirlerim = new List<Sehirler>();
            cmd = new SqlCommand("select * from kalkisIller");
            SqlDataReader reader = Dll.sehirListele(cmd);

            while (reader.Read())
            {
                sehirlerim.Add(new Sehirler()
                {
                    sehirIsim= reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                   
                });


            }

            reader.Close();
            Dll.baglantiayarla();
            return sehirlerim;




        }

        public List<Sehirler> varisSehirListe()
        {
            sehirlerim = new List<Sehirler>();
            cmd = new SqlCommand("select * from varisIller");
            SqlDataReader reader = Dll.sehirListele(cmd);

            while (reader.Read())
            {
                sehirlerim.Add(new Sehirler()
                {
                    sehirIsim = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                  


                });


            }

            reader.Close();
            Dll.baglantiayarla();
            return sehirlerim;




        }


        public int müsteriKayit(Müsteri müsterim)
        {
            Dll = new DatabaseLogicLayer.SistemKontrolDatabase();
            cmd = new SqlCommand("insert into müsteriKayit(tcKimlikNo,isim,soyisim,telefonNo," +
                "email,biletAlisTarih,ödenecekTutar,yönBilgi," +
                "otobüsSaat,otobüsAd,koltukBilgi,koltukNo)\r\nvalues(@tc_kimlikNo,@isim,@soyisim,@telefonNo," +
                "@email,@biletAlisTarihi,@ödenecekTutar,@yönBilgisi,@otobüsSaati,@otobüsAdi,@koltukBilgisi,@koltukNo)");

            cmd.Parameters.Add("@tc_kimlikNo", SqlDbType.NVarChar).Value = müsterim.tc_KimlikNo;
            cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = müsterim.isim;
            cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = müsterim.soyisim;
            cmd.Parameters.Add("@telefonNo", SqlDbType.NVarChar).Value = müsterim.telefon_No;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = müsterim.email;
            cmd.Parameters.Add("@biletAlisTarihi", SqlDbType.DateTime).Value = müsterim.bilet_AlisTarihi;
            cmd.Parameters.Add("@ödenecekTutar", SqlDbType.NVarChar).Value = müsterim.ödenecek_Tutar;
            cmd.Parameters.Add("@yönBilgisi", SqlDbType.NVarChar).Value = müsterim.yön_Bilgisi;
            cmd.Parameters.Add("@otobüsSaati", SqlDbType.NVarChar).Value = müsterim.otobüs_Saati;
            cmd.Parameters.Add("@otobüsAdi", SqlDbType.NVarChar).Value = müsterim.otobüs_Adi;
            cmd.Parameters.Add("@koltukBilgisi", SqlDbType.NVarChar).Value = müsterim.koltuk_Bilgisi;
            cmd.Parameters.Add("@koltukNo", SqlDbType.NVarChar).Value = müsterim.koltukNo;
            return Dll.müsteriKayit(cmd);

        }

        public List<Müsteri> müsteriListe()
        {
            müsterilerim = new List<Müsteri>();
            cmd = new SqlCommand("select * from müsteriKayit");
            SqlDataReader reader = Dll.müsteriListele(cmd);

            while (reader.Read())
            {
                müsterilerim.Add(new Müsteri()
                {
                    tc_KimlikNo = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    telefon_No = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    email = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    bilet_AlisTarihi = reader.IsDBNull(5) ? DateTime.MinValue:reader.GetDateTime(5),
                    ödenecek_Tutar = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                    yön_Bilgisi = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                    otobüs_Saati = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                    otobüs_Adi = reader.IsDBNull(9) ? string.Empty : reader.GetString(9),
                    koltuk_Bilgisi = reader.IsDBNull(10) ? string.Empty : reader.GetString(10),
                    koltukNo = reader.IsDBNull(11) ? string.Empty : reader.GetString(11)

                });


            }

            reader.Close();
            Dll.baglantiayarla();
            return müsterilerim;

        }
        public int koltukSorgula(string koltukNo)
        {

            cmd = new SqlCommand("select * from müsteriKayit where koltukNo=@koltukNo");
            cmd.Parameters.Add("@koltukNo", SqlDbType.NVarChar).Value = koltukNo;

            reader = Dll.koltukSorgu(cmd);
            while (reader.Read())
            {

                mevcutKoltuk = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);


            }
            reader.Close();
            Dll.baglantiayarla();


            if (koltukNo == mevcutKoltuk)
            {
                return 1;


            }
            else
            {
                return 0;

            }


        }


        public int müsteriSilinme(string odaNumber)
        {

            cmd = new SqlCommand("delete from müsteriKayit where koltukNo=@koltukNumara ");
            cmd.Parameters.Add("@koltukNumara", SqlDbType.NVarChar).Value = odaNumber;




            return Dll.müsteriSilme(cmd);


        }

    }
}
