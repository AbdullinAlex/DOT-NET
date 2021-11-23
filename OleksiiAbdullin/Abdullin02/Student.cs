using Abdullin01;
using System;

namespace Abdullin02
{
    public class Student
    {
        public string firstname { get; set; }
        public string surname { get; set; }
        public string groupIndex { get; set; }
        public string faculty { get; set; }
        public int specialization { get; set; }
        public int academicPerformance { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime dateOfEnter { get; set; }
        public IPrinter printer;
        public Student() : this("Oleksii", "Abdullin", "a", "CIT", 123, 86, new DateTime(2002, 5, 31), new DateTime(2019, 8, 12))
        {

        }
        public Student(string firstname, string surname, string groupIndex, string faculty,
            int specialization, int academicPerformance, DateTime dateOfBirth, DateTime dateOfEnter)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.groupIndex = groupIndex;
            this.faculty = faculty;
            this.specialization = specialization;
            this.academicPerformance = academicPerformance;
            this.dateOfBirth = dateOfBirth;
            this.dateOfEnter = dateOfEnter;
            this.printer = new ConsolePrinter();
        }
        public void Print()
        {
            printer.Print(ToString());
        }
        public override string ToString()
        {
            return "Fristname: " + firstname + "\nSurname: " + surname +
                "\nDate of birth: " + dateOfBirth.Day + "." + dateOfBirth.Month + "." + dateOfBirth.Year +
                "\nDate of enter: " + dateOfEnter.Day + "." + dateOfEnter.Month + "." + dateOfEnter.Year +
                "\nIndex of group: " + groupIndex + "\nFaculty: " + faculty +
                "\nSpecialization: " + specialization + "\nAcademic Performance: " + academicPerformance + "\n";
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
            return s.firstname == this.firstname &&
                    s.surname == this.surname &&
                    s.groupIndex == this.groupIndex &&
                    s.faculty == this.faculty &&
                    s.specialization == this.specialization &&
                    s.academicPerformance == this.academicPerformance &&
                    s.dateOfBirth == this.dateOfBirth &&
                    s.dateOfEnter == this.dateOfEnter;
        }
    }
}
