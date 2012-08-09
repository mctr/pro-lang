using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.Win32;

namespace Malzeme_stok
{
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection("Data Source=localhost;Initial Catalog=Malzeme_Stok;Integrated Security=True");
        DataTable tablo = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            
            /*SqlDataAdapter adtr = new SqlDataAdapter("select Kullanıcı_Adı,Oda_Numarası,Dahili_No,Malzeme_Türü,Marka_Model from  Malzemeler where Kullanıcı_Adı='"+  +"'", bag);
            adtr.Fill(tablo);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
            */
        }
        void raporla()
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select Kullanıcı_Adı,Oda_Numarası,Dahili_No,Malzeme_Türü,Marka_Model from  Malzemeler where Kullanıcı_Adı='" + textBox1.Text + "'", bag);
            adtr.Fill(tablo);
            CrystalReport1 rapor = new CrystalReport1();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            raporla();
        }
    }
}
