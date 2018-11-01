﻿using System;

namespace src
{
    public class UniversityCourse : CalendarItem
    {
        private string _profLastName;
        private string _profFirstName;
        private int _startHour;
        private int _studentCount;

        //-->Properties
        public int ClassLength { get; set; }
        public string ClassDays { get; set; }
        public static int InstanceCount { get; set; }

        public string ProfessorName
        {
            get
            {
                return $"{_profFirstName}.{_profLastName}";
            }
            set
            {
                if (!value.Contains("."))
                    return;

                string[] parts = value.Split('.');
                if (!string.IsNullOrEmpty(parts[0]) && !string.IsNullOrEmpty(parts[1]))
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
                if (value > 0 && value < 13)
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
        //-->end Properties

        public UniversityCourse(string id, string title, string location, string professorName = "", int startHour = 6, string classDays = "MTWThF", int classLength = 1, int studentCount = 0)
            : base(id, title, location)
        {
            ProfessorName = professorName;
            StartHour = startHour;
            ClassDays = classDays;
            ClassLength = classLength;
            StudentCount = studentCount;

            InstanceCount++;
        }

        public override string GetSummaryInformation()
        {
            return $@"Id: {ID}        Title: {Title}      Instructor: {ProfessorName}     Location: {Location}
Days: {ClassDays}       StartTime: {StartHour}:00       EndTime: {EndHour}:00";
        }

        public void Deconstruct(out string id, out string title, out string location, out string professorName)
        {
            (id, title, location) = this;
            professorName = ProfessorName;
        }

        public void Deconstruct(out string id, out string title, out string location, out string professorName, out int startHour, out string classDays, out int classLength, out int studentCount)
        {
            (id, title, location, professorName) = this;
            startHour = StartHour;
            classDays = ClassDays;
            classLength = ClassLength;
            studentCount = StudentCount;
        }
    }
}