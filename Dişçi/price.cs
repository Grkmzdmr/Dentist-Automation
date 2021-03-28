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
    public partial class price : Form
    {
        public price()
        {
            InitializeComponent();
        }
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        int ücret;
        int ücret1;
        int ücret2;
        int net1;
        int net2;
        int net;

        public void calculatorYear()
        {

            List<string> liste4 = new List<string>();
            List<int> liste5 = new List<int>();


            connection1.Open();
            SqlCommand command = new SqlCommand("select patientOperation AS [Tedavi Türü],COUNT(*) AS [Tedavi Sayısı] from Patients Where OperationDate Between '" + dateTimePicker1.Value.ToString("yyyy-01-01") + "'And '" + dateTimePicker1.Value.ToString("yyyy-12-31") + "'Group By patientOperation", connection1);

            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            dataGridView3.DataSource = dt;


            SqlDataReader sql = command.ExecuteReader();


            while (sql.Read())
            {
                liste4.Add(sql[0].ToString());
                liste5.Add(Convert.ToInt32(sql[1].ToString()));


            }

            connection1.Close();




            connection1.Open();
            SqlCommand km = new SqlCommand("Select SUM(OperationMoney) from Patients Where OperationDate Between '" + dateTimePicker1.Value.ToString("yyyy-01-01") + "'And '" + dateTimePicker1.Value.ToString("yyyy-12-31") + "'", connection1);
            SqlDataReader nwrd = km.ExecuteReader();
            while (nwrd.Read())
            {
                if (nwrd[0] != System.DBNull.Value)
                {
                    ücret = Convert.ToInt32(nwrd[0]);
                    textBox6.Text = nwrd[0].ToString();

                }
                else { ücret = 0; }
                

            }
            connection1.Close();
            connection1.Open();
            SqlCommand km1 = new SqlCommand("Select SUM(materialPrice) from out Where materialDate Between '" + dateTimePicker1.Value.ToString("yyyy-01-01") + "'And '" + dateTimePicker1.Value.ToString("yyyy-12-31") + "'", connection1);
            SqlDataReader nwrd1 = km1.ExecuteReader();
            if (nwrd1.Read())
            {
                if (nwrd1[0] != System.DBNull.Value)
                {
                    net = Convert.ToInt32(nwrd1[0]);
                    if ((ücret - net) < 0)
                    {
                        
                        label11.Text = "NET ZARAR :";
                    }
                    else
                    {
                        textBox5.Text = (ücret - net).ToString();
                    }
                    
                    
                }
                else { net = 0; textBox5.Text = (ücret - net).ToString(); }
                


            }
            connection1.Close();




        }
        public void calculatorMonth()
        {
            List<string> liste2 = new List<string>();
            List<int> liste3 = new List<int>();
            label4.Text = dateTimePicker3.Value.Year.ToString()+" "+ "YILI";

            switch (dateTimePicker3.Value.Month)
            {
                case 1:
                    label3.Text = "OCAK AYI";
                    break;
                case 2:
                    label3.Text = "ŞUBAT AYI";
                    break;
                case 3:
                    label3.Text = "MART AYI";
                    break;
                case 4:
                    label3.Text = "NİSAN AYI";
                    break;
                case 5:
                    label3.Text = "MAYIS AYI";
                    break;
                case 6:
                    label3.Text = "HAZİRAN AYI";
                    break;
                case 7:
                    label3.Text = "TEMMUZ AYI";
                    break;
                case 8:
                    label3.Text = "AĞUSTOS AYI";
                    break;
                case 9:
                    label3.Text = "EYLÜL AYI";
                    break;
                case 10:
                    label3.Text = "EKİM AYI";
                    break;
                case 11:
                    label3.Text = "KASIM AYI";
                    break;
                case 12:
                    label3.Text = "ARALIK AYI";
                    break;

                
            }

            connection1.Open();
            SqlCommand command1 = new SqlCommand("select patientOperation AS [Tedavi Türü],COUNT(*) AS [Tedavi Sayısı] from Patients Where OperationDate Between '" + dateTimePicker3.Value.ToString("yyyy-MM-01")+"'And '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'Group By patientOperation", connection1);

            command1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(command1);
            sda1.Fill(dt1);
            dataGridView2.DataSource = dt1;


            SqlDataReader sql1 = command1.ExecuteReader();


            while (sql1.Read())
            {
                liste2.Add(sql1[0].ToString());
                liste3.Add(Convert.ToInt32(sql1[1].ToString()));


            }

            connection1.Close();
            connection1.Open();
            SqlCommand km = new SqlCommand("Select SUM(OperationMoney) from Patients Where OperationDate Between '" + dateTimePicker3.Value.ToString("yyyy-MM-01") + "'And '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'", connection1);
            SqlDataReader nwrd = km.ExecuteReader();
            if (nwrd.Read())
            {
                if (nwrd[0] != System.DBNull.Value)
                {
                    ücret1 = Convert.ToInt32(nwrd[0]);
                    textBox4.Text = ücret1.ToString();
                }
                else { ücret1 = 0;
                    textBox4.Text = ücret1.ToString();
                }
                


            }
            else {
                textBox4.Text = 0.ToString();
            }
            connection1.Close();
            connection1.Open();
            SqlCommand km1 = new SqlCommand("Select SUM(materialPrice) from out Where materialDate Between '" + dateTimePicker3.Value.ToString("yyyy-MM-01") + "'And '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "'", connection1);
            SqlDataReader nwrd1 = km1.ExecuteReader();
            if (nwrd1.Read())
            {
                if (nwrd1[0] != System.DBNull.Value)
                {
                    net1 = Convert.ToInt32(nwrd1[0]);
                    if((ücret1 - net1) < 0)
                    {
                        label5.Text = "NET ZARAR :";
                        textBox3.Text = (ücret1 - net1).ToString();
                    }
                    else
                    {
                        textBox3.Text = (ücret1 - net1).ToString();
                    }
                    
                }
                else { net1 = 0; textBox3.Text = (ücret1 - net1).ToString(); }
                


            }
            connection1.Close();


        }
        public void calculator()
        {



            List<string> liste = new List<string>();
            List<int> liste1 = new List<int>();


            connection1.Open();
            SqlCommand command = new SqlCommand("select patientOperation AS [Tedavi Türü],COUNT(*) AS [Tedavi Sayısı] from Patients Where OperationDate Between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'And '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'Group By patientOperation", connection1);

            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(command);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


            SqlDataReader sql = command.ExecuteReader();


            while (sql.Read())
            {
                liste.Add(sql[0].ToString());
                liste1.Add(Convert.ToInt32(sql[1].ToString()));


            }

            connection1.Close();




            connection1.Open();
            SqlCommand km = new SqlCommand("Select SUM(OperationMoney) as [Tedavi Sayısı] from Patients Where OperationDate Between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'And '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", connection1);
            SqlDataReader nwrd = km.ExecuteReader();
            if (nwrd.Read() )
            {
                if(nwrd[0] != System.DBNull.Value)
                {
                    ücret2 = Convert.ToInt32(nwrd[0]);
                    textBox1.Text = nwrd[0].ToString();
                }
                else { ücret2 = 0; textBox1.Text = ücret2.ToString(); }
                


            }
            else {  }
            connection1.Close();
            connection1.Open();
            SqlCommand km1 = new SqlCommand("Select SUM(materialPrice) from out Where materialDate Between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'And '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'", connection1);
            SqlDataReader nwrd1 = km1.ExecuteReader();
            if (nwrd1.Read())
            {

                if (nwrd1[0] != System.DBNull.Value)
                {
                    net2 = Convert.ToInt32(nwrd1[0]);
                    if((ücret2-net2) < 0)
                    {
                        textBox2.Text = (ücret2 - net2).ToString();
                        label2.Text = "NET ZARAR :";
                        
                    }
                    else {
                        textBox2.Text = (ücret2 - net2).ToString();
                    }
                    
                }
                else { net2 = 0; textBox2.Text = (ücret2 - net2).ToString(); }
                


            }
            connection1.Close();














        }


        private void price_Load(object sender, EventArgs e)
        {
            calculatorMonth();

            calculatorYear();
            
            
            
            
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculator();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
