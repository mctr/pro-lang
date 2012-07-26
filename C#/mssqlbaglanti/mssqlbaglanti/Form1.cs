using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mssqlbaglanti
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        void temizle() {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        void ekle() {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("Insert Into ögrenci(Okul_no,Ad,Soyad,Tc_kimlik_no,Bölüm) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
        }

        void göster() {
          //  String sql = "select * from ögrenci";
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True;");
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from ögrenci", connection);
            DataSet can = new DataSet();
            adaptor.Fill(can, "ögrenci");
            dataGridView1.DataSource = can.Tables[0];

            /* String sql = "select * from ögrenci";
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True;");
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter(sql, connection);
            DataSet can = new DataSet();
            adaptor.Fill(can, "ögrenci");
            dataGridView1.DataSource = can.Tables[0];
            connection.Close();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "" && textBox4.Text.Trim() != "" && textBox5.Text.Trim() != "")
            {
                try
                {
                    ekle();
                    temizle();
                    göster();
                }
                catch
                {
                    MessageBox.Show("Dikkat!!.. Kayıtlı kişi girişi...");
                }
            }
            else
                MessageBox.Show("Lütfen boş alan bırakmayınız..");
           // SqlConnection bag = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True;");
           // SqlCommand cmd = new SqlCommand("Insert Into ögrenci(Okul_no,Ad,Soyad,Tc_kimlik_no,Bölüm) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')", connection);
           // bag.Open();
           // cmd.ExecuteNonQuery();
            
            
           // DataTable db = new DataTable();
           // String sql = "SELECT * from ögrenci";
           // SqlDataAdapter adapter = new SqlDataAdapter();
            //cmd.bag = 
            //   MessageBox.Show("Kayıt gerçekleştirildi..");
         //   bag.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          DialogResult cevap;
          cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (cevap == DialogResult.Yes)
          {
              SqlConnection baglanti1 = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True;");
              baglanti1.Open();
              SqlCommand cmd = new SqlCommand("delete from ögrenci where Ad='" + textBox2.Text + "' ", baglanti1);//delete işlemleri
              cmd.ExecuteNonQuery();
              göster();
              temizle();  
          }
          }

        private void button4_Click(object sender, EventArgs e)
        {
           SqlConnection baglanti1 = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True;");
           baglanti1.Open();
           SqlCommand cmd = new SqlCommand("UPDATE ögrenci SET Okul_no='" + textBox1.Text + "', Ad='" + textBox2.Text + "',Soyad='" + textBox3.Text + "',Tc_kimlik_no='" + textBox4.Text + "',Bölüm='" + textBox5.Text + "' WHERE Tc_kimlik_no='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' ", baglanti1);//update işlemleri
           cmd.ExecuteNonQuery();
           MessageBox.Show("Güncellendi", "Bilgi");
           göster();
           temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            göster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True");
           // baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=deneme;Integrated Security=True";  // database ile bağlantı sağlandı(database ismi telefonrehberi)
            baglanti.Open();                                           //bapğlantı açıldı
            DataSet dataset = new DataSet();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != ""  && textBox5.Text != "")
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from ögrenci where Okul_no='" + textBox1.Text + "' and Ad='" + textBox2.Text + "' and Soyad='" + textBox3.Text + "' and Tc_kimlik_no='" + textBox4.Text + "' and Bölüm='" + textBox5.Text + "' ", baglanti); // personel tablosundan değerler alındı.
                adaptor.Fill(dataset, "ögrenci");
                dataGridView1.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
            }
            else
            {
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from ögrenci where Okul_no='" + textBox1.Text + "' or Ad='" + textBox2.Text + "' or Soyad='" + textBox3.Text + "' or Tc_kimlik_no='" + textBox4.Text + "' or Bölüm='" + textBox5.Text + "' ", baglanti); // personel tablosundan değerler alındı.
                adaptor.Fill(dataset, "ögrenci");
                dataGridView1.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
            }
            //göster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            göster();
            temizle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String mctr = "select * from ögrenci ORDER BY Ad";
            SqlConnection foo = new SqlConnection("Data Source=localhost;Initial Catalog=deneme;Integrated Security=True");
            foo.Open();
            DataSet dataset = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(mctr, foo); // personel tablosundan değerler alındı.
            adaptor.Fill(dataset, "ögrenci");
            dataGridView1.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = deneme;
        }

    }
}
