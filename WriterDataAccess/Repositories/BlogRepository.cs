using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterDataAccess.Abstract;
using WriterDataAccess.Concrete;

namespace WriterDataAccess.Repositories
{
    public class BlogRepository : IBlog

    {
        public void AddBlog(Blog blog)
        {
            using var c = new WriterContext();
            c.Add(blog);
            c.SaveChanges();

        }

        public void DeleteBlog(Blog blog)
        {
            using var c = new WriterContext();
            c.Remove(blog);
            c.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var c = new WriterContext();
            return c.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog(Blog blog)
        {
            using var c = new WriterContext();
            return c.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var c = new WriterContext();
            c.Update(blog);
        }
    }
}
