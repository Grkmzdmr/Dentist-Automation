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
    public partial class patientsInfo : Form
    {
        public patientsInfo()
        {
            InitializeComponent();
        }
        SqlConnection connection3 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            connection3.Open();
            SqlCommand komut35 = new SqlCommand("Select patientName,patientSurname,patientTC,patientNumber,patientAge from Patients where patientName like '%" + textBox1.Text+"%' OR patientTC like '%" +textBox1.Text+"%'", connection3);                                    
            SqlDataReader sql = komut35.ExecuteReader();
            while(sql.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = sql["patientName"].ToString();
                ekle.SubItems.Add(sql["patientSurname"].ToString());
                ekle.SubItems.Add(sql["patientTC"].ToString());
                ekle.SubItems.Add(sql["patientNumber"].ToString());
                ekle.SubItems.Add(sql["patientAge"].ToString());
                listView1.Items.Add(ekle);

            }
            
            connection3.Close();
            
            
           

        }

        private void patientsInfo_Load(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
