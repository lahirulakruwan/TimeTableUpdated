using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagement.Controller.TimeSlotsController;
using TimeTableManagement.Model.TimeSlotsModel;

namespace TimeTableManagement.Forms
{
    public partial class TimeSlots : Form
    {
        NumberOfWorkingDaysCon numberOfWorkingDaysCon = new NumberOfWorkingDaysCon();
        WorkingDaysModel workingDaysModel = new WorkingDaysModel();
        TimeSlotsModel timeSlotsModel = new TimeSlotsModel();
        TimeSlotsCon timeSlotsCon = new TimeSlotsCon();
        TimeSlotsConWE timeSlotsConWE = new TimeSlotsConWE();
        TimeSlotsModelWE timeSlotsModelWE = new TimeSlotsModelWE();

        public TimeSlots()
        {
            InitializeComponent();
            fillDataTables();
            tableHide();
            fillTimeSlotData();
            timeSlotsInitial();
            hideInputsTimeSlots();
            hideInputsTimeSlotsWE();
            fillTimeSlotDataWE();
            timeSlotsInitialWE();

            if (numberOfWorkingDaysCon.cheackRecords() == true)
            {
                btnSave.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
                numWeekday.Enabled = false;
                numWeekend.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                chkMonday.Enabled = true;
                chkTuesday.Enabled = true;
                chkWednesday.Enabled = true;
                chkThursday.Enabled = true;
                chkFriday.Enabled = true;
                chkSaturday.Enabled = true;
                chkSunday.Enabled = true;
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
            }
            if (Convert.ToInt32(numWeekday.Value) == 0)
            {
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
            }
            else
            {
                chkMonday.Enabled = true;
                chkTuesday.Enabled = true;
                chkWednesday.Enabled = true;
                chkThursday.Enabled = true;
                chkFriday.Enabled = true;
            }
            if (Convert.ToInt32(numWeekend.Value) == 0)
            {
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
            }
            else
            {
                chkSaturday.Enabled = true;
                chkSunday.Enabled = true;
            }
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }
        private void fillTimeSlotData()
        {
            dataWorkingTime.DataSource = timeSlotsCon.getdatatoTableWorkingTime();
            dataStartTime.DataSource = timeSlotsCon.getdatatoTableStartTime();
            dataType.DataSource = timeSlotsCon.getdatatoTableType();
            dataTimeSlots.DataSource = timeSlotsCon.getdatatoTableTimeSlots();
        }

        private void fillDataTables()
        {
            dataGridViewNumOfWorkingDays.DataSource = numberOfWorkingDaysCon.getdatatoTableNumWorkingDays();
            dataGridViewWeekday.DataSource = numberOfWorkingDaysCon.getdatatoTableWorkingDaysWeekday();
            dataGridViewWekend.DataSource = numberOfWorkingDaysCon.getdatatoTableWorkingDaysWeekend();
        }

        private void timeSlotsInitial()
        {
            workingHrs.Value = 0;
            workingMin.Value = 0;
            startHrs.Value = 0;
            startMin.Value = 0;
            oneHrs.Checked = false;
            radio30Min.Checked = false;
        }

        private void timeSlotsInitialWE()
        {
            workingHrsWE.Value = 0;
            workingMinWE.Value = 0;
            startHrsWE.Value = 0;
            startMinWE.Value = 0;
            oneHrsWE.Checked = false;
            radio30MinWE.Checked = false;
        }

        private void fillTimeSlotDataWE()
        {
            dataWorkingTimeWE.DataSource = timeSlotsConWE.getdatatoTableWorkingTimeWE();
            dataStartTimeWE.DataSource = timeSlotsConWE.getdatatoTableStartTimeWE();
            dataTypeWE.DataSource = timeSlotsConWE.getdatatoTableTypeWE();
            dataTimeSlotsWE.DataSource = timeSlotsConWE.getdatatoTableTimeSlotsWE();
        }

        private void hideInputsTimeSlotsWE()
        {
            if (timeSlotsConWE.cheackRecordsWE() == true)
            {
                workingHrsWE.Enabled = false;
                workingMinWE.Enabled = false;
                startHrsWE.Enabled = false;
                startMinWE.Enabled = false;
                oneHrsWE.Checked = false;
                radio30MinWE.Checked = false;
                oneHrsWE.Enabled = false;
                radio30MinWE.Enabled = false;
            }
            else
            {
                workingHrsWE.Enabled = true;
                workingMinWE.Enabled = true;
                startHrsWE.Enabled = true;
                startMinWE.Enabled = true;
                oneHrsWE.Checked = false;
                radio30MinWE.Checked = false;
                oneHrsWE.Enabled = true;
                radio30MinWE.Enabled = true;
            }
        }

        private void hideInputsTimeSlots()
        {
            if (timeSlotsCon.cheackRecords() == true)
            {
                workingHrs.Enabled = false;
                workingMin.Enabled = false;
                startHrs.Enabled = false;
                startMin.Enabled = false;
                oneHrs.Checked = false;
                radio30Min.Checked = false;
                oneHrs.Enabled = false;
                radio30Min.Enabled = false;
            }
            else
            {
                workingHrs.Enabled = true;
                workingMin.Enabled = true;
                startHrs.Enabled = true;
                startMin.Enabled = true;
                oneHrs.Checked = false;
                radio30Min.Checked = false;
                oneHrs.Enabled = true;
                radio30Min.Enabled = true;
            }
        }

        private void tableHide()
        {
            if (numberOfWorkingDaysCon.cheackRecords() == false)
            {
                dataGridViewNumOfWorkingDays.Visible = false;
                dataGridViewWeekday.Visible = false;
                dataGridViewWekend.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            else
            {
                dataGridViewNumOfWorkingDays.Visible = true;
                dataGridViewWeekday.Visible = true;
                dataGridViewWekend.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }
        }

        private void numWeekday_ValueChanged(object sender, EventArgs e)
        {
            workingDaysModel.WeekdayDays = Convert.ToInt32(numWeekday.Value);
            if (Convert.ToInt32(numWeekday.Value) == 0)
            {
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
            }
            else
            {
                chkMonday.Enabled = true;
                chkTuesday.Enabled = true;
                chkWednesday.Enabled = true;
                chkThursday.Enabled = true;
                chkFriday.Enabled = true;
            }
            chkMonday.Checked = false;
            chkTuesday.Checked = false;
            chkWednesday.Checked = false;
            chkThursday.Checked = false;
            chkFriday.Checked = false;
        }

        private void numWeekend_ValueChanged(object sender, EventArgs e)
        {
            workingDaysModel.WeekendDays = Convert.ToInt32(numWeekend.Value);

            if (Convert.ToInt32(numWeekend.Value) == 0)
            {
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
            }
            else
            {
                chkSaturday.Enabled = true;
                chkSunday.Enabled = true;
            }
            chkSaturday.Checked = false;
            chkSunday.Checked = false;
        }

        private void chkMonday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekday();
        }

        private void chkTuesday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekday();
        }

        private void chkWednesday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekday();
        }

        private void chkThursday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekday();
        }

        private void chkFriday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekday();
        }

        private void chkSaturday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekend();
        }

        private void chkSunday_CheckedChanged(object sender, EventArgs e)
        {
            HideCheackBoxWeekend();
        }

        private void HideCheackBoxWeekday()
        {
            if (Convert.ToInt32(numWeekday.Value) == 1)
            {
                if (chkMonday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkTuesday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkWednesday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkTuesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkThursday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkFriday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                }
                else
                {
                    chkMonday.Enabled = true;
                    chkTuesday.Enabled = true;
                    chkWednesday.Enabled = true;
                    chkThursday.Enabled = true;
                    chkFriday.Enabled = true;
                }
            }

            if (Convert.ToInt32(numWeekday.Value) == 2)
            {
                if (chkMonday.Checked && chkTuesday.Checked)
                {
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkWednesday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkThursday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                }

                else if (chkTuesday.Checked && chkWednesday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkTuesday.Checked && chkThursday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkTuesday.Checked && chkFriday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                }

                else if (chkWednesday.Checked && chkThursday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkMonday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkWednesday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkMonday.Enabled = false;
                    chkThursday.Enabled = false;
                }
                else if (chkThursday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkMonday.Enabled = false;
                    chkWednesday.Enabled = false;
                }
                else
                {
                    chkMonday.Enabled = true;
                    chkTuesday.Enabled = true;
                    chkWednesday.Enabled = true;
                    chkThursday.Enabled = true;
                    chkFriday.Enabled = true;
                }
            }
            else if (Convert.ToInt32(numWeekday.Value) == 3)
            {
                if (chkMonday.Checked && chkTuesday.Checked && chkWednesday.Checked)
                {
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }

                else if (chkMonday.Checked && chkTuesday.Checked && chkFriday.Checked)
                {
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                }
                else if (chkMonday.Checked && chkWednesday.Checked && chkTuesday.Checked)
                {
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkWednesday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkThursday.Enabled = false;
                }
                else if (chkMonday.Checked && chkThursday.Checked && chkTuesday.Checked)
                {
                    chkWednesday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkThursday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                }


                else if (chkMonday.Checked && chkFriday.Checked && chkTuesday.Checked)
                {
                    chkWednesday.Enabled = false;
                    chkTuesday.Enabled = false;
                }
                else if (chkMonday.Checked && chkWednesday.Checked && chkThursday.Checked)
                {
                    chkFriday.Enabled = false;
                    chkTuesday.Enabled = false;
                }
                else if (chkTuesday.Checked && chkWednesday.Checked && chkThursday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkWednesday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                    chkThursday.Enabled = false;
                }
                else if (chkThursday.Checked && chkWednesday.Checked && chkFriday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkTuesday.Enabled = false;
                }
                else if (chkTuesday.Checked && chkWednesday.Checked && chkFriday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkThursday.Enabled = false;
                }
                else if (chkTuesday.Checked && chkThursday.Checked && chkFriday.Checked)
                {
                    chkMonday.Enabled = false;
                    chkWednesday.Enabled = false;
                }
                else
                {
                    chkMonday.Enabled = true;
                    chkTuesday.Enabled = true;
                    chkWednesday.Enabled = true;
                    chkThursday.Enabled = true;
                    chkFriday.Enabled = true;
                }

            }
            else if (Convert.ToInt32(numWeekday.Value) == 4)
            {
                if (chkMonday.Checked && chkTuesday.Checked && chkWednesday.Checked && chkThursday.Checked)
                {
                    chkFriday.Enabled = false;
                }
                else if (chkMonday.Checked && chkTuesday.Checked && chkWednesday.Checked && chkFriday.Checked)
                {
                    chkThursday.Enabled = false;
                }
                else if (chkMonday.Checked && chkTuesday.Checked && chkThursday.Checked && chkFriday.Checked)
                {
                    chkWednesday.Enabled = false;
                }
                else if (chkMonday.Checked && chkWednesday.Checked && chkThursday.Checked && chkFriday.Checked)
                {
                    chkTuesday.Enabled = false;
                }
                else if (chkTuesday.Checked && chkWednesday.Checked && chkThursday.Checked && chkFriday.Checked)
                {
                    chkMonday.Enabled = false;
                }
                else
                {
                    chkMonday.Enabled = true;
                    chkTuesday.Enabled = true;
                    chkWednesday.Enabled = true;
                    chkThursday.Enabled = true;
                    chkFriday.Enabled = true;
                }
            };
        }

        private void HideCheackBoxWeekend()
        {
            if (Convert.ToInt32(numWeekend.Value) == 1)
            {
                if (chkSaturday.Checked)
                {
                    chkSunday.Enabled = false;
                }
                else if (chkSunday.Checked)
                {
                    chkSaturday.Enabled = false;
                }
                else
                {
                    chkSunday.Enabled = true;
                    chkSaturday.Enabled = true;
                }
            }
        }

        private void storeWorkingDayModel()
        {
            if (chkMonday.Checked == true)
            {
                workingDaysModel.Monday = "Working";
            }
            else
            {
                workingDaysModel.Monday = "Not working";
            }

            if (chkTuesday.Checked == true)
            {
                workingDaysModel.Tuesday = "Working";
            }
            else
            {
                workingDaysModel.Tuesday = "Not working";
            }

            if (chkWednesday.Checked == true)
            {
                workingDaysModel.Wednesday = "Working";
            }
            else
            {
                workingDaysModel.Wednesday = "Not working";
            }

            if (chkThursday.Checked == true)
            {
                workingDaysModel.Thursday = "Working";
            }
            else
            {
                workingDaysModel.Thursday = "Not working";
            }

            if (chkFriday.Checked == true)
            {
                workingDaysModel.Friday = "Working";
            }
            else
            {
                workingDaysModel.Friday = "Not working";
            }

            if (chkSaturday.Checked == true)
            {
                workingDaysModel.Saturday = "Working";
            }
            else
            {
                workingDaysModel.Saturday = "Not working";
            }

            if (chkSunday.Checked == true)
            {
                workingDaysModel.Sunday = "Working";
            }
            else
            {
                workingDaysModel.Sunday = "Not working";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            storeWorkingDayModel();

            numberOfWorkingDaysCon.insertNumberOfWorkingDays(workingDaysModel);
            fillDataTables();
            tableHide();
            numWeekday.Value = 0;
            numWeekend.Value = 0;
            if (numberOfWorkingDaysCon.cheackRecords() == true)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            if (numberOfWorkingDaysCon.cheackRecords() == true)
            {
                btnSave.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
                numWeekday.Enabled = false;
                numWeekend.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                chkMonday.Enabled = true;
                chkTuesday.Enabled = true;
                chkWednesday.Enabled = true;
                chkThursday.Enabled = true;
                chkFriday.Enabled = true;
                chkSaturday.Enabled = true;
                chkSunday.Enabled = true;
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            storeWorkingDayModel();
            numberOfWorkingDaysCon.updateNumberOfWorkingDays(workingDaysModel);
            tableHide();
            fillDataTables();
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            numWeekday.Value = 0;
            numWeekend.Value = 0;
            if (numberOfWorkingDaysCon.cheackRecords() == true)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
            if (numberOfWorkingDaysCon.cheackRecords() == true)
            {
                btnSave.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
                numWeekday.Enabled = false;
                numWeekend.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                chkMonday.Enabled = true;
                chkTuesday.Enabled = true;
                chkWednesday.Enabled = true;
                chkThursday.Enabled = true;
                chkFriday.Enabled = true;
                chkSaturday.Enabled = true;
                chkSunday.Enabled = true;
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
            }
            numWeekday.Enabled = false;
            numWeekend.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            numberOfWorkingDaysCon.deleteNumOfWorkingDays();
            fillDataTables();
            tableHide();
            numWeekday.Value = 0;
            numWeekend.Value = 0;

            if (numberOfWorkingDaysCon.cheackRecords() == true)
            {
                btnSave.Enabled = false;
                chkMonday.Enabled = false;
                chkTuesday.Enabled = false;
                chkWednesday.Enabled = false;
                chkThursday.Enabled = false;
                chkFriday.Enabled = false;
                chkSaturday.Enabled = false;
                chkSunday.Enabled = false;
                numWeekday.Enabled = false;
                numWeekend.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
                if (Convert.ToInt32(numWeekday.Value) == 0)
                {
                    chkMonday.Enabled = false;
                    chkTuesday.Enabled = false;
                    chkWednesday.Enabled = false;
                    chkThursday.Enabled = false;
                    chkFriday.Enabled = false;
                }
                else
                {
                    chkMonday.Enabled = true;
                    chkTuesday.Enabled = true;
                    chkWednesday.Enabled = true;
                    chkThursday.Enabled = true;
                    chkFriday.Enabled = true;
                }
                if (Convert.ToInt32(numWeekend.Value) == 0)
                {
                    chkSaturday.Enabled = false;
                    chkSunday.Enabled = false;
                }
                else
                {
                    chkSaturday.Enabled = true;
                    chkSunday.Enabled = true;
                }
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
            }
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timeSlotsModel.WorkingTimeHrs = Convert.ToInt32(workingHrs.Value);
            timeSlotsModel.WorkingTimeMin = Convert.ToInt32(workingMin.Value);
            timeSlotsModel.StartTimeHrs = Convert.ToInt32(startHrs.Value);
            timeSlotsModel.StartTimeMin = Convert.ToInt32(startMin.Value);
            if (oneHrs.Checked == true)
            {
                timeSlotsModel.TimeSloatType = "One hour time slots";
            }
            else if (radio30Min.Checked == true)
            {
                timeSlotsModel.TimeSloatType = "Thirty minutes time slots";
            }
            timeSlotsCon.insertTimeSlots(timeSlotsModel);
            fillTimeSlotData();
            timeSlotsInitial();
            hideInputsTimeSlots();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeSlotsModel.WorkingTimeHrs = Convert.ToInt32(workingHrs.Value);
            timeSlotsModel.WorkingTimeMin = Convert.ToInt32(workingMin.Value);
            timeSlotsModel.StartTimeHrs = Convert.ToInt32(startHrs.Value);
            timeSlotsModel.StartTimeMin = Convert.ToInt32(startMin.Value);
            if (oneHrs.Checked == true)
            {
                timeSlotsModel.TimeSloatType = "One hour time slots";
            }
            else if (radio30Min.Checked == true)
            {
                timeSlotsModel.TimeSloatType = "Thirty minutes time slots";
            }
            timeSlotsCon.updateTimeSlots(timeSlotsModel);
            fillTimeSlotData();
            timeSlotsInitial();
            hideInputsTimeSlots();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeSlotsCon.deleteTimeSlots();
            hideInputsTimeSlots();
            fillTimeSlotData();
            timeSlotsInitial();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timeSlotsModelWE.WorkingTimeHrsWE = Convert.ToInt32(workingHrsWE.Value);
            timeSlotsModelWE.WorkingTimeMinWE = Convert.ToInt32(workingMinWE.Value);
            timeSlotsModelWE.StartTimeHrsWE = Convert.ToInt32(startHrsWE.Value);
            timeSlotsModelWE.StartTimeMinWE = Convert.ToInt32(startMinWE.Value);
            if (oneHrsWE.Checked == true)
            {
                timeSlotsModelWE.TimeSloatTypeWE = "One hour time slots";
            }
            else if (radio30MinWE.Checked == true)
            {
                timeSlotsModelWE.TimeSloatTypeWE = "Thirty minutes time slots";
            }
            timeSlotsConWE.insertTimeSlotsWE(timeSlotsModelWE);
            fillTimeSlotDataWE();
            timeSlotsInitialWE();
            hideInputsTimeSlotsWE();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timeSlotsModelWE.WorkingTimeHrsWE = Convert.ToInt32(workingHrsWE.Value);
            timeSlotsModelWE.WorkingTimeMinWE = Convert.ToInt32(workingMinWE.Value);
            timeSlotsModelWE.StartTimeHrsWE = Convert.ToInt32(startHrsWE.Value);
            timeSlotsModelWE.StartTimeMinWE = Convert.ToInt32(startMinWE.Value);
            if (oneHrsWE.Checked == true)
            {
                timeSlotsModelWE.TimeSloatTypeWE = "One hour time slots";
            }
            else if (radio30MinWE.Checked == true)
            {
                timeSlotsModelWE.TimeSloatTypeWE = "Thirty minutes time slots";
            }
            timeSlotsConWE.updateTimeSlotsWE(timeSlotsModelWE);
            fillTimeSlotDataWE();
            timeSlotsInitialWE();
            hideInputsTimeSlotsWE();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timeSlotsConWE.deleteTimeSlotsWE();
            hideInputsTimeSlotsWE();
            fillTimeSlotDataWE();
            timeSlotsInitialWE();
        }

        private void dataGridViewNumOfWorkingDays_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataNum = this.dataGridViewNumOfWorkingDays.Rows[e.RowIndex];
                numWeekday.Value = Convert.ToInt32(dataNum.Cells["weekday"].Value);
                numWeekend.Value = Convert.ToInt32(dataNum.Cells["weekend"].Value);
                DataGridViewRow dataWeekday = this.dataGridViewWeekday.Rows[e.RowIndex];
                if (dataWeekday.Cells["monday"].Value.ToString() == "Working")
                {
                    chkMonday.Checked = true;
                }
                else
                {
                    chkMonday.Checked = false;
                }
                if (dataWeekday.Cells["tuesday"].Value.ToString() == "Working")
                {
                    chkTuesday.Checked = true;
                }
                else
                {
                    chkTuesday.Checked = false;
                }
                if (dataWeekday.Cells["wednesday"].Value.ToString() == "Working")
                {
                    chkWednesday.Checked = true;
                }
                else
                {
                    chkWednesday.Checked = false;
                }
                if (dataWeekday.Cells["thursday"].Value.ToString() == "Working")
                {
                    chkThursday.Checked = true;
                }
                else
                {
                    chkThursday.Checked = false;
                }
                if (dataWeekday.Cells["friday"].Value.ToString() == "Working")
                {
                    chkFriday.Checked = true;
                }
                else
                {
                    chkFriday.Checked = false;
                }
                DataGridViewRow dataWeekend = this.dataGridViewWekend.Rows[e.RowIndex];
                if (dataWeekend.Cells["Saturday"].Value.ToString() == "Working")
                {
                    chkSaturday.Checked = true;
                }
                else
                {
                    chkSaturday.Checked = false;
                }
                if (dataWeekend.Cells["sunday"].Value.ToString() == "Working")
                {
                    chkSunday.Checked = true;
                }
                else
                {
                    chkSunday.Checked = false;
                }
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void dataGridViewWeekday_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataNum = this.dataGridViewNumOfWorkingDays.Rows[e.RowIndex];
                numWeekday.Value = Convert.ToInt32(dataNum.Cells["weekday"].Value);
                numWeekend.Value = Convert.ToInt32(dataNum.Cells["weekend"].Value);
                DataGridViewRow dataWeekday = this.dataGridViewWeekday.Rows[e.RowIndex];
                if (dataWeekday.Cells["monday"].Value.ToString() == "Working")
                {
                    chkMonday.Checked = true;
                }
                else
                {
                    chkMonday.Checked = false;
                }
                if (dataWeekday.Cells["tuesday"].Value.ToString() == "Working")
                {
                    chkTuesday.Checked = true;
                }
                else
                {
                    chkTuesday.Checked = false;
                }
                if (dataWeekday.Cells["wednesday"].Value.ToString() == "Working")
                {
                    chkWednesday.Checked = true;
                }
                else
                {
                    chkWednesday.Checked = false;
                }
                if (dataWeekday.Cells["thursday"].Value.ToString() == "Working")
                {
                    chkThursday.Checked = true;
                }
                else
                {
                    chkThursday.Checked = false;
                }
                if (dataWeekday.Cells["friday"].Value.ToString() == "Working")
                {
                    chkFriday.Checked = true;
                }
                else
                {
                    chkFriday.Checked = false;
                }
                DataGridViewRow dataWeekend = this.dataGridViewWekend.Rows[e.RowIndex];
                if (dataWeekend.Cells["Saturday"].Value.ToString() == "Working")
                {
                    chkSaturday.Checked = true;
                }
                else
                {
                    chkSaturday.Checked = false;
                }
                if (dataWeekend.Cells["sunday"].Value.ToString() == "Working")
                {
                    chkSunday.Checked = true;
                }
                else
                {
                    chkSunday.Checked = false;
                }
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void dataGridViewWekend_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dataNum = this.dataGridViewNumOfWorkingDays.Rows[e.RowIndex];
                numWeekday.Value = Convert.ToInt32(dataNum.Cells["weekday"].Value);
                numWeekend.Value = Convert.ToInt32(dataNum.Cells["weekend"].Value);
                DataGridViewRow dataWeekday = this.dataGridViewWeekday.Rows[e.RowIndex];
                if (dataWeekday.Cells["monday"].Value.ToString() == "Working")
                {
                    chkMonday.Checked = true;
                }
                else
                {
                    chkMonday.Checked = false;
                }
                if (dataWeekday.Cells["tuesday"].Value.ToString() == "Working")
                {
                    chkTuesday.Checked = true;
                }
                else
                {
                    chkTuesday.Checked = false;
                }
                if (dataWeekday.Cells["wednesday"].Value.ToString() == "Working")
                {
                    chkWednesday.Checked = true;
                }
                else
                {
                    chkWednesday.Checked = false;
                }
                if (dataWeekday.Cells["thursday"].Value.ToString() == "Working")
                {
                    chkThursday.Checked = true;
                }
                else
                {
                    chkThursday.Checked = false;
                }
                if (dataWeekday.Cells["friday"].Value.ToString() == "Working")
                {
                    chkFriday.Checked = true;
                }
                else
                {
                    chkFriday.Checked = false;
                }
                DataGridViewRow dataWeekend = this.dataGridViewWekend.Rows[e.RowIndex];
                if (dataWeekend.Cells["Saturday"].Value.ToString() == "Working")
                {
                    chkSaturday.Checked = true;
                }
                else
                {
                    chkSaturday.Checked = false;
                }
                if (dataWeekend.Cells["sunday"].Value.ToString() == "Working")
                {
                    chkSunday.Checked = true;
                }
                else
                {
                    chkSunday.Checked = false;
                }
                numWeekday.Enabled = true;
                numWeekend.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void dataWorkingTime_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTime = this.dataWorkingTime.Rows[e.RowIndex];
            workingHrs.Value = Convert.ToInt32(dataTime.Cells["Hours"].Value);
            workingMin.Value = Convert.ToInt32(dataTime.Cells["Minutes"].Value);
            DataGridViewRow dataStart = this.dataStartTime.Rows[e.RowIndex];
            startHrs.Value = Convert.ToInt32(dataStart.Cells["Hours"].Value);
            startMin.Value = Convert.ToInt32(dataStart.Cells["Minutes"].Value);
            DataGridViewRow dataType1 = this.dataType.Rows[e.RowIndex];
            if (dataType1.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrs.Checked = true;
                radio30Min.Checked = false;
            }
            else if (dataType1.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrs.Checked = false;
                radio30Min.Checked = true;
            }
            workingHrs.Enabled = true;
            workingMin.Enabled = true;
            startHrs.Enabled = true;
            startMin.Enabled = true;
            oneHrs.Enabled = true;
            radio30Min.Enabled = true;
        }

        private void dataStartTime_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTime = this.dataWorkingTime.Rows[e.RowIndex];
            workingHrs.Value = Convert.ToInt32(dataTime.Cells["Hours"].Value);
            workingMin.Value = Convert.ToInt32(dataTime.Cells["Minutes"].Value);
            DataGridViewRow dataStart = this.dataStartTime.Rows[e.RowIndex];
            startHrs.Value = Convert.ToInt32(dataStart.Cells["Hours"].Value);
            startMin.Value = Convert.ToInt32(dataStart.Cells["Minutes"].Value);
            DataGridViewRow dataType1 = this.dataType.Rows[e.RowIndex];
            if (dataType1.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrs.Checked = true;
                radio30Min.Checked = false;
            }
            else if (dataType1.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrs.Checked = false;
                radio30Min.Checked = true;
            }
            workingHrs.Enabled = true;
            workingMin.Enabled = true;
            startHrs.Enabled = true;
            startMin.Enabled = true;
            oneHrs.Enabled = true;
            radio30Min.Enabled = true;
        }

        private void dataType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTime = this.dataWorkingTime.Rows[e.RowIndex];
            workingHrs.Value = Convert.ToInt32(dataTime.Cells["Hours"].Value);
            workingMin.Value = Convert.ToInt32(dataTime.Cells["Minutes"].Value);
            DataGridViewRow dataStart = this.dataStartTime.Rows[e.RowIndex];
            startHrs.Value = Convert.ToInt32(dataStart.Cells["Hours"].Value);
            startMin.Value = Convert.ToInt32(dataStart.Cells["Minutes"].Value);
            DataGridViewRow dataType1 = this.dataType.Rows[e.RowIndex];
            if (dataType1.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrs.Checked = true;
                radio30Min.Checked = false;
            }
            else if (dataType1.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrs.Checked = false;
                radio30Min.Checked = true;
            }
            workingHrs.Enabled = true;
            workingMin.Enabled = true;
            startHrs.Enabled = true;
            startMin.Enabled = true;
            oneHrs.Enabled = true;
            radio30Min.Enabled = true;
        }

        private void dataTimeSlots_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTime = this.dataWorkingTime.Rows[e.RowIndex];
            workingHrs.Value = Convert.ToInt32(dataTime.Cells["Hours"].Value);
            workingMin.Value = Convert.ToInt32(dataTime.Cells["Minutes"].Value);
            DataGridViewRow dataStart = this.dataStartTime.Rows[e.RowIndex];
            startHrs.Value = Convert.ToInt32(dataStart.Cells["Hours"].Value);
            startMin.Value = Convert.ToInt32(dataStart.Cells["Minutes"].Value);
            DataGridViewRow dataType1 = this.dataType.Rows[e.RowIndex];
            if (dataType1.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrs.Checked = true;
                radio30Min.Checked = false;
            }
            else if (dataType1.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrs.Checked = false;
                radio30Min.Checked = true;
            }
            workingHrs.Enabled = true;
            workingMin.Enabled = true;
            startHrs.Enabled = true;
            startMin.Enabled = true;
            oneHrs.Enabled = true;
            radio30Min.Enabled = true;
        }

        private void dataWorkingTimeWE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTimeWE = this.dataWorkingTimeWE.Rows[e.RowIndex];
            workingHrsWE.Value = Convert.ToInt32(dataTimeWE.Cells["Hours"].Value);
            workingMinWE.Value = Convert.ToInt32(dataTimeWE.Cells["Minutes"].Value);
            DataGridViewRow dataStartWE = this.dataStartTimeWE.Rows[e.RowIndex];
            startHrsWE.Value = Convert.ToInt32(dataStartWE.Cells["Hours"].Value);
            startMinWE.Value = Convert.ToInt32(dataStartWE.Cells["Minutes"].Value);
            DataGridViewRow dataType1WE = this.dataTypeWE.Rows[e.RowIndex];
            if (dataType1WE.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrsWE.Checked = true;
                radio30MinWE.Checked = false;
            }
            else if (dataType1WE.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrsWE.Checked = false;
                radio30MinWE.Checked = true;
            }
            workingHrsWE.Enabled = true;
            workingMinWE.Enabled = true;
            startHrsWE.Enabled = true;
            startMinWE.Enabled = true;
            oneHrsWE.Enabled = true;
            radio30MinWE.Enabled = true;
        }

        private void dataStartTimeWE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTimeWE = this.dataWorkingTimeWE.Rows[e.RowIndex];
            workingHrsWE.Value = Convert.ToInt32(dataTimeWE.Cells["Hours"].Value);
            workingMinWE.Value = Convert.ToInt32(dataTimeWE.Cells["Minutes"].Value);
            DataGridViewRow dataStartWE = this.dataStartTimeWE.Rows[e.RowIndex];
            startHrsWE.Value = Convert.ToInt32(dataStartWE.Cells["Hours"].Value);
            startMinWE.Value = Convert.ToInt32(dataStartWE.Cells["Minutes"].Value);
            DataGridViewRow dataType1WE = this.dataTypeWE.Rows[e.RowIndex];
            if (dataType1WE.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrsWE.Checked = true;
                radio30MinWE.Checked = false;
            }
            else if (dataType1WE.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrsWE.Checked = false;
                radio30MinWE.Checked = true;
            }
            workingHrsWE.Enabled = true;
            workingMinWE.Enabled = true;
            startHrsWE.Enabled = true;
            startMinWE.Enabled = true;
            oneHrsWE.Enabled = true;
            radio30MinWE.Enabled = true;
        }

        private void dataTypeWE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTimeWE = this.dataWorkingTimeWE.Rows[e.RowIndex];
            workingHrsWE.Value = Convert.ToInt32(dataTimeWE.Cells["Hours"].Value);
            workingMinWE.Value = Convert.ToInt32(dataTimeWE.Cells["Minutes"].Value);
            DataGridViewRow dataStartWE = this.dataStartTimeWE.Rows[e.RowIndex];
            startHrsWE.Value = Convert.ToInt32(dataStartWE.Cells["Hours"].Value);
            startMinWE.Value = Convert.ToInt32(dataStartWE.Cells["Minutes"].Value);
            DataGridViewRow dataType1WE = this.dataTypeWE.Rows[e.RowIndex];
            if (dataType1WE.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrsWE.Checked = true;
                radio30MinWE.Checked = false;
            }
            else if (dataType1WE.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrsWE.Checked = false;
                radio30MinWE.Checked = true;
            }
            workingHrsWE.Enabled = true;
            workingMinWE.Enabled = true;
            startHrsWE.Enabled = true;
            startMinWE.Enabled = true;
            oneHrsWE.Enabled = true;
            radio30MinWE.Enabled = true;
        }

        private void dataTimeSlotsWE_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataTimeWE = this.dataWorkingTimeWE.Rows[e.RowIndex];
            workingHrsWE.Value = Convert.ToInt32(dataTimeWE.Cells["Hours"].Value);
            workingMinWE.Value = Convert.ToInt32(dataTimeWE.Cells["Minutes"].Value);
            DataGridViewRow dataStartWE = this.dataStartTimeWE.Rows[e.RowIndex];
            startHrsWE.Value = Convert.ToInt32(dataStartWE.Cells["Hours"].Value);
            startMinWE.Value = Convert.ToInt32(dataStartWE.Cells["Minutes"].Value);
            DataGridViewRow dataType1WE = this.dataTypeWE.Rows[e.RowIndex];
            if (dataType1WE.Cells["Type"].Value.ToString() == "One hour time slots")
            {
                oneHrsWE.Checked = true;
                radio30MinWE.Checked = false;
            }
            else if (dataType1WE.Cells["Type"].Value.ToString() == "Thirty minutes time slots")
            {
                oneHrsWE.Checked = false;
                radio30MinWE.Checked = true;
            }
            workingHrsWE.Enabled = true;
            workingMinWE.Enabled = true;
            startHrsWE.Enabled = true;
            startMinWE.Enabled = true;
            oneHrsWE.Enabled = true;
            radio30MinWE.Enabled = true;
        }
    }
}
