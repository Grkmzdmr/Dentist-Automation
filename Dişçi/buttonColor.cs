using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dişçi
{   
    
    class buttonColor
    {
        
        public void Buttonrenk(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 115, 0, 0);
            btn.Enabled = false;
            
        }
        public void Buttonchange(Button btn2)
        {
            btn2.Enabled = true;
            btn2.BackColor = Color.FromArgb(255, 0, 57, 9);
           
        }
        public void Sendinf(SqlConnection sql,Button b,DateTimePicker d)
        {
            Form3 fo = new Form3();
            sql.Open();
            SqlCommand k = new SqlCommand("Insert into dateTable (Udate,Uhour) values (@d,@d12)",sql);
            String day1 = d.Value.Day.ToString();
            String month2 = d.Value.Month.ToString();
            String year3 = d.Value.Year.ToString();
            String date4 = year3 + "-" + month2 + "-" + day1;
            
            k.Parameters.AddWithValue("@d", date4);
            k.Parameters.AddWithValue("@d12", b.Text);
            
            
            k.ExecuteNonQuery();
            sql.Close();                 
            RandevuKayit randevuKayit = new RandevuKayit();
            randevuKayit.Show();
            
            

        }
        public void firstButton(Button bt)=>bt.Visible = false;
        
        public void secondButton(Button bt1) => bt1.Visible = true;
    }
}
