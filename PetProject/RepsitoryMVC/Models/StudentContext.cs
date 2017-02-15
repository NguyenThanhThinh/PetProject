using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepsitoryMVC.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("RepositoryMVC")
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}