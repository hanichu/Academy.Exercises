﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Exercises.Entities
{
    public class Employee : Person
    {
        public string Job { get; set; }

        public decimal Salary { get; set; }
    }
}
