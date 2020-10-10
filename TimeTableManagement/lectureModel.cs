using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagement.Model.vishakaModel
{
    class lectureModel
    {
        private String name ;
        private String E_Id;
        private String faculty;
        private String dept;
        private String center;
        private String building;
        private String level;
        private String rank;

        public string namefield
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string employee_idfield
        {
            get
            {
                return E_Id;
            }

            set
            {
                E_Id = value;
            }
        }

        public string facultyfield
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }

        public string deptfield
        {
            get
            {
                return dept;
            }

            set
            {
                dept = value;
            }
        }

        public string centerfield
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public string buildingfield
        {
            get
            {
                return building;
            }

            set
            {
                building = value;
            }
        }

        public string levelfield
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public string rankfield
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }
    }

}
