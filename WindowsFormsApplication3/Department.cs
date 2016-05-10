using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    class Department
    {
        public string D_Id;
        public string Location;
        public string name;

        public string Reg1()
        {


            SqlCommand cm = new SqlCommand();
            cm.CommandText = "INSERT INTO student VALUES(@a,@b,@c)";
            cm.Parameters.AddWithValue("a", D_Id);
            cm.Parameters.AddWithValue("b", Location);
            cm.Parameters.AddWithValue("c", name);
           

            DBHandler db = new DBHandler();
            string m = db.InsertData(cm);
            return m;

        }


    }

}
