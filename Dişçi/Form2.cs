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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from AdminPanel where userName = @u1 and userPassword = @u2",connection);
            command.Parameters.AddWithValue("@u1", userNameText.Text);
            command.Parameters.AddWithValue("@u2", userPasswordText.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş !!");
                userPasswordText.Text = "";
            }
            connection.Close();
        }

        private void userPasswordText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
