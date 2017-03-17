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

namespace malzeme_takip
{
    public partial class Form1 : Form
    {

        OleDbConnection bag;
        OleDbDataAdapter veri;
        OleDbCommand cmd;
        DataSet vgir;
        public Form1()
        {
            InitializeComponent();
        }
        void degistir()
        {
            cmd = new OleDbCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "update yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, kutuNo, toplamGirisMik, toplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik)";
            cmd.ExecuteNonQuery();
            bag.Close();
            datadoldur();
        }
        void sil()
        {
            cmd = new OleDbCommand();
            bag.Open();
            cmd.Connection = bag;
            cmd.CommandText = "delete from yogaltim_ana=";
        }
        void ekle()
        {
            string sorgu = "insert into yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, kutuNo, toplamGirisMik, toplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik)";
            OleDbCommand komut = new OleDbCommand(sorgu, bag);
            komut.Parameters.AddWithValue("@malzemeAdi", Interaction.InputBox("BİLGİ GİRİŞİ", "BİLGİ GİRİŞİ", "BİLGİ GİRİŞİ", 250, 250));
            komut.Parameters.AddWithValue("@malzemeAdi", Convert.ToString(textBox1.Text.Trim()));
            datadoldur();
            komut.ExecuteNonQuery();
            komut.Dispose();
        }
        void datadoldur()
        {
            bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Source=F:\\malz.takip.son\\malzeme_takip\\malzeme_takip\\yogaltim.accdb");
            //var deneme = bag;
            //string ded=deneme.ToString();
            veri = new OleDbDataAdapter("Select *from yogaltim_ana", bag);
            vgir=new DataSet();
            bag.Open();
            veri.Fill(vgir,"yogaltim_ana");
            dataGridView1.DataSource = vgir.Tables["yogaltim_ana"];
            bag.Close();
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //datadoldur();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ekle();
            //string sorgu = "insert into yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, kutuNo, toplamGirisMik, toplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik)";
            //OleDbCommand komut = new OleDbCommand(sorgu, bag);
            //komut.Parameters.AddWithValue("@malzemeAdi",Interaction.InputBox("Malzeme Giriş","Malzeme Giriş","Malzeme Giriş",1250,3000));
            //komut.Parameters.AddWithValue("@malzemeAdi", Convert.ToString(textBox1.Text.Trim()));
            //datadoldur();
            //komut.ExecuteNonQuery();
            //komut.Dispose();
            


            /*      
    cmd = new OleDbCommand();
    bag.Open();
    cmd.Connection = bag;
    cmd.CommandText = "insert into yogaltim_ana (malzemeAdi,malzemeNo,malzemeOzelligi,girisBirimi,sayfaNo,dolapNo,KutuNo,toplamGirisMik,ToplamCıkMik,depodaKalMik) values ('" + comboBox1.Items.Add +"','"+textBox1.Text+"','"+textBox2.Text+"' ,'" +comboBox2.Items.Add+"','"+textBox3.Text+"','" +textBox4.Text+"','" +textBox5.Text+"','" +textBox5.Text+"','" +textBox6.Text+"','" +textBox7.Text+"','" +textBox8.Text+"')";
    cmd.ExecuteNonQuery();
    bag.Close();
            cmd.Connection = bag;
            string sorgu = "insert into yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, KutuNo, toplamGirisMik, ToplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik)";
            OleDbCommand komut = new OleDbCommand("insert into yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, KutuNo, toplamGirisMik, ToplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik", bag);
            komut.Parameters.AddWithValue("@malzemeAdi", Convert.ToString(comboBox1.SelectedItem.ToString()));
            komut.Parameters.AddWithValue("@malzemeAdi", Convert.ToString(textBox1.Text.Trim()));
            komut.ExecuteNonQuery();
            komut.Dispose();
            datadoldur();
            cmd.Connection = bag;
            string sorgu = "insert into yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, KutuNo, toplamGirisMik, ToplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik)";
            OleDbCommand komut = new OleDbCommand("insert into yogaltim_ana(malzemeAdi, malzemeNo, malzemeOzelligi, girisBirimi, sayfaNo, dolapNo, KutuNo, toplamGirisMik, ToplamCıkMik, depodaKalMik) values(@malzemeAdi, @malzemeNo, @malzemeOzelligi, @girisBirimi, @sayfaNo, @dolapNo, @KutuNo, @toplamGirisMik, @ToplamCıkMik, @depodaKalMik", bag);
            komut.Parameters.AddWithValue("@malzemeAdi", Convert.ToString(comboBox1.SelectedItem.ToString()));
            komut.ExecuteNonQuery();
            komut.Dispose();
             
        */
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
