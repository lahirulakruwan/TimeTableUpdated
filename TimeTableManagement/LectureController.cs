using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.LecturerModel;

namespace TimeTableManagement.Controller.LectureController
{
    class LectureController
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public LectureController()
        {
            con = DBConnection.getDBConnection();
        }

        public void insertLecturerDetails(Lecturer lecturer)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "INSERT INTO LecturerTbl(Eid,name,faculty,depertment,center,building,level,rank)  VALUES ('" + lecturer.eid + "','" + lecturer.lecName + "','"+ lecturer.faculty+"','"+lecturer.department+"','"+lecturer.center+"','"+lecturer.buildng+"','"+lecturer.level+"','"+lecturer.rank+"')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            if(ret != 0){
                System.Windows.Forms.MessageBox.Show("Successful");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Adding Error !!");

            }

           
            con.Close();
        }

        public DataTable getdatatoTable()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "SELECT Eid,name,faculty,depertment,center,building,level,rank from LecturerTbl";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            dataTable.Load(data);

            return dataTable;
            
        }

        public void DeleteLecturer(Lecturer lecturer)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            string query = "DELETE  FROM   LecturerTbl  WHERE  Eid='" + lecturer.eid + "'";
            SqlCommand com = new SqlCommand(query, con);

            string ans = System.Windows.Forms.MessageBox.Show("Are sure to remove lecturer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Lecturer removed successful");
            }

            con.Close();

        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            string query = "UPDATE LecturerTbl  SET name ='"+lecturer.lecName+ "',faculty ='" + lecturer.faculty+ "', depertment='"+lecturer.department+ "', center = '"+lecturer.center+ "',building= '"+lecturer.buildng+"', level = '"+lecturer.level+"', rank ='"+lecturer.rank+"'  WHERE  Eid='" + lecturer.eid + "'";
            SqlCommand com = new SqlCommand(query, con);

            string ans = System.Windows.Forms.MessageBox.Show("Are sure to update lecturer details?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Lecturer details update successful");
            }

            con.Close();

        }





        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }


    }
}
