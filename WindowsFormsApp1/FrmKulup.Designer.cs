
namespace WindowsFormsApp1
{
    partial class FrmKulup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKulup));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTKULÜPADI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTKULÜPID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BTNLİSTELE = new System.Windows.Forms.Button();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTNGÜNCELLE = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BTNSİL = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULÜP İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 121);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXTKULÜPADI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTKULÜPID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-1, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // TXTKULÜPADI
            // 
            this.TXTKULÜPADI.Location = new System.Drawing.Point(95, 48);
            this.TXTKULÜPADI.Name = "TXTKULÜPADI";
            this.TXTKULÜPADI.Size = new System.Drawing.Size(239, 27);
            this.TXTKULÜPADI.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "KULÜP ADI :";
            // 
            // TXTKULÜPID
            // 
            this.TXTKULÜPID.Enabled = false;
            this.TXTKULÜPID.Location = new System.Drawing.Point(95, 15);
            this.TXTKULÜPID.Name = "TXTKULÜPID";
            this.TXTKULÜPID.Size = new System.Drawing.Size(239, 27);
            this.TXTKULÜPID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "KULÜP ID :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // BTNLİSTELE
            // 
            this.BTNLİSTELE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNLİSTELE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLİSTELE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLİSTELE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNLİSTELE.Location = new System.Drawing.Point(65, 277);
            this.BTNLİSTELE.Name = "BTNLİSTELE";
            this.BTNLİSTELE.Size = new System.Drawing.Size(105, 33);
            this.BTNLİSTELE.TabIndex = 5;
            this.BTNLİSTELE.Text = "LİSTELE";
            this.BTNLİSTELE.UseVisualStyleBackColor = false;
            this.BTNLİSTELE.Click += new System.EventHandler(this.BTNLİSTELE_Click);
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNEKLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNEKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEKLE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNEKLE.Location = new System.Drawing.Point(65, 316);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(105, 33);
            this.BTNEKLE.TabIndex = 7;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = false;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 316);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // BTNGÜNCELLE
            // 
            this.BTNGÜNCELLE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNGÜNCELLE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNGÜNCELLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGÜNCELLE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNGÜNCELLE.Location = new System.Drawing.Point(230, 277);
            this.BTNGÜNCELLE.Name = "BTNGÜNCELLE";
            this.BTNGÜNCELLE.Size = new System.Drawing.Size(109, 33);
            this.BTNGÜNCELLE.TabIndex = 9;
            this.BTNGÜNCELLE.Text = "GÜNCELLE";
            this.BTNGÜNCELLE.UseVisualStyleBackColor = false;
            this.BTNGÜNCELLE.Click += new System.EventHandler(this.BTNGÜNCELLE_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(176, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // BTNSİL
            // 
            this.BTNSİL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BTNSİL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNSİL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSİL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTNSİL.Location = new System.Drawing.Point(230, 316);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(109, 33);
            this.BTNSİL.TabIndex = 11;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.UseVisualStyleBackColor = false;
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(176, 316);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(305, -1);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 34);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pictureBox6_MouseLeave);
            this.pictureBox6.MouseHover += new System.EventHandler(this.pictureBox6_MouseHover);
            // 
            // FrmKulup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(343, 358);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.BTNSİL);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.BTNGÜNCELLE);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.BTNEKLE);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BTNLİSTELE);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmKulup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKulup";
            this.Load += new System.EventHandler(this.FrmKulup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXTKULÜPADI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTKULÜPID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BTNLİSTELE;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTNGÜNCELLE;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BTNSİL;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}