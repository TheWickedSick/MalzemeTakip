using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace malzemeTakip
{
    public partial class Form1 : Form
    {
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\malzemeTakipAccess.accdb");
        OleDbDataAdapter veri;
        OleDbCommand cmd=new OleDbCommand();
        DataSet vgir;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void datadoldur()
        {
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\malzemeTakipAccess.accdb");
        bag.Open();
        veri = new OleDbDataAdapter("Select *from malzeme_ana",bag);
        DataTable tablo = new DataTable();
        veri.Fill(tablo);
        dataGridView1.DataSource = tablo;
        bag.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string a;
            a = Interaction.InputBox("Bilgi gir","Bilgi Gir","Bilgi gir",200,200);
            datadoldur();

        }
    
    
    
    
    }
}
