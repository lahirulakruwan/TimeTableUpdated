using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.SubjectController;
using TimeTableManagement.Model.SubjectModel;

namespace TimeTableManagement.Forms
{
    public partial class subjectsform : Form
    {
        public subjectsform()
        {
            InitializeComponent();
            subjectController subctrl = new subjectController();
            subTbl.DataSource = subctrl.getSubjectdatatoTable();
            for(int i = 2015; i <= 2100; i++)
            {
                Year.Items.Add(i);
            }
        }

        private void subAdd_Click(object sender, EventArgs e)
        {
            if (Year.Text != "" && offyear.Text != "" && offSem.Text != "" && subName.Text != "" && subCode.Text != "" && lecHrs.Text != "" && labHrs.Text != "" && tuteHrs.Text != "" && evalHrs.Text != "")
            {
                subjectModel subjectModel = new subjectModel();
                subjectModel.year = Year.Text;
                subjectModel.OffYear = offyear.Text;
                subjectModel.OffSem = offSem.Text;
                subjectModel.SubName = subName.Text;
                subjectModel.subCode = subCode.Text;
                subjectModel.lechours = lecHrs.Text;
                subjectModel.labHours = labHrs.Text;
                subjectModel.tuteHours = tuteHrs.Text;
                subjectModel.evalHours = evalHrs.Text;

                subjectController subctrl = new subjectController();
                subctrl.insertSubjectDetails(subjectModel);

                subTbl.DataSource = subctrl.getSubjectdatatoTable();
                Year.Text = "";
                offyear.Text = "";
                offSem.Text = "";
                subName.Text = "";
                subCode.Text = "";
                lecHrs.Text = "";
                labHrs.Text = "";
                tuteHrs.Text = "";
                evalHrs.Text = "";

            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void subTbl_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow data = this.subTbl.Rows[e.RowIndex];
                Year.Text = data.Cells["year"].Value.ToString();
                offyear.Text = data.Cells["offYear"].Value.ToString();
                offSem.Text = data.Cells["offSem"].Value.ToString();
                subName.Text = data.Cells["SubName"].Value.ToString();
                subCode.Text = data.Cells["SubCode"].Value.ToString();
                lecHrs.Text = data.Cells["LecHrs"].Value.ToString();
                labHrs.Text = data.Cells["TuteHrs"].Value.ToString();
                tuteHrs.Text = data.Cells["LabHrs"].Value.ToString();
                evalHrs.Text = data.Cells["EvalHrs"].Value.ToString();

                subCode.ReadOnly = true;

                 subAdd.Enabled = false;

            }
        }

        private void subDel_Click(object sender, EventArgs e)
        {

            subjectModel subject = new subjectModel();
            subject.subCode = subCode.Text;

            subjectController subController = new subjectController();
            subController.DeleteSubject(subject);

            Year.Text = "";
            offyear.Text = "";
            offSem.Text = "";
            subName.Text = "";
            subCode.Text = "";
            lecHrs.Text = "";
            labHrs.Text = "";
            tuteHrs.Text = "";
            evalHrs.Text = "";

            subCode.ReadOnly = false;
            subAdd.Enabled = true;

            subTbl.DataSource = subController.getSubjectdatatoTable();

        }

        private void subClear_Click(object sender, EventArgs e)
        {
            Year.Text = "";
            offyear.Text = "";
            offSem.Text = "";
            subName.Text = "";
            subCode.Text = "";
            lecHrs.Text = "";
            labHrs.Text = "";
            tuteHrs.Text = "";
            evalHrs.Text = "";

            subAdd.Enabled = true;
            subCode.ReadOnly = false;
        }

        private void subEdit_Click(object sender, EventArgs e)
        {

            if (Year.Text != "" && offyear.Text != "" && offSem.Text != "" && subName.Text != "" && subCode.Text != "" && lecHrs.Text != "" && labHrs.Text != "" && tuteHrs.Text != "" && evalHrs.Text != "")
            {
                subjectModel subjectModel = new subjectModel();

            subjectModel.year = Year.Text;
            subjectModel.OffYear = offyear.Text;
            subjectModel.OffSem = offSem.Text;
            subjectModel.SubName = subName.Text;
            subjectModel.subCode = subCode.Text;
            subjectModel.lechours = lecHrs.Text;
            subjectModel.labHours = labHrs.Text;
            subjectModel.tuteHours = tuteHrs.Text;
            subjectModel.evalHours = evalHrs.Text;

         subAdd.Enabled = true;


            subjectController ctrl = new subjectController();
            ctrl.UpdateSubject(subjectModel);

            subTbl.DataSource = ctrl.getSubjectdatatoTable();

            Year.Text = "";
            offyear.Text = "";
            offSem.Text = "";
            subName.Text = "";
            subCode.Text = "";
            lecHrs.Text = "";
            labHrs.Text = "";
            tuteHrs.Text = "";
            evalHrs.Text = "";

            subCode.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Please Fill the all the required fields ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void offSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


