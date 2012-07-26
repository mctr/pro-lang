using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = new int();
        int b = new int();

        void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(textBox1.Text);
            b = Convert.ToInt16(textBox2.Text);
            textBox3.Text = Convert.ToString(a + b);
            textBox4.Text = Convert.ToString(a - b);
            textBox5.Text = Convert.ToString(a * b);
            textBox6.Text = Convert.ToString(a / b);
            textBox7.Text = Convert.ToString(Math.Pow(a, b));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
