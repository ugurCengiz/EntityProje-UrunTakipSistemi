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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();


        private void BTNLİSTELE_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList();
            dataGridView1.DataSource = kategoriler;

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TXTAD.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("KATEGORİ EKLENDİ");

        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(ktgr);
            db.SaveChanges();
            MessageBox.Show("KATEGORİ SİLİNDİ");


        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var ktgr = db.TBLKATEGORI.Find(x);
            ktgr.AD = TXTAD.Text;
            db.SaveChanges();
            MessageBox.Show("KATEGORİ GÜNCELLENDİ");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
