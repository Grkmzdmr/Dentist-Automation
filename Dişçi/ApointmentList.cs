using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dişçi
{
    public partial class ApointmentList : Form
    {
       

        public ApointmentList()
        {
            InitializeComponent();
        }
        SqlConnection connection12 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        public string idd;
        private void ApointmentList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dentistAutomationDataSet7.Patients' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.patientsTableAdapter3.Fill(this.dentistAutomationDataSet7.Patients);
            
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(idd != null)
            {
                connection12.Open();
                SqlCommand sil = new SqlCommand("Delete from Patients Where patientID = @p1", connection12);
                sil.Parameters.AddWithValue("@p1", idd);
                sil.ExecuteNonQuery();
                connection12.Close();
                this.patientsTableAdapter3.Fill(this.dentistAutomationDataSet7.Patients);

            }
            else
            {
                MessageBox.Show("Silmek İçin Bir Randevu Seçiniz.");
            }
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idd = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientsTableAdapter3.Fill(this.dentistAutomationDataSet7.Patients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
