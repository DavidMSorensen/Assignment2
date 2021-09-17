using System;

namespace Library
{
    public class Student
    {
        public Student(int id){
            Id = id;
        }
        public int Id{get;}
        public string GivenName{get; set;}
        public string SurName{get; set;}
        public Status Status{get;}
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}
    }

    public enum Status{
        New, Active, Dropout, Graduated
    }
}
