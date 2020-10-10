using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Model.lahirumodel;

namespace TimeTableManagement.Forms
{
    public partial class Form3 : Form
    {

        Studentcon studentCon = new Studentcon();
        studentmodel studentmod = new studentmodel();
        public static String academicyrsemshldupdatevalue;
        public static String programmeupdatevalue;
        public static int updateGroupnumber;
        public static String updategroupid;
        public int updatesubgroupnumber;
        public String updatesubgroupid;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            studentmod.Academicyearsemester1 = academicyearsem.Text;
            studentCon.insertAcademicyearsemesterDetails(studentmod);

            academicyearsem.Items.Clear();

            SqlDataReader dr = studentCon.loadacademicyrsemestervalues();
            while (dr.Read())
            {
                academicyearsem.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // academicyrsemshldupdatevalue_index = academicyearsem.Items.IndexOf(academicyearsem.Text);
            //// Console.WriteLine(academicyrsemshldupdatevalue_index.ToString());
            academicyrsemshldupdatevalue =  academicyearsem.Text;
          // GroupId_txt.Text = academicyrsemshldupdatevalue.ToString();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                SqlDataReader dr = studentCon.loadacademicyrsemesterallvalues();
           
                
           while (dr.Read())
            {
                String academicyrsem = Convert.ToString(dr["AcademicYrsem"]);
                int academicindexprimarykey = Convert.ToInt32(dr["AcademicYrsemId"]);
                
                if (academicyrsemshldupdatevalue.Equals(academicyrsem))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Academicyearsemester1 = academicyearsem.Text;
                    studentmod.Academicyearsemester_id1 = academicindexprimarykey;
                   
                     
                }
            }

            studentCon.updateacademicyrandsem(studentmod);
            academicyearsem.Items.Clear();
            SqlDataReader dr1 = studentCon.loadacademicyrsemestervalues();
            while (dr1.Read())
            {
                academicyearsem.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();



        }

        private void students_Load(object sender, EventArgs e)
        { 



            Student_Data_Grid_View.DataSource = studentCon.GetStudentallvalues();
         
        
        
          SqlDataReader dr = studentCon.loadacademicyrsemestervalues();
            while(dr.Read())
            {
                academicyearsem.Items.Add(dr.GetValue(0).ToString());
            }



            SqlDataReader dr1 = studentCon.loadprogrammevalues();
            while (dr1.Read())
            {
                Programme_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }


            SqlDataReader dr3 = studentCon.loadgroupnumbervalues();
            while (dr3.Read())
            {
                Groupnumber_comboBox.Items.Add(dr3.GetValue(0).ToString());
            }

            SqlDataReader dr4 = studentCon.loadgroupidrvalues();
            while (dr4.Read())
            {
                GroupId_comboBox.Items.Add(dr4.GetValue(0).ToString());
            }
            SqlDataReader dr5 = studentCon.loadsubgroupnumbervalues();
            while (dr5.Read())
            {
                Sub_group_number_comboBox.Items.Add(dr5.GetValue(0).ToString());
            }

            SqlDataReader dr6 = studentCon.loadsubgroupidrvalues();
            while (dr6.Read())
            {
                Sub_group_comboBox.Items.Add(dr6.GetValue(0).ToString());
            }




            dr.Close();
            dr.Close();
            dr3.Close();
            dr4.Close();
            dr5.Close();
            dr6.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlDataReader dr = studentCon.loadacademicyrsemesterallvalues();


            while (dr.Read())
            {
                String academicyrsem = Convert.ToString(dr["AcademicYrsem"]);
                int academicindexprimarykey = Convert.ToInt32(dr["AcademicYrsemId"]);

                if (academicyrsemshldupdatevalue.Equals(academicyrsem))
                {
                    studentmod.Academicyearsemester1 = academicyearsem.Text;
                    studentmod.Academicyearsemester_id1 = academicindexprimarykey;


                }
            }


            studentCon.DeleteAcademicyearsem(studentmod);
            academicyearsem.Items.Clear();
            SqlDataReader dr1 = studentCon.loadacademicyrsemestervalues();
            while (dr1.Read())
            {
                academicyearsem.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            programmeupdatevalue = Programme_comboBox.Text;
           // GroupId_txt.Text = academicyrsemshldupdatevalue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            studentmod.Programmename1 = Programme_comboBox.Text;
            studentCon.insertProgrammeDetails(studentmod);

            Programme_comboBox.Items.Clear();

            SqlDataReader dr = studentCon.loadprogrammevalues();
            while (dr.Read())
            {
                Programme_comboBox.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadProgrammeallvalues();


            while (dr.Read())
            {
                String programmename = Convert.ToString(dr["Programme_name"]);
                int programmmeid = Convert.ToInt32(dr["Programme_Id"]);

                if (programmeupdatevalue.Equals(programmename))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Programmename1 = Programme_comboBox.Text;
                    studentmod.Programme_id1 = programmmeid;


                }
            }

            studentCon.updateprogramme(studentmod);
            Programme_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadprogrammevalues();
            while (dr1.Read())
            {
                Programme_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadProgrammeallvalues();


            while (dr.Read())
            {
                String programmename = Convert.ToString(dr["Programme_name"]);
                int programmmeid = Convert.ToInt32(dr["Programme_Id"]);

                if (programmeupdatevalue.Equals(programmename))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Programmename1 = Programme_comboBox.Text;
                    studentmod.Programme_id1 = programmmeid;


                }
            }



            studentCon.Deleteprogramme(studentmod);
            Programme_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadprogrammevalues();
            while (dr1.Read())
            {
                Programme_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);
            studentCon.insertGroupnumber(studentmod);

            Groupnumber_comboBox.Items.Clear();

            SqlDataReader dr = studentCon.loadgroupnumbervalues();
            while (dr.Read())
            {
                Groupnumber_comboBox.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();





        }

        private void Groupnumber_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGroupnumber = Convert.ToInt32(Groupnumber_comboBox.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadgroupnumberallvalues();


            while (dr.Read())
            {
                int groupnumber = Convert.ToInt32(dr["Group_number"]);
                int groupid = Convert.ToInt32(dr["Group_number_id"]);

                if (updateGroupnumber.Equals(groupnumber))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);
                    studentmod.Group_number_id1 = groupid;


                }
            }

            studentCon.updategroupnumber(studentmod);
            Groupnumber_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadgroupnumbervalues();
            while (dr1.Read())
            {
                Groupnumber_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadgroupnumberallvalues();


            while (dr.Read())
            {
                int groupnumber = Convert.ToInt32(dr["Group_number"]);
                int groupid = Convert.ToInt32(dr["Group_number_id"]);

                if (updateGroupnumber.Equals(groupnumber))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);
                    studentmod.Group_number_id1 = groupid;


                }
            }

            studentCon.Deletegroupnumber(studentmod);
            Groupnumber_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadgroupnumbervalues();
            while (dr1.Read())
            {
                Groupnumber_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void GroupId_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void studSubmitbtn_Click(object sender, EventArgs e)
        {
                 studentmod.Group_Id1  =  GroupId_comboBox.Text;
                studentmod.Sub_Group_Id1 = Sub_group_comboBox.Text;

             studentCon.All_Details(studentmod);

         

        }

        private void button15_Click(object sender, EventArgs e)
        {
            String academictext = academicyearsem.Text;
            String Programmetxt = Programme_comboBox.Text;
            String groupnumbertxt = Groupnumber_comboBox.Text;

            GroupId_comboBox.Text = Convert.ToString(academicyearsem.Text.ToString()) + '.' + (Convert.ToString(Programme_comboBox.Text.ToString())) + '.' + (Convert.ToString(Groupnumber_comboBox.Text));

            studentmod.Group_id1 = GroupId_comboBox.Text;
            studentCon.insertGroupId(studentmod);

            GroupId_comboBox.Items.Clear();

            SqlDataReader dr = studentCon.loadgroupidrvalues();
            while (dr.Read())
            {
                GroupId_comboBox.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadgroupidrallvalues();


            while (dr.Read())
            {
                String groupnumber = Convert.ToString(dr["Group_number"]);
                int groupid = Convert.ToInt32(dr["Group_key"]);

                if (updategroupid.Equals(groupnumber))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Group_id1 = GroupId_comboBox.Text;
                    studentmod.Group_id_primary_key1 = groupid;


                }
            }



            studentCon.DeletegroupId(studentmod);
            GroupId_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadgroupidrvalues();
            while (dr1.Read())
            {
                GroupId_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void GroupId_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           updategroupid = GroupId_comboBox.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            studentmod.Sub_group_number1  = Convert.ToInt32(Sub_group_number_comboBox.Text);
            studentCon.insertsubgroupnumber(studentmod);

            Sub_group_number_comboBox.Items.Clear();

            SqlDataReader dr = studentCon.loadsubgroupnumbervalues();
            while (dr.Read())
            {
                Sub_group_number_comboBox.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();

        }

        private void Sub_group_number_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatesubgroupnumber = Convert.ToInt32(Sub_group_number_comboBox.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadsubgroupnumberallvalues();


            while (dr.Read())
            {
                int subgroupnumber= Convert.ToInt32(dr["Sub_group_number"]);
                int subgroupid = Convert.ToInt32(dr["Sub_group_id"]);

                if (updatesubgroupnumber.Equals(subgroupnumber))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Sub_group_number1 = Convert.ToInt32(Sub_group_number_comboBox.Text);
                    studentmod.Sub_group_number_primary_key1 = subgroupid;


                }
            }

            studentCon.updatesubgroupnumber(studentmod);
            Sub_group_number_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadsubgroupnumbervalues();
            while (dr1.Read())
            {
                Sub_group_number_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadsubgroupnumberallvalues();


            while (dr.Read())
            {
                int subgroupnumber = Convert.ToInt32(dr["Sub_group_number"]);
                int subgroupid = Convert.ToInt32(dr["Sub_group_id"]);


                if (updatesubgroupnumber.Equals(subgroupnumber))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Sub_group_number1 = Convert.ToInt32(Sub_group_number_comboBox.Text);
                    studentmod.Sub_group_number_primary_key1 = subgroupid;


                }
            }

            studentCon.Deletesubgroupnumber(studentmod);
            Sub_group_number_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadsubgroupnumbervalues();
            while (dr1.Read())
            {
                Sub_group_number_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String academictext = academicyearsem.Text;
            String Programmetxt = Programme_comboBox.Text;
            String groupnumbertxt = Groupnumber_comboBox.Text;

           // GroupId_comboBox.Text = Convert.ToString(academicyearsem.Text.ToString()) + '.' + (Convert.ToString(Programme_comboBox.Text.ToString())) + '.' + (Convert.ToString(Groupnumber_comboBox.Text));

            Sub_group_comboBox.Text = Convert.ToString(GroupId_comboBox.Text.ToString()) + '.' + (Convert.ToString(Sub_group_number_comboBox.Text.ToString()));


            studentmod.Sub_Group_id1 = Sub_group_comboBox.Text;
            studentCon.insertSubGroupId(studentmod);

            Sub_group_comboBox.Items.Clear();

            SqlDataReader dr = studentCon.loadsubgroupidrvalues();
            while (dr.Read())
            {
                Sub_group_comboBox.Items.Add(dr.GetValue(0).ToString());
            }

            dr.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            SqlDataReader dr = studentCon.loadsubgroupidrallvalues();


            while (dr.Read())
            {
                String subgroupid = Convert.ToString(dr["Subgroup_id_value"]);
                int subgroupid_key = Convert.ToInt32(dr["Subgroup_id_key"]);

                if (updatesubgroupid.Equals(subgroupid))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    studentmod.Sub_Group_id1 = Sub_group_comboBox.Text;
                    studentmod.Sub_Group_id_primary_key1 = subgroupid_key;


                }
            }



            studentCon.DeletesubgroupId(studentmod);
             Sub_group_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadsubgroupidrvalues();
            while (dr1.Read())
            {
                Sub_group_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            dr1.Close();
        }

        private void Sub_group_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatesubgroupid = Sub_group_comboBox.Text;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studentdashboard das = new studentdashboard();
            das.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Student_Data_Grid_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
