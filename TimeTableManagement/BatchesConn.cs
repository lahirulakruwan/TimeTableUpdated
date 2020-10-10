using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;
using System.Data;
using System.Collections;
using System.Windows;

namespace TimeTableManagement.Controller.LocationConn
{
    class BatchesConn
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public BatchesConn()
        {
            con = DBConnection.getDBConnection();
        }

        public ArrayList getBatches()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select GroupID from Session";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;
        }

        public ArrayList getSubjectAccourdingToSession(String session)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal")) { 
            DataTable dataTable = new DataTable();
            string query = "select Subject from Session";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;
            }else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Consecutivetbl";

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



        public ArrayList getTheGroupIDsUsingSubjectnmeSession(String session, String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal"))
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine("adwjnakwdnkj" + subjectName);
                string query = "select GroupID from Session where Subject = '" + subjectName + "'";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select Subject from Consecutivetbl";

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

        public ArrayList getTheSubGroupIDsUsingSubjectnmeSession(String session, String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal"))
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine("adwjnakwdnkj" + subjectName);
                string query = "select subgroup from Session where Subject = '" + subjectName + "'";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select subgroup from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select subgroup from Consecutivetbl";

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

        public ArrayList getTheTagTypeUsingSubjectnmeSession(String session, String subjectName)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            if (session.Equals("Normal"))
            {
                DataTable dataTable = new DataTable();
                Console.WriteLine("adwjnakwdnkj" + subjectName);
                string query = "select type from Session where Subject = '" + subjectName + "'";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else if (session.Equals("Parallel"))
            {
                DataTable dataTable = new DataTable();
                string query = "select type from Parallel_tbl";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;
            }
            else
            {
                DataTable dataTable = new DataTable();
                string query = "select type from Consecutivetbl";

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

        public ArrayList getAllGroupIds()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

                string query = "select Group_number from Group_number_table";

                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


                while (data.Read())
                {
                    int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                    i++;
                }
                return arrayList;           
    
        }

        public ArrayList getAllSubGroupIds()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "select Sub_group_number from Sub_group_numbers";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }
            return arrayList;

        }


        public void SR_updateGroupsWithAssignedRoom(String selectedGroupName, String selectedSubGroupName, String selectedSessionType, String selectedTagType, String selectedroomName)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            if (selectedSessionType.Equals("Normal"))
            {

                SqlDataReader dr = loadAllNormalSessions();

                while (dr.Read())
                {
                    String GroupID = Convert.ToString(dr["GroupID"]);
                    if (selectedGroupName.Equals(GroupID))
                    {

                        string sql = "UPDATE Session SET roomName='" + selectedroomName + "' WHERE GroupID = '" + selectedGroupName + "' AND type = '" + selectedTagType + "'";

                        SqlCommand com = new SqlCommand(sql, con);

                        MessageBox.Show("Updateddd");
                        com.ExecuteNonQuery();
                    }
                }
            }
         /*   else if (SessionType.Equals("Consecutive"))
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

            }
            else if (SessionType.Equals("Parallel"))
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
            }*/
        }


        public SqlDataReader loadAllNormalSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Session";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadAllConseSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Consecutivetbl";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadAllParallelSessions()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT * from Parallel";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }
    }
}
