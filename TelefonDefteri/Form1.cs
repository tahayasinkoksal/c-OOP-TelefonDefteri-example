using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonDefteri
{
   


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        public string ad = "", soyad = "", telefon = "", mail = "";
        public ListView listea;
        
        List<Kisi> kisilistesi;
        

        private void Form1_Load(object sender, EventArgs e)
        {

            kisilistesi = new List<Kisi>();
            listea = listViewkisiler;
            
        }


        private void btnkayitekle_Click(object sender, EventArgs e)
        {
            //KAYIT BUTONUNA TIKLANINCA OLMASI GEREKENLER

            ad = tbad.Text;
            soyad = tbsoyad.Text;
            telefon = tbtelofon.Text;
            mail = tbmail.Text;
            if (ad != "" && soyad != "" && telefon != "" && mail != "")
            {
                Kisi kisi = new Kisi(ad, soyad, telefon, mail);
                kisilistesi.Add(kisi);

                ekle();
            }
            
            
            Temizle();
        }

        public void ekle() {

            listViewkisiler.Items.Clear();
            if (tbaraad.Text == "" && tbarasoyad.Text == "")
            {
                for (int i = 0; i < kisilistesi.Count; i++)
                {


                    listViewkisiler.Items.Add(new ListViewItem(kisilistesi[i].BilgileriYazdir()));

                }
            }
        
        }

        //KAYIT LİSTELEME BUTONU
        private void btnkayitlistele_Click(object sender, EventArgs e)
        {

            listViewkisiler.Items.Clear();

            if (tbaraad.Text == "" && tbarasoyad.Text == "")
            {
                for (int i = 0; i < kisilistesi.Count; i++)
                {


                    listViewkisiler.Items.Add(new ListViewItem(kisilistesi[i].BilgileriYazdir()));

                }
            }
            //sadece ad ile arama soyad boş ise
            if (tbaraad.Text != "" && tbarasoyad.Text == "")
            {
               
                for (int i = 0; i < kisilistesi.Count(); i++)
                {
                    if ((kisilistesi[i].BilgileriYazdir()[0].ToLower()).Contains(tbaraad.Text.ToLower()))
                    {
                        listViewkisiler.Items.Add(new ListViewItem(kisilistesi[i].BilgileriYazdir()));
                    }

                }  
            }

            //sadece soyad ile arama ad boş ise
            if (tbarasoyad.Text != "" && tbaraad.Text == "")
            {

                for (int i = 0; i < kisilistesi.Count(); i++)
                {
                    if ((kisilistesi[i].BilgileriYazdir()[1].ToLower()).Contains(tbarasoyad.Text.ToLower()))
                    {
                        listViewkisiler.Items.Add(new ListViewItem(kisilistesi[i].BilgileriYazdir()));
                    }

                }
            }


            //hem ad hem soyada göre arama
            if (tbarasoyad.Text != "" && tbaraad.Text != "")
            {

                for (int i = 0; i < kisilistesi.Count(); i++)
                {
                    if (((kisilistesi[i].BilgileriYazdir()[1].ToLower()).Contains(tbarasoyad.Text.ToLower())) && ((kisilistesi[i].BilgileriYazdir()[0].ToLower()).Contains(tbaraad.Text.ToLower())))
                    {
                        listViewkisiler.Items.Add(new ListViewItem(kisilistesi[i].BilgileriYazdir()));
                    }

                }
            }

           
        }

        public void Temizle()
        {
            tbad.Text = "";
            tbsoyad.Text = "";
            tbtelofon.Text = "";
            tbmail.Text = "";
        }
       

       

    }
    public class Kisi {

        string ad;
        string soyad;
        string telefon;
        string mail;


        public Kisi(string ad, string soyad, string telefon, string mail) 
        {
            this.ad = ad;
            this.soyad = soyad;
            this.telefon = telefon;
            this.mail = mail;

           

        }

        public string[] BilgileriYazdir() 
        {
            string[] veri = { this.ad, this.soyad, this.telefon, this.mail };
            return veri;
        
        }



      
    }

  
}
