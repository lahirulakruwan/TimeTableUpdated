using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.lahirumodel;
namespace TimeTableManagement.Controller.lahiruconn
{
    class parallelsessioncon
    {


        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();
       

        public  parallelsessioncon()
        {
            con = DBConnection.getDBConnection();
        }

        public SqlDataReader load_sesssion_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Session ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public SqlDataReader load_subject_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT SubName,SubCode  from SubjectTable ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;



        }

        public SqlDataReader loadtagdetailsvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Tag_Name from  Tag_table";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

      
        public SqlDataReader loadgroupid()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Group_number from Group_id";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadsubgroupid()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Subgroup_id_value from Sub_group_id_table";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadlectueres()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT name from LecturerTbl";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadtimeslot()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Time_Slots  from  time_slots";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public void insertparallelDetails(parallelmodel parallelmodel)
        {
            int i = 0;

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            
                string query1 = "SELECT *  from  Parallel_tbl";
                SqlDataReader dr1 = new SqlCommand(query1,con).ExecuteReader();
                          

            while (dr1.Read())
            {
                if (parallelmodel.starttime.Equals(dr1.GetValue(1).ToString()) && parallelmodel.day.Equals(dr1.GetValue(2).ToString()) && parallelmodel.groupid.Equals(dr1.GetValue(7).ToString()) ||  parallelmodel.sub_group_id.Equals(dr1.GetValue(8).ToString()))
                {

                    MessageBox.Show("Sessions are overlapped !!", "Error", MessageBoxButton.OK);
                    i = 1;
                    break;
                }

            }


             if(i != 1)
            { 
                string query = "INSERT INTO  Parallel_tbl(Start_Time,Day,Duration,Subject,Subject_code,Type,Group_Id,Sub_Group_Id,Lecturer)  VALUES ('" + parallelmodel.starttime + "','" + parallelmodel.day + "','" + parallelmodel.duration + "','" + parallelmodel.subject + "','" + parallelmodel.subject_code + "','" + parallelmodel.type + "','" + parallelmodel.groupid + "','" + parallelmodel.sub_group_id + "','" + parallelmodel.lecturer + "')";
                SqlCommand com = new SqlCommand(query, con);
                int ret = NewMethod(com);

                MessageBox.Show("No of Records have been inserted" + ret, "Information");
            }



            dr1.Close();
            con.Close();
        }


        public DataTable loadparallelvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Parallel_tbl";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }



        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }




    }





}
