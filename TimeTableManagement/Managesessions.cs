using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Model.lahirumodel;

namespace TimeTableManagement.Forms
{
    public partial class Managesessions : Form
    {

        NotAvaliablesession notavaliableCon = new NotAvaliablesession();
        Notavaliablemodel notavaliablemod = new Notavaliablemodel();


        consecutivesession consecutivecon = new consecutivesession();
        consecutivemodel consecutivemodel = new consecutivemodel();



        parallelsessioncon parallecon = new parallelsessioncon();
        parallelmodel paramodel = new parallelmodel();


        public Managesessions()
        {
            InitializeComponent();


        }

        private void academicyearsem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = notavaliableCon.load_subjectname_subjectcode_details();

            while (dr.Read())
            {
                if (typelistcomboBox.Text.Equals(dr.GetValue(0).ToString()))
                {
                    textBox1.Text = dr.GetValue(1).ToString();


                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Academicyrdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (typecombobox.Text == ""  || typelistcomboBox.Text == ""  || daycomboBox.Text == "")
            {
                MessageBox.Show("Please Fill the text boxes ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                notavaliablemod.type = typecombobox.Text;
                notavaliablemod.type_name = typelistcomboBox.Text;
                notavaliablemod.subjectcode = textBox1.Text;
                notavaliablemod.tagname = not_avaa_tag_combo.Text;
                notavaliablemod.day = daycomboBox.Text;
                notavaliablemod.timefrom = startTimetxt.Text + "." + starttimecomboBox.Text;
                notavaliablemod.timeto = endTimetxt.Text + "." + endtimecomboBox.Text;
                notavaliablemod.not_avaliable = Avaliabletxt.Text;

                notavaliableCon.insertNotavaliableDetails(notavaliablemod);
                NotAvaliabletable.DataSource = notavaliableCon.loadnotavaliablevalues();


                typecombobox.Text = "";
                typelistcomboBox.Text = "";
                textBox1.Text = "";
                startTimetxt.Text = "";
                starttimecomboBox.Text = "";
                endTimetxt.Text = "";
                endtimecomboBox.Text = "";
                not_avaa_tag_combo.Text = "";
                daycomboBox.Text = "";
                Avaliabletxt.Text = "";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            NotAvaliabletable.DataSource = notavaliableCon.loadnotavaliablevalues();

        }

        private void typecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typecombobox.SelectedIndex == 0)
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                not_avaa_tag_combo.Items.Clear();
                textBox1.Text = "";
                SqlDataReader dr = notavaliableCon.load_lecturename_allvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(0).ToString());
                }

                textBox1.Enabled = false;
                not_avaa_tag_combo.Enabled = false;

            }
            else if (typecombobox.SelectedIndex == 1)
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                not_avaa_tag_combo.Items.Clear();
                textBox1.Text = "";
                SqlDataReader dr = notavaliableCon.load_Group_Id_allvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(0).ToString());
                }
                textBox1.Enabled = false;
                not_avaa_tag_combo.Enabled = false;

            }
            else if (typecombobox.SelectedIndex == 2)
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                not_avaa_tag_combo.Items.Clear();
                textBox1.Text = "";
                SqlDataReader dr = notavaliableCon.load_Sub_Group_Id_allvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(0).ToString());
                }
                textBox1.Enabled = false;
                not_avaa_tag_combo.Enabled = false;
            }
            else if(typecombobox.SelectedIndex == 3)
            {
                typelistcomboBox.Text = "";
                typelistcomboBox.Items.Clear();
                not_avaa_tag_combo.Items.Clear();
                textBox1.Text = "";
                SqlDataReader dr = notavaliableCon.load_subject_details();
                SqlDataReader dr1 = notavaliableCon.loadtagdetailsvalues();
                while (dr.Read())
                {
                    typelistcomboBox.Items.Add(dr.GetValue(3).ToString());
                   

                    while(dr1.Read())
                    {
                        not_avaa_tag_combo.Items.Add(dr1.GetValue(0).ToString());
                    }

                    
                }
                textBox1.Enabled =  true;
                not_avaa_tag_combo.Enabled = true;
            }




        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void endTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int total = 0;


            SqlDataReader dr = consecutivecon.load_sesssion_details();



            while (dr.Read())
            { 
                if (subjectcomboBox.Text.Equals(dr.GetValue(1).ToString()))
                {

                    Console.WriteLine(dr);
                    subjectcodetxt.Text = dr.GetValue(2).ToString();
                    groupidtxt.Text = dr.GetValue(4).ToString();
                   // subgroupidtxt.Text = dr.GetValue(5).ToString();

                    if (dr.GetValue(3).ToString() == "Lecture")
                    {
                        Console.WriteLine("tute");
                        tag1txt.Text = dr.GetValue(3).ToString();
                        tag1timeduration.Text = dr.GetValue(7).ToString();
                        total = total + Int32.Parse(tag1timeduration.Text);

                    }

                   if (dr.GetValue(3).ToString() == "Tutorial")
                    {
                      
                        tag2txt.Text = dr.GetValue(3).ToString();
                        tag2timeduration.Text = dr.GetValue(7).ToString();
                        total = total + Int32.Parse(tag2timeduration.Text);


                    }


                    thrstxt.Text = total.ToString();
                }




            }





        }

        private void subjectcomboBox_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void subjectcomboBox_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void subjectcomboBox_DragLeave(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_Click(object sender, EventArgs e)
        {
            consecutive_data_table.DataSource = consecutivecon.loadnotconsecutivevalues();

                subjectcodetxt.Text = "";
                groupidtxt.Text = "";
               // subgroupidtxt.Text = "";
                tag1txt.Text = "";
                tag1timeduration.Text = "";
                tag2txt.Text = "";
                tag2timeduration.Text = "";
                thrstxt.Text = "";
          
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            consecutive_data_table.DataSource = consecutivecon.loadnotconsecutivevalues();
            NotAvaliabletable.DataSource = notavaliableCon.loadnotavaliablevalues();
            parallel_tbl.DataSource = parallecon.loadparallelvalues();

            subjectcomboBox.Items.Clear();
            lecturer_combo_box.Items.Clear();

            SqlDataReader dr1 = consecutivecon.load_subject_details();
            while (dr1.Read())
            {
                subjectcomboBox.Items.Add(dr1.GetValue(0).ToString());
            }

            SqlDataReader dr3 = consecutivecon.loadlectueres();
            while (dr3.Read())
            {
                consecutive_lecturer_combo.Items.Add(dr3.GetValue(0).ToString());
            }



            SqlDataReader dr2 = parallecon.loadlectueres();
            while (dr2.Read())
            {
                lecturer_combo_box.Items.Add(dr2.GetValue(0).ToString());
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (subjectcomboBox.Text == "" || consecutive_lecturer_combo.Text == "")
            {
                MessageBox.Show("Please Fill the text box ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                consecutivemodel.lecturer = consecutive_lecturer_combo.Text.ToString();
                consecutivemodel.subject = subjectcomboBox.Text.ToString();
                consecutivemodel.subjectcode = subjectcodetxt.Text.ToString();
                consecutivemodel.groupid = groupidtxt.Text.ToString();
               // consecutivemodel.subgroupid = subgroupidtxt.Text.ToString();
                consecutivemodel.Tag1 = tag1txt.Text.ToString();
                consecutivemodel.Tag2 = tag2txt.Text.ToString();
                // consecutivemodel.Tag3 = tag3txt.Text.ToString();

                consecutivemodel.Tag1timeduration = Convert.ToInt32(tag1timeduration.Text);
            //    consecutivemodel.Tag2timeduration = Convert.ToInt32(tag2timeduration.Text);
                //   consecutivemodel.Tag3timeduration = Convert.ToInt32(tag3timeduration.Text);

                consecutivemodel.total_hours = Convert.ToInt32(thrstxt.Text);

                consecutivecon.insertConcecutiveDetails(consecutivemodel);
                consecutive_data_table.DataSource = consecutivecon.loadnotconsecutivevalues();

                consecutive_lecturer_combo.Text = "";
                tag1txt.Text = "";
                tag2txt.Text = "";
                //   tag3txt.Text = "";
                tag1timeduration.Text = "";
                tag2timeduration.Text = "";
                //    tag3timeduration.Text = "";
                subjectcodetxt.Text = "";
                groupidtxt.Text = "";
               // subgroupidtxt.Text = "";
                subjectcomboBox.Text = "";
                thrstxt.Text = "";

            }




        }

        private void subjectcodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tag1txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_DropDown(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_TextUpdate(object sender, EventArgs e)
        {
            int total = 0;

            SqlDataReader dr5 = consecutivecon.load_sesssion_details();

            while (dr5.Read())
            {
                if (subjectcomboBox.Text.Equals(dr5.GetValue(1).ToString()))
                {
                    subjectcodetxt.Text = dr5.GetValue(2).ToString();
                    groupidtxt.Text = dr5.GetValue(4).ToString();
                   // subgroupidtxt.Text = dr5.GetValue(5).ToString();

                    if ( dr5.GetValue(3).ToString()=="Lecture")
                    {

                        tag1txt.Text = dr5.GetValue(3).ToString();
                        tag1timeduration.Text = dr5.GetValue(7).ToString();
                        total = total + Int32.Parse(tag1timeduration.Text);

                    }

                   else if ( dr5.GetValue(3).ToString()=="Tutorial")
                    {

                        tag2txt.Text = dr5.GetValue(3).ToString();
                        tag2timeduration.Text = dr5.GetValue(7).ToString();
                        total = total + Int32.Parse(tag2timeduration.Text);


                    }


                    thrstxt.Text = total.ToString();
                }




            }

        }

        private void subgroupidcombox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Subject_name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr = parallecon.load_subject_details();

            while (dr.Read())
            {
                if (Subject_name_combo.Text.Equals(dr.GetValue(0).ToString()))
                {
                    subject_cod_txt.Text = dr.GetValue(1).ToString();


                }


            }

            SqlDataReader dr1 = parallecon.load_sesssion_details();



            while (dr1.Read())
            {
                if (Subject_name_combo.Text.Equals(dr1.GetValue(1).ToString()))
                {

                   type_combo_box.Items.Add(dr1.GetValue(3).ToString());
                   groupid_combo_box.Items.Add(dr1.GetValue(4).ToString());
                   sub_group_id_combo_box.Items.Add(dr1.GetValue(5).ToString());
                  /// duration_combo_box.Items.Add(dr1.GetValue(7).ToString());
                  // Count_combo_box.Items.Add(dr1.GetValue(6).ToString());

                }


            }

        }

        private void Subject_name_combo_Click(object sender, EventArgs e)
        {
            Subject_name_combo.Items.Clear();
            SqlDataReader dr1 = parallecon.load_subject_details();
            while (dr1.Read())
            {
                Subject_name_combo.Items.Add(dr1.GetValue(0).ToString());
            }

            type_combo_box.Items.Clear();
            groupid_combo_box.Items.Clear();
            sub_group_id_combo_box.Items.Clear();
          //  duration_combo_box.Items.Clear();
          //  Count_combo_box.Items.Clear();





        }

        private void Subject_name_combo_TextUpdate(object sender, EventArgs e)
        {
            SqlDataReader dr = parallecon.load_subject_details();

            while (dr.Read())
            {
                if (Subject_name_combo.Text.Equals(dr.GetValue(0).ToString()))
                {
                    subject_cod_txt.Text = dr.GetValue(1).ToString();


                }


            }
            SqlDataReader dr1 = parallecon.load_sesssion_details();



            while (dr1.Read())
            {
                if (Subject_name_combo.Text.Equals(dr1.GetValue(1).ToString()))
                {

                    type_combo_box.Items.Add(dr1.GetValue(3).ToString());
                    groupid_combo_box.Items.Add(dr1.GetValue(4).ToString());
                    sub_group_id_combo_box.Items.Add(dr1.GetValue(5).ToString());
                  //  duration_combo_box.Items.Add(dr1.GetValue(7).ToString());
                  //  Count_combo_box.Items.Add(dr1.GetValue(6).ToString());

                }


            }


        }

        private void type_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Startimecombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Startimecombobox_Click(object sender, EventArgs e)
        {
           Startimecombobox.Items.Clear();
            SqlDataReader dr1 = parallecon.loadtimeslot();
            while (dr1.Read())
            {
                Startimecombobox.Items.Add(dr1.GetValue(0).ToString());
            }
        }

        private void subject_cod_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void groupid_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void sub_group_id_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Yr_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Startimecombobox.Text == "" || day_combo_box.Text == "" || duration_txt.Text == "")
            {
                MessageBox.Show("Please Fill the  boxes ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
               
                paramodel.starttime = Startimecombobox.Text.ToString();
                paramodel.day = day_combo_box.Text.ToString();
                paramodel.duration = Int32.Parse(duration_txt.Text.ToString());
                paramodel.subject = Subject_name_combo.Text.ToString();
                paramodel.subject_code = subject_cod_txt.Text.ToString();
                paramodel.type = type_combo_box.Text.ToString();
                paramodel.groupid = groupid_combo_box.Text.ToString();
                paramodel.sub_group_id = sub_group_id_combo_box.Text.ToString();
                paramodel.lecturer = lecturer_combo_box.Text.ToString();




                parallecon.insertparallelDetails(paramodel);
                parallel_tbl.DataSource = parallecon.loadparallelvalues();
               


                starttimecomboBox.Text = "";
                day_combo_box.Text = "";
                duration_txt.Text = "";
                Subject_name_combo.Text = "";
                subjectcodetxt.Text = "";
                typecombobox.Text = "";
                groupid_combo_box.Text = "";
                sub_group_id_combo_box.Text = "";
                lecturer_combo_box.Text = "";
            

            }
        }

        private void lecturer_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void subjectcomboBox_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
