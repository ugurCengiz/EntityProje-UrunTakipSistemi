using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void BTNKATEGORİ_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.Show();
        }

        private void BTNÜRÜNİŞLEMLERİ_Click(object sender, EventArgs e)
        {
            FrmÜrün frm2 = new FrmÜrün();
            frm2.Show();
        }

        private void BTNİSTATİSTİK_Click(object sender, EventArgs e)
        {
            Frmİstatsitik frm3 = new Frmİstatsitik();
            frm3.Show();

        }
    }
}
