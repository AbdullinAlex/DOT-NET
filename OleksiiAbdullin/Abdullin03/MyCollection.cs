using System.Collections;
using System.Collections.Generic;

namespace Abdullin03
{
    public class MyCollection : IEnumerable
    {
        private List<Student> _studentsArray = new List<Student>();

        public void Add(Student student)
        {
            if (student is null)
            {
                student = new Student();
            }
            _studentsArray.Add(student);
        }

        public bool Remove(int id)
        {
            if (id >= _studentsArray.Count || 0 > id)
            {
                return false;
            }
            _studentsArray.RemoveAt(id);
            return true; 
        }

        public void Clear()
        {
            _studentsArray.Clear();
        }
        public Student GetStudentById(int id)
        {
            int i = 0;
            if (id >= _studentsArray.Count || 0 > id)
            {
                return null;
            }
            foreach (var stud in _studentsArray)
            {
                if (id == i)
                {
                    return stud;
                }
            }
            return null;
        }

        public Student GetStudent(Student student)
        {
            foreach (var stud in _studentsArray)
            {
                if (stud.Equals(student))
                {
                    return student;
                }
            }
            return null;
        }
        public List<Student> GetStudents()
        {
            return _studentsArray;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public MyCollectionEnum GetEnumerator()
        {
            return new MyCollectionEnum(_studentsArray);
        }
    }
}
