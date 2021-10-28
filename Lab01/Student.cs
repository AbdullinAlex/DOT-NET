using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
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

        public override string ToString()
        {
            return "Fristname: " + firstname + "\nSurname" + surname + 
                "\nDate of birth: " + dateOfBirth.Day +"."+ dateOfBirth.Month+"."+dateOfBirth.Year +
                "\nDate of enter: " + dateOfEnter.Day +"."+ dateOfBirth.Month+"."+dateOfBirth.Year +
                "\nIndex of group: " + groupIndex + "\nFaculty: " + faculty
                "\nSpecialization: " + specialization + "\nAcademic Performance: " + academicPerfoemance;
        }

        public void Print()
        {
            printer.Print(this.ToString());
        }

        public Student() : base("Oleksii", "Abdullin", "a", "CIT", 123, 86, new DateTime(2002, 5, 31), new DateTime(2019, 8, 12))
        {

        }
        public Student(string firstname, string surname, string groupIndex, string faculty, 
            int specialization, int academicPerfoemance, DateTime dateOfBirth, DateTime dateOfEnter)
        {
            this.firstname = firstname;
            this.surname = surname;
            this.groupIndex = groupIndex;
            this.faculty = faculty;
            this.specialization = specialization;
            this.academicPerformance = academicPerfoemance;
            this.dateOfBirth = dateOfBirth;
            this.dateOfEnter = dateOfEnter;
        }
    }
}
