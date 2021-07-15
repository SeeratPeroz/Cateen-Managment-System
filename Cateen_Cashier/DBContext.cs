using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cateen_Cashier
{
        class DBContext
        {
            public static SqlConnection con;

            //public static void createConnection()
            //{
            //    con = new SqlConnection("data source=.; initial catalog=Canteen_Database; integrated security=true");
            //}
            public static void createConnection(String uname, String upass)
            {
                con = new SqlConnection(" data source =.; initial catalog= Canteen_Database; user=" + uname + ";password=" + upass);
            Program.userName = uname;
            Program.userPass = upass;
        }

        public static void openConnection()
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            }
            public static void closeConnection()
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    

}
