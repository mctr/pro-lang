using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Diagnostics;

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;             // bağlantılar için gerekli olan tanımlar yapıldı.
        SqlConnection connection1;
        SqlDataReader oku;
        SqlDataReader oku2;
        SqlCommand komut;
        SqlCommand komut2;
        SqlDataAdapter adaptor;
        SqlDataAdapter adaptor2;
        DataSet dataset;
        DataSet dataset2;

        public Form1()
        {
            InitializeComponent();
           
        }

       
        
            SqlConnection bag= new SqlConnection("Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True");
            DataTable tablo=new DataTable();
            DataTable tablo2 = new DataTable();
            SqlDataAdapter adptr=new SqlDataAdapter();
            SqlCommand kmt =new SqlCommand();

        

        void listele()
        {

            tablo.Clear();
            tablo2.Clear();
            bag.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * From personel", bag);
            SqlDataAdapter adtr2 = new SqlDataAdapter("select * From sekreter", bag);
            adtr.Fill(tablo);
            adtr2.Fill(tablo2);
            dataGridView1.DataSource = tablo;
            dataGridView2.DataSource = tablo2;
            adtr.Dispose();
            adtr2.Dispose();
            bag.Close();
        }

        void goster() 
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True";  // database ile bağlantı sağlandı(database ismi telefonrehberi)
            baglanti.Open();                                           //bapğlantı açıldı
            dataset = new DataSet();
            adaptor = new SqlDataAdapter("select * from personel", baglanti); // personel tablosundan değerler alındı.
            adaptor.Fill(dataset, "personel");
            dataGridView1.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
            komut = new SqlCommand();
            komut.Connection = baglanti;


            connection1 = new SqlConnection();
            connection1.ConnectionString = "Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True";  // database ile bağlantı sağlandı
            connection1.Open();                                          //bağlantı açıldı
            dataset2 = new DataSet();
            adaptor2 = new SqlDataAdapter("select * from sekreter", connection1); // sekreter tablosundan değerler alındı.
            adaptor2.Fill(dataset2, "sekreter");
            dataGridView2.DataSource = dataset2.Tables[0];               // datagriedview bağlantısı
            komut2 = new SqlCommand();
            komut2.Connection = connection1;
            //çalıştırılan bu komutla tablomuz datagriedviewde gözüktü.
        }

        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            textBox18.Clear();
            richTextBox1.Clear();
            textBox20.Clear();
            textBox21.Clear();
            maskedTextBox11.Clear();
            maskedTextBox12.Clear();
            textBox24.Clear();
            textBox25.Clear();
            maskedTextBox13.Clear();
            maskedTextBox14.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

                goster();//tabloları datagriedview lerde göstermemize yarayan fonksiyon.
                listele();

                dataGridView1.Columns[0].HeaderText = "Ad";
                dataGridView1.Columns[1].HeaderText = "Soyad";
                dataGridView1.Columns[2].HeaderText = "Sicil_No";
                dataGridView1.Columns[3].HeaderText = "Dahili_No";
                dataGridView1.Columns[4].HeaderText = "Cep";
                dataGridView1.Columns[5].HeaderText = "Başkanlık";
                dataGridView1.Columns[6].HeaderText = "Görev";

                dataGridView2.Columns[0].HeaderText = "Aranılan";
                dataGridView2.Columns[1].HeaderText = "Arayan";
                dataGridView2.Columns[2].HeaderText = "Saat";
                dataGridView2.Columns[3].HeaderText = "Aranılan_cep";
                dataGridView2.Columns[4].HeaderText = "Dahili_No";
                dataGridView2.Columns[5].HeaderText = "Birim";
                dataGridView2.Columns[6].HeaderText = "Not_";
                //dataGridView2.Columns[7].HeaderText = "ID";
               
            

              
                 DataTable dt1 = new DataTable();                //comboboxlara Sicil_No  yu çekne
                 adaptor.Fill(dt1);
                 DataTable dt2 = new DataTable();
                 adaptor.Fill(dt2);
                 DataTable dt3=new DataTable();
                 adaptor2.Fill(dt3);    

                 comboBox1.DataSource = dt1;
                 comboBox1.DisplayMember = "Sicil_No";
                 comboBox1.ValueMember = "Sicil_No";           // comboboxa bu kodlarla Sicil_No yu çektik

                 comboBox4.DataSource = dt3;
                 comboBox4.DisplayMember = "ID";
                 comboBox4.ValueMember = "ID";
                
                
                 
            temizle();    
                 

        }
       

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox13.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
  
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != ""  && maskedTextBox2.Text != "" )
                {
            SqlCommand cmd1 = new SqlCommand("insert into personel(Ad,Soyad,Sicil_No,Dahili_No,Cep,Başkanlık,Görev) values(@ad,@soyad,@sno,@dno,@cep,@baskanlik,@gorev)", baglanti);
            cmd1.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd1.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd1.Parameters.AddWithValue("@sno", textBox3.Text);
            cmd1.Parameters.AddWithValue("@dno", maskedTextBox1.Text);
            cmd1.Parameters.AddWithValue("@cep", maskedTextBox2.Text);
            cmd1.Parameters.AddWithValue("@baskanlik", textBox6.Text);
            cmd1.Parameters.AddWithValue("@gorev", textBox7.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi", "Bilgi");
                }
                else { MessageBox.Show("Ekleme gerçekleştirilemedi,lütfen gerekli boş alanları doldurunuz", "Bilgi"); }
            }
            catch
            {
                MessageBox.Show("Eklenemedi!!! Harf Hatası!!! Sicil Numarası Aynı Olamaz!!!", "Bilgi");
            }
            finally
            {
                Form1_Load(sender, e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

               try
                {
                    SqlCommand cmd = new SqlCommand("insert into sekreter(Arayan,Aranılan,Saat,Aranılan_cep,Dahili_No,Birim,Not_) values (@aranilan,@arayan,@saat,@cep,@dano,@birim,@not)", connection1); // insert işlemleri
                cmd.Parameters.AddWithValue("@arayan", textBox15.Text);
                cmd.Parameters.AddWithValue("@aranilan", textBox14.Text);
                cmd.Parameters.AddWithValue("@saat", maskedTextBox5.Text);
                cmd.Parameters.AddWithValue("@cep", maskedTextBox6.Text);
                cmd.Parameters.AddWithValue("@dano", maskedTextBox13.Text);
                cmd.Parameters.AddWithValue("@birim", textBox18.Text);
                cmd.Parameters.AddWithValue("@not", richTextBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi", "Bilgi");
                }
            catch
            {
                MessageBox.Show("Eklenemedi!!! Harf Hatası!!!", "Bilgi");
            }
            finally
            {
                Form1_Load(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          DialogResult cevap;
          cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (cevap == DialogResult.Yes)
          {
              komut.CommandText = "delete from personel where Sicil_No='" + comboBox1.Text + "' ";
              komut.ExecuteNonQuery();
              MessageBox.Show("Başarıyla Silindi", "Bilgi");



              SqlCommand cmd1 = new SqlCommand("insert into psilinen(sAd,sSoyad,sSicil_No,sDahili_No,sCep,sBaşkanlık,sGörev) values(@ad,@soyad,@sno,@dno,@cep,@baskanlik,@gorev)", baglanti);
              cmd1.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells[0].Value.ToString());
              cmd1.Parameters.AddWithValue("@soyad", dataGridView1.CurrentRow.Cells[1].Value.ToString());
              cmd1.Parameters.AddWithValue("@sno", dataGridView1.CurrentRow.Cells[2].Value.ToString());
              cmd1.Parameters.AddWithValue("@dno", dataGridView1.CurrentRow.Cells[3].Value.ToString());
              cmd1.Parameters.AddWithValue("@cep", dataGridView1.CurrentRow.Cells[4].Value.ToString());
              cmd1.Parameters.AddWithValue("@baskanlik", dataGridView1.CurrentRow.Cells[5].Value.ToString());
              cmd1.Parameters.AddWithValue("@gorev", dataGridView1.CurrentRow.Cells[6].Value.ToString());
              cmd1.ExecuteNonQuery();
          }
          
           Form1_Load(sender, e);


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox4.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            textBox21.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox20.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox11.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox12.Text= dataGridView2.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox14.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox24.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox25.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                DialogResult cevap;

                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {

                    komut.CommandText = "delete from sekreter where ID='" + comboBox4.Text + "' ";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Silindi", "Bilgi");

                    SqlCommand cmd = new SqlCommand("insert into ssilinen(sArayan,sAranılan,sSaat,sAranılan_cep,sDahili_No,sBirim,sNot_) values (@aranilan,@arayan,@saat,@cep,@sdno,@birim,@not)", connection1); // insert işlemleri
                    cmd.Parameters.AddWithValue("@arayan", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@aranilan", dataGridView2.CurrentRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@saat", dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@cep", dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@sdno", dataGridView2.CurrentRow.Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("@birim", dataGridView2.CurrentRow.Cells[5].Value.ToString());
                    cmd.Parameters.AddWithValue("@not", dataGridView2.CurrentRow.Cells[6].Value.ToString());
                    cmd.ExecuteNonQuery();


                   
                }
                
            Form1_Load(sender, e);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                //if (textBox7.Text != "" || textBox8.Text != "" )
                //{
                    SqlCommand cmd = new SqlCommand("UPDATE personel SET Ad='"+ textBox8.Text +"', Soyad='"+ textBox9.Text +"',Sicil_No='"+ comboBox1.Text +"',Dahili_No='" + maskedTextBox3.Text +"',Cep='" +maskedTextBox4.Text + "',Başkanlık='" + textBox12.Text + "' , Görev='"+ textBox13.Text + "' WHERE Sicil_No='"+ comboBox1.Text + "' ", baglanti);//update işlemleri
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Güncellendi", "Bilgi");
               // }
               // else { MessageBox.Show("Ekleme gerçekleştirilemedi,lütfen gerekli boş alanları doldurunuz", "Bilgi"); }
            }
            catch
            {
                MessageBox.Show("Güncellenemedi!!!", "Bilgi");
            }
            finally
            {
                Form1_Load(sender, e);
            }
        
        

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            try
            {

                DialogResult cevap;

                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {

                    kmt.Connection = bag;

                    bag.Open();

                    kmt.CommandText = "delete from personel where Sicil_No='" + dataGridView1.CurrentRow.Cells[2].Value.ToString() + "'";

                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Silindi", "Bilgi");

                    SqlCommand cmd1 = new SqlCommand("insert into psilinen(sAd,sSoyad,sSicil_No,sDahili_No,sCep,sBaşkanlık,sGörev) values(@ad,@soyad,@sno,@dno,@cep,@baskanlik,@gorev)", baglanti);
                    cmd1.Parameters.AddWithValue("@ad", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd1.Parameters.AddWithValue("@soyad", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    cmd1.Parameters.AddWithValue("@sno", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    cmd1.Parameters.AddWithValue("@dno", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    cmd1.Parameters.AddWithValue("@cep", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    cmd1.Parameters.AddWithValue("@baskanlik", dataGridView1.CurrentRow.Cells[5].Value.ToString());
                    cmd1.Parameters.AddWithValue("@gorev", dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    cmd1.ExecuteNonQuery();
           
                    bag.Close();

                    listele();

                }

            }

            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);

            }
            finally
            {
                Form1_Load(sender, e);
            }
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            try
            {

                DialogResult cevap;

                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {

                    kmt.Connection = baglanti;

                    bag.Open();

                    kmt.CommandText = "delete from sekreter where ID='" + dataGridView2.CurrentRow.Cells[7].Value.ToString() + "'";

                    kmt.ExecuteNonQuery();


                    SqlCommand cmd = new SqlCommand("insert into ssilinen(sArayan,sAranılan,sSaat,sAranılan_cep,sDahili_No,sBirim,sNot_) values (@aranilan,@arayan,@saat,@cep,@sdno,@birim,@not)", connection1); // insert işlemleri
                    cmd.Parameters.AddWithValue("@arayan", dataGridView2.CurrentRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@aranilan", dataGridView2.CurrentRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@saat", dataGridView2.CurrentRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@cep", dataGridView2.CurrentRow.Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("@sdno", dataGridView2.CurrentRow.Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("@birim", dataGridView2.CurrentRow.Cells[5].Value.ToString());
                    cmd.Parameters.AddWithValue("@not", dataGridView2.CurrentRow.Cells[6].Value.ToString());
                    cmd.ExecuteNonQuery();

                    bag.Close();
                    MessageBox.Show("Başarıyla Silindi", "Bilgi");
                    listele();

                }

            }

            catch (Exception hata)
            {

                MessageBox.Show(hata.Message);

            }
            finally
            {
                Form1_Load(sender, e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
                try
                {
                
                SqlCommand cmd4  = new SqlCommand("UPDATE sekreter SET Aranılan='" + textBox21.Text + "', Arayan='" + textBox20.Text + "',Saat='" + maskedTextBox11.Text + "',Aranılan_cep='" + maskedTextBox12.Text + "', Dahili_No='"+maskedTextBox14.Text+"' ,Birim='" + textBox24.Text + "',Not_='" + textBox25.Text + "' WHERE ID='" + comboBox4.Text + "' ", baglanti);//update işlemleri
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Güncellendi", "Bilgi");
                
                }
            catch
            {
                MessageBox.Show("Güncellenemedi!!!", "Bilgi");
            }
            finally
            {
                Form1_Load(sender, e);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True";  // database ile bağlantı sağlandı(database ismi telefonrehberi)
            baglanti.Open();                                           //bapğlantı açıldı
            dataset = new DataSet();
            adaptor = new SqlDataAdapter("select * from psilinen", baglanti); 
            adaptor.Fill(dataset, "psilinen");
            dataGridView1.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
            komut = new SqlCommand();
            komut.Connection = baglanti;
            groupBox1.Hide();
            groupBox3.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            goster();
            groupBox1.Show();
            groupBox3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            connection1 = new SqlConnection();
            connection1.ConnectionString = "Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True";  // database ile bağlantı sağlandı
            connection1.Open();                                          //bağlantı açıldı
            dataset2 = new DataSet();
            adaptor2 = new SqlDataAdapter("select * from ssilinen", connection1);
            adaptor2.Fill(dataset2, "ssilinen");
            dataGridView2.DataSource = dataset2.Tables[0];               // datagriedview bağlantısı
            komut2 = new SqlCommand();
            komut2.Connection = connection1;
            //çalıştırılan bu komutla tablomuz datagriedviewde gözüktü.
            groupBox4.Hide();
            groupBox5.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            goster();
            groupBox4.Show();
            groupBox5.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {   
            baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True";  // database ile bağlantı sağlandı(database ismi telefonrehberi)
            baglanti.Open();                                           //bapğlantı açıldı
            dataset = new DataSet();
            if (textBox10.Text != "" && textBox11.Text != "" && textBox16.Text != "" && maskedTextBox7.Text != "" && maskedTextBox8.Text != "" && textBox17.Text != "" && textBox19.Text != "")
            {
                adaptor = new SqlDataAdapter("select * from personel where Ad='" + textBox10.Text + "' and Soyad='" + textBox11.Text + "' and Sicil_No='" + textBox16.Text + "' and Dahili_No='" + maskedTextBox7.Text + "' and Cep='" + maskedTextBox8.Text + "' and Başkanlık='" + textBox17.Text + "' and Görev='" + textBox19.Text + "' ", baglanti); // personel tablosundan değerler alındı.
                adaptor.Fill(dataset, "personel");
                dataGridView3.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
                komut = new SqlCommand();
                komut.Connection = baglanti;
            }
            else 
            {
                adaptor = new SqlDataAdapter("select * from personel where Ad='" + textBox10.Text + "' or Soyad='" + textBox11.Text + "' or Sicil_No='" + textBox16.Text + "' or Dahili_No='" + maskedTextBox7.Text + "' or Cep='" + maskedTextBox8.Text + "' or Başkanlık='" + textBox17.Text + "' or Görev='" + textBox19.Text + "' ", baglanti); // personel tablosundan değerler alındı.
                adaptor.Fill(dataset, "personel");
                dataGridView3.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
                komut = new SqlCommand();
                komut.Connection = baglanti;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            connection1 = new SqlConnection();
            connection1.ConnectionString = "Data Source=localhost;Initial Catalog=telefonrehberi;Integrated Security=True";  // database ile bağlantı sağlandı
            connection1.Open();                                          //bağlantı açıldı
            dataset2 = new DataSet();
            if (textBox26.Text != "" && textBox27.Text != "" && maskedTextBox9.Text != "" && maskedTextBox10.Text != "" && textBox28.Text != "" && richTextBox2.Text != "" )
            {
                adaptor2 = new SqlDataAdapter("select * from sekreter  where Aranılan='" + textBox26.Text + "' and Arayan='" + textBox27.Text + "' and Saat='" + maskedTextBox9.Text + "' and Aranılan_cep='" + maskedTextBox10.Text + "' and Birim='" + textBox28.Text + "' and Not_='" + richTextBox2.Text + "' ", connection1); // sekreter tablosundan değerler alındı.
                adaptor2.Fill(dataset2, "sekreter");
                dataGridView3.DataSource = dataset2.Tables[0];               // datagriedview bağlantısı
                komut2 = new SqlCommand();
                komut2.Connection = connection1;
            }
            else
            {
                adaptor2 = new SqlDataAdapter("select * from sekreter  where Aranılan='" + textBox26.Text + "' or Arayan='" + textBox27.Text + "' or Saat='" + maskedTextBox9.Text + "' or Aranılan_cep='" + maskedTextBox10.Text + "' or Birim='" + textBox28.Text + "' or Not_='" + richTextBox2.Text + "' ", connection1); // sekreter tablosundan değerler alındı.
                adaptor2.Fill(dataset2, "sekreter");
                dataGridView3.DataSource = dataset2.Tables[0];               // datagriedview bağlantısı
                komut2 = new SqlCommand();
                komut2.Connection = connection1;

            }

        }

        private void label43_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

                cevap = MessageBox.Show("Kayıtları kalıcı olarak silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.Yes)
                {

                    kmt.Connection = bag;

                    bag.Open();

                    kmt.CommandText = "delete from psilinen ";
                    kmt.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Sıfırlandı", "Bilgi");
                    bag.Close();
                }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("www.trt.net.tr");
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label48_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show("Kayıtları kalıcı olarak silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {

                kmt.Connection = bag;

                bag.Open();

                
                komut2.CommandText = "delete from ssilinen";

               
                komut2.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Sıfırlandı", "Bilgi");
                bag.Close();
            }
            Form1_Load(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

       

        

        
      
        

            
       

        

        
       

    }
}
