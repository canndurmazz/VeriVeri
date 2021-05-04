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

namespace VeriTabanıProje
{
    public partial class satinalma : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True;MultipleActiveResultSets=True;");
        public satinalma()
        {
            InitializeComponent();
        }

        private void satinalma_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'fabrikavtDataSet17.Hammadde' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hammaddeTableAdapter2.Fill(this.fabrikavtDataSet17.Hammadde);
            // TODO: Bu kod satırı 'fabrikavtDataSet16.Hammadde' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hammaddeTableAdapter1.Fill(this.fabrikavtDataSet16.Hammadde);
            // TODO: Bu kod satırı 'fabrikavtDataSet15.Hammadde' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.hammaddeTableAdapter.Fill(this.fabrikavtDataSet15.Hammadde);

        }

        private void mustericombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hamcombo.SelectedIndex == 0)
            {
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT * from hammadde where hammadde_id = 1", baglanti);
                SqlDataReader okuc = cek.ExecuteReader();
                while (okuc.Read())
                {
                    stok.Text = okuc["hammadde_miktar"].ToString();
                    birimfiyat.Text = okuc["hammadde_brfiyat"].ToString();
                }
                baglanti.Close();
            }
            if (hamcombo.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT * from hammadde where hammadde_id = 2", baglanti);
                SqlDataReader okuc = cek.ExecuteReader();
                while (okuc.Read())
                {
                    stok.Text = okuc["hammadde_miktar"].ToString();
                    birimfiyat.Text = okuc["hammadde_brfiyat"].ToString();
                }
                baglanti.Close();
            }
            if (hamcombo.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT * from hammadde where hammadde_id = 3", baglanti);
                SqlDataReader okuc = cek.ExecuteReader();
                while (okuc.Read())
                {
                    stok.Text = okuc["hammadde_miktar"].ToString();
                    birimfiyat.Text = okuc["hammadde_brfiyat"].ToString();
                }
                baglanti.Close();
            }
        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(miktar.Text);
            double b = Double.Parse(birimfiyat.Text);
            toplamfiyat.Text = (a * b).ToString();
            hammadde_miktar.Text = (int.Parse(stok.Text) + int.Parse(miktar.Text)).ToString();
        }

        private void onayla_Click(object sender, EventArgs e)
        {
            if (hamcombo.SelectedIndex == 0)
            {
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT * from Hammadde where hammadde_id = 1", baglanti);
                SqlDataReader okuc = cek.ExecuteReader();
                string kayit = "update Hammadde set hammadde_miktar=@hammadde_miktar where hammadde_id=1";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                while (okuc.Read())
                {
                    int a = int.Parse(miktar.Text) + int.Parse(stok.Text);
                        MessageBox.Show("Hammadde Alımı Başarıyla Kaydedildi", "Onaylandı !");
                        komut.Parameters.AddWithValue("@hammadde_miktar", a);
                        komut.ExecuteNonQuery();                                    
                }
            }
            baglanti.Close();
            if (hamcombo.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT * from Hammadde where hammadde_id = 2", baglanti);
                SqlDataReader okuc = cek.ExecuteReader();
                string kayit = "update Hammadde set hammadde_miktar=@hammadde_miktar where hammadde_id=2";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                while (okuc.Read())
                {
                    int a = int.Parse(miktar.Text) + int.Parse(stok.Text);
                    MessageBox.Show("Hammadde Alımı Başarıyla Kaydedildi", "Onaylandı !");
                    komut.Parameters.AddWithValue("@hammadde_miktar", a);
                    komut.ExecuteNonQuery();

                    dataGridView1.Refresh();
                }
                okuc.Close();
            }
            baglanti.Close();
            if (hamcombo.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlCommand cek = new SqlCommand("SELECT * from Hammadde where hammadde_id = 2", baglanti);
                SqlDataReader okuc = cek.ExecuteReader();
                string kayit = "update Hammadde set hammadde_miktar=@hammadde_miktar where hammadde_id=2";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                while (okuc.Read())
                {
                    int a = int.Parse(miktar.Text) + int.Parse(stok.Text);
                    MessageBox.Show("Hammadde Alımı Başarıyla Kaydedildi", "Onaylandı !");
                    komut.Parameters.AddWithValue("@hammadde_miktar", a);
                    komut.ExecuteNonQuery();

                    dataGridView1.Refresh();
                }
                okuc.Close();
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            satinalma satinalma = new satinalma();
            satinalma.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            satinmesaj satinmesaj = new satinmesaj();
            satinmesaj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            istek istek = new istek();
            istek.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;

                else
                    this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
