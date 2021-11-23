using System;

namespace Abdullin01
{
    class Student
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string GroupIndex { get; set; }
        public string Faculty { get; set; }
        public int Specialization { get; set; }
        public int AcademicPerformance { get; set; }
        public DateTime DateOFBirth { get; set; }
        public DateTime DateOfEnter { get; set; }
        public IPrinter Printer;

        public override string ToString()
        {
            return "Fristname: " + Firstname + "\nSurname" + Surname +
                "\nDate of birth: " + DateOFBirth.Day + "." + DateOFBirth.Month + "." + DateOFBirth.Year +
                "\nDate of enter: " + DateOfEnter.Day + "." + DateOfEnter.Month + "." + DateOfEnter.Year +
                "\nIndex of group: " + GroupIndex + "\nFaculty: " + Faculty +
                "\nSpecialization: " + Specialization + "\nAcademic Performance: " + AcademicPerformance + "\n";
        }

        public void Print()
        {
            Printer.Print(ToString());
        }

        public Student() : this("Oleksii", "Abdullin", "a", "CIT", 123, 86, new DateTime(2002, 5, 31), new DateTime(2019, 8, 12))
        {

        }

        public Student(string firstname, string surname, string groupIndex, string faculty,
            int specialization, int academicPerformance, DateTime dateOfBirth, DateTime dateOfEnter)
        {
            this.Firstname = firstname;
            this.Surname = surname;
            this.GroupIndex = groupIndex;
            this.Faculty = faculty;
            this.Specialization = specialization;
            this.AcademicPerformance = academicPerformance;
            this.DateOFBirth = dateOfBirth;
            this.DateOfEnter = dateOfEnter;
            this.Printer = new ConsolePrinter();
        }
    }
}
