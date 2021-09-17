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
        public Status Status
        {
            get
            {
                if(DateTime.Now < StartDate.AddYears(1)){
                    return Status.New;
                }else if(EndDate < GraduationDate){
                    return Status.Dropout;
                }else if(DateTime.Now > GraduationDate){
                    return Status.Graduated;
                } else {
                    return Status.Active;
                }
            }
        }
        public DateTime StartDate{get; set;}
        public DateTime EndDate{get; set;}
        public DateTime GraduationDate{get; set;}

        public override string ToString()
        {
            return $"Id: {Id}\nName: {GivenName}\nSurname: '{GivenName}'\nStatus: {Status}\nStart date: {StartDate}\nEnd date: {EndDate}\nGraduation date: {GraduationDate}";
        }
    }

    public enum Status{
        New, Active, Dropout, Graduated
    }
}