using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication3
{
    class DBHandler{


        SqlConnection cn;
        public DBHandler(){
        cn =new SqlConnection();
        cn.ConnectionString = "Data Source=.;Initial Catalog=MIS;Integrated Security=True";
        
        
        }
    
      public static SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MIS;Integrated Security=True");
        public string InsertData(SqlCommand cm)
        {
            string m;
            try { 
           // SqlConnection cn = new SqlConnection();
           // cn.ConnectionString = "Data Source=.;Initial Catalog=MIS;Integrated Security=True";
            cm.Connection = cn;

            cn.Open();

             if(cm.ExecuteNonQuery()==1)
             { m = "New Student saved"; }
             else {m= "New Student  not saved"; }
             cn.Close();

            } catch(Exception x){

              m = x.Message;
            }
             return m;

        }

        public DataTable GetData(SqlCommand cm) {

            //SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "Data Source=.;Initial Catalog=MIS;Integrated Security=True";
            cm.Connection =cn;
            SqlDataAdapter adp = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        
        }

    }
}
