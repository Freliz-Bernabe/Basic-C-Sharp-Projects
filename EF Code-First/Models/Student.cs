﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Code_First.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public Grade grade { get; set; }
    }
}