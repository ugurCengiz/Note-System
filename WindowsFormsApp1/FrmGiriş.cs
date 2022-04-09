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
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOğrenciNotlar frm = new FrmOğrenciNotlar();
            frm.numara = textBox1.Text;
            frm.Show();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOgretmen frm = new FrmOgretmen();
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
