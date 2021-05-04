using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace VeriTabanıProje
{
    public partial class kullaniciekle : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        SqlDataAdapter da2;
        public kullaniciekle()
        {
            InitializeComponent();
        }
        void PersonelGetir()
        {
            try
            {
                baglanti = new SqlConnection("Data Source=USER11\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=SSPI;MultipleActiveResultSets=True");
                baglanti.Open();     
                da = new SqlDataAdapter("Select personel_id as ID,personel_ad as AD,personel_soyad as Soyad,personel_tel as TEL, personel_mail as Mail," +
                    "personel_cinsiyet as Cinsiyet,personel_dogumTarihi as 'Doğum Tarihi',personel_tc as TC," +
                    "personel_girisTarihi as 'Giriş Tarih',personel_maas as Maaş,adres_id as Adres , departman.departman_ad from personel inner join departman on departman.departman_id=personel.departman_id ", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;

                da2 = new SqlDataAdapter("Select kullanici_id,kullanici_ad,kullanici_sifre, yetki.yetki_ad from kullanicilar inner join yetki on kullanicilar.yetki_id=yetki.yetki_id",baglanti);
                DataTable tablo2 = new DataTable();
                da2.Fill(tablo2);
                dataGridView2.DataSource = tablo2;
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        void Combo()
        {
            try
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=USER11\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=SSPI;MultipleActiveResultSets=True";
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT * FROM yetki";
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                baglanti.Open();
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr["yetki_ad"]);
                }
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        private void kullaniciekle_Load(object sender, EventArgs e)
        {
            Combo();
            PersonelGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
           
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textkAd.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textkSifre.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
