using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.lahirumodel;
using System.Windows.Forms;
using System.Data;

namespace TimeTableManagement.Controller.lahiruconn
{
    class Studentcon
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public Studentcon()
        {
            con = DBConnection.getDBConnection();
        }


        //CRUD FUNCTION FOR ACADEMIC YEAR AND SEMESTER

        public void insertAcademicyearsemesterDetails(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Academicyrsemtable(AcademicYrsem)  VALUES ('" + studentMod.Academicyearsemester1+ "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadacademicyrsemestervalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT AcademicYrsem from Academicyrsemtable";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();
           
            return dr;

        }



        public SqlDataReader loadacademicyrsemesterallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Academicyrsemtable";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public void updateacademicyrandsem(studentmodel studentMod)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE  Academicyrsemtable  SET AcademicYrsem='" + studentMod.Academicyearsemester1 + "' WHERE AcademicYrsemId = '" + studentMod.Academicyearsemester_id1 + "'";
            SqlDataAdapter sad = new SqlDataAdapter(sql,con);
            sad.SelectCommand.ExecuteNonQuery();
            
            MessageBox.Show(" Record have been updated", "Information");

         

        }

        public void DeleteAcademicyearsem(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM   Academicyrsemtable  WHERE  AcademicYrsemId='" + studentMod.Academicyearsemester_id1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");
            }
            con.Close();
        }


        //CRUD FUNCTION FOR PROGRAMMME

        public void insertProgrammeDetails(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Programme_table(Programme_name)  VALUES ('" + studentMod.Programmename1 + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }


        public SqlDataReader loadprogrammevalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Programme_name from Programme_table";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadProgrammeallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from Programme_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public void updateprogramme(studentmodel studentMod)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE  Programme_table  SET Programme_name='"+studentMod.Programmename1+"' WHERE Programme_Id = '"+studentMod.Programme_id1+"'";
            SqlDataAdapter sad = new SqlDataAdapter(sql, con);
            sad.SelectCommand.ExecuteNonQuery();

            MessageBox.Show(" Record have been updated", "Information");



        }

        public void Deleteprogramme(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM   Programme_table   WHERE Programme_Id ='" + studentMod.Programme_id1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }


        //CRUD FUNCTION FOR GROUP NUMBER

        public void insertGroupnumber(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Group_number_table(Group_number)  VALUES ('" + studentMod.Group_number1 + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadgroupnumbervalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Group_number from  Group_number_table";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadgroupnumberallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from  Group_number_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public void updategroupnumber(studentmodel studentMod)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE Group_number_table   SET Group_number='" + studentMod.Group_number1 + "' WHERE Group_number_id = '" + studentMod.Group_number_id1 + "'";
            SqlDataAdapter sad = new SqlDataAdapter(sql, con);
            sad.SelectCommand.ExecuteNonQuery();

            MessageBox.Show(" Record have been updated", "Information");



        }

        public void Deletegroupnumber(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  Group_number_table  WHERE Group_number_id ='" + studentMod.Group_number_id1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }

        public void insertGroupId(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Group_id(Group_number)  VALUES ('" + studentMod.Group_id1 + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadgroupidrvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Group_number from Group_id";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadgroupidrallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from  Group_id";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public void DeletegroupId(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  Group_id  WHERE Group_key ='" + studentMod.Group_id_primary_key1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }




        public void insertsubgroupnumber(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Sub_group_numbers(Sub_group_number)  VALUES ('" + studentMod.Sub_group_number1 + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadsubgroupnumbervalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Sub_group_number from  Sub_group_numbers";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadsubgroupnumberallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from  Sub_group_numbers";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }

        public void updatesubgroupnumber(studentmodel studentMod)
        {

            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string sql = "UPDATE  Sub_group_numbers  SET Sub_group_number='" + studentMod.Sub_group_number1+ "' WHERE Sub_group_id = '" + studentMod.Sub_group_number_primary_key1 + "'";
            SqlDataAdapter sad = new SqlDataAdapter(sql, con);
            sad.SelectCommand.ExecuteNonQuery();

            MessageBox.Show(" Record have been updated", "Information");



        }

        public void Deletesubgroupnumber(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  Sub_group_numbers  WHERE Sub_group_id  ='" + studentMod.Sub_group_number_primary_key1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }


        //CRUD FUNCTION FOR SUB-GROUP-ID

        public void insertSubGroupId(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Sub_group_id_table(Subgroup_id_value)  VALUES ('" + studentMod.Sub_Group_id1 + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }

        public SqlDataReader loadsubgroupidrvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT Subgroup_id_value from Sub_group_id_table";
            SqlDataReader dr = new SqlCommand(query, con).ExecuteReader();

            return dr;

        }

        public SqlDataReader loadsubgroupidrallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "SELECT *  from  Sub_group_id_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();
            return dr1;


        }


        public void DeletesubgroupId(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "DELETE  FROM  Sub_group_id_table  WHERE Subgroup_id_key='" + studentMod.Sub_Group_id_primary_key1 + "'";
            SqlCommand com = new SqlCommand(query, con);


            string ans = MessageBox.Show("Are sure to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();


            if (ans == "Yes")
            {
                int ret = com.ExecuteNonQuery();
                MessageBox.Show("No of records deleted" + ret, "Information");


            }


            con.Close();

        }


        public void All_Details(studentmodel studentMod)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            string query = "INSERT INTO Student_Details(AcademicYrSemester,Programme,Groupnumber,GroupId,SubGroupnumber,SubGroupId)  VALUES ('" + studentMod.Academic_yr_sem1 + "','"+studentMod.Programme1 + "','" + studentMod.Group_number1 + "','" + studentMod.Group_Id1 + "','" + studentMod.Sub_group_number2 + "','" + studentMod.Sub_Group_Id1 + "')";
            SqlCommand com = new SqlCommand(query, con);
            int ret = NewMethod(com);

            MessageBox.Show("No of Records have been inserted" + ret, "Information");
            con.Close();
        }


        public DataTable GetStudentallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable(); 

            string query = "SELECT *  from  Student_Details";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();



            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable GetAcademicyrandsemallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Academicyrsemtable";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable GetPorgrammeallvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Programme_table";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }


        public DataTable GetGroupIdvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Group_id";
            SqlDataReader dr1 = new SqlCommand(query, con).ExecuteReader();

            dtstudents.Load(dr1);
            return dtstudents;
        }

        public DataTable GetSubGroupIdvalues()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }

            DataTable dtstudents = new DataTable();

            string query = "SELECT *  from  Sub_group_id_table";
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
