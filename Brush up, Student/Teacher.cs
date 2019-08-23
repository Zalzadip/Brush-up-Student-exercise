using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up__Student
{
    class Teacher: Person
    {
        private float _salary;

        public float Salary
        {
            get => _salary;
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException(nameof(value));
                _salary = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary: " + Salary;
        }
    }
}
