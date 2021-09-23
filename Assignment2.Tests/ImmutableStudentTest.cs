using System;
using Xunit;
using Library;

namespace Assignment2.Tests
{
    public class ImmutableStudentTest
    {
        [Fact]
        public void Given_Two_Identical_ImmutableStudents_Assert_True_With_Equals()
        {
            //Arrange
            DateTime startDate = DateTime.Now.AddYears(-1);
            DateTime endDate = DateTime.Now.AddYears(2);
            DateTime graduationDate = DateTime.Now.AddYears(2);
           
            var imStudent1 = new ImmutableStudent()
            {
                Id = 2,
                GivenName = "Kim",
                SurName = "Larsen",
                StartDate = startDate,
                EndDate = endDate,
                GraduationDate = graduationDate
            };
            var imStudent2 = new ImmutableStudent()
            {
                Id = 2,
                GivenName = "Kim",
                SurName = "Larsen",
                StartDate = startDate,
                EndDate = endDate,
                GraduationDate = graduationDate
            };
            //Act
            var actual = imStudent1.Equals(imStudent2);
            
            //Assert
            Assert.True(actual);
        }
        [Fact]
        public void Given_Two_Identical_ImmutableStudents_Assert_True_With_EqualSigns()
        {
            //Arrange
            DateTime startDate = DateTime.Now.AddYears(-1);
            DateTime endDate = DateTime.Now.AddYears(2);
            DateTime graduationDate = DateTime.Now.AddYears(2);
            
            var imStudent1 = new ImmutableStudent()
            {
                Id = 2,
                GivenName = "Kim",
                SurName = "Larsen",
                StartDate = startDate,
                EndDate = endDate,
                GraduationDate = graduationDate
            };
            var imStudent2 = new ImmutableStudent()
            {
                Id = 2,
                GivenName = "Kim",
                SurName = "Larsen",
                StartDate = startDate,
                EndDate = endDate,
                GraduationDate = graduationDate
            };
            
            //Act
            var actual = imStudent1 == imStudent2;
            
            //Assert
            Assert.True(actual);
        }
        [Fact]
        public void Given_ImmutableStudent_Get_Nice_To_String()
        {
            //Arrange
            DateTime startDate = DateTime.Now.AddYears(-1);
            DateTime endDate = DateTime.Now.AddYears(2);
            DateTime graduationDate = DateTime.Now.AddYears(2);
            
            var imStudent = new ImmutableStudent()
            {
                Id = 2,
                GivenName = "Kim",
                SurName = "Larsen",
                StartDate = startDate,
                EndDate = endDate,
                GraduationDate = graduationDate
            };

            //Act
            var actual = imStudent.ToString();
            
            //Assert
            var expected =
                $"ImmutableStudent {{ Id = {imStudent.Id}, GivenName = {imStudent.GivenName}, SurName = {imStudent.SurName}, Status = {imStudent.Status}, StartDate = {imStudent.StartDate}, EndDate = {imStudent.EndDate}, GraduationDate = {imStudent.GraduationDate} }}";

            Assert.Equal(expected,actual);
        }
      
    }
}