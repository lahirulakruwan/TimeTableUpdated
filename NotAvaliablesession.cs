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
    class NotAvaliablesession
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();


        public NotAvaliablesession()
        {
            con = DBConnection.getDBConnection();


        }


        public SqlDataReader load_lecturename_allvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT name  from  LecturerTbl";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public SqlDataReader load_Group_Id_allvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Group_number  from  Group_id";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }
        public SqlDataReader load_Sub_Group_Id_allvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Subgroup_id_value  from  Sub_group_id_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public SqlDataReader load_subject_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from SubjectTable ";
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

        public SqlDataReader load_subjectname_subjectcode_details()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT SubName,SubCode  from SubjectTable ";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;



        }


        public void insertNotavaliableDetails(Notavaliablemodel notavamodel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Not_Avalibale_table(Type,Type_name,Subject_code,Tag,Day,Time_From,Time_To,Avaliability)  VALUES ('" + notavamodel.type + "','" + notavamodel.type_name + "','" +notavamodel.subjectcode+ "','"+notavamodel.tagname+"','" + notavamodel.day + "','" + notavamodel.timefrom + "','" + notavamodel.timeto + "','" + notavamodel.not_avaliable + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

       
        public DataTable loadnotavaliablevalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Not_Avalibale_table";
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
