
namespace VeriTabanıProje
{
    partial class istek
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
            this.fabrikavtDataSet5 = new VeriTabanıProje.fabrikavtDataSet5();
            this.ıstekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istekTableAdapter = new VeriTabanıProje.fabrikavtDataSet5TableAdapters.IstekTableAdapter();
            this.ileti = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fabrikavtDataSet6 = new VeriTabanıProje.fabrikavtDataSet6();
            this.ıstekBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.istekTableAdapter1 = new VeriTabanıProje.fabrikavtDataSet6TableAdapters.IstekTableAdapter();
            this.istekcombo = new System.Windows.Forms.ComboBox();
            this.fabrikavtDataSet7 = new VeriTabanıProje.fabrikavtDataSet7();
            this.ıstekBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.istekTableAdapter2 = new VeriTabanıProje.fabrikavtDataSet7TableAdapters.IstekTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // fabrikavtDataSet5
            // 
            this.fabrikavtDataSet5.DataSetName = "fabrikavtDataSet5";
            this.fabrikavtDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıstekBindingSource
            // 
            this.ıstekBindingSource.DataMember = "Istek";
            this.ıstekBindingSource.DataSource = this.fabrikavtDataSet5;
            // 
            // istekTableAdapter
            // 
            this.istekTableAdapter.ClearBeforeFill = true;
            // 
            // ileti
            // 
            this.ileti.Location = new System.Drawing.Point(12, 48);
            this.ileti.Multiline = true;
            this.ileti.Name = "ileti";
            this.ileti.Size = new System.Drawing.Size(512, 106);
            this.ileti.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(418, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "İsteği İlet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fabrikavtDataSet6
            // 
            this.fabrikavtDataSet6.DataSetName = "fabrikavtDataSet6";
            this.fabrikavtDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıstekBindingSource1
            // 
            this.ıstekBindingSource1.DataMember = "Istek";
            this.ıstekBindingSource1.DataSource = this.fabrikavtDataSet6;
            // 
            // istekTableAdapter1
            // 
            this.istekTableAdapter1.ClearBeforeFill = true;
            // 
            // istekcombo
            // 
            this.istekcombo.FormattingEnabled = true;
            this.istekcombo.Items.AddRange(new object[] {
            "Satış Departmanı",
            "Satın Alma Departmanı",
            "Üretim Departmanı",
            "Finans Departmanı",
            "İnsan Kaynakları Departmanı"});
            this.istekcombo.Location = new System.Drawing.Point(12, 12);
            this.istekcombo.Name = "istekcombo";
            this.istekcombo.Size = new System.Drawing.Size(215, 24);
            this.istekcombo.TabIndex = 3;
            this.istekcombo.SelectedIndexChanged += new System.EventHandler(this.istekcombo_SelectedIndexChanged);
            // 
            // fabrikavtDataSet7
            // 
            this.fabrikavtDataSet7.DataSetName = "fabrikavtDataSet7";
            this.fabrikavtDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ıstekBindingSource2
            // 
            this.ıstekBindingSource2.DataMember = "Istek";
            this.ıstekBindingSource2.DataSource = this.fabrikavtDataSet7;
            // 
            // istekTableAdapter2
            // 
            this.istekTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(504, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // istek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(531, 197);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.istekcombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ileti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "istek";
            this.Text = "istek";
            this.Load += new System.EventHandler(this.istek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabrikavtDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıstekBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private fabrikavtDataSet5 fabrikavtDataSet5;
        private System.Windows.Forms.BindingSource ıstekBindingSource;
        private fabrikavtDataSet5TableAdapters.IstekTableAdapter istekTableAdapter;
        private System.Windows.Forms.TextBox ileti;
        private System.Windows.Forms.Button button1;
        private fabrikavtDataSet6 fabrikavtDataSet6;
        private System.Windows.Forms.BindingSource ıstekBindingSource1;
        private fabrikavtDataSet6TableAdapters.IstekTableAdapter istekTableAdapter1;
        private System.Windows.Forms.ComboBox istekcombo;
        private fabrikavtDataSet7 fabrikavtDataSet7;
        private System.Windows.Forms.BindingSource ıstekBindingSource2;
        private fabrikavtDataSet7TableAdapters.IstekTableAdapter istekTableAdapter2;
        private System.Windows.Forms.Label label1;
    }
}