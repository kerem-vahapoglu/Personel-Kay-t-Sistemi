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
using Microsoft.SqlServer.Server;


namespace Personel_Kayıt_Sistemi
{
    public partial class formIstatistik : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LKTU092;Initial Catalog=PersonelKayitSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        public formIstatistik()
        {
            InitializeComponent();
        }


        private void formIstatistik_Load(object sender, EventArgs e)
        {

            //Kişi Sayısı
            baglanti.Open();

            SqlCommand sqlKisiSayisi = new SqlCommand("select count(*) from tb_personel", baglanti);

            SqlDataReader rd = sqlKisiSayisi.ExecuteReader();

            while (rd.Read())
            {
                lbKisiSayisi.Text = rd[0].ToString();

            }

            baglanti.Close();


            //İl sayısı
            baglanti.Open();

            SqlCommand sqlIlSayisi = new SqlCommand("select distinct(count(personSehir)) from tb_personel", baglanti);
            
            SqlDataReader rd2 = sqlIlSayisi.ExecuteReader();

            while (rd2.Read())
            {
                lbIlSayisi.Text = rd2[0].ToString();
            }

            baglanti.Close();


            //Evli kişi sayısı
            baglanti.Open();

            SqlCommand sqlEvliSayisi = new SqlCommand("select count(*) from tb_personel where personMedeniDurum=1",baglanti);

            SqlDataReader rd3 = sqlEvliSayisi.ExecuteReader();

            while (rd3.Read())
            {
                lbEvliSayisi.Text=rd3[0].ToString();
            }

            baglanti.Close();


            // Bekar Sayısı

            baglanti.Open();

            SqlCommand sqlBekarSayisi = new SqlCommand("select count(*) from tb_personel where personMedeniDurum=0", baglanti);

            SqlDataReader rd4 = sqlBekarSayisi.ExecuteReader();

            while (rd4.Read())
            {
                lbBekarSayisi.Text = rd4[0].ToString();
            }

            baglanti.Close();


        }
    }
}
