using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.lahirumodel;


namespace TimeTableManagement.Controller.lahiruconn
{
    class consecutivesession
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public consecutivesession()
        {
            con = DBConnection.getDBConnection();


        }


        public SqlDataReader load_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Session ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }
        public SqlDataReader load_subject_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT SubName  from SubjectTable ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;



        }


        public void insertConcecutiveDetails(consecutivemodel consecutivemodel )
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO  Consecutivetbl(Lecturer,subject,subjectcode,groupid,Tag1,Tag1timeduration,Tag2,Tag2timeduration,Totalhours)  VALUES ('" + consecutivemodel.lecturer + "','" + consecutivemodel.subject + "','" + consecutivemodel.subjectcode + "','" + consecutivemodel.groupid + "','" + consecutivemodel.Tag1 + "','" + consecutivemodel.Tag1timeduration + "','" + consecutivemodel.Tag2 + "','" + consecutivemodel.Tag2timeduration + "','" + consecutivemodel.total_hours + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public DataTable loadnotconsecutivevalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Consecutivetbl";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }
        public SqlDataReader loadlectueres()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT name from LecturerTbl";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }







        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }








    }
}
