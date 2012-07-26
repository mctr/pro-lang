using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mssqlbaglanti
{
    public partial class Form2 : Form
    {
    Form1 frm = new Form1();  //Öncelikle bir değişken tanımlıyoruz...
        public Form2()
        {
            InitializeComponent();
        }

        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                frm.Show(); //Button'a tıkladığımız zaman form2'ye geçmesini sağlıyoruz
                this.Hide(); ; //Form2 açıldıktan sonra FORM1'ri gizliyoruz.
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya şifre Hatalı..");
                temizle();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = (char)42; //42 yıldızın ascii kodu.Farklı bir karakterde 
        }
    }
}
