using System;
using System.Diagnostics;
using Brush_up__Student;
using Xunit;

namespace XUnitTestProject1
{
    public class PersonTest
    {
        Person person = new Person();

        [Fact]
        public void PersonNotNull()
        {
            person.Name = "Morten";
            Assert.NotEmpty(person.Name);
        }

        [Fact]
        public void PersonArgumentException()
        {
            Assert.Throws<ArgumentException>(() => person.Name = "M");
            Assert.Throws<ArgumentException>(() => person.Address = null);
        }

        [Fact]
        public void Gender()
        {
            person.Gender = GenderType.Male;
            Assert.True(person.Gender == GenderType.Male);
        }
    }
}
