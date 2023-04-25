﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericUoWRepository<T> : IGenericUoWDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUoWRepository(Context context)
        {
            _context = context;
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _context.Add(t);

        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t); //Birden fazla yere güncelleme işlemi yaptırır.
        }

        public void Update(T t)
        {
            _context.Update(t);
        }
    }
}
