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
    public partial class materials : Form
    {
        public materials()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        public string idd;
      
      

       public void malzmfatr()
        {
            connection.Open();
            SqlCommand nsql = new SqlCommand("Insert into out (materialName,materialPrice,materialDate) values (@m1,@m2,@m3)", connection);
            nsql.Parameters.AddWithValue("@m1", nameMat.Text +"Faturasi");
            nsql.Parameters.AddWithValue("@m2", countMat.Text.ToString());
            nsql.Parameters.AddWithValue("@m3", dateTimePicker1.Value);
            nsql.ExecuteNonQuery();
            connection.Close();
            countMat.Text = "";
            nameMat.Text = "";
            MessageBox.Show("Başarıyla Eklendi...");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            malzmfatr();

        }

        private void materials_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dentistAutomationDataSet8._out' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label4.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;      
            nameMat.Visible = true;
            countMat.Visible = true;
            button8.Visible = true;
            button6.Visible = false;
            label1.Text = "Malzeme Girişi";
            label2.Text = "Malzeme İsmi :";
            label3.Text = "Malzeme Tutarı :";
            button9.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label4.Visible = false;
            label1.Text = "Fatura Girişi";
            label2.Text = "Fatura Türü :";
            label3.Text = "Fatura Tutarı :";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            nameMat.Visible = true;
            countMat.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            label4.Visible = false;
            button4.Visible = false;
            button8.Visible = false;
            label1.Text = "Kira Girişi";
            label2.Text = "Kira Ayı :";
            label3.Text = "Kira Tutarı :";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            nameMat.Visible = true;
            countMat.Visible = true;
            button6.Visible = true;
            button9.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand nsql = new SqlCommand("Insert into out (materialName,materialPrice,materialDate) values (@m1,@m2,@m3)", connection);
            nsql.Parameters.AddWithValue("@m1", nameMat.Text+"AyiKirasi");
            nsql.Parameters.AddWithValue("@m2", countMat.Text.ToString());
            nsql.Parameters.AddWithValue("@m3", dateTimePicker1.Value);
            nsql.ExecuteNonQuery();
            connection.Close();
            countMat.Text = "";
            nameMat.Text = "";
            MessageBox.Show("Başarıyla Eklendi..");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.outTableAdapter.Fill(this.dentistAutomationDataSet8._out);
            button9.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            nameMat.Visible = false;
            countMat.Visible = false;
            button6.Visible = false;
            button4.Visible = false;
            button8.Visible = false;
            dataGridView1.Visible = true;
            label4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand nsql = new SqlCommand("Insert into out (materialName,materialPrice,materialDate) values (@m1,@m2,@m3)", connection);
            nsql.Parameters.AddWithValue("@m1", nameMat.Text);
            nsql.Parameters.AddWithValue("@m2", countMat.Text.ToString());
            nsql.Parameters.AddWithValue("@m3", dateTimePicker1.Value);
            nsql.ExecuteNonQuery();
            connection.Close();
            countMat.Text = "";
            nameMat.Text = "";
            MessageBox.Show("Başarıyla Eklendi..");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if( idd != null )
            {
                connection.Open();
                SqlCommand sil = new SqlCommand("Delete from out Where outID = @p1", connection);
                sil.Parameters.AddWithValue("@p1", idd);
                sil.ExecuteNonQuery();
                connection.Close();
                
            }          
            else
            {
                MessageBox.Show("Silmek İçin Bir Randevu Seçiniz.");
            }
            this.outTableAdapter.Fill(this.dentistAutomationDataSet8._out);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idd = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

        }

       
    }
}
