using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Dep
    {
        public static DataTable GetAllData()
        {

            SqlConnection cn = DBHandler.conn;
            SqlCommand cm = new SqlCommand();
            cm.Connection = cn;
            cm.CommandText = "SELECT * FROM student";

            SqlDataAdapter adp = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

    }
}
