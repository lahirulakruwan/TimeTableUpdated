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
using TimeTableManagement.Controller.TimeTableGenerate;

namespace TimeTableManagement.Forms
{
    public partial class TimeTableGenerate : Form
    {
        TimeTableGenerateCon timeTableGenerate = new TimeTableGenerateCon();
        public TimeTableGenerate()
        {
            InitializeComponent();
            selectLecture.DataSource = timeTableGenerate.getLectures();
            LecTimeTable.DataSource = timeTableGenerate.getdatatoTableTimeTable();
            radioWeekdayLec.Checked = true;
        }

        private void btnGenLec_Click(object sender, EventArgs e)
        {
            printPreviewDialogLecturer.Document = printTimetableLecturer;
            printPreviewDialogLecturer.ShowDialog();
        }

        private void printTimetableLecturer_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-2FO46M3;Initial Catalog=TimeTableDB;Integrated Security=True;MultipleActiveResultSets = True";
            con = new SqlConnection(connetionString);
            con.Open();
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            if (radioWeekdayLec.Checked == true)
            {



                e.Graphics.DrawRectangle(Pens.Black, 10, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 90, 20, 150, 20);
                e.Graphics.DrawRectangle(Pens.Black, 240, 20, 150, 20);
                e.Graphics.DrawRectangle(Pens.Black, 390, 20, 150, 20);
                e.Graphics.DrawRectangle(Pens.Black, 540, 20, 150, 20);
                e.Graphics.DrawRectangle(Pens.Black, 690, 20, 150, 20);

                e.Graphics.DrawString("Monday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(90, 20, 150, 20), stringFormat);
                e.Graphics.DrawString("Tuesday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(240, 20, 150, 20), stringFormat);
                e.Graphics.DrawString("Wednesday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(390, 20, 150, 20), stringFormat);
                e.Graphics.DrawString("Thursday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(540, 20, 150, 20), stringFormat);
                e.Graphics.DrawString("Friday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(690, 20, 150, 20), stringFormat);


                //e.Graphics.DrawRectangle(Pens.Black, 90, 40, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 240, 40, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 390, 40, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 540, 40, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 690, 40, 150, 50);

                //e.Graphics.DrawRectangle(Pens.Black, 10, 90, 80, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 90, 90, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 240, 90, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 390, 90, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 540, 90, 150, 50);
                //e.Graphics.DrawRectangle(Pens.Black, 690, 90, 150, 50);






                string query = "select Time_Slots from time_slots";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();




                int size = 40;
                while (data.Read())
                {

                    int i = 0;
                    e.Graphics.DrawRectangle(Pens.Black, 10, size, 80, 50);
                    e.Graphics.DrawString(data.GetValue(i).ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(10, size, 80, 50), stringFormat);



                    e.Graphics.DrawRectangle(Pens.Black, 90, size, 150, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 240, size, 150, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 390, size, 150, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 540, size, 150, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 690, size, 150, 50);



                    i++;
                    size = size + 50;

                }

                string query1 = "select Time_Slots from time_slots";
                SqlDataReader data1 = new SqlCommand(query1, con).ExecuteReader();



                System.Data.SqlClient.SqlCommand sqlCommandMondayIsWork = new System.Data.SqlClient.SqlCommand("SELECT monday FROM Working_days where id = 1");
                sqlCommandMondayIsWork.Connection = con;
                String MondayIsWork = sqlCommandMondayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandTuesdayIsWork = new System.Data.SqlClient.SqlCommand("SELECT tuesday FROM Working_days where id = 1");
                sqlCommandTuesdayIsWork.Connection = con;
                String TuesdayIsWork = sqlCommandTuesdayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandWednesdayIsWork = new System.Data.SqlClient.SqlCommand("SELECT wednesday FROM Working_days where id = 1");
                sqlCommandWednesdayIsWork.Connection = con;
                String WednesdayIsWork = sqlCommandWednesdayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandThursdayIsWork = new System.Data.SqlClient.SqlCommand("SELECT thursday FROM Working_days where id = 1");
                sqlCommandThursdayIsWork.Connection = con;
                String ThursdayIsWork = sqlCommandThursdayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandFridayIsWork = new System.Data.SqlClient.SqlCommand("SELECT friday FROM Working_days where id = 1");
                sqlCommandFridayIsWork.Connection = con;
                String FridayIsWork = sqlCommandFridayIsWork.ExecuteScalar().ToString();

                int sizeNW = 40;

                while (data1.Read())
                {
                    if (MondayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(90, sizeNW, 150, 50), stringFormat);
                    }
                    if (TuesdayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(240, sizeNW, 150, 50), stringFormat);
                    }
                    if (WednesdayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(390, sizeNW, 150, 50), stringFormat);
                    }
                    if (ThursdayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(540, sizeNW, 150, 50), stringFormat);
                    }
                    if (FridayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(690, sizeNW, 150, 50), stringFormat);
                    }
                    sizeNW = sizeNW + 50;
                }


                string sessionsquery = "SELECT Session.Subject, Session.subjectCode, Session.type,Session.GroupID ,Session.subgroup, Session.studentcount, Session.typeduration,Session.Lecturers,SubjectTable.offYear,offSem FROM Session LEFT Join  SubjectTable on Session.subjectCode = SubjectTable.SubCode";
                SqlDataReader sessions = new SqlCommand(sessionsquery, con).ExecuteReader();

                int size2 = 40;
                while (sessions.Read())
                {
                    e.Graphics.DrawString(sessions.GetValue(1).ToString() + "-" + sessions.GetValue(0).ToString() + " (" + sessions.GetValue(2).ToString() + ") " + sessions.GetValue(3).ToString() + "." + sessions.GetValue(4).ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(240, size2, 150, 50), stringFormat);
                    size2 = size2 + 50;
                    e.Graphics.DrawString(sessions.GetValue(1).ToString() + "-" + sessions.GetValue(0).ToString() + " (" + sessions.GetValue(2).ToString() + ") " + sessions.GetValue(3).ToString() + "." + sessions.GetValue(4).ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(240, size2, 150, 50), stringFormat);

                    size2 = size2 + 50;
                }

                //string SessionQuery = "select * from Session";
                //SqlDataReader SessionQueryData = new SqlCommand(SessionQuery, con).ExecuteReader();

                //int size2 = 40;
                //while (SessionQueryData.Read())
                //{

                //int i = 0;
                //e.Graphics.DrawRectangle(Pens.Black, 90, size2, 150, 50);
                //e.Graphics.DrawString(SessionQueryData.GetValue(2).ToString()+"-"+ SessionQueryData.GetValue(1).ToString()+" ("+ SessionQueryData.GetValue(3).ToString()+") "+ SessionQueryData.GetValue(4).ToString()+"."+ SessionQueryData.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(90, size2, 150, 50), stringFormat);

                //i++;
                //size2 = size2 + 50;
                //}
            }
            else if(radioWeekendLec.Checked == true)
            {
                e.Graphics.DrawRectangle(Pens.Black, 10, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 90, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 170, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 250, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 330, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 410, 20, 80, 20);
                e.Graphics.DrawRectangle(Pens.Black, 490, 20, 170, 20);
                e.Graphics.DrawRectangle(Pens.Black, 660, 20, 170, 20);

                e.Graphics.DrawString("Monday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(90, 20, 80, 20), stringFormat);
                e.Graphics.DrawString("Tuesday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(170, 20, 80, 20), stringFormat);
                e.Graphics.DrawString("Wednesday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(250, 20, 80, 20), stringFormat);
                e.Graphics.DrawString("Thursday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(330, 20, 80, 20), stringFormat);
                e.Graphics.DrawString("Friday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(410, 20, 80, 20), stringFormat);
                e.Graphics.DrawString("saturday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(490, 20, 170, 20), stringFormat);
                e.Graphics.DrawString("sunday", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(660, 20, 170, 20), stringFormat);

                string query = "select Time_Slots from time_slotsWE";
                SqlDataReader data = new SqlCommand(query, con).ExecuteReader();

                int size = 40;
                while (data.Read())
                {

                    int i = 0;
                    e.Graphics.DrawRectangle(Pens.Black, 10, size, 80, 50);
                    e.Graphics.DrawString(data.GetValue(i).ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(10, size, 80, 50), stringFormat);



                    
                    e.Graphics.DrawRectangle(Pens.Black, 90, size, 80, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 170, size, 80, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 250, size, 80, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 330, size, 80, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 410, size, 80, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 490, size, 170, 50);
                    e.Graphics.DrawRectangle(Pens.Black, 660, size, 170, 50);

                    e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(90, size, 80, 50), stringFormat);
                    e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(170, size, 80, 50), stringFormat);
                    e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(250, size, 80, 50), stringFormat);
                    e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(330, size, 80, 50), stringFormat);
                    e.Graphics.DrawString("-x-", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new RectangleF(410, size, 80, 50), stringFormat);

                    i++;
                    size = size + 50;

                }

            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialogGroup.Document = printTimeTableGroup;
            printPreviewDialogGroup.ShowDialog();
            
        }

        private void printPreviewDialogGroup_Load(object sender, EventArgs e)
        {

        }

        private void printTimeTableGroup_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=DESKTOP-2FO46M3;Initial Catalog=TimeTableDB;Integrated Security=True;MultipleActiveResultSets = True";
            con = new SqlConnection(connetionString);
            con.Open();
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            string groupSessionsQuery = "SELECT Session.Subject, Session.subjectCode, Session.type,Session.GroupID ,Session.subgroup, Session.studentcount, Session.typeduration,Session.Lecturers,SubjectTable.offYear,offSem FROM Session LEFT Join  SubjectTable on Session.subjectCode = SubjectTable.SubCode";
            SqlDataReader sessions = new SqlCommand(groupSessionsQuery, con).ExecuteReader();

            e.Graphics.DrawRectangle(Pens.Black, 10, 20, 80, 20);
            e.Graphics.DrawRectangle(Pens.Black, 90, 20, 150, 20);
            e.Graphics.DrawRectangle(Pens.Black, 240, 20, 150, 20);
            e.Graphics.DrawRectangle(Pens.Black, 390, 20, 150, 20);
            e.Graphics.DrawRectangle(Pens.Black, 540, 20, 150, 20);
            e.Graphics.DrawRectangle(Pens.Black, 690, 20, 150, 20);

            e.Graphics.DrawString("Monday", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(90, 20, 150, 20), stringFormat);
            e.Graphics.DrawString("Tuesday", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(240, 20, 150, 20), stringFormat);
            e.Graphics.DrawString("Wednesday", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(390, 20, 150, 20), stringFormat);
            e.Graphics.DrawString("Thursday", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(540, 20, 150, 20), stringFormat);
            e.Graphics.DrawString("Friday", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(690, 20, 150, 20), stringFormat);


            string query = "select Time_Slots from time_slots";
            SqlDataReader data = new SqlCommand(query, con).ExecuteReader();




            int size = 40;
            while (data.Read())
            {

                int i = 0;
                e.Graphics.DrawRectangle(Pens.Black, 10, size, 80, 50);
                e.Graphics.DrawString(data.GetValue(i).ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(10, size, 80, 50), stringFormat);

                e.Graphics.DrawRectangle(Pens.Black, 90, size, 150, 50);
                e.Graphics.DrawRectangle(Pens.Black, 240, size, 150, 50);
                e.Graphics.DrawRectangle(Pens.Black, 390, size, 150, 50);
                e.Graphics.DrawRectangle(Pens.Black, 540, size, 150, 50);
                e.Graphics.DrawRectangle(Pens.Black, 690, size, 150, 50);

                i++;
                size = size + 50;

                System.Data.SqlClient.SqlCommand sqlCommandMondayIsWork = new System.Data.SqlClient.SqlCommand("SELECT monday FROM Working_days where id = 1");
                sqlCommandMondayIsWork.Connection = con;
                String MondayIsWork = sqlCommandMondayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandTuesdayIsWork = new System.Data.SqlClient.SqlCommand("SELECT tuesday FROM Working_days where id = 1");
                sqlCommandTuesdayIsWork.Connection = con;
                String TuesdayIsWork = sqlCommandTuesdayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandWednesdayIsWork = new System.Data.SqlClient.SqlCommand("SELECT wednesday FROM Working_days where id = 1");
                sqlCommandWednesdayIsWork.Connection = con;
                String WednesdayIsWork = sqlCommandWednesdayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandThursdayIsWork = new System.Data.SqlClient.SqlCommand("SELECT thursday FROM Working_days where id = 1");
                sqlCommandThursdayIsWork.Connection = con;
                String ThursdayIsWork = sqlCommandThursdayIsWork.ExecuteScalar().ToString();

                System.Data.SqlClient.SqlCommand sqlCommandFridayIsWork = new System.Data.SqlClient.SqlCommand("SELECT friday FROM Working_days where id = 1");
                sqlCommandFridayIsWork.Connection = con;
                String FridayIsWork = sqlCommandFridayIsWork.ExecuteScalar().ToString();

                string query1 = "select Time_Slots from time_slots";
                SqlDataReader data1 = new SqlCommand(query1, con).ExecuteReader();

                int sizeNW = 40;

                while (data1.Read())
                {
                    if (MondayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(90, sizeNW, 150, 50), stringFormat);
                    }
                    if (TuesdayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(240, sizeNW, 150, 50), stringFormat);
                    }
                    if (WednesdayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(390, sizeNW, 150, 50), stringFormat);
                    }
                    if (ThursdayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(540, sizeNW, 150, 50), stringFormat);
                    }
                    if (FridayIsWork == "Not working")
                    {
                        e.Graphics.DrawString("-x-", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new RectangleF(690, sizeNW, 150, 50), stringFormat);
                    }
                    sizeNW = sizeNW + 50;
                }

                int SizeY;
                if (MondayIsWork == "Not working")
                {
                    SizeY = 90 + 150;
                }
                else
                {
                    SizeY = 90;
                }
                
                int SizeX = 40;
                while (sessions.Read())
                {

                    String subCode = sessions.GetValue(1).ToString();
                    System.Data.SqlClient.SqlCommand sqlCommandCheackYear = new System.Data.SqlClient.SqlCommand("SELECT offYear FROM SubjectTable WHERE SubCode = '" + subCode + "'");
                    sqlCommandCheackYear.Connection = con;
                    String year = sqlCommandCheackYear.ExecuteScalar().ToString();

                    System.Data.SqlClient.SqlCommand sqlCommandCheackSem = new System.Data.SqlClient.SqlCommand("SELECT offSem FROM SubjectTable WHERE SubCode = '" + subCode + "'");
                    sqlCommandCheackSem.Connection = con;
                    String Sem = sqlCommandCheackSem.ExecuteScalar().ToString();

                    //e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);
                    //SizeX = SizeX + 50;

                    if (year == selectGroupYear.Text && Sem == groupSem.Text && groupId.Text == sessions.GetValue(3).ToString())
                    {
                        System.Data.SqlClient.SqlCommand sqlCommandConsecative = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM Consecutivetbl WHERE subjectcode = '" + subCode + "' AND groupid = '" + sessions.GetValue(3).ToString() + "'");
                        sqlCommandConsecative.Connection = con;

                        System.Data.SqlClient.SqlCommand sqlCommandTimeSloats = new System.Data.SqlClient.SqlCommand("SELECT COUNT(*) FROM time_slots");
                        sqlCommandTimeSloats.Connection = con;
                        int sloatcount = Convert.ToInt32(sqlCommandTimeSloats.ExecuteScalar());
                        int max = sloatcount * 50 + 40;

                        
                        int consicative = Convert.ToInt32(sqlCommandConsecative.ExecuteScalar());
                        if (consicative >= 1)
                        {
                            // e.Graphics.DrawRectangle(Pens.Black, sizeX, sizeY, 80, 50);
                            e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);

                            SizeX = SizeX + 50;
                            e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);

                            SizeX = SizeX + 50;

                            e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);

                            SizeX = SizeX + 50;
                            e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);

                            SizeX = SizeX + 50;

                        }
                        else
                        {
                            e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);

                            SizeX = SizeX + 50;
                            e.Graphics.DrawString(sessions.GetValue(2).ToString() + "-" + sessions.GetValue(1).ToString() + " (" + sessions.GetValue(3).ToString() + ") " + sessions.GetValue(4).ToString() + "." + sessions.GetValue(5).ToString(), new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new RectangleF(SizeY, SizeX, 150, 50), stringFormat);

                            SizeX = SizeX + 50;
                            if(SizeX == max)
                            {
                               
                                   
                                        SizeX = 40;
                                        SizeY = SizeY + 150;
                                   
                                    
                                

                                

                            }
                        }
                    }
                }
            }

            
        }
    }
}
