using Library.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            using (var _context = new LibraryContext())
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            using (var _context = new LibraryContext())
            {
                var entity = _context.Set<TEntity>().Find(id);
                if(entity != null)
                {
                    _context.Set<TEntity>().Remove(entity);
                    _context.SaveChanges();
                }
            }
        }

        public List<TEntity> GetAll()
        {
            using (var _context = new LibraryContext())
            {
                return _context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var _context = new LibraryContext())
            {
                return _context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
            using(var _context = new LibraryContext())
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges(); 
            }
        }
    }
}
