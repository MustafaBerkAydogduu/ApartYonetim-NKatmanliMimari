using EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartNKatmanliMimari
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd =new SqlCommand("Select * From ADMİN where KULLANICIAD=@p1 and SIFRE =@p2", Baglanti.baglanti);
            cmd.Parameters.AddWithValue("@p1",textBox1.Text);
            cmd.Parameters.AddWithValue("@p2",textBox2.Text);
            if(cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader dr=cmd.ExecuteReader();

            if (dr.Read()) 
            {
                cmd.Connection.Close();
                YonetimPanel yonetim = new YonetimPanel();
                yonetim.Show();
                this.Hide();
                
            }
            else
            {
                cmd.Connection.Close();
            }





        }
    }
}
