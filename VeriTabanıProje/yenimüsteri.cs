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
    public partial class yenimüsteri : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=CANPC\\SQLEXPRESS;Initial Catalog=fabrikavt;Integrated Security=True");
        public yenimüsteri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(musteri_adsoyad.Text) == true  || string.IsNullOrEmpty(musteri_tel.Text) == true
                || string.IsNullOrEmpty(musteri_mail.Text) == true 
                || string.IsNullOrEmpty(il.Text) == true || string.IsNullOrEmpty(ilce.Text) == true
                || string.IsNullOrEmpty(mahalle.Text) == true || string.IsNullOrEmpty(sokak.Text) == true
                || string.IsNullOrEmpty(no.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Musteri(musteri_adsoyad,musteri_tel,musteri_mail) values (@musteri_adsoyad,@musteri_tel,@musteri_mail)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@musteri_adsoyad", musteri_adsoyad.Text);                
                    komut.Parameters.AddWithValue("@musteri_tel", musteri_tel.Text);
                    komut.Parameters.AddWithValue("@musteri_mail", musteri_mail.Text);                
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    try
                    {
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        string kayitt = "insert into Adress(il,ilce,mahalle,sokak,no,daire) values (@il,@ilce,@mahalle,@sokak,@no,@daire)";
                        SqlCommand komutt = new SqlCommand(kayitt, baglanti);
                        komut.Parameters.AddWithValue("@il", il.Text);
                        komut.Parameters.AddWithValue("@ilce", ilce.Text);
                        komut.Parameters.AddWithValue("@mahalle", mahalle.Text);
                        komut.Parameters.AddWithValue("@sokak", sokak.Text);
                        komut.Parameters.AddWithValue("@no", no.Text);
                        komut.Parameters.AddWithValue("@daire", daire.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Adres Kaydı Başarılı !");
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                    }
                    MessageBox.Show("Müşteri Kaydı Başarılı !");
                }
                catch (Exception hata)
                {
                   MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void yenimüsteri_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(musteri_adsoyad.Text) == true || string.IsNullOrEmpty(musteri_tel.Text) == true
               || string.IsNullOrEmpty(musteri_mail.Text) == true
               || string.IsNullOrEmpty(il.Text) == true || string.IsNullOrEmpty(ilce.Text) == true
               || string.IsNullOrEmpty(mahalle.Text) == true || string.IsNullOrEmpty(sokak.Text) == true
               || string.IsNullOrEmpty(no.Text) == true)
            {
                MessageBox.Show("Bu Alanlar Boş Bırakılamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into Adress(il,ilce,mahalle,sokak,no,daire) values (@il,@ilce,@mahalle,@sokak,@no,@daire)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);                 
                    komut.Parameters.AddWithValue("@il", il.Text);
                    komut.Parameters.AddWithValue("@ilce", ilce.Text);
                    komut.Parameters.AddWithValue("@mahalle", mahalle.Text);                 
                    komut.Parameters.AddWithValue("@sokak", sokak.Text);
                    komut.Parameters.AddWithValue("@no", no.Text);
                    komut.Parameters.AddWithValue("@daire", daire.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Adres Kaydı Başarılı !");
                }
                catch (Exception hata)
                {
                    MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            kmc kmc = new kmc();
            kmc.Show();
            this.Hide();
        }
    }
}
