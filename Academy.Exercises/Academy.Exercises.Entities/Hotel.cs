using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Exercises.Entities
{
    public class Hotel
    {
        public Building[] Buildings { get; set; }

        public Employee[] Employees { get; set; }

        public Customer[] Customers { get; set; }
    }
}
