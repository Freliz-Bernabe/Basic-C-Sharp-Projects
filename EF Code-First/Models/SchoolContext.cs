using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Code_First.Models
{
    public class SchoolContext
    {
        public SchoolContext() : base()
            {

            }

            public DbSet<Student> Students { get; set; }
            public DbSet<Grade> Grades { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}