﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DemirokPansiyonV._1
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9G2OPQN\SQLEXPRESS;Initial Catalog=DemirokPansiyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt16(LblPersonelMaas.Text) + Convert.ToInt16(LblAlinanUrunler1.Text) + Convert.ToInt16(LblAlinanUrunler2.Text) + Convert.ToInt16(LblAlinanUrunler3.Text) + Convert.ToInt16(LblFaturalar1.Text) + Convert.ToInt16(LblFaturalar2.Text) + Convert.ToInt16(LblFaturalar3.Text));
            LblSonuc.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Ücret
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            //Gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(Gida) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();

            //İçecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(Icecek) as toplam2 from Stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblAlinanUrunler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();

            //Atıştırmalıklar
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(Cerezler) as toplam3 from Stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblAlinanUrunler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            //Elektrik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Elektrik) as ftoplam from Faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblFaturalar1.Text = oku5["ftoplam"].ToString();
            }
            baglanti.Close();

            //Su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(Su) as ftoplam1 from Faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturalar2.Text = oku6["ftoplam1"].ToString();
            }
            baglanti.Close();

            //İnternet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Internet) as ftoplam2 from Faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblFaturalar3.Text = oku7["ftoplam2"].ToString();
            }
            baglanti.Close();
        }

        private void BtnPersonelKaydet_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            LblPersonelMaas.Text = (personel * 1500).ToString();
        }
    }
}
