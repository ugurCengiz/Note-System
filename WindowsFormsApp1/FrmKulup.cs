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
    public partial class FrmKulup : Form
    {
        public FrmKulup()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-92FPH14;Initial Catalog=BonusOkul;Integrated Security=True");
        void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter(@"Select * from TBLKULUPLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmKulup_Load(object sender, EventArgs e)
        {
            liste();

        }

        private void BTNLİSTELE_Click(object sender, EventArgs e)
        {
            liste();

        }

        private void BTNEKLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TBLKULUPLER (KULUPAD) VALUES (@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", TXTKULÜPADI.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KULÜP LİSTEYE BAŞARIYLA YÜKLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();


        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Red;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLKULUPLER SET KULUPAD=@p1 WHERE KULUPID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TXTKULÜPADI.Text);
            komut.Parameters.AddWithValue("@p2", TXTKULÜPID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KULÜP ADI BAŞARIYLA GÜNCELLENMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTKULÜPID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTKULÜPADI.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete  From TBLKULUPLER WHERE KULUPID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", TXTKULÜPID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();            
            MessageBox.Show("KULÜP BAŞARIYLA SİLİNMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();


        }
    }
}
