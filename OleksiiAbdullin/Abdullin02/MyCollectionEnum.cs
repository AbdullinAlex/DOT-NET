using System;
using System.Collections;
using System.Collections.Generic;

namespace Abdullin02
{
    public class MyCollectionEnum : IEnumerator
    {
        public List<Student> Stud;

        int position = -1;
        public MyCollectionEnum(List<Student> stud)
        {
            Stud = stud;
        }

        public bool MoveNext()
        {
            position++;
            return (position < Stud.Count);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Student Current
        {
            get
            {
                try
                {
                    return Stud[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
