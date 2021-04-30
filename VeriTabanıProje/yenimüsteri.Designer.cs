
namespace VeriTabanıProje
{
    partial class yenimüsteri
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
            this.kullaniciEmail = new System.Windows.Forms.TextBox();
            this.kullaniciTelefon = new System.Windows.Forms.TextBox();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.il = new System.Windows.Forms.TextBox();
            this.ilce = new System.Windows.Forms.TextBox();
            this.mahalle = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.TextBox();
            this.sokak = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.daire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adresid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.fabrikavtDataSet = new VeriTabanıProje.fabrikavtDataSet();
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new VeriTabanıProje.fabrikavtDataSetTableAdapters.MusteriTableAdapter();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrikavtDataSet1 = new VeriTabanıProje.fabrikavtDataSet1();
            this.adresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresTableAdapter = new VeriTabanıProje.fabrikavtDataSet1TableAdapters.AdresTableAdapter();
            this.adresidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.musteriid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kullaniciEmail
            // 
            this.kullaniciEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullaniciEmail.Location = new System.Drawing.Point(157, 125);
            this.kullaniciEmail.Name = "kullaniciEmail";
            this.kullaniciEmail.Size = new System.Drawing.Size(152, 22);
            this.kullaniciEmail.TabIndex = 2;
            // 
            // kullaniciTelefon
            // 
            this.kullaniciTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullaniciTelefon.Location = new System.Drawing.Point(157, 91);
            this.kullaniciTelefon.Name = "kullaniciTelefon";
            this.kullaniciTelefon.Size = new System.Drawing.Size(152, 22);
            this.kullaniciTelefon.TabIndex = 1;
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kullaniciAdi.Location = new System.Drawing.Point(157, 61);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(152, 22);
            this.kullaniciAdi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(157, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Bilgileri Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "E-Posta Adresiniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefon Numaranız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adınız";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(682, -2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(24, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "-------------------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(445, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "------------------------------------------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(314, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Adres Bilgileri";
            // 
            // il
            // 
            this.il.Location = new System.Drawing.Point(157, 249);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(100, 22);
            this.il.TabIndex = 3;
            // 
            // ilce
            // 
            this.ilce.Location = new System.Drawing.Point(157, 277);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(100, 22);
            this.ilce.TabIndex = 4;
            this.ilce.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // mahalle
            // 
            this.mahalle.Location = new System.Drawing.Point(157, 305);
            this.mahalle.Name = "mahalle";
            this.mahalle.Size = new System.Drawing.Size(100, 22);
            this.mahalle.TabIndex = 5;
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(593, 250);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(100, 22);
            this.no.TabIndex = 7;
            // 
            // sokak
            // 
            this.sokak.Location = new System.Drawing.Point(593, 222);
            this.sokak.Name = "sokak";
            this.sokak.Size = new System.Drawing.Size(100, 22);
            this.sokak.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(24, 254);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "İl :";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(24, 282);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "İlçe :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(24, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 52;
            this.label15.Text = "Mahalle :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(460, 222);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 54;
            this.label17.Text = "Sokak :";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(460, 253);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 17);
            this.label18.TabIndex = 55;
            this.label18.Text = "No :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(541, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 28);
            this.button2.TabIndex = 56;
            this.button2.Text = "Adresi Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(648, -2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 57;
            this.label6.Text = "<";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(460, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Daire :";
            // 
            // daire
            // 
            this.daire.Location = new System.Drawing.Point(593, 278);
            this.daire.Name = "daire";
            this.daire.Size = new System.Drawing.Size(100, 22);
            this.daire.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "Adres ID :";
            // 
            // adresid
            // 
            this.adresid.Location = new System.Drawing.Point(157, 219);
            this.adresid.Name = "adresid";
            this.adresid.Size = new System.Drawing.Size(100, 22);
            this.adresid.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(326, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(177, 133);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adresidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adresBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(516, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(177, 133);
            this.dataGridView2.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 64;
            this.label7.Text = "Son Müşteri ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(513, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 17);
            this.label12.TabIndex = 65;
            this.label12.Text = "Son Adres ID:";
            // 
            // fabrikavtDataSet
            // 
            this.fabrikavtDataSet.DataSetName = "fabrikavtDataSet";
            this.fabrikavtDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            this.musteriBindingSource.DataSource = this.fabrikavtDataSet;
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriidDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabrikavtDataSet1
            // 
            this.fabrikavtDataSet1.DataSetName = "fabrikavtDataSet1";
            this.fabrikavtDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adresBindingSource
            // 
            this.adresBindingSource.DataMember = "Adres";
            this.adresBindingSource.DataSource = this.fabrikavtDataSet1;
            // 
            // adresTableAdapter
            // 
            this.adresTableAdapter.ClearBeforeFill = true;
            // 
            // adresidDataGridViewTextBoxColumn
            // 
            this.adresidDataGridViewTextBoxColumn.DataPropertyName = "adres_id";
            this.adresidDataGridViewTextBoxColumn.HeaderText = "adres_id";
            this.adresidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresidDataGridViewTextBoxColumn.Name = "adresidDataGridViewTextBoxColumn";
            this.adresidDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresidDataGridViewTextBoxColumn.Width = 125;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(14, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 17);
            this.label16.TabIndex = 67;
            this.label16.Text = "Müsteri ID :";
            // 
            // musteriid
            // 
            this.musteriid.Location = new System.Drawing.Point(157, 31);
            this.musteriid.Name = "musteriid";
            this.musteriid.Size = new System.Drawing.Size(152, 22);
            this.musteriid.TabIndex = 66;
            // 
            // yenimüsteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(708, 365);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.musteriid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adresid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.daire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sokak);
            this.Controls.Add(this.no);
            this.Controls.Add(this.mahalle);
            this.Controls.Add(this.ilce);
            this.Controls.Add(this.il);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kullaniciEmail);
            this.Controls.Add(this.kullaniciTelefon);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yenimüsteri";
            this.Text = "yenimüsteri";
            this.Load += new System.EventHandler(this.yenimüsteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox kullaniciEmail;
        private System.Windows.Forms.TextBox kullaniciTelefon;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox il;
        private System.Windows.Forms.TextBox ilce;
        private System.Windows.Forms.TextBox mahalle;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox sokak;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox daire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adresid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private fabrikavtDataSet fabrikavtDataSet;
        private System.Windows.Forms.BindingSource musteriBindingSource;
        private fabrikavtDataSetTableAdapters.MusteriTableAdapter musteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private fabrikavtDataSet1 fabrikavtDataSet1;
        private System.Windows.Forms.BindingSource adresBindingSource;
        private fabrikavtDataSet1TableAdapters.AdresTableAdapter adresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox musteriid;
    }
}