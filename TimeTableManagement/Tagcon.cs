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
using TimeTableManagement.Model.lahirumodel;
using MessageBox = System.Windows.Forms.MessageBox;

namespace TimeTableManagement.Controller.lahiruconn
{
    class Tagcon
    {

        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();


        public Tagcon()
        {
            con = DBConnection.getDBConnection();


        }


        public void insertTagDetails(Tagmodel tagmodel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            int i = 0;

            string query1 = "SELECT *  from  Tag_table";
            SqlDataReader dr1 = new SqlCommand(query1, con).ExecuteReader();


            while (dr1.Read())
            {
                if (tagmodel.Tag_name1.Equals(dr1.GetValue(1).ToString()) || tagmodel.Tag_name1 == "Tutorial")
                {

                    MessageBox.Show("Tags Repeated!!", "Error");
                    i = 1;
                    break;
                }

            }

            if (i != 1)
            {

                string query = "INSERT INTO  Tag_table(Tag_Name)  VALUES ('" + tagmodel.Tag_name1 + "')";
                SqlCommand com = new SqlCommand(query, con);
                int ret = NewMethod(com);

                MessageBox.Show("No of Records have been inserted" + ret, "Information");
            }

            dr1.Close();
            con.Close();
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



        public SqlDataReader loadatagallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Tag_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public void updatetagdetails(Tagmodel tagmodel)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE  Tag_table  SET Tag_Name='" + tagmodel.Tag_name1 + "' WHERE Tag_Id = '" + tagmodel.Tag_id1 + "'";
            SqlDataAdapter sad = new SqlDataAdapter(sql, con);
            sad.SelectCommand.ExecuteNonQuery();

            MessageBox.Show(" Record have been updated", "Information");



        }

        public void DeleteTagdetails(Tagmodel tagmodel)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM   Tag_table  WHERE  Tag_Id='" + tagmodel.Tag_id1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();



        }


        public DataTable GetTagallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dttags = new DataTable();

            string query = "SELECT *  from  Tag_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dttags.Load(dr1);
            return dttags;
        }





















        private static int NewMethod(SqlCommand com)
        {
            return com.ExecuteNonQuery();
        }







    }
}
