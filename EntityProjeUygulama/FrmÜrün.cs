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
    public partial class FrmÜrün : Form
    {
        public FrmÜrün()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.STOK,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.DURUM

                                        }
                                        ).ToList();


        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            TBLURUN t = new TBLURUN();
            t.URUNAD = TXTÜRÜNAD.Text;
            t.MARKA = TXTMARKA.Text;
            t.STOK = short.Parse(TXTSTOK.Text);
            t.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(TXTFİYAT.Text);
            t.DURUM = true;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN BAŞARIYLA EKLENDİ");
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var urun = db.TBLURUN.Find(x);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("ÜRÜN BAŞARIYLA SİLİNDİ");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTÜRÜNAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTMARKA.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTSTOK.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXTFİYAT.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTDURUM.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TXTID.Text);
            var urun = db.TBLURUN.Find(x);
            urun.URUNAD = TXTÜRÜNAD.Text;
            urun.MARKA = TXTMARKA.Text;
            urun.STOK = short.Parse(TXTSTOK.Text);
            urun.KATEGORI = int.Parse(comboBox1.SelectedValue.ToString());
            urun.FIYAT = decimal.Parse(TXTFİYAT.Text);
            urun.DURUM = true;
            db.SaveChanges();
            MessageBox.Show("ÜRÜN  GÜNCELLENDİ");

        }

        private void FrmÜrün_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "AD";
            comboBox1.DataSource = kategoriler;


        }

        private void BTNTEMİZLE_Click(object sender, EventArgs e)
        {
            
        }
    }
}
