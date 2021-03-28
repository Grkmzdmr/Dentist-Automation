using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dişçi
{
    class operationprices
    {
        SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-MVSFB77\\SQLEXPRESS;Initial Catalog=DentistAutomation;Integrated Security=True");
        public void takeopPrice(List<int> list)
        {
            
            
            connection1.Open();
            SqlCommand sql = new SqlCommand("Select opPrice from OpList ", connection1);
            SqlDataReader sqlData = sql.ExecuteReader();
            while (sqlData.Read())
            {
                list.Add(Convert.ToInt32(sqlData[0]));
                
            }
            
            
            connection1.Close();
            
            
            
           
        }
        public void sumprice(List<int> countlist,DateTimePicker dt,DateTimePicker dt1)
        {
            

            connection1.Open();
            SqlCommand sql = new SqlCommand("Select Count(*) from Patients where patientOperation = @p1 AND OperationDate Between '" + dt.Value.ToString("yyyy-MM-dd") + "'And '" + dt1.Value.ToString("yyyy-MM-dd") + "'", connection1);
            sql.Parameters.AddWithValue("@p1", "Kanal Tedavisi");
            

            SqlDataReader sqld = sql.ExecuteReader();
            while (sqld.Read())
            {
                countlist.Add(Convert.ToInt32(sqld[0])) ;
            }
            
                connection1.Close();
           
        }
        public void sumPrice1(List<int> countlist,DateTimePicker dt, DateTimePicker dt1)
        {
            connection1.Open();
            SqlCommand sql1 = new SqlCommand("Select Count(*) from Patients where patientOperation = @p1 AND  OperationDate Between '" + dt.Value.ToString("yyyy-MM-dd") + "'And '" + dt1.Value.ToString("yyyy-MM-dd") + "'", connection1);
            sql1.Parameters.AddWithValue("@p1", "Dolgu Tedavisi");
            SqlDataReader sqld1 = sql1.ExecuteReader();
            while (sqld1.Read())
            {
                countlist.Add(Convert.ToInt32(sqld1[0]));
            }
           
            connection1.Close();
        }
        public void sumPrice2(List<int> countlist,DateTimePicker dt, DateTimePicker dt1)
        {
            connection1.Open();
            SqlCommand sql1 = new SqlCommand("Select Count(*) from Patients where patientOperation = @p1 AND  OperationDate Between '" + dt.Value.ToString("yyyy-MM-dd") + "'And '" + dt1.Value.ToString("yyyy-MM-dd") + "'", connection1);
            sql1.Parameters.AddWithValue("@p1", "Kontrol");
            SqlDataReader sqld1 = sql1.ExecuteReader();
            while (sqld1.Read())
            {
                countlist.Add(Convert.ToInt32(sqld1[0]));
            }
            
            
            connection1.Close();
        }
        public void sumPrice3(List<int> countlist, DateTimePicker dt, DateTimePicker dt1)
        {
            connection1.Open();
            SqlCommand sql1 = new SqlCommand("Select Count(*) from Patients where patientOperation = @p1 AND OperationDate Between '" + dt.Value.ToString("yyyy-MM-dd") + "'And '" + dt1.Value.ToString("yyyy-MM-dd") + "'" , connection1);
            sql1.Parameters.AddWithValue("@p1", "Gömülü Diş Ameliyatı");
            SqlDataReader sqld1 = sql1.ExecuteReader();
            while (sqld1.Read())
            {
                countlist.Add(Convert.ToInt32(sqld1[0]));
            }
            
            connection1.Close();
        }
        public void sumPrice4(List<int> countlist, DateTimePicker dt, DateTimePicker dt1)
        {
            connection1.Open();
            SqlCommand sql1 = new SqlCommand("Select Count(*) from Patients where patientOperation = @p1 AND OperationDate Between '" + dt.Value.ToString("yyyy-MM-dd") + "'And '" + dt1.Value.ToString("yyyy-MM-dd") + "'", connection1);
            sql1.Parameters.AddWithValue("@p1", "İmplant Tedavisi");
            SqlDataReader sqld1 = sql1.ExecuteReader();
            while(sqld1.Read())
            {

                countlist.Add(Convert.ToInt32(sqld1[0]));

            }
            
            connection1.Close();
        }
        public void sumPrice5(List<int> countlist, DateTimePicker dt, DateTimePicker dt1)
        {
            connection1.Open();
            SqlCommand sql1 = new SqlCommand("Select Count(*) from Patients where patientOperation = @p1 AND  OperationDate Between '" + dt.Value.ToString("yyyy-MM-dd") + "'And '" + dt1.Value.ToString("yyyy-MM-dd") + "'", connection1);
            sql1.Parameters.AddWithValue("@p1", "Diğer Tedaviler");
            SqlDataReader sqld1 = sql1.ExecuteReader();
            while (sqld1.Read())
            {
                countlist.Add(Convert.ToInt32(sqld1[0]));
                
            }
           
            connection1.Close();
        }
        
    }

}
