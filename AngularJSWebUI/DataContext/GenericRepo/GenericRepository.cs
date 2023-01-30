﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularJSWebUI.DataContext.GenericRepo
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private DemoContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new DemoContext();
            table = _context.Set<T>();
        }
        public GenericRepository(DemoContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}