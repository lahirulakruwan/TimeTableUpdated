using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.TimeSlotsModel
{
    class WorkingDaysModel
    {

        private int weekdayDays;
        private int weekendDays;
        private String monday;
        private String tuesday;
        private String wednesday;
        private String thursday;
        private String friday;
        private String saturday;
        private String sunday;

        public int WeekdayDays
        {
            get
            {
                return weekdayDays;
            }

            set
            {
                weekdayDays = value;
            }
        }

        public int WeekendDays
        {
            get
            {
                return weekendDays;
            }

            set
            {
                weekendDays = value;
            }
        }

        public String Monday
        {
            get
            {
                return monday;
            }

            set
            {
                monday = value;
            }
        }

        public String Tuesday
        {
            get
            {
                return tuesday;
            }

            set
            {
                tuesday = value;
            }
        }

        public String Wednesday
        {
            get
            {
                return wednesday;
            }

            set
            {
                wednesday = value;
            }
        }

        public String Thursday
        {
            get
            {
                return thursday;
            }

            set
            {
                thursday = value;
            }
        }

        public String Friday
        {
            get
            {
                return friday;
            }

            set
            {
                friday = value;
            }
        }

        public String Saturday
        {
            get
            {
                return saturday;
            }

            set
            {
                saturday = value;
            }
        }

        public String Sunday
        {
            get
            {
                return sunday;
            }

            set
            {
                sunday = value;
            }
        }

    }
}
