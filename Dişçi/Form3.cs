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
    public partial class Form3 : Form
    {
        buttonColor bt = new buttonColor();
        public String nameTime;

        public Form3()
        {

            InitializeComponent();


        }
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        public void listeleme()
        {
            bt.secondButton(b1);
            bt.secondButton(b2);
            bt.secondButton(b3);
            bt.secondButton(b4);
            bt.secondButton(b5);
            bt.secondButton(b6);
            bt.secondButton(b7);
            bt.secondButton(b8);
            bt.secondButton(b9);
            bt.secondButton(b10);
            bt.secondButton(b11);
            bt.secondButton(b12);
            bt.secondButton(b13);
            bt.secondButton(b14);
            bt.secondButton(b15);
            bt.secondButton(b16);
            bt.secondButton(b17);
            bt.secondButton(b18);
            bt.secondButton(b19);
            bt.secondButton(b20);
            bt.secondButton(b21);
            bt.secondButton(b22);
            bt.secondButton(b23);
            dateTimePicker1.ValueChanged += new System.EventHandler(dateTimePicker1_ValueChanged);
            List<String> op = new List<string>();
            String day = dateTimePicker1.Value.Day.ToString();
            String month = dateTimePicker1.Value.Month.ToString();
            String year = dateTimePicker1.Value.Year.ToString();
            String date = year + "-" + month + "-" + day;
            connection1.Open();
            SqlCommand komut = new SqlCommand("Select OperationHours from Patients where OperationDate = @date", connection1);
            komut.Parameters.AddWithValue("@date", date);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                op.Add(reader[0].ToString());
            }
            connection1.Close();

            foreach (var eleman in op)
            {
                if (b1.Text == eleman) { bt.Buttonrenk(b1); }
                else if (b2.Text == eleman) { bt.Buttonrenk(b2); }
                else if (b3.Text == eleman) { bt.Buttonrenk(b3); }
                else if (b4.Text == eleman) { bt.Buttonrenk(b4); }
                else if (b5.Text == eleman) { bt.Buttonrenk(b5); }
                else if (b6.Text == eleman) { bt.Buttonrenk(b6); }
                else if (b7.Text == eleman) { bt.Buttonrenk(b7); }
                else if (b8.Text == eleman) { bt.Buttonrenk(b8); }
                else if (b9.Text == eleman) { bt.Buttonrenk(b9); }
                else if (b10.Text == eleman) { bt.Buttonrenk(b10); }
                else if (b11.Text == eleman) { bt.Buttonrenk(b11); }
                else if (b12.Text == eleman) { bt.Buttonrenk(b12); }
                else if (b13.Text == eleman) { bt.Buttonrenk(b13); }
                else if (b14.Text == eleman) { bt.Buttonrenk(b14); }
                else if (b15.Text == eleman) { bt.Buttonrenk(b15); }
                else if (b16.Text == eleman) { bt.Buttonrenk(b16); }
                else if (b17.Text == eleman) { bt.Buttonrenk(b17); }
                else if (b18.Text == eleman) { bt.Buttonrenk(b18); }
                else if (b19.Text == eleman) { bt.Buttonrenk(b19); }
                else if (b20.Text == eleman) { bt.Buttonrenk(b20); }
                else if (b21.Text == eleman) { bt.Buttonrenk(b21); }
                else if (b22.Text == eleman) { bt.Buttonrenk(b22); }
                else if (b23.Text == eleman) { bt.Buttonrenk(b23); }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            bt.Buttonchange(b1);
            bt.Buttonchange(b2);
            bt.Buttonchange(b3);
            bt.Buttonchange(b4);
            bt.Buttonchange(b5);
            bt.Buttonchange(b6);
            bt.Buttonchange(b7);
            bt.Buttonchange(b8);
            bt.Buttonchange(b9);
            bt.Buttonchange(b10);
            bt.Buttonchange(b11);
            bt.Buttonchange(b12);
            bt.Buttonchange(b13);
            bt.Buttonchange(b14);
            bt.Buttonchange(b15);
            bt.Buttonchange(b16);
            bt.Buttonchange(b17);
            bt.Buttonchange(b18);
            bt.Buttonchange(b19);
            bt.Buttonchange(b20);
            bt.Buttonchange(b21);
            bt.Buttonchange(b22);
            bt.Buttonchange(b23);
            bt.firstButton(b1);
            bt.firstButton(b2);
            bt.firstButton(b3);
            bt.firstButton(b4);
            bt.firstButton(b5);
            bt.firstButton(b6);
            bt.firstButton(b7);
            bt.firstButton(b8);
            bt.firstButton(b9);
            bt.firstButton(b10);
            bt.firstButton(b11);
            bt.firstButton(b12);
            bt.firstButton(b13);
            bt.firstButton(b14);
            bt.firstButton(b15);
            bt.firstButton(b16);
            bt.firstButton(b17);
            bt.firstButton(b18);
            bt.firstButton(b19);
            bt.firstButton(b20);
            bt.firstButton(b21);
            bt.firstButton(b22);
            bt.firstButton(b23);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listeleme();   
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void b1_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b1,dateTimePicker1);                   
        private void b2_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b2,dateTimePicker1); 
        private void b3_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b3, dateTimePicker1);       
        private void b4_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b4, dateTimePicker1);
        private void b5_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b5, dateTimePicker1);
        private void b6_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b6, dateTimePicker1); 
        private void b7_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b7, dateTimePicker1); 
        private void b8_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b8, dateTimePicker1); 
        private void b9_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b9, dateTimePicker1); 
        private void b10_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b10, dateTimePicker1); 
        private void b11_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b11, dateTimePicker1); 
        private void b12_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b12, dateTimePicker1); 
        private void b13_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b13, dateTimePicker1); 
        private void b14_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b14, dateTimePicker1); 
        private void b15_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b15, dateTimePicker1); 
        private void b16_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b16, dateTimePicker1); 
        private void b17_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b17, dateTimePicker1); 
        private void b18_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b18, dateTimePicker1);       
        private void b19_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b19, dateTimePicker1);       
        private void b20_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b20, dateTimePicker1);        
        private void b21_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b21, dateTimePicker1); 
        private void b22_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b22, dateTimePicker1); 
        private void b23_Click(object sender, EventArgs e)=>bt.Sendinf(connection1, b23, dateTimePicker1);

        private void Form3_Load(object sender, EventArgs e)
        {
            bt.firstButton(b1);
            bt.firstButton(b2);
            bt.firstButton(b3);
            bt.firstButton(b4);
            bt.firstButton(b5);
            bt.firstButton(b6);
            bt.firstButton(b7);
            bt.firstButton(b8);
            bt.firstButton(b9);
            bt.firstButton(b10);            
            bt.firstButton(b11);
            bt.firstButton(b12);
            bt.firstButton(b13);
            bt.firstButton(b14);
            bt.firstButton(b15);
            bt.firstButton(b16);
            bt.firstButton(b17);
            bt.firstButton(b18);
            bt.firstButton(b19);
            bt.firstButton(b20);
            bt.firstButton(b21);
            bt.firstButton(b22);
            bt.firstButton(b23);
         

        }
    }
   
   
}

