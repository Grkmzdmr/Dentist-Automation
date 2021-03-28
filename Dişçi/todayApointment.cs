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
    public partial class todayApointment : Form
    {
        public todayApointment()
        {
            InitializeComponent();
        }
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");

        public void dayApoint()
        {
            listView1.Items.Clear();
            connection1.Open();
            SqlCommand command = new SqlCommand("Select patientName,patientSurname,patientOperation,patientNumber,OperationHours from Patients where OperationDate LIKE '%" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "%' Order by OperationHours", connection1);
            SqlDataReader sql = command.ExecuteReader();
            while (sql.Read())
            {
                ListViewItem ekle1 = new ListViewItem();
                ekle1.Text = sql["patientName"].ToString();
                ekle1.SubItems.Add(sql["patientSurname"].ToString());
                ekle1.SubItems.Add(sql["patientOperation"].ToString());
                ekle1.SubItems.Add(sql["patientNumber"].ToString());
                ekle1.SubItems.Add(sql["OperationHours"].ToString());
                listView1.Items.Add(ekle1);

            }

            connection1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void todayApointment_Load(object sender, EventArgs e)
        {
            dayApoint();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dayApoint();
        }
    }
}
