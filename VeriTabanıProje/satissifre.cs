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
using System.Collections;


namespace VeriTabanıProje
{
    public partial class satissifre : Form
    {
       // SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public satissifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
            if (string.IsNullOrEmpty(kullaniciAd.Text) == true || string.IsNullOrEmpty(kullaniciSifre.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand al = new SqlCommand("select * from musteriler where kullaniciAd=@kullaniciAd and kullaniciSifre=@KullaniciSifre", baglanti);
                    al.Parameters.Add("@kullaniciAd", SqlDbType.VarChar, 50).Value = kullaniciAd.Text;
                    al.Parameters.Add("@kullaniciSifre", SqlDbType.VarChar, 50).Value = kullaniciSifre.Text;

                    SqlDataReader oku = al.ExecuteReader();
                    if (!oku.HasRows)
                    {

                        MessageBox.Show("Böyle Bir Kullanıcı Yok.", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        while (oku.Read())
                        {
                            string ad = (oku["KullaniciAd"].ToString());
                            string sifre = (oku["KullaniciSifre"].ToString());
                            if (ad == kullaniciAd.Text || sifre == kullaniciSifre.Text)
                            {
                                secim secim = new secim();
                                secim.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                finally
                {
                    baglanti.Close();
                }

            }*/
            /*
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=USER11\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=SSPI";
            baglanti.Open();
            string sorgu = "Select kullanici_ad from kullanicilar where yetki_id=(select yetki_id from yetki where yetki_ad='Personel') and kullanici_id in (select personel_id from personel where departman_id=(select departman_id from departman where departman_ad='Satış'))";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            string a = Convert.ToString(komut.ExecuteScalar());

            string sorgu2 = "Select kullanici_sifre from kullanicilar where yetki_id=(select yetki_id from yetki where yetki_ad='Personel') and kullanici_id in (select personel_id from personel where departman_id=(select departman_id from departman where departman_ad='Satış'))";
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
            string b = Convert.ToString(komut.ExecuteScalar());

            if (kullaniciAd.Text==a||kullaniciSifre.Text==b)
            {
                MessageBox.Show("Giriş başarılı");
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }

            baglanti.Close();*/
            try
            { 

                SqlConnection baglanti = new SqlConnection();
                
                baglanti.ConnectionString = "Data Source=USER11\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=SSPI;MultipleActiveResultSets=True" ;
                baglanti.Open();
                SqlCommand al = new SqlCommand("Select kullanici_ad,kullanici_sifre from kullanicilar where yetki_id=(select yetki_id from yetki where yetki_ad='Personel') and kullanici_id in (select personel_id from personel where departman_id=(select departman_id from departman where departman_ad='Satış'))",baglanti);
                SqlDataReader oku = al.ExecuteReader();
                if (!oku.HasRows)
                {
                    oku.Close();
                    baglanti.Close();
                }
                else
                {
                    while (oku.Read())
                    {
                        string a = (oku["kullanici_ad"].ToString()).ToString();
                        string b = (oku["kullanici_sifre"].ToString()).ToString();
                        if (kullaniciAd.Text == a || kullaniciSifre.Text == b)
                        {
                            MessageBox.Show("Giriş başarılı");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            satisyoneticisifre satisyoneticisifre = new satisyoneticisifre();
            satisyoneticisifre.Show();
            this.Hide();
        }

        private void satissifre_Load(object sender, EventArgs e)
        {
            
        }
    }
}
