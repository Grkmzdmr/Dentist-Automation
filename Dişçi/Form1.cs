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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void takeApointment_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApointmentList ap = new ApointmentList();
            ap.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            patientsInfo patientsInfo = new patientsInfo();
            this.Hide();
            patientsInfo.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            materials m = new materials();
            this.Hide();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settings set = new settings();
            
            set.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            price price = new price();
            price.Show();
            this.Hide();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            todayApointment td = new todayApointment();
            td.Show();
            this.Hide();
        }
    }
}
