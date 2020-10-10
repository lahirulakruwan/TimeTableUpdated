using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagement.DBConnection;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Windows;

namespace TimeTableManagement.Controller.LocationConn
{
    class roomsAvalability
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public roomsAvalability()
        {
            con = DBConnection.getDBConnection();
        }


        public Boolean checkRoomIsAvailable(String roomName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            roomsConn roomsConn = new roomsConn();

            SqlDataReader dr = load_ALL_Normal_sesssion_rooms_details();

            while (dr.Read())
            {

                String TableroomName = Convert.ToString(dr["roomName"]);

                if (roomName.Equals(TableroomName)){

                    return false;
                }

            }


            return true;
        }


        public SqlDataReader load_ALL_Normal_sesssion_rooms_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "SELECT *  from Session ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;
        }

    

    public SqlDataReader load_ALL_Conse_sesssion_rooms_details()
    {
        if (con.State.ToString() != "Open")
        {
            con.Open();
        }
        string query = "SELECT *  from Session ";
        SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
        return dr1;
    }

    public SqlDataReader load_ALL_Parallel_sesssion_rooms_details()
    {
        if (con.State.ToString() != "Open")
        {
            con.Open();
        }
        string query = "SELECT *  from Parallel_tbl ";
        SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
        return dr1;
    }

}
}





