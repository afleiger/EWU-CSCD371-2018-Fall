using System;
using System.Collections.Generic;
using CalendarItem;

namespace Course
{
    public class Course : CalendarItem.CalendarItem
    { 
        private int _studentCount;

        public string ClassDays { get; set; }

        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public int ClassLength
        {
            get
            {
                return EndTime - StartTime;
            }
            set
            {
                EndTime = StartTime + value;
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

        public string InstructorFirstName { get; set; }

        public string InstructorLastName { get; set; }

        public string InstructorName
        {
            get
            {
                return $"{InstructorLastName}, {InstructorFirstName}";
            }
        }

        public Course(int id, string classTitle, string instructorFirstName, string instructorLastName, string classDays, int startTime, int classLength, int studentCount) :
            base(id, classTitle)
        {
            InstructorFirstName = instructorFirstName;
            InstructorLastName = instructorLastName;
            ClassDays = classDays;
            StartTime = startTime;
            ClassLength = classLength;
            StudentCount = studentCount;
        }

    }
}
