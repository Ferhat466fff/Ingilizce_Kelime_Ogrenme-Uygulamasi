using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kelime_Öğren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ferhat\\Desktop\\dbSozluk.accdb");
        Random rast = new Random();
        int sure = 90;
        int kelime = 0;

        void kelime_getirme()
        {
            //txt_İNGİLİZCEYE ingilizce kelime lbl_CEVAP türkçesini Rastgele alma işlemi(turkce keimeyi label koycaz ve visıable false yapacagız)
            int sayi;
            sayi = rast.Next(1, 2490);//1'dahil 2490 dahil deği dbsozluk acsessde ve 2489 satır var 

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from sozluk where id=@p1", baglanti);//ıdye gore getirecek
            komut.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_INGILIZCE.Text = dr[1].ToString();//txtingilizceye=dr[1](ingilizce keime)
                lbl_CEVAP.Text = dr[2].ToString();//lblcevap=dr[2](turkce keime)
                lbl_CEVAP.Text = lbl_CEVAP.Text.ToLower();//kucuk yazsın
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kelime_getirme();
            timer1.Start();//form acılınca timer baslasın

        }

        private void txt_TURKCE_TextChanged(object sender, EventArgs e)
        {   //TextChanged(türkceye keime girilidigi anda ne yapsın)
            if (txt_TURKCE.Text==lbl_CEVAP.Text)//kelime dogruysa
            {
                kelime++;
                lbl_KELIME.Text = kelime.ToString();
                kelime_getirme();
                txt_TURKCE.Clear();

            }
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lbl_SURE.Text = sure.ToString();
            if(sure==0)
            {
                txt_TURKCE.Enabled = false;
                txt_INGILIZCE.Enabled = false;
                timer1.Stop();
            }
        }
    }
}
