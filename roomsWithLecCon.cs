using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using TimeTableManagement.Controller.session_controller;
using System.Collections;
using System.Windows;

namespace TimeTableManagement.Controller.LocationConn
{
    class roomsWithLecCon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public roomsWithLecCon()
        {
            con = DBConnection.getDBConnection();
        }
        session lecturer = new session();


        public ArrayList LoadTagsWithRooms(String tagType)
        {
            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "select roomName from RoomTable where roomType = '" + tagType + "'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;

        }


        public void insertLecWithPrefereedRoom(String lecturer, String roomType, String roomName, String SessionType)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            string query = "INSERT INTO LecturerWithRoom(Lecturer,roomType,roomName, SessionType)  VALUES ('" + lecturer + "','" + roomType + "','" + roomName + "', '" + SessionType + "')";
            
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            updateLEcturerWithAssignedRoom(lecturer, roomName, roomType, SessionType);
            MessageBox.Show("Assigned Lecturer to the prefereed room");
            con.Close();
        }


        public void updateLEcturerWithAssignedRoom(String lecturer, String roomName, String roomType, String SessionType)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            if (SessionType.Equals("Normal")) { 
            String cemi = ",";
            String nvla = lecturer + cemi;
            Console.WriteLine("awduqiquq" + nvla);

            SqlDataReader dr = loadAllSessions();

            while (dr.Read())
            {
                String lecturerName = Convert.ToString(dr["Lecturers"]);
                if (nvla.Equals(lecturerName))
                {

                    string sql = "UPDATE Session SET roomName='" + roomName + "' WHERE Lecturers = '" + lecturerName + "' AND type = '" + roomType + "'";

                        SqlCommand com = new SqlCommand(sql, con);
                    SqlDataReader dr1 = loadAllroomsWithLecturers();
                    while (dr1.Read())
                    {
                        String lecturerNameN = Convert.ToString(dr1["Lecturer"]);
                        if (lecturer.Equals(lecturerNameN))
                        {
                            string query = "DELETE  FROM LecturerWithRoom  WHERE  Lecturer ='" + lecturerNameN + "' AND roomType = '" + roomType + "' AND roomName = '" + roomName + "'AND SessionType = '" + SessionType + "'";
                            MessageBox.Show("asdiuh");
                            SqlCommand com1 = new SqlCommand(query, con);
                            com1.ExecuteNonQuery();
                        }
                    }
                    com.ExecuteNonQuery();
                }
            }
            }else if (SessionType.Equals("Consecutive"))
            {
                String cemi = ",";
                String nvla = lecturer + cemi;
                Console.WriteLine("awduqiquq" + nvla);

                SqlDataReader dr = loadAllSessions();

                while (dr.Read())
                {
                    String lecturerName = Convert.ToString(dr["Consecutive"]);
                    if (nvla.Equals(lecturerName))
                    {
                        string sql = "UPDATE Session SET roomName='" + roomName + "' WHERE Lecturers = '" + lecturerName + "' AND type = '" + roomType + "'";
                        SqlCommand com = new SqlCommand(sql, con);
                        SqlDataReader dr1 = loadAllroomsWithLecturers();
                        while (dr1.Read())
                        {
                            String lecturerNameN = Convert.ToString(dr1["Lecturer"]);
                            if (lecturer.Equals(lecturerNameN))
                            {
                                string query = "DELETE  FROM LecturerWithRoom  WHERE  Lecturer ='" + lecturerNameN + "' AND roomType = '" + roomType + "' AND roomName = '" + roomName + "'AND SessionType = '" + SessionType + "'";

                                SqlCommand com1 = new SqlCommand(query, con);
                                com1.ExecuteNonQuery();
                            }
                        }

                        com.ExecuteNonQuery();

                    }
                }

            }else if (SessionType.Equals("Parallel"))
            {
                String cemi = ",";
                String nvla = lecturer + cemi;
                Console.WriteLine("awduqiquq" + nvla);

                SqlDataReader dr = loadAllSessions();

                while (dr.Read())
                {
                    String lecturerName = Convert.ToString(dr["Lecturers"]);
                    if (nvla.Equals(lecturerName))
                    {

                        string sql = "UPDATE Parallel SET roomName='" + roomName + "' WHERE Lecturers = '" + lecturerName + "' AND type = '" + roomType + "'";

                        SqlCommand com = new SqlCommand(sql, con);
                        SqlDataReader dr1 = loadAllroomsWithLecturers();
                        while (dr1.Read())
                        {
                            String lecturerNameN = Convert.ToString(dr1["Lecturer"]);
                            if (lecturer.Equals(lecturerNameN))
                            {
                                string query = "DELETE  FROM LecturerWithRoom  WHERE  Lecturer ='" + lecturerNameN + "' AND roomType = '" + roomType + "' AND roomName = '" + roomName + "'AND SessionType = '" + SessionType + "'";
                                SqlCommand com1 = new SqlCommand(query, con);
                                com1.ExecuteNonQuery();
                            }
                        }

                        com.ExecuteNonQuery();

                    }
                }
            }
        }

        public SqlDataReader loadAllSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Session";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadAllroomsWithLecturers()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from LecturerWithRoom";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

    }
}
