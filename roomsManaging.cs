
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.LocationConn;
using TimeTableManagement.Controller.lahiruconn;
using TimeTableManagement.Model.locationModel;
using TimeTableManagement.Controller.session_controller;
using System.Collections;

namespace TimeTableManagement.Forms
{
    public partial class roomsManaging : Form
    {
        public roomsManaging()
        {
            InitializeComponent();
            roomsConn roomsConn = new roomsConn();
            roomsWithLecCon rql = new roomsWithLecCon();
            session lecturer = new session();
            BatchesConn bc = new BatchesConn();
            consecutivesession consecutivesession = new consecutivesession();

            assignRoom.DataSource = roomsConn.getRooms();
            asubjectCode.DataSource = roomsConn.getSession();
            roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();
            notAvailableGridView.DataSource = roomsConn.load_not_available_details();
            lecWithRoomsGrid.DataSource = roomsConn.load_Lec_with_rooms();
            faculty.DataSource = roomsConn.getFaultyRooms();
            rfaculty.DataSource = roomsConn.getFaultyRooms();
            electurenme.DataSource = lecturer.getLectures();
            grpNme.DataSource = bc.getAllGroupIds();
            subGNme.DataSource = bc.getAllSubGroupIds();

            //           lroomtype.DataSource = roomsConn.
            loadLecturerPreferedTags();
            loadSessionItems();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Boolean boo = new Boolean();

            roomsConn roomsConn = new roomsConn();
            String selectedNme = assignRoom.Text.ToString();
            roomsAvalability ra = new roomsAvalability();
            boo = ra.checkRoomIsAvailable(selectedNme);

            if (boo.Equals(true)) { 
            aroomType.DataSource = roomsConn.getRoomsType(selectedNme);
            }
            else
            {
            //    assignRoom.DataSource = roomsConn.checkRooooms(String roomnm);
                MessageBox.Show("Room is already assigned");
            }

        }

        private void locBtn2_Click(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            roomModel roomsModel = new roomModel();
            String selectedSessionType = sessionType.Text.ToString();

            roomsModel.roomName = assignRoom.Text;
            roomsModel.subjectCode = asubjectCode.Text;
            roomsModel.facultyNme = faculty.Text;
            roomsConn.updateSessionTable(roomsModel, notavltime.Text.ToString(), selectedSessionType);
            roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();


        }

        private void asubjectCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String getSelectedSubject = asubjectCode.Text.ToString();
            String getSelectedSession = sessionType.Text.ToString();

            atags.DataSource = roomsConn.getSessionType(getSelectedSubject, getSelectedSession);
          //  atag2.DataSource = roomsConn.getTag2Type(getSelectedSubject, getSelectedSession);

            String selectedSessionType = sessionType.Text.ToString();
            String selectedSubject = asubjectCode.Text.ToString();
            atags.DataSource = roomsConn.getSessionTypeTag(selectedSessionType, selectedSubject, aroomType.Text.ToString());
        }

        private void aroomType_SelectedIndexChanged(object sender, EventArgs e)
        {   
            roomsConn roomsConn = new roomsConn();

            String selectedLabNme = aroomType.Text.ToString();
            String selectedSessionType = sessionType.Text.ToString();
            atags.DataSource = roomsConn.getSessionType(selectedLabNme, selectedSessionType);

        }

        private void atag2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomManagingSource_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = roomManagingSource.CurrentRow;

            var selectedName = currentRow.Cells[0].Value;
            var selectedName1 = currentRow.Cells[1].Value;


        }

        private void sessionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedSessionType = sessionType.Text.ToString();
            asubjectCode.DataSource = roomsConn.getSessionTypeTable(selectedSessionType);
            if (selectedSessionType.Equals("Normal")){
                atag2.Hide();
                label1.Hide();
                roomManagingSource.DataSource = roomsConn.load_normal_sesssion_details();
            }
            else
            {
                atag2.Show();
                label1.Show();
               // comboBox1.Show();
               // label7.Show();
            }
            if (selectedSessionType.Equals("Normal"))
            {
                roomManagingSource.DataSource = roomsConn.load_normal_sesssion_details();
            }else if(selectedSessionType.Equals("Consecutive"))
            {
                roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();

            }
            else if (selectedSessionType.Equals("Parallel"))
            {
                roomManagingSource.DataSource = roomsConn.load_parallel_sesssion_details();

            }



        }
        void loadSessionItems()
        {
            sessionType.Items.Add("Normal");
            sessionType.Items.Add("Consecutive");
            sessionType.Items.Add("Parallel");

            sesType.Items.Add("Normal");
            sesType.Items.Add("Consecutive");
            sesType.Items.Add("Parallel");

            sType.Items.Add("Normal");
            sType.Items.Add("Consecutive");
            sType.Items.Add("Parallel");

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedFaculty = faculty.Text.ToString();
            assignRoom.DataSource = roomsConn.getRoomsByFaculty(selectedFaculty);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedFaculty = rfaculty.Text.ToString(); 
            rName.DataSource = roomsConn.getRoomsByFaculty(selectedFaculty);


        }

        private void notAvailableGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void releaceBtn_Click(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            roomsConn.insertNotAvailableTimes(rName.Text.ToString(), rfaculty.Text.ToString(), rntime.Text.ToString());
            notAvailableGridView.DataSource = roomsConn.load_not_available_details();
            rrrname.DataSource = roomsConn.getNotAvailableRooms();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void rrbtn_Click(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedRoomName = rrrname.Text.ToString();

            roomsConn.DeleteNotAvailableRooms(selectedRoomName);
            notAvailableGridView.DataSource = roomsConn.load_not_available_details();
            rrrname.DataSource = roomsConn.getNotAvailableRooms();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void rntime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomsManaging_Load(object sender, EventArgs e)
        {
            roomsConn roomsConn = new roomsConn();
            String selectedFaculty = rfaculty.Text.ToString();
            rrrname.DataSource = roomsConn.getNotAvailableRooms();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                                                        
            String lecName = electurenme.Text.ToString();
            String roomType = lroomtype.Text.ToString();
            String roomName = lroomName.Text.ToString();
            String roomTyp = sesType.Text.ToString();
            roomsWithLecCon rwl = new roomsWithLecCon();
            roomsConn roomsConn = new roomsConn();

            rwl.insertLecWithPrefereedRoom(lecName, roomType, roomName, roomTyp);
            lecWithRoomsGrid.DataSource = roomsConn.load_Lec_with_rooms();
        }


        void loadLecturerPreferedTags()
        {
            lroomtype.Items.Add("Lecture");
            lroomtype.Items.Add("Tutorial");
            lroomtype.Items.Add("Lab");

            tagType.Items.Add("Lecture");
            tagType.Items.Add("Tutorial");
            tagType.Items.Add("Lab");
        }

        private void lroomName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedRoomType = lroomtype.Text.ToString();
            roomsWithLecCon rwl = new roomsWithLecCon();
            lroomName.DataSource = rwl.LoadTagsWithRooms(selectedRoomType);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selectedGroupName = grpNme.Text.ToString();
            String selectedSubGroupName = subGNme.Text.ToString();
            String selectedSessionType = sType.Text.ToString();
            String selectedTagType = tagType.Text.ToString();
            String selectedroomName = rmName.Text.ToString();
            BatchesConn bc = new BatchesConn();
            roomsConn roomsConn = new roomsConn();

            bc.SR_updateGroupsWithAssignedRoom(selectedGroupName, selectedSubGroupName, selectedSessionType, selectedTagType, selectedroomName);
            if (selectedSessionType.Equals("Normal"))
            {
                roomManagingSource.DataSource = roomsConn.load_normal_sesssion_details();
            }
            else if (selectedSessionType.Equals("Consecutive"))
            {
                roomManagingSource.DataSource = roomsConn.load_con_sesssion_details();

            }
            else if (selectedSessionType.Equals("Parallel"))
            {
                roomManagingSource.DataSource = roomsConn.load_parallel_sesssion_details();

            }
        }

        private void sType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BatchesConn bt = new BatchesConn();
            roomsConn roomsConn = new roomsConn();
            String selectedSession = sType.Text.ToString();
            String selectedSubject = subGNme.Text.ToString();
            sname.DataSource = bt.getSubjectAccourdingToSession(selectedSession);

            if (selectedSession.Equals("Normal"))
            {
                grpWithRoomsGrid.DataSource = roomsConn.load_normal_sesssion_details();
            }
            else if (selectedSession.Equals("Consecutive"))
            {
                grpWithRoomsGrid.DataSource = roomsConn.load_con_sesssion_details();

            }
            else if (selectedSession.Equals("Parallel"))
            {
                grpWithRoomsGrid.DataSource = roomsConn.load_parallel_sesssion_details();

            }
        }

        private void sname_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedSession = sType.Text.ToString();
            String selectedSubject = sname.Text.ToString();
            BatchesConn bc = new BatchesConn();
    //        grpNme.DataSource = bc.getTheGroupIDsUsingSubjectnmeSession(selectedSession, selectedSubject);
   //         subGNme.DataSource = bc.getTheSubGroupIDsUsingSubjectnmeSession(selectedSession, selectedSubject);
    //        tagType.DataSource = bc.getTheTagTypeUsingSubjectnmeSession(selectedSession, selectedSubject);

        }

        private void grpNme_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void subGNme_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tagType_SelectedIndexChanged(object sender, EventArgs e)
        {

            String selectedTag = tagType.Text.ToString();
            roomsConn roomsConn = new roomsConn();

            rmName.DataSource = roomsConn.getRoomsType(selectedTag);

        }

        private void rmName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
