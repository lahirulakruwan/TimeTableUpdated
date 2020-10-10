using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.DBConnection
{
    class DbConn
    {
        public SqlConnection getDBConnection()
        {


            string conString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection1()
        {


            string conString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }

        public SqlConnection getDBConnection2()
        {


            string conString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }
        public SqlConnection getDBConnection3()
        {


            string conString = @"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets = True";
            SqlConnection conn = new SqlConnection(conString);
            return conn;
        }


    }






}
