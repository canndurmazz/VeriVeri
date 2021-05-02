﻿using System;
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
    public partial class ikDepartmanislem : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public ikDepartmanislem()
        {
            InitializeComponent();
        }
        public DataTable Ara(string ara)
        {
            try
            {
                DataTable tbl = new DataTable();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(ara, baglanti);
                adtr.Fill(tbl);
                dataGridView2.DataSource = tbl;
                baglanti.Close();
                return tbl;
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                return null;
            }
        }
        void PersonelGetir()
        {
            try
            {
                baglanti = new SqlConnection("server =USER11\\SQLEXPRESS; Initial Catalog = fabrikavt; Integrated Security = SSPI");
                baglanti.Open();
                da = new SqlDataAdapter("Select personel_id as 'Personel id',personel_ad as 'Personel ad',personel_soyad 'Personel soyad' from personel", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView2.DataSource = tablo;
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        void Getir()
        {
            try
            {
                baglanti = new SqlConnection("server =USER11\\SQLEXPRESS; Initial Catalog = fabrikavt; Integrated Security = SSPI");
                baglanti.Open();
                da = new SqlDataAdapter("Select * from departman", baglanti);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
               
               baglanti.Open();
               string sorgu4 = "select top 1 departman_id from departman order by departman_id desc";
               SqlCommand cmd3 = new SqlCommand(sorgu4, baglanti);
               int did = 1;
               if (cmd3.ExecuteScalar() != null)
               {
                    did = Convert.ToInt32(cmd3.ExecuteScalar());
                    did = did + 1;
               }

                string sorgu = "insert into departman values(@departman_id,@departman_ad,@yonetici_id)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@departman_id", did);
                komut.Parameters.AddWithValue("@departman_ad", textDepad.Text);
                komut.Parameters.AddWithValue("@yonetici_id", textYonetici.Text);
                //baglanti.Open();
                komut.ExecuteNonQuery();
                Getir();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
                baglanti.Close();
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "delete from departman where departman_id=@departman_id";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@departman_id", Convert.ToInt32(textDepid.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Getir();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDepad.Text) || string.IsNullOrEmpty(textDepid.Text) || string.IsNullOrEmpty(textYonetici.Text) || string.IsNullOrWhiteSpace(textYonetici.Text))
            {
                MessageBox.Show("Boş alan bırakılamaz");
            }
            else
            {
                try
                {
                    string sorgu = "update departman set departman_id=@departman_id,departman_ad=@departman_ad,yonetici_id=@yonetici_id where departman_id=@departman_id";
                    komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@departman_id", Convert.ToInt32(textDepid.Text));
                    komut.Parameters.AddWithValue("@departman_ad", textDepad.Text);
                    komut.Parameters.AddWithValue("@yonetici_id", textYonetici.Text);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    Getir();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textDepid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textDepad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textYonetici.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textYonetici.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void ikDepartmanislem_Load(object sender, EventArgs e)
        {
            PersonelGetir();
            Getir();
        }

        private void textAra_TextChanged(object sender, EventArgs e)
        {
            Ara("Select personel_id as 'Personel id',personel_ad as 'Personel ad',personel_soyad 'Personel soyad' from personel where personel_ad like'" + textAra.Text + "%'");
        }
    }
}
