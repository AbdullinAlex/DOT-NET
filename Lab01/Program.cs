using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Student> Students = new List<Student>();
            Students.Add(new Student());
            int option = 0;
            bool inMenu = true;
            while (inMenu)
            {
                Console.WriteLine("Menu options:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Show all students");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your option: ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nInvalid datatype. Try again.\n");
                }
                switch (option)
                {
                    case 1:
                        Regex regex_string = new Regex(@"^[a-z]+$", RegexOptions.IgnoreCase);

                        string firstname;
                        string surname;
                        string groupIndex;
                        string faculty;
                        int specialization;
                        int academicPerdormance;
                        DateTime dateOfBirth;
                        DateTime dateOfEnter;

                        Console.Write("Enter firstname of student: ");
                        firstname = Console.ReadLine();
                        if (!regex_string.IsMatch(firstname))
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }

                        Console.Write("Enter surname of student: ");
                        surname = Console.ReadLine();
                        if (!regex_string.IsMatch(surname))
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }

                        Console.Write("Enter index of group: ");
                        groupIndex = Console.ReadLine();
                        if (!regex_string.IsMatch(groupIndex))
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }

                        Console.Write("Enter faculty of student: ");
                        faculty = Console.ReadLine();
                        if (!regex_string.IsMatch(faculty))
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }

                        Console.Write("Enter specialization of student: ");
                        try
                        {
                            specialization = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }

                        Console.Write("Enter academic performance of student: ");
                        try
                        {
                            academicPerdormance = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }
                        if(academicPerdormance > 100 || academicPerdormance < 0)
                        {
                            break;
                        }

                        Console.Write("Enter date of birth of student (e.g. 01/01/2001 or 1.1.2001): ");
                        try
                        {
                            dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }

                        Console.Write("Enter date of enter to university (e.g. 01/01/2001 or 1.1.2001): ");
                        try
                        {
                            dateOfEnter = Convert.ToDateTime(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("\nError! Invalid datatype.\n");
                            break;
                        }
                        Student s = new Student(firstname, surname, groupIndex, faculty, specialization,
                            academicPerdormance, dateOfBirth, dateOfEnter);
                        Students.Add(s);
                        break;
                    case 2:
                        try
                        {
                            Console.Write("\nEnter student id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            bool result = id <= Students.Count - 1;
                            if (result && id >= 0)
                            {
                                Students.RemoveAt(id);
                                Console.Write("\nStudent was deleted succsessfully.\n");
                            }
                            else
                            {
                                Console.Write("\nError! Invalid student id. \n");
                            }
                        }
                        catch
                        {
                            Console.Write("\nError! Invalid datatype. \n");
                        }
                        break;
                    case 3:
                        if(Students.Count > 0)
                        {
                            int i = 0;
                            foreach (Student stud in Students)
                            {
                                Console.WriteLine($"\nStudent ID: {i}");
                                stud.print();
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nList is empty!\n");
                        }
                        break;
                    case 0:
                        inMenu = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect option. Try again.");
                        break;
                }
            }
        }
    }
}
