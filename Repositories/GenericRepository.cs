using CV_MVC.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace CV_MVC.Repositories
{
    public class GenericRepository<T> where T: class,new()
    {
        DbCVEntities db = new DbCVEntities();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T obj)
        {
            db.Set<T>().Add(obj);
            db.SaveChanges();
        }


        public void TDelete(T obj)
        {
            db.Set<T>().Remove(obj);
            db.SaveChanges();
        }


        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T obj)
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}