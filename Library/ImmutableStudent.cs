using System;

namespace Library
{
    public record ImmutableStudent()
    {
        public int Id{get; init;}
        public string GivenName{get; init;}
        public string SurName{get; init;}
        public Status Status
        {
            get
            {
                if(DateTime.Now < StartDate.AddYears(1))
                    return Status.New;
                if(EndDate < GraduationDate)
                    return Status.Dropout;
                if (DateTime.Now > GraduationDate)
                    return Status.Graduated;
                return Status.Active;
            }
        }
        public DateTime StartDate{get; init;}
        public DateTime EndDate{get; init;}
        public DateTime GraduationDate{get; init;}
    }
}