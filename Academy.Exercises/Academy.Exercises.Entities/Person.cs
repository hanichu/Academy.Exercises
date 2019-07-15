using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Exercises.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
