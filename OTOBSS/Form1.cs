using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oto.core.BusinessLogicLayer;
using oto.core.Entities;

namespace OTOBSS
{
    public partial class Form1 : Form
    {
        OtobüsSistemServis Bll;
        AnkaraYönFirmalar ankaraYön;
        IstanbulYönFirmalar istanbulYön;
        BursaYönFirmalar bursaYön;
        IzmirYönFirmalar izmirYön;

        public Form1()
        {
            InitializeComponent();
            Bll = new OtobüsSistemServis();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            List<Sehirler> kalkisSehirListem1 = Bll.kalkisSehirListe();
            cmb_kalkisNoktasi.DataSource = kalkisSehirListem1;
            List<Sehirler> varisSehirListem1 = Bll.varisSehirListe();
            cmb_varisNoktasi.DataSource = varisSehirListem1;



        }

        private void btn_biletBul_Click(object sender, EventArgs e)
        {
            if(cmb_kalkisNoktasi.Text is "Ankara" && 
                cmb_varisNoktasi.Text is "İstanbul")
            {
                
               ankaraYön = new AnkaraYönFirmalar();               
               ankaraYön.Show();

            }
            else if (cmb_kalkisNoktasi.Text is "Ankara" &&
                cmb_varisNoktasi.Text is "Bursa")
            {
                ankaraYön = new AnkaraYönFirmalar();
                ankaraYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "Ankara" &&
               cmb_varisNoktasi.Text is "İzmir")
            {
                ankaraYön = new AnkaraYönFirmalar();
                ankaraYön.Show();
            }

            else if (cmb_kalkisNoktasi.Text is "İstanbul" &&
                cmb_varisNoktasi.Text is "Ankara")
            {
                istanbulYön = new IstanbulYönFirmalar();
                istanbulYön.Show();

            }
            else if (cmb_kalkisNoktasi.Text is "İstanbul" &&
                 cmb_varisNoktasi.Text is "İzmir")
            {
                istanbulYön = new IstanbulYönFirmalar();
                istanbulYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "İstanbul" &&
              cmb_varisNoktasi.Text is "Bursa")
            {
                istanbulYön = new IstanbulYönFirmalar();
                istanbulYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "Bursa" &&
              cmb_varisNoktasi.Text is "İstanbul")
            {
                bursaYön = new BursaYönFirmalar();
                bursaYön.Show();

            }
            else if (cmb_kalkisNoktasi.Text is "Bursa" &&
             cmb_varisNoktasi.Text is "İzmir")
            {
                bursaYön = new BursaYönFirmalar();
                bursaYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "Bursa" &&
             cmb_varisNoktasi.Text is "Ankara")
            {
                bursaYön = new BursaYönFirmalar();
                bursaYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "İzmir" &&
             cmb_varisNoktasi.Text is "Ankara")
            {
                izmirYön = new IzmirYönFirmalar();
                izmirYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "İzmir" &&
             cmb_varisNoktasi.Text is "İstanbul")
            {
                izmirYön = new IzmirYönFirmalar();
                izmirYön.Show();
            }
            else if (cmb_kalkisNoktasi.Text is "İzmir" &&
             cmb_varisNoktasi.Text is "Bursa")
            {
                izmirYön = new IzmirYönFirmalar();
                izmirYön.Show();
            }

           

        }
       



    }
}
