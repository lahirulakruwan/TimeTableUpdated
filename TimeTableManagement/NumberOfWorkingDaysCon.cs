using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.TimeSlotsModel;
using System.Data;
using System.Data.SqlClient;

namespace TimeTableManagement.Controller.TimeSlotsController
{
    class NumberOfWorkingDaysCon
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();
        private SqlConnection sqlConnection;

        public NumberOfWorkingDaysCon()
        {
            con = DBConnection.getDBConnection2();
        }

        public void insertNumberOfWorkingDays(WorkingDaysModel numberOfWorkingDaysModel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO NumOfWorkingDays(weekday,weekend,id)  VALUES ('" + numberOfWorkingDaysModel.WeekdayDays + "','" + numberOfWorkingDaysModel.WeekendDays + "', 1)";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            string queryDays = "INSERT INTO Working_days(monday,tuesday,wednesday,thursday,friday,saturday,sunday,id)  VALUES ('" + numberOfWorkingDaysModel.Monday + "','" + numberOfWorkingDaysModel.Tuesday + "','" + numberOfWorkingDaysModel.Wednesday + "','" + numberOfWorkingDaysModel.Thursday + "','" + numberOfWorkingDaysModel.Friday + "','" + numberOfWorkingDaysModel.Saturday + "','" + numberOfWorkingDaysModel.Sunday + "', 1)";
            SqlCommand comDay = new SqlCommand(queryDays, con);
            int retDay = NewMethod(comDay);

            MessageBox.Show("successfully Added");
            con.Close();
        }

        public Boolean cheackRecords()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM NumOfWorkingDays");
            sqlCommand.Connection = con;

            int RecordCount = Convert.ToInt32(sqlCommand.ExecuteScalar());

            if (RecordCount >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void deleteNumOfWorkingDays()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string queryDay = "DELETE FROM NumOfWorkingDays WHERE id = 1";
            SqlCommand comDay = new SqlCommand(queryDay, con);

            string queryName = "DELETE FROM Working_days WHERE id = 1";
            SqlCommand comName = new SqlCommand(queryName, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                comDay.ExecuteNonQuery();
                comName.ExecuteNonQuery();

                MessageBox.Show("successfully deleted");
            }


            con.Close();
        }

        public DataTable getdatatoTableNumWorkingDays()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT weekday, weekend from NumOfWorkingDays";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableWorkingDaysWeekday()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT monday, tuesday, wednesday, thursday, friday from Working_days";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableWorkingDaysWeekend()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT saturday, sunday from Working_days";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public void updateNumberOfWorkingDays(WorkingDaysModel numberOfWorkingDaysModel)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sqlNum = "UPDATE NumOfWorkingDays SET weekday='" + numberOfWorkingDaysModel.WeekdayDays + "', weekend='" + numberOfWorkingDaysModel.WeekendDays + "' WHERE id = 1";
            SqlCommand comNum = new SqlCommand(sqlNum, con);

            string sqlDay = "UPDATE Working_days SET monday='" + numberOfWorkingDaysModel.Monday + "', tuesday='" + numberOfWorkingDaysModel.Tuesday + "', wednesday='" + numberOfWorkingDaysModel.Wednesday + "', thursday='" + numberOfWorkingDaysModel.Thursday + "', friday='" + numberOfWorkingDaysModel.Friday + "', saturday='" + numberOfWorkingDaysModel.Saturday + "', sunday='" + numberOfWorkingDaysModel.Sunday + "' WHERE id = 1";
            SqlCommand comDay = new SqlCommand(sqlDay, con);

            string ans = MessageBox.Show("Are sure to Update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int retNum = comNum.ExecuteNonQuery();
                int retDay = comDay.ExecuteNonQuery();
                MessageBox.Show("No of records Updated Information");


            }
            con.Close();
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

    }
}
