using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
    {
        private string _firstname { get; set; }
        private string _surname { get; set; }
        private string _groupIndex { get; set; }
        private string _faculty { get; set; }
        private int _specialization { get; set; }
        private int _academicPerformance { get; set; }
        private DateTime _dateOfBirth { get; set; }
        private DateTime _dateOfEnter { get; set; }

        public void print()
        {
            Console.WriteLine($"Fistname: {_firstname}\n" +
                $"Surname: {_surname}\n" +
                $"Date of birth: {_dateOfBirth.Date.Day}.{_dateOfBirth.Date.Month}.{_dateOfBirth.Date.Year}\n" +
                $"Date of enter: {_dateOfEnter.Date.Day}.{_dateOfEnter.Date.Month}.{_dateOfEnter.Date.Year}\n" +
                $"Index of group: {_groupIndex}\n" +
                $"Faculty: {_faculty}\n" +
                $"Specialization: {_specialization}\n" +
                $"Academic Performance: {_academicPerformance}\n" +
                $"----------------------------------------------------");
        }

        public Student()
        {
            _firstname = "Oleksii";
            _surname = "Abdullin";
            _groupIndex = "a";
            _faculty = "CIT";
            _specialization = 123;
            _academicPerformance = 86;
            _dateOfBirth = new DateTime(2002, 5, 31);
            _dateOfEnter = new DateTime(2019, 8, 12);
        }
        public Student(string firstname, string surname, string groupIndex, string faculty, 
            int specialization, int academicPerfoemance, DateTime dateOfBirth, DateTime dateOfEnter)
        {
            _firstname = firstname;
            _surname = surname;
            _groupIndex = groupIndex;
            _faculty = faculty;
            _specialization = specialization;
            _academicPerformance = academicPerfoemance;
            _dateOfBirth = dateOfBirth;
            _dateOfEnter = dateOfEnter;
        }
    }
}
