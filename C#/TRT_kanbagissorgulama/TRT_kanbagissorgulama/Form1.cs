using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace TRT_kanbagissorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            email();
            raporlama();
        }
        void goster()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True;");
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from Personel", connection);
            DataSet can = new DataSet();
            adaptor.Fill(can, "Personel");
            dataGridView1.DataSource = can.Tables[0];
            //dataGridView2.DataSource = can.Tables[0];
        }

        void kayit_ekle()
        {
            SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True; ");//kayitlarin veri tabani ile baglantisi
            baglantı.Open();//baglantiyi actik
            SqlCommand cmd1 = new SqlCommand("insert into Personel(Sicil_No,Ad,Soyad,Birim,Dahili_No,Cep_No,E_Posta,Kan_Grubu) values(@sicilno, @ad, @soyad, @birim, @dahili, @cep, @posta, @kangrubu)", baglantı);
            cmd1.Parameters.AddWithValue("@sicilno", maskedTextBox1.Text);
            cmd1.Parameters.AddWithValue("@ad", textBox1.Text);
            cmd1.Parameters.AddWithValue("@soyad", textBox2.Text);
            cmd1.Parameters.AddWithValue("@birim", textBox3.Text);
            cmd1.Parameters.AddWithValue("@dahili", maskedTextBox2.Text);
            cmd1.Parameters.AddWithValue("@cep", maskedTextBox3.Text);
            cmd1.Parameters.AddWithValue("@posta", textBox4.Text);
            cmd1.Parameters.AddWithValue("@kangrubu", comboBox3.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi", "Bilgi");
        }

        void sil()
        {
            maskedTextBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            maskedTextBox5.Clear();
            maskedTextBox6.Clear();
            textBox8.Clear();

        }

        void goster1()
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True");
            connection.Open();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from Kan1", connection);
            DataSet can = new DataSet();
            adaptor.Fill(can, "Kan1");
            dataGridView2.DataSource = can.Tables[0];
        }

        void kayit_ekle1()
        {
            SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True");
            baglantı.Open();
            SqlCommand cmd1 = new SqlCommand("insert into Kan1(Sicil_No,Verdiği_Tarih,Verdiği_Kurum) values(@sicilno1,@verdigitarih,@verdigikurum)", baglantı);
            cmd1.Parameters.AddWithValue("@sicilno1", maskedTextBox7.Text);
            cmd1.Parameters.AddWithValue("@verdigitarih", dateTimePicker1.Text);
            cmd1.Parameters.AddWithValue("@verdigikurum", textBox9.Text);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi", "Bilgi");
        }

        void sil1()
        {
            maskedTextBox7.Clear();
            textBox9.Clear();
        }
        void email()
        {
        SqlConnection baglantı = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True");
         baglantı.Open();
            SqlCommand cmd = new SqlCommand("select p.E_Posta from Personel p,Kan1 k where DATEDIFF(day,CONVERT(DATETIME,k.Verdiği_Tarih,103),GETDATE())>=120 and p.Sicil_No=k.Sicil_No", baglantı);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MailMessage mail = new MailMessage();
                
                mail.From = new MailAddress("hanbuke@gmail.com");
                string posta;
                posta = string.Concat(dr["E_Posta"], "@hotmail.com");
                mail.To.Add(posta);
                mail.Bcc.Add("hanbuke@gmail.com");
                //mail.Attachments.Add(new Attachment(@"cmd.CommandType"));
                mail.Subject = "Kan Bilgilendirme";
                mail.Body = "TRT Kan Bagis ve Sorgulama Sisteminden alinan verilere Gore Kan verme zamananiniz gelmistir.";

                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("hanbuke", "NBC2762632");
                smtpServer.EnableSsl = true;


                smtpServer.Send(mail);
            }
                
            }

        void raporlama()
         {
              SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True;");
              connection.Open();
              SqlCommand cmd1 = new SqlCommand("select count(Sicil_No) from Personel ", connection);
              textBox19.Text = cmd1.ExecuteScalar().ToString();
              //cmd1.Parameters.AddWithValue("Sicil_No", textBox19.Text);
              cmd1.ExecuteNonQuery();
              SqlCommand cmd2 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='A Rh +'", connection);
              textBox10.Text = cmd2.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd3 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='A Rh -'", connection);
              textBox11.Text = cmd3.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd4 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='B Rh +'", connection);
              textBox12.Text = cmd4.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd5 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='B Rh -'", connection);
              textBox13.Text = cmd5.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd6 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='AB Rh +'", connection);
              textBox14.Text = cmd6.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd7 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='AB Rh -'", connection);
              textBox15.Text = cmd7.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd8 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='0 Rh +'", connection);
              textBox16.Text = cmd8.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd9 = new SqlCommand("select count(Kan_Grubu) from Personel where Kan_Grubu='0 Rh -'", connection);
              textBox17.Text = cmd9.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
              SqlCommand cmd10 = new SqlCommand("select count(p.Sicil_No) from Personel p,Kan1 k where DATEDIFF(day,CONVERT(DATETIME,k.Verdiği_Tarih,103),GETDATE())>=120 and p.Sicil_No=k.Sicil_No", connection);
              textBox18.Text = cmd10.ExecuteScalar().ToString();
              //cmd1.ExecuteNonQuery();
         }

       
 

 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goster();
            comboBox3.Items.Add("0 Rh +");
            comboBox3.Items.Add("0 Rh -");
            comboBox3.Items.Add("A Rh +");
            comboBox3.Items.Add("A Rh -");
            comboBox3.Items.Add("B Rh +");
            comboBox3.Items.Add("B Rh -");
            comboBox3.Items.Add("AB Rh +");
            comboBox3.Items.Add("AB Rh -");

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            kayit_ekle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti1 = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True");
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Personel where Sicil_No='" + maskedTextBox4.Text + "' ", baglanti1);//delete işlemleri
                cmd.ExecuteNonQuery();
                goster();
                sil();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Personel SET Sicil_No='" + maskedTextBox4.Text + "', Ad='" + textBox5.Text + "',Soyad='" + textBox6.Text + "',Birim='" + textBox7.Text + "',Dahili_No='" + maskedTextBox5.Text + "',Cep_No='" + maskedTextBox6.Text + "',E_Posta='" + textBox8.Text + "'  WHERE Sicil_No='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", connection);//update işlemleri


            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi", "Bilgi");
            goster();
            sil();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            goster1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kayit_ekle1();
            sil1();
            goster1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti1 = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True");
                baglanti1.Open();
                SqlCommand cmd = new SqlCommand("delete from Kan1 where Sicil_No='" + maskedTextBox7.Text + "' ", baglanti1);//delete işlemleri
                cmd.ExecuteNonQuery();
                goster1();
                sil1();
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedTextBox7.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            //dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=TRT_Kan;Integrated Security=True;");
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Kan1 SET Sicil_No='" + maskedTextBox7.Text + "', Verdiği_Tarih='" + dateTimePicker1.Text + "',Verdiği_Kurum='" + textBox9.Text + "'WHERE Sicil_No='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", connection);//update işlemleri


            cmd.ExecuteNonQuery();
            MessageBox.Show("Güncellendi", "Bilgi");
            goster1();
            sil1();
            
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.trt.net.tr");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
     

    }
}
