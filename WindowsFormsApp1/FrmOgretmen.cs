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
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-92FPH14;Initial Catalog=BonusOkul;Integrated Security=True");

        private void BTNKULÜP_Click(object sender, EventArgs e)
        {
            FrmKulup fr = new FrmKulup();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void BTNDERSİSLEMLERİ_Click(object sender, EventArgs e)
        {
            FrmDersler fr2 = new FrmDersler();
            fr2.Show();

        }

        

        private void BTNÖĞRENCİİŞLEMLERİ_Click(object sender, EventArgs e)
        {
            FrmÖğrenci fr3 = new FrmÖğrenci();
            fr3.Show();

        }

        private void BTNSINAVNOTLARI_Click(object sender, EventArgs e)
        {
            FrmSınavNotlar fr4 = new FrmSınavNotlar();
            fr4.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

       
    }
}
