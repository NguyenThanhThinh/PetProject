using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxMVC.Models
{
    public class AjaxContext:DbContext
    {
        public AjaxContext() : base("PetProject")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}