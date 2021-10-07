using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            if (Dogrula())
            {
                Temizle();
                CiftSayiHesapla(Convert.ToInt32(mtxtBaslangic.Text), Convert.ToInt32(mtxtBitis.Text));
                TekSayiHesapla(Convert.ToInt32(mtxtBaslangic.Text), Convert.ToInt32(mtxtBitis.Text));
                AsalSayiHesapla(Convert.ToInt32(mtxtBaslangic.Text), Convert.ToInt32(mtxtBitis.Text));
                MukemmelSayiHesapla(Convert.ToInt32(mtxtBaslangic.Text), Convert.ToInt32(mtxtBitis.Text));
            }   
            else
                MessageBox.Show("Hatali girdi...");
            Hazirla();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hazirla();
            nlHesapMakinesi.ShowBalloonTip(5000,"Durum","Uygulama Basariyla calistirildi",ToolTipIcon.Info);
        }
        private void MukemmelSayiHesapla(int baslangic, int bitis)
        {
            List<int> mukemmelSayiListe = Hesapla.Calistir(Hesapla.Islem.MukemmelSayi, baslangic, bitis);
            foreach (var sayi in mukemmelSayiListe)
                lvMukemmelSayi.Items.Add(Convert.ToString(sayi));
            lvMukemmelSayi.Items.Add("Sayilarin Toplami: " + Convert.ToString(Hesapla.Topla(mukemmelSayiListe)));
            lvMukemmelSayi.Items.Add("Sayilarin Carpimi: " + Convert.ToString(Hesapla.Carp(mukemmelSayiListe)));
        }

        private void AsalSayiHesapla(int baslangic, int bitis)
        {
            List<int> asalSayiListe = Hesapla.Calistir(Hesapla.Islem.AsalSayi, baslangic, bitis);
            foreach (var sayi in asalSayiListe)
                lvAsalSayi.Items.Add(Convert.ToString(sayi));
            lvAsalSayi.Items.Add("Sayilarin Toplami: " + Convert.ToString(Hesapla.Topla(asalSayiListe)));
            lvAsalSayi.Items.Add("Sayilarin Carpimi: " + Convert.ToString(Hesapla.Carp(asalSayiListe)));
        }

        private void TekSayiHesapla(int baslangic, int bitis)
        {
            List<int> tekSayiListe = Hesapla.Calistir(Hesapla.Islem.TekSayi, baslangic, bitis);
            foreach (var sayi in tekSayiListe)
                lvTekSayi.Items.Add(Convert.ToString(sayi));
            lvTekSayi.Items.Add("Sayilarin Toplami: " + Convert.ToString(Hesapla.Topla(tekSayiListe)));
            lvTekSayi.Items.Add("Sayilarin Carpimi: " + Convert.ToString(Hesapla.Carp(tekSayiListe)));
        }
        private void CiftSayiHesapla(int baslangic, int bitis)
        {
            List<int> ciftSayiListe = Hesapla.Calistir(Hesapla.Islem.CiftSayi, baslangic, bitis);
            foreach (var sayi in ciftSayiListe)
                lvCiftSayi.Items.Add(Convert.ToString(sayi));
            lvCiftSayi.Items.Add("Sayilarin Toplami: " + Convert.ToString(Hesapla.Topla(ciftSayiListe)));
            lvCiftSayi.Items.Add("Sayilarin Carpimi: " + Convert.ToString(Hesapla.Carp(ciftSayiListe)));
        }



        private void Temizle()
        {
            lvAsalSayi.Items.Clear();
            lvTekSayi.Items.Clear();
            lvCiftSayi.Items.Clear();
            lvMukemmelSayi.Items.Clear();
        }
        private void Hazirla()
        {
            mtxtBaslangic.Text = "1";
            mtxtBitis.Text = "10000";
            mtxtBaslangic.Focus();
        }
        private bool Dogrula()
        {
            try
            {
                Convert.ToInt32(mtxtBaslangic.Text);
                Convert.ToInt32(mtxtBitis.Text);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        


    }

}


