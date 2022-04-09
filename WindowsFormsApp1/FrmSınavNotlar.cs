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
    public partial class FrmSınavNotlar : Form
    {
        public FrmSınavNotlar()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-92FPH14;Initial Catalog=BonusOkul;Integrated Security=True");
        


        private void BTNARA_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(TXTID.Text));


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSınavNotlar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLDERSLER", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboxBox1.DisplayMember = "DERSAD";
            comboxBox1.ValueMember = "DERSID";
            comboxBox1.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notıd= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            TXTID.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TXTSINAV1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TXTSINAV2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TXTSINAV3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TXTPROJE.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TXTORTALAMA.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            TXTDURUM.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int sınav1, sınav2, sınav3, proje;
        double ortalama;

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void BTNHESAPLA_Click(object sender, EventArgs e)
        {
            
            //string durum;
            sınav1 = Convert.ToInt16(TXTSINAV1.Text);
            sınav2 = Convert.ToInt16(TXTSINAV2.Text);
            sınav3 = Convert.ToInt16(TXTSINAV3.Text);
            proje = Convert.ToInt16(TXTPROJE.Text);
            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;
            TXTORTALAMA.Text = ortalama.ToString();
            if (ortalama >=50)
            {
                TXTDURUM.Text = "True";

            }
            else
            {
                TXTDURUM.Text = "False";     
            }



        }
        int notıd;

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
          
          ds.NotGüncelle(byte.Parse(comboxBox1.SelectedValue.ToString()), int.Parse(TXTID.Text), byte.Parse(TXTSINAV1.Text), byte.Parse(TXTSINAV2.Text), byte.Parse(TXTSINAV3.Text), byte.Parse(TXTPROJE.Text), decimal.Parse(TXTORTALAMA.Text), bool.Parse(TXTDURUM.Text), notıd);
        }
    }
}
