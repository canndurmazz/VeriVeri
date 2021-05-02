using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriTabanıProje
{
    public partial class ikMenu : Form
    {
        public ikMenu()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ikPersonelislem ikper = new ikPersonelislem();
            ikper.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ikDepartmanislem ikdep = new ikDepartmanislem();
            ikdep.Show();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            kmc giris = new kmc();
            giris.Show();
        }
    }
}
