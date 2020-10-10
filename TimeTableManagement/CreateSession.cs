using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.session_controller;
using TimeTableManagement.Model.SessionModel;

namespace TimeTableManagement.Forms
{

    public partial class CreateSession : Form
    {
        ArrayList lec = new ArrayList();
        public CreateSession()
        {
            InitializeComponent();



            session lecturer = new session();

            for (int i = 0; i < lecturer.getSessiondatatoTable().Rows.Count; i++)
            {

                show_data(lecturer.getSessiondatatoTable(), i);
            }
            lecturerlist.DataSource = lecturer.getLectures();

            subNamelist.DataSource = lecturer.getSubjects();


            sessionList.DataSource = lecturer.getSessiondatatoTable();

            findSessionList.DataSource = lecturer.getSessiondatatoTable();




        }

        private void Addlecture_Click(object sender, EventArgs e)
        {

            lec.Add(lecturerlist.Text);
            lecList.Items.Add(lecturerlist.Text);







        }

        private void subNamelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            session subcode = new session();
            subcodeList.DataSource = subcode.getSubCode(subNamelist.Text.ToString());
        }

        private void lecList_DoubleClick(object sender, EventArgs e)
        {
            /*lecList.SelectedItems.
            MessageBox.Show(lecList.SelectedItems.ToString());*/
        }

        private void Createsessions_Click(object sender, EventArgs e)
        {
            if (type.Text != "" && Gid.Text != "" && Scount.Text != "" && subNamelist.Text != "" && subcodeList.Text != "" && lecList.Items.Count != 0)
            {

                foreach (DataGridViewRow row in sessionList.Rows)
                {


                    if (row.Cells[1].Value.ToString().Equals(subcodeList.Text) && row.Cells[2].Value.ToString().Equals(type.Text) && row.Cells[3].Value.ToString().Equals(Gid.Text))
                    {
                        if (type.Text == "Practical")
                        {
                            if (row.Cells[4].Value.ToString().Equals(subBox.Text))
                            {
                                System.Windows.Forms.MessageBox.Show("This session already added !", "Warning").ToString();
                                return;
                            }

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("This session already added !", "Warning").ToString();
                            return;
                        }



                    }


                }

                sessionModel sessionmodel = new sessionModel();
                sessionmodel.SubName = subNamelist.Text;
                sessionmodel.subCode = subcodeList.Text;
                sessionmodel.Type = type.Text;
                sessionmodel.groupId = Int32.Parse(Gid.Text);

                sessionmodel.subgId = subBox.Text;
                sessionmodel.studentcount = Int32.Parse(Scount.Text);

                sessionmodel.lec = "";

                for (int i = 0; i < lecList.Items.Count; i++)
                {
                    sessionmodel.lec = sessionmodel.lec + lecList.Items[i].Text + ",";
                }

                sessionmodel.lecturers = lec;
                session session = new session();
                session.insertSessions(sessionmodel);

                lecList.Items.Clear();
                lecturerlist.Text = "";
                subNamelist.Text = "";
                subcodeList.Text = "";

                lecturerbox.DataSource = session.getLectures();

                subjectBox.DataSource = session.getSubjects();

                GroupBox.DataSource = session.getGroupID();

                //sessionList.DataSource = session.getSessiondatatoTable();


                sessionList.DataSource = session.getSessiondatatoTable();

                flowLayoutPanel1.Controls.Clear();

                for (int i = 0; i < session.getSessiondatatoTable().Rows.Count; i++)
                {

                    show_data(session.getSessiondatatoTable(), i);
                }







            }
            else
            {

                string ans = System.Windows.Forms.MessageBox.Show("Please fill all the require fields !", "Warning").ToString();
            }

        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.Text != "Practical")
            {
                subBox.Hide();
                sublbl.Hide();
            }
            else
            {
                sublbl.Show();
                subBox.Show();
            }
        }

        private void lecturerbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

            session lec = new session();

            lecturerbox.DataSource = lec.getLectures();

            subjectBox.DataSource = lec.getSubjects();

            GroupBox.DataSource = lec.getGroupID();

            sessionList.DataSource = lec.getSessiondatatoTable();

            findSessionList.DataSource = lec.getSessiondatatoTable();

        }

        private void searchSession_Click(object sender, EventArgs e)
        {

            session searchsession = new session();

            sessionModel sessionModel = new sessionModel();
            sessionModel.SubName = subjectBox.Text;
            sessionModel.groupId = Int32.Parse(GroupBox.Text);
            sessionModel.lec = lecturerbox.Text;

            //System.Windows.Forms.MessageBox.Show(sessionModel.lec.ToString());

            findSessionList.DataSource = searchsession.SearchSession(sessionModel);



        }

        public void show_data(DataTable dataTable, int count)
        {


            Label lecturers = new Label();
            lecturers.AutoSize = true;
            lecturers.Height = 15;
            lecturers.Font = new Font("Microsoft Sans Serif", 12f);
            lecturers.BackColor = Color.SandyBrown;
            lecturers.BorderStyle = BorderStyle.FixedSingle;

            lecturers.Text = dataTable.Rows[count][7].ToString() + "\n"
                        + dataTable.Rows[count][0].ToString() + "(" + dataTable.Rows[count][1].ToString() + ") \n" + dataTable.Rows[count][2].ToString() + "\n"
                        + dataTable.Rows[count][8].ToString() + "." + dataTable.Rows[count][9].ToString() + "." + dataTable.Rows[count][3].ToString() + "." + dataTable.Rows[count][4].ToString() + "\n" +
                        dataTable.Rows[count][5].ToString() + "(" + dataTable.Rows[count][6].ToString() + ") \n \n";
            lecturers.Margin = new Padding(2);



            flowLayoutPanel1.Controls.Add(lecturers);



        }
    }
}
