using System;
using Xunit;
using Library;

namespace Assignment2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Library_Student_Constructor_follows_rules()
        {
            var student = new Student(12);
            student.id = 2;
        }
    }
}
