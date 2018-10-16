using System;
using System.Collections.Generic;

namespace Course
{
    public class Course
    {
        private string _lastName;
        private string _firstName;
        private int _studentCount;
        private List<string> _days;

        public int Id { get; }

        public string Title { get; set; }

        public decimal Tuition { get; set; }

        public List<string> ClassDays { get; set; }

        public decimal TotalRevenue
        {
            get
            {
                return Tuition * StudentCount;
            }
        }

        public int StudentCount
        {
            get
            {
                return _studentCount;
            }
            set
            {
                if (value >= 0)
                {
                    _studentCount = value;
                }
            }
        }

        public string InstructorName
        {
            get
            {
                return $"{_lastName}, {_firstName}";
            }
            set
            {
                string[] splitName = value.Split(' ');
                if (!string.IsNullOrEmpty(splitName[0]) && !string.IsNullOrEmpty(splitName[1]))
                {
                    _firstName = splitName[0];
                    _lastName = splitName[1];
                }
            }
        }

    }
}
