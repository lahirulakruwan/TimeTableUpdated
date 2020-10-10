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
    class TimeSlotsCon
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();
        private SqlConnection sqlConnection;

        public TimeSlotsCon()
        {
            con = DBConnection.getDBConnection2();
        }

        public void insertTimeSlots(TimeSlotsModel timeSlotsModel)
        {

            createTimeSlots(timeSlotsModel);
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string queryTime = "INSERT INTO working_time(Hours,Minutes,id)  VALUES ('" + timeSlotsModel.WorkingTimeHrs + "','" + timeSlotsModel.WorkingTimeMin + "', 1)";
            SqlCommand comTime = new SqlCommand(queryTime, con);
            int retTime = NewMethod(comTime);

            string queryStart = "INSERT INTO start_time(Hours,Minutes,id)  VALUES ('" + timeSlotsModel.StartTimeHrs + "','" + timeSlotsModel.StartTimeMin + "', 1)";
            SqlCommand comStart = new SqlCommand(queryStart, con);
            int retStart = NewMethod(comStart);

            string queryType = "INSERT INTO time_sloat_type(Type,id)  VALUES ('" + timeSlotsModel.TimeSloatType + "', 1)";
            SqlCommand comType = new SqlCommand(queryType, con);
            int retType = NewMethod(comType);

            MessageBox.Show("successfully Added");
            con.Close();
        }

        public void updateTimeSlots(TimeSlotsModel timeSlotsModel)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sqlTime = "UPDATE working_time SET Hours='" + timeSlotsModel.WorkingTimeHrs + "', Minutes='" + timeSlotsModel.WorkingTimeMin + "' WHERE id = 1";
            SqlCommand comTime = new SqlCommand(sqlTime, con);

            string sqlStart = "UPDATE start_time SET Hours='" + timeSlotsModel.StartTimeHrs + "', Minutes='" + timeSlotsModel.StartTimeMin + "' WHERE id = 1";
            SqlCommand comStart = new SqlCommand(sqlStart, con);

            string sqlType = "UPDATE time_sloat_type SET Type='" + timeSlotsModel.TimeSloatType + "' WHERE id = 1";
            SqlCommand comType = new SqlCommand(sqlType, con);

            string sqlSlots = "DELETE  FROM  time_slots";
            SqlCommand comSlots = new SqlCommand(sqlSlots, con);

            string ans = MessageBox.Show("Are sure to Update this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                comTime.ExecuteNonQuery();
                comStart.ExecuteNonQuery();
                comType.ExecuteNonQuery();
                comSlots.ExecuteNonQuery();
                createTimeSlots(timeSlotsModel);
                MessageBox.Show("No of records Updated Information");


            }
            con.Close();
        }

        public void createTimeSlots(TimeSlotsModel timeSlotsModel)
        {
            float startTime;
            if (timeSlotsModel.StartTimeMin == 0)
            {
                startTime = timeSlotsModel.StartTimeHrs;
                float timeSlot = (float)Convert.ToDouble(startTime);

                int count = 0;

                if (timeSlotsModel.TimeSloatType == "One hour time slots")
                {
                    while (count < timeSlotsModel.WorkingTimeHrs)
                    {

                        string queryTimeSloat = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        timeSlot = timeSlot + float.Parse("1.00");
                        count++;
                    }
                }
                else if (timeSlotsModel.TimeSloatType == "Thirty minutes time slots")
                {
                    while (count < timeSlotsModel.WorkingTimeHrs)
                    {

                        string queryTimeSloat = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        float timeSlot30 = timeSlot + float.Parse("0.30");
                        string queryTimeSloat30 = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot30.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                        timeSlot = timeSlot + float.Parse("1.00");
                        count++;
                    }
                    if (timeSlotsModel.WorkingTimeMin == 30)
                    {
                        string queryTimeSloat30 = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                    }
                }

            }
            else if (timeSlotsModel.StartTimeMin == 30)
            {
                startTime = (float)timeSlotsModel.StartTimeHrs + float.Parse("0.30");
                float timeSlot = (float)Convert.ToDouble(startTime);

                int count = 0;

                if (timeSlotsModel.TimeSloatType == "One hour time slots")
                {
                    while (count < timeSlotsModel.WorkingTimeHrs)
                    {

                        string queryTimeSloat = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        timeSlot = timeSlot + float.Parse("1.00");
                        count++;
                    }

                }
                else if (timeSlotsModel.TimeSloatType == "Thirty minutes time slots")
                {
                    while (count < timeSlotsModel.WorkingTimeHrs)
                    {

                        string queryTimeSloat = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot.ToString() + "')";
                        SqlCommand comTime = new SqlCommand(queryTimeSloat, con);
                        int retTime = NewMethod(comTime);
                        float timeSlot30 = (timeSlot - float.Parse("0.30")) + float.Parse("1.00");
                        string queryTimeSloat30 = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot30.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                        timeSlot = timeSlot30 + float.Parse("0.30");
                        count++;
                    }
                    if (timeSlotsModel.WorkingTimeMin == 30)
                    {
                        string queryTimeSloat30 = "INSERT INTO time_slots(Time_Slots)  VALUES ('" + timeSlot.ToString() + "')";
                        SqlCommand comTime30 = new SqlCommand(queryTimeSloat30, con);
                        int retTime30 = NewMethod(comTime30);
                    }
                }

            }

        }

        public Boolean cheackRecords()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            System.Data.SqlClient.SqlCommand sqlCommand = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM working_time");
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

        public void deleteTimeSlots()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string queryWork = "DELETE  FROM  working_time WHERE id = 1";
            SqlCommand comWork = new SqlCommand(queryWork, con);

            string queryStart = "DELETE  FROM  start_time WHERE id = 1";
            SqlCommand comStart = new SqlCommand(queryStart, con);

            string queryType = "DELETE  FROM  time_sloat_type WHERE id = 1";
            SqlCommand comType = new SqlCommand(queryType, con);

            string querySlots = "DELETE  FROM  time_slots";
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

        public DataTable getdatatoTableWorkingTime()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Hours, Minutes from working_time";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableStartTime()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Hours, Minutes from start_time";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableType()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Type from time_sloat_type";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();
            dataTable.Load(data);
            return dataTable;
        }

        public DataTable getdatatoTableTimeSlots()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            DataTable dataTable = new DataTable();
            string query = "SELECT Time_Slots from time_slots";
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
