﻿
namespace VeriTabanıProje
{
    partial class siparis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.stok = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fabrikavtDataSet2 = new VeriTabanıProje.fabrikavtDataSet2();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new VeriTabanıProje.fabrikavtDataSet2TableAdapters.MusteriTableAdapter();
            this.fabrikavtDataSet3 = new VeriTabanıProje.fabrikavtDataSet3();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new VeriTabanıProje.fabrikavtDataSet3TableAdapters.UrunTableAdapter();
            this.mustericombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunbrfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fabrikavtDataSet4 = new VeriTabanıProje.fabrikavtDataSet4();
            this.urunTableAdapter1 = new VeriTabanıProje.fabrikavtDataSet4TableAdapters.UrunTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.miktar = new System.Windows.Forms.TextBox();
            this.onayla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.urun_miktar = new System.Windows.Forms.TextBox();
            this.toplamfiyat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.birimfiyat = new System.Windows.Forms.TextBox();
            this.labelbirim = new System.Windows.Forms.Label();
            this.hesapla = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uruncombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok :";
            // 
            // stok
            // 
            this.stok.Enabled = false;
            this.stok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stok.Location = new System.Drawing.Point(158, 107);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(177, 22);
            this.stok.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(381, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Yeni Sipariş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(887, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Müşteri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(864, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "<";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // fabrikavtDataSet2
            // 
            this.fabrikavtDataSet2.DataSetName = "fabrikavtDataSet2";
            this.fabrikavtDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.fabrikavtDataSet2;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // fabrikavtDataSet3
            // 
            this.fabrikavtDataSet3.DataSetName = "fabrikavtDataSet3";
            this.fabrikavtDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "Urun";
            this.urunBindingSource.DataSource = this.fabrikavtDataSet3;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // mustericombo
            // 
            this.mustericombo.FormattingEnabled = true;
            this.mustericombo.Location = new System.Drawing.Point(158, 32);
            this.mustericombo.Name = "mustericombo";
            this.mustericombo.Size = new System.Drawing.Size(177, 24);
            this.mustericombo.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunadDataGridViewTextBoxColumn,
            this.urunbrfiyatDataGridViewTextBoxColumn,
            this.urunmiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.Location = new System.Drawing.Point(342, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(571, 232);
            this.dataGridView1.TabIndex = 16;
            // 
            // urunadDataGridViewTextBoxColumn
            // 
            this.urunadDataGridViewTextBoxColumn.DataPropertyName = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.HeaderText = "urun_ad";
            this.urunadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadDataGridViewTextBoxColumn.Name = "urunadDataGridViewTextBoxColumn";
            this.urunadDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunadDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunbrfiyatDataGridViewTextBoxColumn
            // 
            this.urunbrfiyatDataGridViewTextBoxColumn.DataPropertyName = "urun_brfiyat";
            this.urunbrfiyatDataGridViewTextBoxColumn.HeaderText = "urun_brfiyat";
            this.urunbrfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunbrfiyatDataGridViewTextBoxColumn.Name = "urunbrfiyatDataGridViewTextBoxColumn";
            this.urunbrfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunbrfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunmiktarDataGridViewTextBoxColumn
            // 
            this.urunmiktarDataGridViewTextBoxColumn.DataPropertyName = "urun_miktar";
            this.urunmiktarDataGridViewTextBoxColumn.HeaderText = "urun_miktar";
            this.urunmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunmiktarDataGridViewTextBoxColumn.Name = "urunmiktarDataGridViewTextBoxColumn";
            this.urunmiktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.urunmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunBindingSource1
            // 
            this.urunBindingSource1.DataMember = "Urun";
            this.urunBindingSource1.DataSource = this.fabrikavtDataSet4;
            // 
            // fabrikavtDataSet4
            // 
            this.fabrikavtDataSet4.DataSetName = "fabrikavtDataSet4";
            this.fabrikavtDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter1
            // 
            this.urunTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Miktar :";
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(158, 144);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(177, 22);
            this.miktar.TabIndex = 18;
            this.miktar.TextChanged += new System.EventHandler(this.miktar_TextChanged);
            // 
            // onayla
            // 
            this.onayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.onayla.Location = new System.Drawing.Point(192, 270);
            this.onayla.Name = "onayla";
            this.onayla.Size = new System.Drawing.Size(144, 37);
            this.onayla.TabIndex = 19;
            this.onayla.Text = "Onayla";
            this.onayla.UseVisualStyleBackColor = true;
            this.onayla.Click += new System.EventHandler(this.onayla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kalan Stok :";
            // 
            // urun_miktar
            // 
            this.urun_miktar.Enabled = false;
            this.urun_miktar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun_miktar.Location = new System.Drawing.Point(158, 210);
            this.urun_miktar.Name = "urun_miktar";
            this.urun_miktar.Size = new System.Drawing.Size(177, 22);
            this.urun_miktar.TabIndex = 21;
            this.urun_miktar.TextChanged += new System.EventHandler(this.kalanstok_TextChanged);
            // 
            // toplamfiyat
            // 
            this.toplamfiyat.Enabled = false;
            this.toplamfiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toplamfiyat.Location = new System.Drawing.Point(159, 242);
            this.toplamfiyat.Name = "toplamfiyat";
            this.toplamfiyat.Size = new System.Drawing.Size(177, 22);
            this.toplamfiyat.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(9, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Toplam Tutar :";
            // 
            // birimfiyat
            // 
            this.birimfiyat.Enabled = false;
            this.birimfiyat.Location = new System.Drawing.Point(159, 177);
            this.birimfiyat.Name = "birimfiyat";
            this.birimfiyat.Size = new System.Drawing.Size(177, 22);
            this.birimfiyat.TabIndex = 25;
            this.birimfiyat.TextChanged += new System.EventHandler(this.birimfiyat_TextChanged);
            // 
            // labelbirim
            // 
            this.labelbirim.AutoSize = true;
            this.labelbirim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelbirim.Location = new System.Drawing.Point(9, 182);
            this.labelbirim.Name = "labelbirim";
            this.labelbirim.Size = new System.Drawing.Size(81, 17);
            this.labelbirim.TabIndex = 24;
            this.labelbirim.Text = "Birim Fiyat :";
            // 
            // hesapla
            // 
            this.hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapla.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hesapla.Location = new System.Drawing.Point(12, 270);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(144, 37);
            this.hesapla.TabIndex = 26;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(835, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "_";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(575, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 37);
            this.button1.TabIndex = 28;
            this.button1.Text = "Gelen Mesaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(769, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 37);
            this.button3.TabIndex = 29;
            this.button3.Text = "Yeni Mesaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün :";
            // 
            // uruncombo
            // 
            this.uruncombo.FormattingEnabled = true;
            this.uruncombo.Location = new System.Drawing.Point(158, 70);
            this.uruncombo.Name = "uruncombo";
            this.uruncombo.Size = new System.Drawing.Size(177, 24);
            this.uruncombo.TabIndex = 15;
            this.uruncombo.SelectedIndexChanged += new System.EventHandler(this.uruncombo_SelectedIndexChanged);
            // 
            // siparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(913, 316);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.hesapla);
            this.Controls.Add(this.birimfiyat);
            this.Controls.Add(this.labelbirim);
            this.Controls.Add(this.toplamfiyat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.urun_miktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.onayla);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uruncombo);
            this.Controls.Add(this.mustericombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "siparis";
            this.Text = "kayitlimüsteri";
            this.Load += new System.EventHandler(this.kayitlimüsteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stok;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private fabrikavtDataSet2 fabrikavtDataSet2;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private fabrikavtDataSet2TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private fabrikavtDataSet3 fabrikavtDataSet3;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private fabrikavtDataSet3TableAdapters.UrunTableAdapter urunTableAdapter;
        private System.Windows.Forms.ComboBox mustericombo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private fabrikavtDataSet4 fabrikavtDataSet4;
        private System.Windows.Forms.BindingSource urunBindingSource1;
        private fabrikavtDataSet4TableAdapters.UrunTableAdapter urunTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Button onayla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urun_miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunbrfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunmiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox toplamfiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox birimfiyat;
        private System.Windows.Forms.Label labelbirim;
        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uruncombo;
    }
}