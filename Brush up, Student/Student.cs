using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up__Student
{
    public class Student
    {
        private string _name;
        private string _address;
        private int _semester;
        private GenderType _gender;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2)
                    throw new ArgumentException("Value cannot be less the 2 characters.", nameof(value));
                _name = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Value cannot be null or empty.", nameof(value));
                _address = value;
            }
        }

        public int Semester
        {
            get => _semester;
            set
            {
                if (value < 1 || value > 8) throw new ArgumentOutOfRangeException(nameof(value));
                _semester = value;
            }
        }

        public GenderType Gender
        {
            get => _gender;
            set => _gender = value;
        }
    }

    public enum GenderType
    {
        Male, Female
    }
}
