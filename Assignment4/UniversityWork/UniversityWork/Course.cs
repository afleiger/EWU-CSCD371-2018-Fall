using System;

namespace UniversityWork
{
    public class Course : CalendarItem
    {

        private string _profLastName;
        private string _profFirstName;
        private int _startHour;

        private static int _instanceCount = 0;

        public string ProfessorName
        {
            get
            {
                return $"{_profFirstName}.{_profLastName}";
            }
            set
            {
                if(!value.Contains("."))
                    return;

                string[] parts = value.Split('.');
                if(!string.IsNullOrEmpty(parts[0]) && !string.IsNullOrEmpty(parts[1]))
                {
                    _profLastName = parts[1];
                    _profFirstName = parts[0];
                }
            }
        }

        public int StartHour
        {
            get
            {
                return (_startHour - 1) % 12 + 1;
            }
            set
            {
                if(value > 0 && value < 13)
                {
                    _startHour = value;
                }
            }
        }

        public int EndHour
        {
            get
            {
                return (StartHour + ClassLength - 1) % 12 + 1;
            }
        }

        public int ClassLength { get; set; }

        public int StudentCount { get; set; }

        public string ClassDays { get; set; }

        public static int InstanceCount
        {
            get
            {
                return _instanceCount;
            }
            set
            {
                _instanceCount = value;
            }
        }


        public Course(string id, string title, string location, string professorName, int startHour, string classDays = "MTWThF", int classLength = 1, int studentCount = 0 )
            :base(id, title, location)
        {
            ProfessorName = professorName;
            StartHour = startHour;
            ClassDays = classDays;
            ClassLength = classLength;
            StudentCount = studentCount;

            InstanceCount++;
        }

        public string GetSummaryInformation()
        {
            return "";
        }

        public void Deconstruct(out string id, out string title, out string location, out string professorName)
        {
            id = ID;
            title = Title;
            location = Location;
            professorName = ProfessorName;
        }

        public void Deconstruct(out string id, out string title, out string location, out string professorName, out int startHour, out string classDays, out int classLength, out int studentCount )
        {
            id = ID;
            title = Title;
            location = Location;
            professorName = ProfessorName;
            startHour = StartHour;
            classDays = ClassDays;
            classLength = ClassLength;
            studentCount = StudentCount;
        }

    }
}
