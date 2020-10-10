using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeSlotsModel
{
    class TimeSlotsModelWE
    {

        private float workingTimeHrsWE;
        private float workingTimeMinWE;
        private float startTimeHrsWE;
        private float startTimeMinWE;
        private String timeSloatTypeWE;

        public float WorkingTimeHrsWE
        {
            get
            {
                return workingTimeHrsWE;
            }

            set
            {
                workingTimeHrsWE = value;
            }
        }

        public float WorkingTimeMinWE
        {
            get
            {
                return workingTimeMinWE;
            }

            set
            {
                workingTimeMinWE = value;
            }
        }

        public float StartTimeHrsWE
        {
            get
            {
                return startTimeHrsWE;
            }

            set
            {
                startTimeHrsWE = value;
            }
        }

        public float StartTimeMinWE
        {
            get
            {
                return startTimeMinWE;
            }

            set
            {
                startTimeMinWE = value;
            }
        }

        public String TimeSloatTypeWE
        {
            get
            {
                return timeSloatTypeWE;
            }

            set
            {
                timeSloatTypeWE = value;
            }
        }

    }
}
