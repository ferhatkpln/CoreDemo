using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();
        public void Delete(T parametre)
        {
            c.Remove(parametre);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            return c.Set<T>().ToList();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public void Insert(T parametre)
        {
            c.Add(parametre);
            c.SaveChanges();
        }

        public void Update(T parametre)
        {
            c.Update(parametre);
            c.SaveChanges();
        }
    }
}
