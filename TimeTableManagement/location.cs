using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TimeTableManagement.Controller.LocationConn;
using TimeTableManagement.DBConnection;
using TimeTableManagement.Model.locationModel;

namespace TimeTableManagement.Forms
{
    public partial class location : Form
    {
        DbConn DBConnection = new DbConn();
        SqlConnection con = new SqlConnection();

        public location()
        {
            InitializeComponent();
            con = DBConnection.getDBConnection();
            fillCombo();
            loadLabItems();
        }
        public static String academicyrsemshldupdatevalue;


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

        LocationConn LocationConn = new LocationConn();
        locationModel locationModel = new locationModel();
        public static String programmeupdatevalue;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void locBtn2_Click(object sender, EventArgs e)
        {

            if(locationID.Text != "" && buildingName.Text != "")
            {
                locationModel.locationPID = locationID.Text;
                locationModel.locationPName = buildingName.Text;

                LocationConn.insertLocationDetails(locationModel);

                locationdataGridView.DataSource = LocationConn.GetLocationvalues();

                fillCombo();
            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void location_Load(object sender, EventArgs e)
        {
            locationdataGridView.DataSource = LocationConn.GetLocationvalues();
            allLocationDet.DataSource = LocationConn.GetAllLocationvalues();
            roomDatagridView.DataSource = LocationConn.GetRoomvalues();
            //String val = "BUI";
            //int value = 00000;
            //value = value + 1;
            //locationID.Text = val + value.ToString("00000");

        }

        private void locationdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var currentRow = locationdataGridView.CurrentRow;

            var selectedName = currentRow.Cells[0].Value;
            var selectedName1 = currentRow.Cells[1].Value;


            locationID.Text = selectedName.ToString();
            buildingName.Text = selectedName1.ToString();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            if (buildingNameT.Text != "" && roomIDT.Text != "" && roomNameT.Text != "" && roomCapacity.Text != "" && roomCapacityT.Text != "")
            {
                locationModel.buildingName = buildingNameT.Text;
                locationModel.roomID = roomIDT.Text;
                locationModel.roomName = roomNameT.Text;
                locationModel.roomCapacity = roomCapacity.Text;
                locationModel.roomType = roomCapacityT.Text;

                LocationConn.insertRoomDetails(locationModel);

                SqlDataReader dr = LocationConn.loadRoomvalues();
                dr.Close();
                roomDatagridView.DataSource = LocationConn.GetRoomvalues();
                allLocationDet.DataSource = LocationConn.GetAllLocationvalues();

            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            String academicyrsemshldupdatevalue = roomIDT.Text;
            SqlDataReader dr = LocationConn.loadRoomvalues();
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            while (dr.Read())
            {
                String roomID = Convert.ToString(dr["roomID"]);
                if (academicyrsemshldupdatevalue.Equals(roomID))
                {
                    String buldingName = buildingNameT.Text;
                    string query = "DELETE  FROM RoomTable  WHERE  roomID='" + roomID + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");

                }
            }

            dr.Close();
            roomDatagridView.DataSource = LocationConn.GetRoomvalues();
            allLocationDet.DataSource = LocationConn.GetAllLocationvalues();

        }

        private void deleteB1_Click(object sender, EventArgs e)
        {
            String academicyrsemshldupdatevalue = locationID.Text;
            SqlDataReader dr = LocationConn.loadLocavalues();
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            while (dr.Read())
            {
                String buildingNme = Convert.ToString(dr["locationID"]);
                if (academicyrsemshldupdatevalue.Equals(buildingNme))
                {
                    String locationID1 = locationID.Text;
                    string query = "DELETE  FROM LocationTimeTable  WHERE  locationID='" + locationID1 + "'";
                    SqlCommand com = new SqlCommand(query, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");

                }
            }

            dr.Close();
            locationdataGridView.DataSource = LocationConn.GetLocationvalues();
        }

        private void roomDatagridView_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var currentRow = roomDatagridView.CurrentRow;

            var selectedName = currentRow.Cells[0].Value;
            var selectedName1 = currentRow.Cells[1].Value;
            var selectedName2 = currentRow.Cells[2].Value;
            var selectedName3 = currentRow.Cells[3].Value;
            var selectedName4 = currentRow.Cells[4].Value;

            buildingNameT.Text = selectedName.ToString();
            roomIDT.Text = selectedName1.ToString();
            roomNameT.Text = selectedName2.ToString();
            roomCapacity.Text = selectedName3.ToString();
            roomCapacityT.Text = selectedName4.ToString();

        }

        private void locationID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String academicyrsemshldupdatevalue = buildingNameT.Text;
            String nme1 = roomIDT.Text;
            String nme2 = roomNameT.Text;
            String nme3 = roomCapacity.Text;
            String nme4 = roomCapacityT.Text;

            SqlDataReader dr = LocationConn.loadRoomvalues();
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            while (dr.Read())
            {
                String roomID = Convert.ToString(dr["roomID"]);
                if (nme1.Equals(roomID))
                {
                    string sql = "UPDATE RoomTable SET roomID='" + nme1 + "' WHERE roomID = '" + nme1 + "'";
                    string sql1 = "UPDATE RoomTable SET roomName='" + nme2 + "' WHERE roomID = '" + nme1 + "'";
                    string sql2 = "UPDATE RoomTable SET roomCapacity='" + nme3 + "' WHERE roomID = '" + nme1 + "'";
                    string sql3 = "UPDATE RoomTable SET roomType='" + nme4 + "' WHERE roomID = '" + nme1 + "'";

                    SqlCommand com = new SqlCommand(sql, con);
                    SqlCommand com2 = new SqlCommand(sql1, con);
                    SqlCommand com3 = new SqlCommand(sql2, con);
                    SqlCommand com4 = new SqlCommand(sql3, con);

                    MessageBox.Show("Updated!");

                    com.ExecuteNonQuery();
                    com2.ExecuteNonQuery();
                    com3.ExecuteNonQuery();
                    com4.ExecuteNonQuery();

                }
            }

            dr.Close();
            roomDatagridView.DataSource = LocationConn.GetRoomvalues();
            allLocationDet.DataSource = LocationConn.GetAllLocationvalues();

        }



        private void updateB1_Click(object sender, EventArgs e)
        {

        }

        private void updateB1_Click_1(object sender, EventArgs e)
        {
            String academicyrsemshldupdatevalue = locationID.Text;
            String nme1 = locationID.Text;
            String nme2 = buildingName.Text;

            SqlDataReader dr = LocationConn.loadLocavalues();
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            while (dr.Read())
            {
                String locationID = Convert.ToString(dr["locationID"]);
                if (academicyrsemshldupdatevalue.Equals(locationID))
                {
                    string sql = "UPDATE LocationTimeTable SET locationID='" + nme1 + "' WHERE locationID = '" + academicyrsemshldupdatevalue + "'";
                    string sql1 = "UPDATE LocationTimeTable SET locationName='" + nme2 + "' WHERE locationID = '" + academicyrsemshldupdatevalue + "'";


                    SqlCommand com = new SqlCommand(sql, con);
                    SqlCommand com2 = new SqlCommand(sql1, con);

                    MessageBox.Show("Updated!");

                    com.ExecuteNonQuery();
                    com2.ExecuteNonQuery();

                }
            }
            fillCombo();
            dr.Close();

            locationdataGridView.DataSource = LocationConn.GetLocationvalues();
        }

        private void buildingNameT_SelectedIndexChanged(object sender, EventArgs e)
        {
            academicyrsemshldupdatevalue = buildingNameT.Text;

        }

        void fillCombo()
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            String query = "SELECT * FROM LocationTimeTable";
            SqlCommand com = new SqlCommand(query, con);
            SqlDataReader dr = LocationConn.loadLocavalues();
            while (dr.Read())
            {
                String sname = Convert.ToString(dr["locationName"]);
                buildingNameT.Items.Add(sname);
            }
            dr.Close();
        }

        void loadLabItems()
        {
            roomCapacityT.Items.Add("Lecture");
            roomCapacityT.Items.Add("Tutorial");
            roomCapacityT.Items.Add("Lab");
        }

        private void roomCapacityT_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void allLocationDet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            String sqlquery = "SELECT * FROM RoomTable where roomName = '" + textBox1.Text + "'";
            SqlCommand sqlccomm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlccomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            allLocationDet.DataSource = dt;
            con.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            allLocationDet.DataSource = LocationConn.GetAllLocationvalues();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (con.State.ToString() != "Open")
            {
                con.Open();
            }
            String sqlquery = "SELECT * FROM RoomTable where buildingName = '" + textBox2.Text + "'";
            SqlCommand sqlccomm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlccomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            allLocationDet.DataSource = dt;
            con.Close();
        }
    }
}
