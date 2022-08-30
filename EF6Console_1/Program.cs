﻿using EF6Console.DAL;
using EF6Console.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}