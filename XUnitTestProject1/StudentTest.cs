using System;
using System.Collections.Generic;
using System.Text;
using Brush_up__Student;
using Xunit;

namespace XUnitTestProject1
{
    public class StudentTest
    {
        Student student = new Student();

        [Fact]
        public void StudentNotNull()
        {
            student.Name = "Morten";
            Assert.NotEmpty(student.Name);
        }

        [Fact]
        public void StudentArgumentException()
        {
            Assert.Throws<ArgumentException>(() => student.Name = "M");
            Assert.Throws<ArgumentException>(() => student.Address = null);
            Assert.Throws<ArgumentOutOfRangeException>(() => student.Semester = 0);
        }

        [Fact]
        public void Gender()
        {
            student.Gender = GenderType.Male;
            Assert.True(student.Gender == GenderType.Male);
        }
    }
}
