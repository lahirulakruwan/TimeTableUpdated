using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.SubjectModel;

namespace TimeTableManagement.Controller.SubjectController
{
    class subjectController
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public subjectController()
        {
            con = DBConnection.getDBConnection();
        }

        public void insertSubjectDetails(subjectModel subject)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            string query = "INSERT INTO SubjectTable(offYear,offSem,SubName,SubCode,LecHrs,TuteHrs,LabHrs,EvalHrs,year)  VALUES ('" + subject.OffYear + "','" + subject.OffSem + "','" + subject.SubName + "','" + subject.subCode + "','" + subject.lechours + "','" + subject.tuteHours + "','" + subject.labHours + "','" + subject.evalHours + "','"+subject.year+"')";

            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            if (ret != 0)
            {
                System.Windows.Forms.MessageBox.Show("Successful");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Adding Error !!");

            }


            con.Close();
        }

        public DataTable getSubjectdatatoTable()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dataTable = new DataTable();
            string query = "SELECT year, offYear,offSem,SubName,SubCode,LecHrs,TuteHrs,LabHrs,EvalHrs from SubjectTable";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

            dataTable.Load(data);

            return dataTable;

        }

        public void DeleteSubject(subjectModel subjectModel)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            string query = "DELETE  FROM   SubjectTable  WHERE  SubCode='" + subjectModel.subCode + "'";
            SqlCommand com = new SqlCommand(query, con);

            string ans = System.Windows.Forms.MessageBox.Show("Are sure to remove subject?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("subject removed successful");
            }

            con.Close();

        }


        public void UpdateSubject(subjectModel subjectModel)
        {
            if (con.State.ToString() != "Open")
            { con.Open(); }

            string query = "UPDATE SubjectTable  SET year='"+subjectModel.year+"', offYear ='" + subjectModel.OffYear + "',offSem ='" + subjectModel.OffSem + "', SubName='" + subjectModel.SubName + "', LecHrs = '" + subjectModel.lechours + "',TuteHrs= '" + subjectModel.tuteHours + "', LabHrs = '" + subjectModel.labHours + "', EvalHrs ='" + subjectModel.evalHours + "'  WHERE  SubCode='" + subjectModel.subCode + "'";
            SqlCommand com = new SqlCommand(query, con);

            string ans = System.Windows.Forms.MessageBox.Show("Are sure to update subject details?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("subject details update successful");
            }

            con.Close();

        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }
    }
}
