﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BMSAS_Tracking.Desktop
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Position { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}