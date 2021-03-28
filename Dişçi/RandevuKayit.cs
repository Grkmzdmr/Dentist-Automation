using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Dişçi
{
    public partial class RandevuKayit : Form
    {
        public bool dateChanged = false;
        Form3 form1 = new Form3();
        buttonColor btc = new buttonColor();
        int fiyat= 0;
        public string gender;
        public RandevuKayit()
        {
            InitializeComponent();
        }
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");

      

            private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            this.Hide();
            
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          


                if (comboBox1.SelectedIndex == -1 || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" && radioButton1.Checked == false && radioButton2.Checked == false )
                {
                MessageBox.Show("Lütfen Bütün Kutuları Doldurunuz.");}
                else
                {
                List<string> l = new List<string>();
                List<string> l2 = new List<string>();
                List<string> l3 = new List<string>();
                List<int> l4 = new List<int>();
                if (radioButton1.Checked == true)
                {
                    radioButton2.Enabled = false;
                    gender = "Kadın";
                }
                else if (radioButton2.Checked == true)
                {
                    radioButton1.Enabled = false;
                    gender = "Erkek";
                }

                connection1.Open();
                SqlCommand k1 = new SqlCommand("select Udate from dateTable Order by Dateid desc", connection1);
                SqlDataReader s = k1.ExecuteReader();

                while (s.Read())
                {
                    l.Add(s[0].ToString());
                }
                connection1.Close();
                connection1.Open();

                SqlCommand k3 = new SqlCommand("select Uhour from dateTable Order by Dateid desc", connection1);
                SqlDataReader s2 = k3.ExecuteReader();
                while (s2.Read())
                {
                    l2.Add(s2[0].ToString());
                }
                connection1.Close();
                connection1.Open();
                SqlCommand k4 = new SqlCommand("select uReal from dateTable order by Dateid desc", connection1);
                SqlDataReader s3 = k4.ExecuteReader();
                while (s3.Read())
                {
                    l3.Add(s3[0].ToString());
                }
                connection1.Close();
                connection1.Open();
                SqlCommand ckm = new SqlCommand("select OpPrice from Oplist", connection1);
                SqlDataReader sdr = ckm.ExecuteReader();
                while (sdr.Read())
                {
                    l4.Add(Convert.ToInt32(sdr[0]));
                }
                connection1.Close();
                connection1.Open();
                SqlCommand komut = new SqlCommand("Insert into Patients (patientName,patientSurname,patientTc,patientOperation,patientAge,patientNumber,patientGender,OperationDate,OperationHours,OperationMoney) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8,@h9,@h10)", connection1);
                komut.Parameters.AddWithValue("@h1", textBox1.Text);
                komut.Parameters.AddWithValue("@h2", textBox2.Text);
                komut.Parameters.AddWithValue("@h3", textBox3.Text);
                komut.Parameters.AddWithValue("@h4", comboBox1.SelectedItem.ToString());



                if (comboBox1.SelectedItem.ToString() == "Kontrol")
                {
                    komut.Parameters.AddWithValue("@h10", l4[2]);

                }
                else if (comboBox1.SelectedItem.ToString() == "Kanal Tedavisi")
                {
                    komut.Parameters.AddWithValue("@h10", l4[0]);


                }
                else if (comboBox1.SelectedItem.ToString() == "Dolgu Tedavisi")
                {
                    komut.Parameters.AddWithValue("@h10", l4[1]);

                }
                else if (comboBox1.SelectedItem.ToString() == "Gömülü Diş Ameliyatı")
                {
                    komut.Parameters.AddWithValue("@h10", l4[3]);

                }
                else if (comboBox1.SelectedItem.ToString() == "İmplant Tedavisi")
                {
                    komut.Parameters.AddWithValue("@h10", l4[4]);

                }
                else if (comboBox1.SelectedItem.ToString() == "Diğer Tedaviler")
                {
                    komut.Parameters.AddWithValue("@h10", l4[5]);

                }
                komut.Parameters.AddWithValue("@h5", textBox4.Text);
                komut.Parameters.AddWithValue("@h6", textBox5.Text);
                komut.Parameters.AddWithValue("@h7", gender);
                komut.Parameters.AddWithValue("@h8", l[0]);
                komut.Parameters.AddWithValue("@h9", l2[0]);



                komut.ExecuteNonQuery();
                connection1.Close();

                MessageBox.Show("Randevu Başarıyla Oluşturulmuştur.");
                this.Hide();

               
            }
            
            
        }

        private void RandevuKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
