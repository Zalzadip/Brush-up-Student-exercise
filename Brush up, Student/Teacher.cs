using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up__Student
{
    public class Teacher: Person
    {
        private double _salary;

        public double Salary
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
