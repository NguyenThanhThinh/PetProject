﻿using RepsitoryMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepsitoryMVC.Repositorys
{
    public class Repositorys<T> : IRepository<T> where T : class
    {
        protected StudentContext _db { get; set; }
        protected DbSet<T> _table = null;
        public Repositorys()
        {
            _db = new StudentContext();
            _table = _db.Set<T>();
        }
        public Repositorys(StudentContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }
        public IEnumerable<T> SelectAll()
        {
            return _table.ToList();
        }

        public T SelectById(object id)
        {
            try
            {
                return _table.Find(id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

       
        public void Update(T obj)
        {
            _table.Attach(obj);
            _db.Entry(obj).State = EntityState.Modified;
        }
    }
}