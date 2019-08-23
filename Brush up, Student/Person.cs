using System;
using System.Collections.Generic;
using System.Text;

namespace Brush_up__Student
{
    public class Person
    {
        private string _name;
        private string _address;
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

        public GenderType Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nAddress: " + Address + "\nGender: " + Gender;
        }
    }

    public enum GenderType
    {
        Male, Female
    }
}
