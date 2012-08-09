using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Win32;

namespace Malzeme_stok
{
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form1()
        {
            InitializeComponent();
            comborefresh();
            frm2 = new Form2();
            frm2.frm1 = this;
        }
       

        void comborefresh()  // comboboxa eleman ekleme yapabilmek yani combobaxı sürekli güncel tutmak için bu fonksiyon yazıldı
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            SqlConnection foo = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True;");
            foo.Open();
            SqlCommand cmd = new SqlCommand("select Malzeme from İsim", foo);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["Malzeme"]);
                comboBox2.Items.Add(dr["Malzeme"]);
                comboBox3.Items.Add(dr["Malzeme"]);
            }

        }
         SqlConnection baglanti;    // = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True;");
         DataSet dataset;
         SqlDataAdapter adaptor;
         SqlCommand komut;
        
        void göster()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True;");
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from Malzemeler", connection);
            DataSet can = new DataSet();
            adaptor.Fill(can, "Malzemeler");
            dataGridView1.DataSource = can.Tables[0];
            dataGridView2.DataSource = can.Tables[0];
        }
         
        void temizle1()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
        }

        void temizle2()
        {
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
        }
        
        void temizle3()
        {
            textBox18.Clear();
            textBox17.Clear();
            maskedTextBox6.Clear();
            textBox16.Clear();
            maskedTextBox5.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
        }

        void kayıt_ekle()
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True");
                    baglantı.Open();
                    SqlCommand cmd1 = new SqlCommand("insert into Malzemeler(Kullanıcı_Adı,Oda_Numarası,Dahili_No,Sicil_No,Cep_No,Malzeme_Türü,Marka_Model,Seri_Numarası,Demirbaş_No) values(@ad,@oda,@dahili,@sicil,@cep,@malzeme,@marka,@seri,@demirbaş)", baglantı);
                    cmd1.Parameters.AddWithValue("@ad", textBox1.Text);
                    cmd1.Parameters.AddWithValue("@oda", textBox2.Text);
                    cmd1.Parameters.AddWithValue("@dahili", maskedTextBox1.Text);
                    cmd1.Parameters.AddWithValue("@sicil", textBox3.Text);
                    cmd1.Parameters.AddWithValue("@cep", maskedTextBox2.Text);
                    cmd1.Parameters.AddWithValue("@malzeme", comboBox1.Text);
                    cmd1.Parameters.AddWithValue("@marka", textBox4.Text);
                    cmd1.Parameters.AddWithValue("@seri", textBox5.Text);
                    cmd1.Parameters.AddWithValue("@demirbaş", textBox6.Text);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla Eklendi", "Bilgi");
                }
                else
                    MessageBox.Show("Ekleme gerçekleştirilemedi,lütfen gerekli boş alanları doldurunuz", "Bilgi");
            }
            catch
            {
                MessageBox.Show("Eklenemedi!!! Harf Hatası!!!", "Bilgi");
            }


        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            göster();
        }
  
        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayıt_ekle();
            göster();
            temizle1();
        }
       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBox12.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Malzemeler SET Kullanıcı_Adı='" + textBox12.Text + "', Oda_Numarası='" + textBox11.Text + "',Dahili_No='" + maskedTextBox4.Text + "',Sicil_No='" + textBox10.Text + "',Cep_No='" + maskedTextBox3.Text + "',Malzeme_Türü='" + comboBox2.Text + "',Marka_Model='" + textBox9.Text + "' , Seri_Numarası='" + textBox8.Text + "',Demirbaş_No='" + textBox7.Text + "' WHERE Sicil_No='" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' ", connection);//update işlemleri
            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi", "Bilgi");
            göster();
            temizle2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti1 = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True;");
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Malzemeler where Sicil_No='" + textBox10.Text + "' ", baglanti1);   //delete işlemleri
                cmd.ExecuteNonQuery();
                göster();
                temizle2();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            göster();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True";  // database ile bağlantı sağlandı(database ismi telefonrehberi)
            baglanti.Open();                                           //bapğlantı açıldı
            dataset = new DataSet();
            DataTable tablo = new DataTable();
            if (textBox18.Text != "" && textBox17.Text != "" && textBox16.Text != "" && comboBox3.Text != "" && maskedTextBox6.Text != "" && textBox15.Text != "" && textBox14.Text != "" && textBox13.Text != "" && maskedTextBox5.Text != "")
            {
                adaptor = new SqlDataAdapter("select * from Malzemeler where Kullanıcı_Adı='" + textBox18.Text + "' and Oda_Numarası='" + textBox17.Text + "' and Dahili_No='" + maskedTextBox6.Text + "' and Sicil_No='" + textBox16.Text + "' and Cep_No='" + maskedTextBox5.Text + "' and Malzeme_Türü='" + comboBox3.Text + "' and Marka_Model='" + textBox15.Text + "' and Seri_Numarası='" + textBox14.Text + "' and Demirbaş_No='" + textBox13.Text + "' ", baglanti); // personel tablosundan değerler alındı.
                adaptor.Fill(dataset, "Malzemeler");
                dataGridView2.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
                komut = new SqlCommand();
                komut.Connection = baglanti;
            }
            else
            {
                adaptor = new SqlDataAdapter("select * from Malzemeler where Kullanıcı_Adı='" + textBox18.Text + "' or Oda_Numarası='" + textBox17.Text + "' or Dahili_No='" + maskedTextBox6.Text + "' or Sicil_No='" + textBox16.Text + "' or Cep_No='" + maskedTextBox5.Text + "' or Malzeme_Türü='" + comboBox3.Text + "' or Marka_Model='" + textBox15.Text + "' or Seri_Numarası='" + textBox14.Text + "' or Demirbaş_No='" + textBox13.Text + "' ", baglanti); // personel tablosundan değerler alındı.
                adaptor.Fill(dataset, "Malzemeler");
                dataGridView2.DataSource = dataset.Tables[0];               // datagriedview bağlantısı
                komut = new SqlCommand();
                komut.Connection = baglanti;
                
            }
            temizle3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            göster();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e) // comboboxa eleman ekleme
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı eklemek istediginize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglantı1 = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True");
                baglantı1.Open();
                SqlCommand cmd1 = new SqlCommand("insert into İsim(Malzeme) values('" + comboBox1.Text + "')", baglantı1);
                cmd1.ExecuteNonQuery();
                comborefresh();
            }
        }

        private void button10_Click(object sender, EventArgs e) // comboboxdaki seçileni silmek
        {
            SqlConnection silmek = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True");
            silmek.Open();
            SqlCommand sil = new SqlCommand("delete from İsim   Where Malzeme='" + comboBox1.Text + "' ", silmek);
            sil.ExecuteNonQuery();
            comborefresh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.trt.net.tr");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult cevap;

            cevap = MessageBox.Show("Kayıtları hepsini kalıcı olarak silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti3 = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True");
                baglanti3.Open();
                SqlCommand kmt = new SqlCommand("delete from Malzemeler", baglanti3);
                kmt.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Sıfırlandı", "Bilgi");
                baglanti3.Close();
            }
        }
        
      
        

       private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            PaintEventArgs myPaintArgs = new PaintEventArgs(e.Graphics, new Rectangle(new Point(50, 50), this.Size));

            this.InvokePaint(dataGridView2, myPaintArgs);
        }
           
        
        private void button18_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            PrintPreviewDialog pdlg = new PrintPreviewDialog();
            pdlg.Document = PD;
            pdlg.ShowDialog();

            try
            {
                PD.Print();
            }
            catch
            {
                Console.WriteLine("Yazici çiktisi alinamiyor...");
            }
            finally
            {
                PD.Dispose();
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            frm2.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        }

      
    }
 
    