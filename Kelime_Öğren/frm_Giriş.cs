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

namespace Kelime_Öğren
{
    public partial class frm_Giriş : Form
    {
        public frm_Giriş()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER;Initial Catalog=Kelime_Ogrenme;Integrated Security=True");
        private void frm_Giriş_Load(object sender, EventArgs e)
        {
           
        
    }

        private void btn_GİRİŞ_YAP_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Table_1 where AD=@p1 AND SIFRE=@p2", baglantı);
            komut.Parameters.AddWithValue("@p1", txt_AD.Text);
            komut.Parameters.AddWithValue("@p2", txt_SIFRE.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 fr = new Form1();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı Adı&Şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglantı.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_UYE_OL fr = new frm_UYE_OL();
            fr.Show();
        }
    }
}
