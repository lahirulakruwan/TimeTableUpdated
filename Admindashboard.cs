using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace TimeTableManagement.Forms
{
    public partial class Admindashboard : Form
    {
        public Admindashboard()
        {
            InitializeComponent();

          

           
            OpenChildForm(new dashboard());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LecturerForm());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new dashboard());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new students());
        }


        private Form activeform = null;
        private object notavaliableCon;

        public object NotAvaliabletable { get; private set; }

        public void OpenChildForm(Form childform)
        {

           if(activeform != null)
                 activeform = null;
           activeform = childform;
           childform.TopLevel = false;
           childform.FormBorderStyle = FormBorderStyle.None;
           childform.Dock = DockStyle.Fill;
           panel3.Controls.Add(childform);
           childform.BringToFront();
           childform.Show(); 


        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Managesessions());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new location());

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new subjectsform());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StaticsRelated());

        }

        private void button11_Click(object sender, EventArgs e)
        {
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimeSlots());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateSession());
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new roomsManaging());
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new TimeTableGenerate());
        }
    }
}
