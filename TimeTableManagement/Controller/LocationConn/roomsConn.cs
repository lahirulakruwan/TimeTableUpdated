using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using TimeTableManagement.Model.locationModel;
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Controller.LocationConn;

namespace TimeTableManagement.Controller.LocationConn
{
    class roomsConn
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();


        public roomsConn()
        {
            con = DBConnection.getDBConnection();

        }

        public ArrayList getRooms()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select roomName from RoomTable";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }

        public ArrayList getRoomsType(String name)
        {
            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select roomType from RoomTable where roomName = '" + name + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;
            }


        public ArrayList getRoomsByFaculty(String selectedFaculty)
        {
            {
                ArrayList arrayList = new ArrayList();

                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }

                DataTable dataTable = new DataTable();
                // Boolean dr1 = checkRoomIsAvailable(name);

                string query = "select roomName from RoomTable where buildingName = '" + selectedFaculty + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;


            }
        }

        public ArrayList getNotAvailableRooms()
        {
            {
                ArrayList arrayList = new ArrayList();

                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }

                DataTable dataTable = new DataTable();
                // Boolean dr1 = checkRoomIsAvailable(name);

                string query = "select roomName from NotAvailableRoomTimes";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;


            }
        }
        public ArrayList getSession()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();

            string query = "select  subjectcode from Consecutivetbl";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }

        public ArrayList getSessionType(String name, String getSelectedSession)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            if (getSelectedSession.Equals("Consecutive")) {
                string query = "select Tag1 from Consecutivetbl where Tag1 = '" + name + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

                Console.WriteLine("awdwadaw", arrayList);

                return arrayList;
            }else if (getSelectedSession.Equals("Parallel"))
            {
                string query = "select Type from Parallel_tbl where Type = '" + name + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

                Console.WriteLine("awdwadaw", arrayList);

                return arrayList;

            }
            else
            {
                string query = "select type from Session where type = '" + name + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

                Console.WriteLine("awdwadaw", arrayList);

                return arrayList;
                return arrayList;

            }
        }
        


        public ArrayList getTag2Type(String name)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            Console.WriteLine(name);

            DataTable dataTable = new DataTable();

            string query = "select Tag2 from Consecutivetbl where subjectcode = '" + name + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }

            Console.WriteLine("awdwadaw", arrayList);

            return arrayList;
        }

       public ArrayList updateSessionTable(roomModel roommodel, String notavlTime, String sessionType)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            roomsConn roomsConn = new roomsConn();
            if (sessionType.Equals("Consecutive")) { 
            SqlDataReader dr = roomsConn.load_sesssion_rooms_details(sessionType);

            while (dr.Read())
            {

                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                String subjectCode = Convert.ToString(dr["subjectCode"]);

                if (roommodel.subjectCode.Equals(subjectCode)){
                    string query = "update Consecutivetbl set roomName = '" + roommodel.roomName + "'where subjectCode = '" + roommodel.subjectCode + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    MessageBox.Show("Updated!");
                    com.ExecuteNonQuery();
                   // insertNotAvailableTimes(roommodel.roomName, roommodel.facultyNme, notavlTime);
                }
            
            }

            Console.WriteLine("awdwadaw", arrayList);

            return arrayList;

            }else if (sessionType.Equals("Parallel")){
                SqlDataReader dr = roomsConn.load_sesssion_rooms_details(sessionType);

                while (dr.Read())
                {

                    if (con.State.ToString() != "Open")
                    {
                        con.Open();
                    }
                    String subjectCode = Convert.ToString(dr["subjectCode"]);

                    if (roommodel.subjectCode.Equals(subjectCode))
                    {
                        string query = "update Consecutivetbl set roomName = '" + roommodel.roomName + "'where subjectCode = '" + roommodel.subjectCode + "'";
                        SqlCommand com = new SqlCommand(query, con);
                        MessageBox.Show("Updated!");
                        com.ExecuteNonQuery();
                        // insertNotAvailableTimes(roommodel.roomName, roommodel.facultyNme, notavlTime);
                    }

                }
                return arrayList;

            }
            else
            {
                SqlDataReader dr = roomsConn.load_sesssion_rooms_details(sessionType);

                while (dr.Read())
                {

                    if (con.State.ToString() != "Open")
                    {
                        con.Open();
                    }
                    String subjectCode = Convert.ToString(dr["subjectCode"]);

                    if (roommodel.subjectCode.Equals(subjectCode))
                    {
                        string query = "update Session set roomName = '" + roommodel.roomName + "'where subjectCode = '" + roommodel.subjectCode + "'";
                        SqlCommand com = new SqlCommand(query, con);
                        MessageBox.Show("Updated!");
                        com.ExecuteNonQuery();
                        // insertNotAvailableTimes(roommodel.roomName, roommodel.facultyNme, notavlTime);
                    }

                }

                return arrayList;

            }
        }

 

        public DataTable load_con_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from Consecutivetbl ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable load_parallel_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from Parallel_tbl ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable load_normal_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from Session ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable load_not_available_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from NotAvailableRoomTimes ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable load_Lec_with_rooms()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from LecturerWithRoom ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }
        public ArrayList getSessionTypeTable(String name)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            Console.WriteLine(name);

            DataTable dataTable = new DataTable();
            if (name.Equals("Normal"))
            {
                string query = "select subjectcode from Session";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }
            else if (name.Equals("Consecutive"))
            {
                string query = "select subjectcode from Consecutivetbl";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }
            else if (name.Equals("Parallel"))
            {
                string query = "select subjectcode from Consecutivetbl";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }

            Console.WriteLine("awdwadaw", arrayList);

            return arrayList;
        }


        public ArrayList getSessionTypeTag(String tagType, String subCode, String tabName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            if (tagType.Equals("Normal"))
            {
                string query = "select type from Session where subjectCode = '" + subCode + "' AND type= '" + tabName + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }
            else if (tagType.Equals("Consecutive"))
            {
                string query = "select Tag1 from Consecutivetbl where subjectcode = '" + subCode + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                Console.WriteLine(arrayList);


            }
            else if (tagType.Equals("Parallel"))
            {
                string query = "select Tag1 from Parallel_tbl where subjectcode = '" + subCode + "'";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }

            }

            return arrayList;
        }

        public void insertNotAvailableTimes(String roomName, String facultyName, String notAvailableTime)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            string query = "INSERT INTO NotAvailableRoomTimes(roomName,notAvailableTime,facultyName)  VALUES ('" + roomName + "','" + notAvailableTime + "','" + facultyName + "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }
        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

        public SqlDataReader load_sesssion_rooms_details(String selectedSessionType)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            if (selectedSessionType.Equals("Normal"))
            {
                string query = "SELECT *  from Session ";
                SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
                return dr1;

            }
            else if (selectedSessionType.Equals("Consecutive"))
            {
                string query = "SELECT *  from Consecutivetbl ";
                SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
                return dr1;

            }
            else
            {
                string query = "SELECT *  from Parallel ";
                SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
                return dr1;
            }
        }

        public Boolean checkRoomIsAvailable(String roomName)
        {

            ArrayList arrayList = new ArrayList();
            roomsConn roomsConn = new roomsConn();
            SqlDataReader dr = roomsConn.loadNotAvailableRooms();

            while (dr.Read())
            {

                if (con.State.ToString() != "Open")
                {
                    con.Open();
                }
                String roomID = Convert.ToString(dr["roomName"]);

                if (roomName.Equals(roomID))
                {
                    MessageBox.Show("Rooms is already Assign!");
                    return false;

                }

            }

            Console.WriteLine("awdwadaw", arrayList);

            return true;
        }
        public SqlDataReader loadNotAvailableRooms()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
 
            string query = "SELECT *  from NotAvailableRoomTimes ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;

        }



        public ArrayList getFaultyRooms()
        {
            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();

                string query = "select buildingName from RoomTable Group BY buildingName";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            

        }

        public void DeleteNotAvailableRooms( String roomName)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM   NotAvailableRoomTimes  WHERE  roomName ='" + roomName + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");
            }
            con.Close();
        }
    }
}
