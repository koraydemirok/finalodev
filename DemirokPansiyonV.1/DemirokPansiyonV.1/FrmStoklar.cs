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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9G2OPQN\SQLEXPRESS;Initial Catalog=DemirokPansiyon;Integrated Security=True");

        private void veriler()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void BtnStokKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stoklar(Gida,Icecek,Cerezler) values ('" + TxtGidalar.Text + "','" + TxtIcecekler.Text + "','" + TxtAtistirmaliklar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler();
        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
