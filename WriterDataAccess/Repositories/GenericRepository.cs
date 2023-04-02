using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WriterDataAccess.Abstract;
using WriterDataAccess.Concrete;

namespace WriterDataAccess.Repositories
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        public void Delete(T TItem)
        {
            using var c = new WriterContext();
            c.Remove(TItem);
            c.SaveChanges();
        }

        public List<T> GetListAll()
        {
            using var c = new WriterContext();
            return c.Set<T>().ToList();
        }
		public List<T> GetListAll(Expression<Func<T, bool>> filter)
		{
            using var c = new WriterContext();
            return c.Set<T>().Where(filter).ToList();
		}
		public T GetById(int id)
        {
            using var c = new WriterContext();
            return c.Set<T>().Find(id);
        }

        public void Insert(T TItem)
        {
            using var c = new WriterContext();
            c.Add(TItem);
            c.SaveChanges();
        }

        public void Update(T TItem)
        {
            using var c = new WriterContext();
            c.Update(TItem);
            c.SaveChanges();
        }

		
	}
}
