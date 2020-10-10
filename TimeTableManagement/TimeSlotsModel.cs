using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeSlotsModel
{
    class TimeSlotsModel
    {

        private float workingTimeHrs;
        private float workingTimeMin;
        private float startTimeHrs;
        private float startTimeMin;
        private String timeSloatType;

        public float WorkingTimeHrs
        {
            get
            {
                return workingTimeHrs;
            }

            set
            {
                workingTimeHrs = value;
            }
        }

        public float WorkingTimeMin
        {
            get
            {
                return workingTimeMin;
            }

            set
            {
                workingTimeMin = value;
            }
        }

        public float StartTimeHrs
        {
            get
            {
                return startTimeHrs;
            }

            set
            {
                startTimeHrs = value;
            }
        }

        public float StartTimeMin
        {
            get
            {
                return startTimeMin;
            }

            set
            {
                startTimeMin = value;
            }
        }

        public String TimeSloatType
        {
            get
            {
                return timeSloatType;
            }

            set
            {
                timeSloatType = value;
            }
        }

    }
}
