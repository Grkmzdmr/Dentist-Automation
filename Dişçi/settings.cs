using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dişçi
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
           
        }
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        string secim;
        int secilenpara;
        
        int secimID;
        
        
        public void oldPrice()
        {
            List<string> list = new List<string>();
            connection1.Open();
            SqlCommand com = new SqlCommand("select opPrice from opList ", connection1);
            SqlDataReader d = com.ExecuteReader();
            while (d.Read())
            {
                list.Add(d[0].ToString());


            }
            label4.Text = list[0];
            label5.Text = list[1];
            label6.Text = list[2];
            label7.Text = list[3];
            label14.Text = list[4];
            label15.Text = list[5];



            connection1.Close();
        }
        public void dnm()
        {
            connection1.Open();
            SqlCommand com = new SqlCommand("Update opList set opName=@p1,opPrice=@p2 where opID =@p3", connection1);

            com.Parameters.AddWithValue("@p1", secim);
            com.Parameters.AddWithValue("@p2", secilenpara);
            com.Parameters.AddWithValue("@p3", secimID);
            com.ExecuteNonQuery();
            connection1.Close();
            MessageBox.Show("Tedavi Fiyatı Başarıyla Değiştirilmiştir.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            oldPrice();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && textBox1.Text != "")
            {
                
                secim = "Kanal Tedavisi";
                secilenpara = Convert.ToInt32(textBox1.Text);
                secimID = 1;
                dnm();

            }else if (radioButton2.Checked && textBox2.Text != " ")
            {
                
                secim = "Dolgu Tedavisi";
                secilenpara = Convert.ToInt32(textBox2.Text);
                secimID = 2;
                dnm();
            }
            else if (radioButton3.Checked && textBox3.Text != "")
            {
                
                secim = "Kontrol";
                secilenpara = Convert.ToInt32(textBox3.Text);
                secimID = 3;
                dnm();

            }
            else if (radioButton4.Checked && textBox4.Text != "")
            {
                
                secim = "Gömülü Diş Ameliyatı";
                secilenpara = Convert.ToInt32(textBox4.Text);
                secimID = 4;
                dnm();

            }
            else if (radioButton5.Checked && textBox5.Text != "")
            {
                
                secim = "İmplant Tedavisi";
                secilenpara = Convert.ToInt32(textBox5.Text);
                secimID = 5;
                dnm();


            }
            else if (radioButton6.Checked && textBox6.Text != "" )
            {
               
                secim = "Diğer Tedaviler";
                secilenpara = Convert.ToInt32(textBox6.Text);
                secimID = 6;
                dnm();


            }
            else{
                MessageBox.Show("Seçim Yapınız...");
            }
           
            
            
            
            
        }

        private void settings_Load(object sender, EventArgs e)
        {
            oldPrice();
            
            

        }
    }
}
