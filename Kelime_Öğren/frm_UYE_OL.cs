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
    public partial class frm_UYE_OL : Form
    {
        public frm_UYE_OL()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=MONSTER;Initial Catalog=Kelime_Ogrenme;Integrated Security=True");
        private void btn_GİRİŞ_YAP_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Table_1 (AD,SIFRE) values(@p1,@p2)", baglantı);
            komut.Parameters.AddWithValue("@p1", txt_AD.Text);
            komut.Parameters.AddWithValue("@p2", txt_SIFRE.Text);
            komut.ExecuteNonQuery();
             baglantı.Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz :" + txt_SIFRE.Text, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); ;

        }
    }
}
