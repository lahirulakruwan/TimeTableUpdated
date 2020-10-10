using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagement.DBConnection;

namespace TimeTableManagement.Controller.TimeTableGenerate
{
    class TimeTableGenerateCon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();
        private SqlConnection sqlConnection;

        public TimeTableGenerateCon()
        {
            con = DBConnection.getDBConnection();
        }


        public ArrayList getLectures()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select name from LecturerTbl";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }

            con.Close();
            return arrayList;
        }

        public void create()
        {


            //ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }


            string query = "select Time_Slots from time_slots";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                string queryTimeSloat = "INSERT INTO WeekdayTimeTable(TimeSlot)  VALUES ('" + data.GetValue(i) + "')";
                SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                comTime.ExecuteNonQuery();


                i++;
            }


            con.Close();

        }

        public DataTable getdatatoTableTimeTable()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT * from WeekdayTimeTable";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }
    }
}
