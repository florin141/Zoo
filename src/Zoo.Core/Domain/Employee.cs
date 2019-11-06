﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Core.Domain
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Picture { get; set; }
    }
}
