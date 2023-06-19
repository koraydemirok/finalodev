using System;
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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9G2OPQN\SQLEXPRESS;Initial Catalog=DemirokPansiyon;Integrated Security=True");

        private void faturaveri()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Elektrik"].ToString();
                ekle.SubItems.Add(oku["Su"].ToString());
                ekle.SubItems.Add(oku["Internet"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            faturaveri();
        }

        private void BtnFaturaKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Faturalar(Elektrik,Su,Internet) values ('" + TxtElektrik.Text + "','" + TxtSu.Text + "','" + TxtInternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            faturaveri();
        }
    }
}
