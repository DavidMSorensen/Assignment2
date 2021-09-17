using System;
using Xunit;
using Library;

namespace Assignment2.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Given_Student_Get_Nice_To_String()
        {
            // Arrange
            DateTime startDate = DateTime.Now.AddYears(-1);
            DateTime endDate = DateTime.Now.AddYears(2);
            DateTime graduationDate = DateTime.Now.AddYears(2);
            
            var student = new Student(2){
                GivenName = "Kim",
                SurName = "Larsen",
                StartDate = startDate,
                EndDate = endDate,
                GraduationDate = graduationDate
            };

            // Act
            var actual = student.ToString();

            // Assert
            var expected = $"Id: {student.Id}\nName: {student.GivenName}\nSurname: '{student.SurName}'\nStatus: {student.Status}\nStart date: {student.StartDate}\nEnd date: {student.EndDate}\nGraduation date: {student.GraduationDate}";
            Assert.Equal(expected,actual);
        }
    
        [Fact]
        public void Student_given_6_months_return_status_new()
        {
        //Arrange
        var student = new Student(1);
        student.StartDate = DateTime.Now.AddMonths(-6);
        
        //Act
        var actual = student.Status;
        
        //Assert
        var expected = Status.New;
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void Student_given_2_years_return_status_active()
        {
        //Arrange
        var student = new Student(1);
        student.StartDate = DateTime.Now.AddYears(-2);
        student.GraduationDate = DateTime.Now.AddYears(1);
        student.EndDate = DateTime.Now.AddYears(1);

        //Act
        var actual = student.Status;
        
        //Assert
        var expected = Status.Active;
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void Student_given_4_years_return_status_graduated()
        {
        //Arrange
        var student = new Student(1);
        student.StartDate = DateTime.Now.AddYears(-4);
        student.GraduationDate = DateTime.Now.AddYears(-1);
        student.EndDate = DateTime.Now.AddYears(-1);

        //Act
        var actual = student.Status;
        
        //Assert
        var expected = Status.Graduated;
        Assert.Equal(expected, actual);
        }

        [Fact]
        public void Student_given_endDate_before_graduationDate_returns_dropout()
        {
        //Arrange
        var student = new Student(1);
        student.StartDate = DateTime.Now.AddYears(-4);
        student.GraduationDate = DateTime.Now.AddYears(-1);
        student.EndDate = DateTime.Now.AddYears(-2);

        //Act
        var actual = student.Status;
        
        //Assert
        var expected = Status.Dropout;
        Assert.Equal(expected, actual);
        }
    }
}
