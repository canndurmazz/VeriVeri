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
using System.Collections;


namespace VeriTabanıProje
{
    public partial class satissifre : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True");
        public satissifre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
            baglanti.Open();
            if (string.IsNullOrEmpty(kullanici_ad.Text) == true || string.IsNullOrEmpty(kullaici_sifre.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlCommand al = new SqlCommand("select * from Kullanicilar where kullanici_ad=@kullanici_ad and kullaici_sifre=@kullaici_sifre", baglanti);
                    al.Parameters.Add("@kullanici_ad", SqlDbType.VarChar, 50).Value = kullanici_ad.Text;
                    al.Parameters.Add("@kullaici_sifre", SqlDbType.VarChar, 50).Value = kullaici_sifre.Text;

                    SqlDataReader oku = al.ExecuteReader();
                    if (!oku.HasRows)
                    {

                        MessageBox.Show("Böyle Bir Kullanıcı Yok.", "GİRİŞ BAŞARISIZ !", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        while (oku.Read())
                        {
                            string ad = (oku["kullanici_ad"].ToString());
                            string sifre = (oku["kullaici_sifre"].ToString());
                            if (ad == kullanici_ad.Text || sifre == kullaici_sifre.Text)
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
    }
}
