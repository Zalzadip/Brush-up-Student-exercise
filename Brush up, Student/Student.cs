using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up__Student
{
    public class Student : Person
    {
        private int _semester;

        public int Semester
        {
            get => _semester;
            set
            {
                if (value < 1 || value > 8) throw new ArgumentOutOfRangeException(nameof(value));
                _semester = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSemester: " + Semester;
        }

        public override bool Equals(object obj)
        {
            return (float)obj == 10;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
