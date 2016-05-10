using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication3
{
    class Student
    {

        public string id;
        public string fname;
        public string lname;
        public string city;

        public string Register()
        {

            //SqlConnection cn = new SqlConnection();
            // cn.ConnectionString = "Data Source=.;Initial Catalog=MIS;Integrated Security=True";

            //  SqlCommand cm = new SqlCommand();
            //  cm.Connection = cn;

            //  cm.CommandText = "INSERT INTO student VALUES(@a,@b,@c,@d)";
            // cm.Parameters.AddWithValue("a", id);
            //  cm.Parameters.AddWithValue("b", fname);
            // cm.Parameters.AddWithValue("c", lname);
            // cm.Parameters.AddWithValue("d", city);
          

            //  cn.Open();
            //   cm.ExecuteNonQuery();
            //   cn.Close();
            //  String m= "saved";
            //   return m;

            SqlCommand cm = new SqlCommand();
            cm.CommandText = "INSERT INTO student VALUES(@a,@b,@c,@d)";
            cm.Parameters.AddWithValue("a", id);
            cm.Parameters.AddWithValue("b", fname);
            cm.Parameters.AddWithValue("c", lname);
            cm.Parameters.AddWithValue("d", city);

            DBHandler db = new DBHandler();
            string m = db.InsertData(cm);
            return m;

        }


        public string Register2()
        {


            SqlCommand cm = new SqlCommand();
            cm.CommandText = "INSERT INTO student VALUES(@a,@b,@c,@d)";
            cm.Parameters.AddWithValue("a", id);
            cm.Parameters.AddWithValue("b", fname);
            cm.Parameters.AddWithValue("c", lname);
            cm.Parameters.AddWithValue("d", city);

            DBHandler db = new DBHandler();
            string m = db.InsertData(cm);
            return m;

        }

        public string Register3()
        {
           SqlConnection cn = DBHandler.conn;
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "INSERT INTO student VALUES(@a,@b,@c,@d)";
            cm.Parameters.AddWithValue("a", id);
            cm.Parameters.AddWithValue("b", fname);
            cm.Parameters.AddWithValue("c", lname);
            cm.Parameters.AddWithValue("d", city);

            DBHandler db = new DBHandler();
            string m = db.InsertData(cm);
            return m;





        }

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

        public static DataTable GetAllData2()
        {
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "SELECT * FROM student";

            DBHandler db = new DBHandler();
            DataTable dt = db.GetData(cm);

            return dt;




        }
    }


    }


    

