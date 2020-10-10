using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.SessionModel;

namespace TimeTableManagement.Controller.session_controller
{
    class session
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public session()
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

            
                while(data.Read())
                {
                int i = 0;
                    arrayList.Add(data.GetValue(i).ToString());
                i++;
                }
            

            return arrayList;
        }

        public ArrayList getSubjects()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select SubName from SubjectTable";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }

        public ArrayList getSubCode(String subname)
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select SubCode from SubjectTable where SubName = '" + subname+"'";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }



        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }


        public void insertSessions(sessionModel session)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string q1 = "";
            if (session.Type == "Lecture")
            {
               
                 q1 = "select LecHrs  from SubjectTable where SubCode = '" + session.subCode + "'";

            }
            else if(session.Type== "Tutorial ")
            {
               
                q1 = "select TuteHrs  from SubjectTable where SubCode = '" + session.subCode + "'";
            }
            else
            {
               
                q1 = "select LabHrs  from SubjectTable where SubCode = '" + session.subCode + "'";
            }
          
           
            SqlDataReader data = new SqlCommand(q1, con).ExecuteReader();
            string hrs = "";
            while (data.Read())
            {
                int i = 0;
                hrs = data.GetValue(0).ToString();
                i++;
            }
          

            string query = "INSERT INTO Session(Subject,subjectCode,type,GroupID,subgroup,studentcount,typeduration,Lecturers)  VALUES ('" + session.SubName + "','" + session.subCode + "','" + session.Type + "','" + session.groupId + "','" + session.subgId + "','"  + session.studentcount + "','"+ hrs.ToString() + "','" +session.lec+ "')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = com.ExecuteNonQuery();

            if (ret != 0)
            {
              /*  string searchId = "select subjectCode from Session where subjectCode = '" + session.subCode + "'";
                SqlDataReader data = new SqlCommand(searchId, con).ExecuteReader();
                string id = data.GetValue(0).ToString();*/

                foreach (string str in session.lecturers)
                {
                    string insertlectures = "INSERT INTO sessionLecturer(subjectCode,Lecturer)  VALUES ('" + session.subCode + "','" + str + "')";
                    SqlCommand com1 = new SqlCommand(insertlectures, con);
                    int ret1 = NewMethod(com1);
                }
                System.Windows.Forms.MessageBox.Show("Adding Successful !!");

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Adding Error !!");

            }


            con.Close();
        }

        public ArrayList getGroupID()
        {

            ArrayList arrayList = new ArrayList();

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "select Distinct GroupID from Session";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();


            while (data.Read())
            {
                int i = 0;
                arrayList.Add(data.GetValue(i).ToString());
                i++;
            }


            return arrayList;
        }
        public DataTable getSessiondatatoTable()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();

            string query = "SELECT Session.Subject, Session.subjectCode, Session.type,Session.GroupID ,Session.subgroup, Session.studentcount, Session.typeduration,Session.Lecturers,SubjectTable.offYear,offSem FROM Session LEFT Join  SubjectTable on Session.subjectCode = SubjectTable.SubCode";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);

            return dataTable;

            
        }


        public DataTable SearchSession(sessionModel sessionModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "SELECT Session.Subject, Session.subjectCode, Session.type,Session.GroupID ,Session.subgroup, Session.studentcount, " +
                "Session.typeduration,sessionLecturer.Lecturer FROM Session left JOIN sessionLecturer ON Session.subjectCode = sessionLecturer.subjectCode " +
                " where Session.GroupID ='" + sessionModel.groupId+ "' and Session.Subject = '"+sessionModel.SubName+ "' and sessionLecturer.Lecturer = '"+sessionModel.lec+"' ";

            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            dataTable.Load(data);

            return dataTable;


        }



    }

  
}
