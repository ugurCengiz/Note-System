using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class FrmÖğrenci : Form
    {
        public FrmÖğrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-92FPH14;Initial Catalog=BonusOkul;Integrated Security=True");
        string c = "";

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void FrmÖğrenci_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.ÖğrenciListesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);            
            CMBKULÜP.DisplayMember = "KULUPAD";
            CMBKULÜP.ValueMember = "KULUPID";
            CMBKULÜP.DataSource = dt;
            baglanti.Close();

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            
            if (RDBTNKIZ.Checked== true)
            {
                c = "Kız";

            }
            if(RDBTNERKEK.Checked== true)
            {
                c = "Erkek";
                
            }
            ds.ÖğrenciEkle(TXTAD.Text, TXTSOYAD.Text, byte.Parse(CMBKULÜP.SelectedValue.ToString()), c);
            MessageBox.Show("ÖĞRENCİ LİSTEYE BAŞARIYLA EKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNLİSTELE_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListesi();

        }

        private void CMBKULÜP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //KULÜPLERİN ID'SİNİ GETİRME
            //TXTID.Text = CMBKULÜP.SelectedValue.ToString();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciSil(int.Parse(TXTID.Text));
            MessageBox.Show("ÖĞRENCİ BİLGİLERİ BAŞARIYLA SİLİNDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciGüncelle(TXTAD.Text, TXTSOYAD.Text, byte.Parse(CMBKULÜP.SelectedValue.ToString()), c,int.Parse (TXTID.Text)); ;
            MessageBox.Show("ÖĞRENCİ BİLGİLERİ BAŞARIYLA GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTAD.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTSOYAD.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CMBKULÜP.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();         
           


        }

        private void RDBTNKIZ_CheckedChanged(object sender, EventArgs e)
        {
            if (RDBTNKIZ.Checked == true)
            {
                c = "Kız";

            }
            
        }

        private void RDBTNERKEK_CheckedChanged(object sender, EventArgs e)
        {
            
            if (RDBTNERKEK.Checked == true)
            {
                c = "Erkek";

            }
        }

        private void BTNARA_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ds.ÖğrenciGetir(TXTARA.Text);


        }
    }
}
