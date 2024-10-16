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

namespace Personel_Kayıt_Sistemi
{
    public partial class Form1 : Form
    {


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-LKTU092;Initial Catalog=PersonelKayitSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");
        public Form1()
        {
            InitializeComponent();
        }

        void temizle()
        {
            txtAd.Text = "";
            txtid.Text = "";
            txtsoyad.Text = "";
            comboSehir.Text = "";
            maskedTel.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tb_personelTableAdapter.Fill(this.personelKayitSistemiDataSet.tb_personel);
        }

        private void btEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komutEkle = new SqlCommand("insert into tb_personel (personAd,personSoyad,personTel,personSehir,personMedeniDurum) values (@p1,@p2,@p3,@p4,@p5)",baglanti);

            komutEkle.Parameters.AddWithValue("@p1",txtAd.Text);
            komutEkle.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komutEkle.Parameters.AddWithValue("@p3", maskedTel.Text);
            komutEkle.Parameters.AddWithValue("@p4", comboSehir.Text);
            komutEkle.Parameters.AddWithValue("@p5",label7.Text);
            komutEkle.ExecuteNonQuery();
            
            baglanti.Close();

            MessageBox.Show("Personel eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text= "false";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();  
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen ].Cells[2].Value.ToString();
            maskedTel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboSehir.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            if (label7.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label7.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from tb_personel where personId=@p1", baglanti);
            baglanti.Open();

            komutSil.Parameters.AddWithValue("@p1", txtid.Text);
            komutSil.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Müşteri Silindi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            temizle();
        }

        private void btGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGüncelle = new SqlCommand("update  tb_personel set personAd=@p1, personSoyad=@p2, personTel=@p3, personSehir=@p4, personMedeniDurum=@p5 where personId=@personId",baglanti);
            baglanti.Open();

            komutGüncelle.Parameters.AddWithValue("@personId",txtid.Text);
            komutGüncelle.Parameters.AddWithValue("@p1", txtAd.Text);
            komutGüncelle.Parameters.AddWithValue("@p2",txtsoyad.Text);
            komutGüncelle.Parameters.AddWithValue("@p3",maskedTel.Text);
            komutGüncelle.Parameters.AddWithValue("@p4",comboSehir.Text);
            komutGüncelle.Parameters.AddWithValue("@p5",label7.Text);

            komutGüncelle.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Personel Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            temizle();

        }

        private void btIstatistik_Click(object sender, EventArgs e)
        {
            formIstatistik frm = new formIstatistik();
            frm.Show();
        }
    }
}
