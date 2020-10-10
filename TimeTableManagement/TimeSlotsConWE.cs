using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.TimeSlotsModel;
using System.Windows.Forms;

namespace TimeTableManagement.Controller.TimeSlotsController
{
    class TimeSlotsConWE
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();
        private SqlConnection sqlConnection;

        public TimeSlotsConWE()
        {
            con = DBConnection.getDBConnection2();
        }

        public void insertTimeSlotsWE(TimeSlotsModelWE timeSlotsModelWE)
        {

            createTimeSlotsWE(timeSlotsModelWE);
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string queryTime = "INSERT INTO working_timeWE(Hours,Minutes,id)  VALUES ('" + timeSlotsModelWE.WorkingTimeHrsWE + "','" + timeSlotsModelWE.WorkingTimeMinWE + "', 1)";
            SqlCommand comTime = new SqlCommand(queryTime, con);
            int retTime = NewMethod(comTime);

            string queryStart = "INSERT INTO start_timeWE(Hours,Minutes,id)  VALUES ('" + timeSlotsModelWE.StartTimeHrsWE + "','" + timeSlotsModelWE.StartTimeMinWE + "', 1)";
            SqlCommand comStart = new SqlCommand(queryStart, con);
            int retStart = NewMethod(comStart);

            string queryType = "INSERT INTO time_sloat_typeWE(Type,id)  VALUES ('" + timeSlotsModelWE.TimeSloatTypeWE + "', 1)";
            SqlCommand comType = new SqlCommand(queryType, con);
            int retType = NewMethod(comType);

            MessageBox.Show("successfully Added");
            con.Close();
        }

        public void updateTimeSlotsWE(TimeSlotsModelWE timeSlotsModelWE)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sqlTime = "UPDATE working_timeWE SET Hours='" + timeSlotsModelWE.WorkingTimeHrsWE + "', Minutes='" + timeSlotsModelWE.WorkingTimeMinWE + "' WHERE id = 1";
            SqlCommand comTime = new SqlCommand(sqlTime, con);

            string sqlStart = "UPDATE start_timeWE SET Hours='" + timeSlotsModelWE.StartTimeHrsWE + "', Minutes='" + timeSlotsModelWE.StartTimeMinWE + "' WHERE id = 1";
            SqlCommand comStart = new SqlCommand(sqlStart, con);

            string sqlType = "UPDATE time_sloat_typeWE SET Type='" + timeSlotsModelWE.TimeSloatTypeWE + "' WHERE id = 1";
            SqlCommand comType = new SqlCommand(sqlType, con);

            string sqlSlots = "DELETE  FROM  time_slotsWE";
            SqlCommand comSlots = new SqlCommand(sqlSlots, con);

            string ans = MessageBox.Show("Are sure to Update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                comTime.ExecuteNonQuery();
                comStart.ExecuteNonQuery();
                comType.ExecuteNonQuery();
                comSlots.ExecuteNonQuery();
                createTimeSlotsWE(timeSlotsModelWE);
                MessageBox.Show("No of records Updated Information");


            }
            con.Close();
        }

        public void createTimeSlotsWE(TimeSlotsModelWE timeSlotsModelWE)
        {
            float startTimeWE;
            if (timeSlotsModelWE.StartTimeMinWE == 0)
            {
                startTimeWE = timeSlotsModelWE.StartTimeHrsWE;
                float timeSlotWE = (float)Convert.ToDouble(startTimeWE);

                int count = 0;

                if (timeSlotsModelWE.TimeSloatTypeWE == "One hour time slots")
                {
                    while (count < timeSlotsModelWE.WorkingTimeHrsWE)
                    {

                        string queryTimeSloat = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlotWE.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        timeSlotWE = timeSlotWE + float.Parse("1.00");
                        count++;
                    }
                }
                else if (timeSlotsModelWE.TimeSloatTypeWE == "Thirty minutes time slots")
                {
                    while (count < timeSlotsModelWE.WorkingTimeHrsWE)
                    {

                        string queryTimeSloat = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlotWE.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        float timeSlot30WE = timeSlotWE + float.Parse("0.30");
                        string queryTimeSloat30 = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlot30WE.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                        timeSlotWE = timeSlotWE + float.Parse("1.00");
                        count++;
                    }
                    if (timeSlotsModelWE.WorkingTimeMinWE == 30)
                    {
                        string queryTimeSloat30 = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlotWE.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                    }
                }

            }
            else if (timeSlotsModelWE.StartTimeMinWE == 30)
            {
                startTimeWE = (float)timeSlotsModelWE.StartTimeHrsWE + float.Parse("0.30");
                float timeSlotWE = (float)Convert.ToDouble(startTimeWE);

                int count = 0;

                if (timeSlotsModelWE.TimeSloatTypeWE == "One hour time slots")
                {
                    while (count < timeSlotsModelWE.WorkingTimeHrsWE)
                    {

                        string queryTimeSloat = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlotWE.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        timeSlotWE = timeSlotWE + float.Parse("1.00");
                        count++;
                    }

                }
                else if (timeSlotsModelWE.TimeSloatTypeWE == "Thirty minutes time slots")
                {
                    while (count < timeSlotsModelWE.WorkingTimeHrsWE)
                    {

                        string queryTimeSloat = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlotWE.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        float timeSlot30WE = (timeSlotWE - float.Parse("0.30")) + float.Parse("1.00");
                        string queryTimeSloat30 = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlot30WE.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                        timeSlotWE = timeSlot30WE + float.Parse("0.30");
                        count++;
                    }
                    if (timeSlotsModelWE.WorkingTimeMinWE == 30)
                    {
                        string queryTimeSloat30 = "INSERT INTO time_slotsWE(Time_Slots)  VALUES ('" + timeSlotWE.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                    }
                }

            }

        }

        public Boolean cheackRecordsWE()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM working_timeWE");
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

        public void deleteTimeSlotsWE()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string queryWork = "DELETE  FROM  working_timeWE WHERE id = 1";
            SqlCommand comWork = new SqlCommand(queryWork, con);

            string queryStart = "DELETE  FROM  start_timeWE WHERE id = 1";
            SqlCommand comStart = new SqlCommand(queryStart, con);

            string queryType = "DELETE  FROM  time_sloat_typeWE WHERE id = 1";
            SqlCommand comType = new SqlCommand(queryType, con);

            string querySlots = "DELETE  FROM  time_slotsWE";
            SqlCommand comSlots = new SqlCommand(querySlots, con);

            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                comWork.ExecuteNonQuery();
                comStart.ExecuteNonQuery();
                comType.ExecuteNonQuery();
                comSlots.ExecuteNonQuery();
                MessageBox.Show("successfully deleted");
            }


            con.Close();
        }

        public DataTable getdatatoTableWorkingTimeWE()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Hours, Minutes from working_timeWE";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableStartTimeWE()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Hours, Minutes from start_timeWE";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableTypeWE()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Type from time_sloat_typeWE";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableTimeSlotsWE()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Time_Slots from time_slotsWE";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }

    }
}
