using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Exercises.Entities
{
    public  enum DocumentType
    {
        Passport,
        DrivingLicence,
        IdCard
    }
    public class Customer : Person
    {
  

        public DocumentType DocumentType { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime DocumentExpire { get; set; }

        public bool IsSpecialGuest { get; set; }
    }
}
