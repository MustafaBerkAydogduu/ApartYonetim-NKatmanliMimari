using DataAccessLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartNKatmanliMimari
{
    public partial class YonetimPanel : Form
    {
        public YonetimPanel()
        {
            InitializeComponent();
            listele();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;

            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = Color.Transparent;

            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            musteri_id.BackColor = Color.Transparent;
            oda_id.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
        }
        public void listele()
        {
            dataGridView1.DataSource = LLMusteri.LLMusteriListele();
            dataGridView2.DataSource = LLOda.LLOdaListele();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            musteri_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_musteriAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_musteriOda.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_musteriTel.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            oda_id.Text= dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_odaNo.Text= dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            cb_odaDurum.Text= dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_odaMusteriNo.Text= dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musteri_id.Text = "";
            txt_musteriAd.Text = "";
            txt_musteriOda.Text = "";
            txt_musteriTel.Text = "";

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oda_id.Text = "";
            txt_odaNo.Text = "";
            cb_odaDurum.Text = "BOŞ";
            txt_odaMusteriNo.Text = "";
        }

        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            EntityMusteri entityMusteri = new EntityMusteri();
            entityMusteri.Ad_soyad = txt_musteriAd.Text;
            entityMusteri.Oda_no = int.Parse(txt_musteriOda.Text);
            entityMusteri.Tel_no = txt_musteriTel.Text;
            LLMusteri.LLMusteriEkle(entityMusteri);
            listele();
        }

        private void btn_musteriGuncelle_Click(object sender, EventArgs e)
        {
            EntityMusteri entityMusteri = new EntityMusteri();
            entityMusteri.Ad_soyad = txt_musteriAd.Text;
            entityMusteri.Oda_no = int.Parse(txt_musteriOda.Text);
            entityMusteri.Tel_no = txt_musteriTel.Text;
            entityMusteri.ID = int.Parse(musteri_id.Text);
            LLMusteri.LLMusteriGuncelle(entityMusteri);
            listele();
        }

        private void btn_musteriSil_Click(object sender, EventArgs e)
        {
            LLMusteri.LLMusteriSil(int.Parse(musteri_id.Text));
            listele();
        }

        private void btn_odaEkle_Click(object sender, EventArgs e)
        {
            EntityOda entityOda = new EntityOda();
            entityOda.Oda_no=txt_odaNo.Text;
            entityOda.Durum= cb_odaDurum.Text;
            entityOda.Musteri_no=int.Parse(txt_odaMusteriNo.Text);
            LLOda.LLOdaEkle(entityOda);
            listele();
        }

        private void btn_odaGuncelle_Click(object sender, EventArgs e)
        {
            EntityOda entityOda = new EntityOda();
            entityOda.Oda_no = txt_odaNo.Text;
            entityOda.Durum = cb_odaDurum.Text;
            entityOda.Musteri_no = int.Parse(txt_odaMusteriNo.Text);
            entityOda.ID = int.Parse(oda_id.Text);
            LLOda.LLOdaGuncelle(entityOda);
            listele();
        }

        private void btn_odaSil_Click(object sender, EventArgs e)
        {
            LLOda.LLOdaSil(int.Parse(oda_id.Text));
            listele();
        }
    }
}
