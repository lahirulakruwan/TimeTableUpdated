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
    public partial class students : Form
    {
        Studentcon studentCon = new Studentcon();
        studentmodel studentmod = new studentmodel();
        Tagcon tagCon = new Tagcon();
        Tagmodel tagmod = new Tagmodel();
        public static String tagupdatevalue;
        public static String academicyrsemshldupdatevalue;
        public static String programmeupdatevalue;
        public static int updateGroupnumber;
        public static String updategroupid;
        public int updatesubgroupnumber;
        public String updatesubgroupid;


        public students()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          



        }
        private Form activeform = null;
        public void OpenChildForm(Form childform)
        {

            if (activeform != null)
                activeform = null;
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // Student_Data_Grid_View.DataSource = studentCon.GetStudentallvalues();
            TagdataGridView.DataSource = tagCon.GetTagallvalues();
            Academicyrdatagrid.DataSource = studentCon.GetAcademicyrandsemallvalues();
            Programmedatagrid.DataSource = studentCon.GetPorgrammeallvalues();
            groupidgridview.DataSource = studentCon.GetGroupIdvalues();
            subgroupiddatagridview.DataSource = studentCon.GetSubGroupIdvalues();
            

            SqlDataReader dr = studentCon.loadacademicyrsemestervalues();
            while (dr.Read())
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


            SqlDataReader dr7 = tagCon.loadtagdetailsvalues();
            while (dr7.Read())
            {
                Tagcombobox.Items.Add(dr7.GetValue(0).ToString());
            }

            dr.Close();
            dr1.Close();
            dr3.Close();
            dr4.Close();
            dr5.Close();
            dr6.Close();
            dr7.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (academicyearsem.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else {
                        studentmod.Academicyearsemester1 = academicyearsem.Text;
                        studentCon.insertAcademicyearsemesterDetails(studentmod);

                        academicyearsem.Items.Clear();

                        SqlDataReader dr = studentCon.loadacademicyrsemestervalues();
                        while (dr.Read())
                        {
                            academicyearsem.Items.Add(dr.GetValue(0).ToString());
                        }

                        academicyearsem.Text = "";
                        Academicyrdatagrid.DataSource = studentCon.GetAcademicyrandsemallvalues();
                        dr.Close();
                    }
        }

        private void academicyearsem_SelectedIndexChanged(object sender, EventArgs e)
        {

            // academicyrsemshldupdatevalue_index = academicyearsem.Items.IndexOf(academicyearsem.Text);
            //// Console.WriteLine(academicyrsemshldupdatevalue_index.ToString());
            academicyrsemshldupdatevalue = academicyearsem.Text;
            // GroupId_txt.Text = academicyrsemshldupdatevalue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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
            academicyearsem.Text = "";
            Academicyrdatagrid.DataSource = studentCon.GetAcademicyrandsemallvalues();
            dr1.Close();
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
            academicyearsem.Text = "";
            Academicyrdatagrid.DataSource = studentCon.GetAcademicyrandsemallvalues();
            dr1.Close();

        }

        private void Programme_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            programmeupdatevalue = Programme_comboBox.Text;
            // GroupId_txt.Text = academicyrsemshldupdatevalue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Programme_comboBox.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                studentmod.Programmename1 = Programme_comboBox.Text;
                studentCon.insertProgrammeDetails(studentmod);

                Programme_comboBox.Items.Clear();

                SqlDataReader dr = studentCon.loadprogrammevalues();
                while (dr.Read())
                {
                    Programme_comboBox.Items.Add(dr.GetValue(0).ToString());
                }
                Programme_comboBox.Text = "";
                Programmedatagrid.DataSource = studentCon.GetPorgrammeallvalues();
                dr.Close();
            }
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
            Programme_comboBox.Text = "";
            Programmedatagrid.DataSource = studentCon.GetPorgrammeallvalues();
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
            Programme_comboBox.Text = "";
            Programmedatagrid.DataSource = studentCon.GetPorgrammeallvalues();
            dr1.Close();
        }

        private void Groupnumber_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateGroupnumber = Convert.ToInt32(Groupnumber_comboBox.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Groupnumber_comboBox.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                try
                {
                    studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);
                    studentCon.insertGroupnumber(studentmod);
                }
                catch (Exception h)
                {

                    MessageBox.Show("Please provide number only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Groupnumber_comboBox.Text = "";
                }



                Groupnumber_comboBox.Items.Clear();

                SqlDataReader dr = studentCon.loadgroupnumbervalues();
                while (dr.Read())
                {
                    Groupnumber_comboBox.Items.Add(dr.GetValue(0).ToString());
                }
                Groupnumber_comboBox.Text = "";
                dr.Close();
            }
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

                    try
                    {
                        studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);

                    }
                    catch(Exception h)
                    {
                        MessageBox.Show("Please provide number only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Groupnumber_comboBox.Text = "";
                    }
                    
                     studentmod.Group_number_id1 = groupid;


                }
            }


            try
            {
                studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);
                studentCon.updategroupnumber(studentmod);
            }
            catch (Exception h)
            {

                MessageBox.Show("Please provide number only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Groupnumber_comboBox.Text = "";
            }



           
            Groupnumber_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadgroupnumbervalues();
            while (dr1.Read())
            {
                Groupnumber_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }
            Groupnumber_comboBox.Text = "";
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
            Groupnumber_comboBox.Text = "";
            dr1.Close();
        }

        private void GroupId_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updategroupid = GroupId_comboBox.Text;
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
            GroupId_comboBox.Text = "";
            groupidgridview.DataSource = studentCon.GetGroupIdvalues();
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
            GroupId_comboBox.Text = "";
            groupidgridview.DataSource = studentCon.GetGroupIdvalues();
            dr1.Close();
        }

        private void Sub_group_number_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatesubgroupnumber = Convert.ToInt32(Sub_group_number_comboBox.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Sub_group_number_comboBox.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    studentmod.Sub_group_number1 = Convert.ToInt32(Sub_group_number_comboBox.Text);
                    studentCon.insertsubgroupnumber(studentmod);
                }
                catch (Exception h)
                {

                    MessageBox.Show("Please provide number only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Sub_group_number_comboBox.Text = "";
                }

                Sub_group_number_comboBox.Items.Clear();

                SqlDataReader dr = studentCon.loadsubgroupnumbervalues();
                while (dr.Read())
                {
                    Sub_group_number_comboBox.Items.Add(dr.GetValue(0).ToString());
                }

                Sub_group_number_comboBox.Text = "";
                dr.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = studentCon.loadsubgroupnumberallvalues();


            while (dr.Read())
            {
                int subgroupnumber = Convert.ToInt32(dr["Sub_group_number"]);
                int subgroupid = Convert.ToInt32(dr["Sub_group_id"]);

                if (updatesubgroupnumber.Equals(subgroupnumber))
                {
                    //GroupId_txt.Text = academicyearsem.Text;             
                    try
                    {
                        studentmod.Sub_group_number1 = Convert.ToInt32(Sub_group_number_comboBox.Text);

                    }
                    catch (Exception h)
                    {
                        MessageBox.Show("Please provide number only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Groupnumber_comboBox.Text = "";
                    }


                    studentmod.Sub_group_number_primary_key1 = subgroupid;


                }
            }
            try
            {
                studentmod.Sub_group_number1 = Convert.ToInt32(Sub_group_number_comboBox.Text);
                studentCon.updatesubgroupnumber(studentmod);
            }
            catch (Exception h)
            {

                MessageBox.Show("Please provide number only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Groupnumber_comboBox.Text = "";
            }

            Sub_group_number_comboBox.Items.Clear();
            SqlDataReader dr1 = studentCon.loadsubgroupnumbervalues();
            while (dr1.Read())
            {
                Sub_group_number_comboBox.Items.Add(dr1.GetValue(0).ToString());
            }
            Sub_group_number_comboBox.Text = "";
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
            Sub_group_number_comboBox.Text = "";
            dr1.Close();
        }

        private void Sub_group_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatesubgroupid = Sub_group_comboBox.Text;
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
            Sub_group_comboBox.Text = "";
            subgroupiddatagridview.DataSource = studentCon.GetSubGroupIdvalues();
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
            Sub_group_comboBox.Text = "";
            subgroupiddatagridview.DataSource = studentCon.GetSubGroupIdvalues();
            dr1.Close();
        }

        private void studSubmitbtn_Click(object sender, EventArgs e)
        {
            studentmod.Academic_yr_sem1 = academicyearsem.Text;
            studentmod.Programme1 = Programme_comboBox.Text;
            studentmod.Group_number1 = Convert.ToInt32(Groupnumber_comboBox.Text);
            studentmod.Sub_group_number2 = Convert.ToInt32(Sub_group_number_comboBox.Text);
            studentmod.Group_Id1 = GroupId_comboBox.Text;
            studentmod.Sub_Group_Id1 = Sub_group_comboBox.Text;
            studentCon.All_Details(studentmod);
           // Student_Data_Grid_View.DataSource = studentCon.GetStudentallvalues();



            academicyearsem.Text = "";
            Programme_comboBox.Text = "";
            Groupnumber_comboBox.Text = "";
            Sub_group_number_comboBox.Text = "";
            GroupId_comboBox.Text = "";
            Sub_group_comboBox.Text = "";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Tagaddbutton_Click(object sender, EventArgs e)
        {
            if (Tagcombobox.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tagcombobox.Text = "";
            }

            else
            {
                tagmod.Tag_name1 = Tagcombobox.Text;
                tagCon.insertTagDetails(tagmod);
                Tagcombobox.Text = "";

                Tagcombobox.Items.Clear();

                SqlDataReader dr = tagCon.loadtagdetailsvalues();
                while (dr.Read())
                {
                    Tagcombobox.Items.Add(dr.GetValue(0).ToString());
                }
                TagdataGridView.DataSource = tagCon.GetTagallvalues();
                dr.Close();
            }
        }

        private void Tagcombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tagupdatevalue = Tagcombobox.Text;
        }

        private void Tageditbutton_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = tagCon.loadatagallvalues();


            while (dr.Read())
            {
                String tagname = Convert.ToString(dr["Tag_Name"]);
                int tagid = Convert.ToInt32(dr["Tag_Id"]);

                if (tagupdatevalue.Equals(tagname))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    tagmod.Tag_name1 = Tagcombobox.Text;
                    tagmod.Tag_id1 = tagid;


                }
            }

            tagCon.updatetagdetails(tagmod);
            Tagcombobox.Items.Clear();
            SqlDataReader dr1 = tagCon.loadtagdetailsvalues();
            while (dr1.Read())
            {
                Tagcombobox.Items.Add(dr1.GetValue(0).ToString());
            }
            TagdataGridView.DataSource = tagCon.GetTagallvalues();
            dr1.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tagdeletebutton_Click(object sender, EventArgs e)
        {
            SqlDataReader dr = tagCon.loadatagallvalues();


            while (dr.Read())
            {
                String tagname = Convert.ToString(dr["Tag_Name"]);
                int tagid = Convert.ToInt32(dr["Tag_Id"]);

                if (tagupdatevalue.Equals(tagname))
                {
                    //GroupId_txt.Text = academicyearsem.Text;
                    tagmod.Tag_name1 = Tagcombobox.Text;
                    tagmod.Tag_id1 = tagid;


                }
            }

            tagCon.DeleteTagdetails(tagmod);
            Tagcombobox.Items.Clear();
            SqlDataReader dr1 = tagCon.loadtagdetailsvalues();
            while (dr1.Read())
            {
                Tagcombobox.Items.Add(dr1.GetValue(0).ToString());
            }
            TagdataGridView.DataSource = tagCon.GetTagallvalues();
            dr1.Close();
        }

        private void Academicyrsemret_Click(object sender, EventArgs e)
        {
            Academicyrdatagrid.DataSource = studentCon.GetAcademicyrandsemallvalues();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Programmedatagrid.DataSource = studentCon.GetPorgrammeallvalues();
        }

        private void Student_Data_Grid_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Academicyrdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TagdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void academicyearsem_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Programme_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void GroupId_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void Sub_group_comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void academicyearsem_TextUpdate(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(academicyearsem.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This box accepts only alphabetical characters");
              //  academicyearsem.Text.Remove(academicyearsem.Text.Length - 1);
            }
        }

        private void Programme_comboBox_TextUpdate(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Programme_comboBox.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This box accepts only alphabetical characters");
              //  Programme_comboBox.Text.Remove(Programme_comboBox.Text.Length - 1);
            }
        }

        private void GroupId_comboBox_TextUpdate(object sender, EventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(GroupId_comboBox.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This box accepts only alphabetical characters");
              //  GroupId_comboBox.Text.Remove(GroupId_comboBox.Text.Length - 1);
            }
        }

        private void Sub_group_comboBox_TextUpdate(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Sub_group_comboBox.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This box accepts only alphabetical characters");
               // Sub_group_comboBox.Text.Remove(Sub_group_comboBox.Text.Length - 1);
            }
        }

        private void Tagcombobox_TextUpdate(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Tagcombobox.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This box accepts only alphabetical characters");
               // Tagcombobox.Text.Remove(Tagcombobox.Text.Length - 1);
            }
        }
    }
}
