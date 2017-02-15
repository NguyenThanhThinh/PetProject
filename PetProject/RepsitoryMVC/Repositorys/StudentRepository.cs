using RepsitoryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepsitoryMVC.Repositorys
{
    public class StudentRepository:Repositorys<Student>
    {
        public List<Student> Search(string name)
        {
            if (string.IsNullOrEmpty(name)) return null;

            var students = this.SelectAll().ToList();

            var search = students.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();

            return search;
        }
    }
}