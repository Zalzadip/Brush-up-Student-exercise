using System;
using System.Collections.Generic;
using System.Text;
using Brush_up__Student;
using Xunit;

namespace XUnitTestProject1
{
    public class TeacherTest
    {
        Teacher teacher = new Teacher();
        [Fact]
        public void TeacherNotNull()
        {
            teacher.Name = "Morten";
            Assert.NotEmpty(teacher.Name);
        }

        [Fact]
        public void TeacherArgumentException()
        {
            Assert.Throws<ArgumentException>(() => teacher.Name = "M");
            Assert.Throws<ArgumentException>(() => teacher.Address = null);
            Assert.Throws<ArgumentOutOfRangeException>(() => teacher.Salary = 0);
        }

        [Fact]
        public void Gender()
        {
            teacher.Gender = GenderType.Male;
            Assert.True(teacher.Gender == GenderType.Male);
        }
    }
}
