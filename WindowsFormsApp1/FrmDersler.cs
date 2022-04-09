using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDersler : Form
    {
        public FrmDersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLDERSLERTableAdapter ds = new DataSet1TableAdapters.TBLDERSLERTableAdapter();

        private void FrmDersler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            ds.DersEKle(TXTDERSPADI.Text);
            MessageBox.Show("DERS LİSTEYE BAŞARIYLA YÜKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BTNLİSTELE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            ds.DersGüncelleme(TXTDERSPADI.Text,byte.Parse (TXTDERSID.Text));
            MessageBox.Show("DERS  BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(TXTDERSID.Text));
            MessageBox.Show("DERS BAŞARIYLA SİLİNDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTDERSID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTDERSPADI.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
