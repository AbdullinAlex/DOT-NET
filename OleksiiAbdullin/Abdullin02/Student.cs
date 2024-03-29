﻿using Abdullin01;
using System;

namespace Abdullin02
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string GroupIndex { get; set; }
        public string Faculty { get; set; }
        public int Specialization { get; set; }
        public int AcademicPerformance { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfEnter { get; set; }
        public IPrinter Printer;
        public Student() : this("Oleksii", "Abdullin", "a", "CIT", 123, 86, new DateTime(2002, 5, 31), new DateTime(2019, 8, 12))
        {

        }
        public Student(string FirstName, string SurName, string GroupIndex, string Faculty,
            int Specialization, int AcademicPerformance, DateTime DateOfBirth, DateTime DateOfEnter)
        {
            this.FirstName = FirstName;
            this.SurName = SurName;
            this.GroupIndex = GroupIndex;
            this.Faculty = Faculty;
            this.Specialization = Specialization;
            this.AcademicPerformance = AcademicPerformance;
            this.DateOfBirth = DateOfBirth;
            this.DateOfEnter = DateOfEnter;
            this.Printer = new ConsolePrinter();
        }
        public void Print()
        {
            Printer.Print(ToString());
        }
        public override string ToString()
        {
            return "Fristname: " + FirstName + "\nSurName: " + SurName +
                "\nDate of birth: " + DateOfBirth.Day + "." + DateOfBirth.Month + "." + DateOfBirth.Year +
                "\nDate of enter: " + DateOfEnter.Day + "." + DateOfEnter.Month + "." + DateOfEnter.Year +
                "\nIndex of group: " + GroupIndex + "\nFaculty: " + Faculty +
                "\nSpecialization: " + Specialization + "\nAcademic Performance: " + AcademicPerformance + "\n";
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Student s = obj as Student;
            if (s == null)
            {
                return false;
            }
            return s.FirstName == this.FirstName &&
                    s.SurName == this.SurName &&
                    s.GroupIndex == this.GroupIndex &&
                    s.Faculty == this.Faculty &&
                    s.Specialization == this.Specialization &&
                    s.AcademicPerformance == this.AcademicPerformance &&
                    s.DateOfBirth == this.DateOfBirth &&
                    s.DateOfEnter == this.DateOfEnter;
        }
    }
}
