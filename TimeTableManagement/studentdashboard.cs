using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagement.Forms
{
    public partial class studentdashboard : Form
    {
        public studentdashboard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
            panel1.Controls.Add(childform);
            childform.BringToFront();
            childform.Show();


        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new students());

        }
    }
}
