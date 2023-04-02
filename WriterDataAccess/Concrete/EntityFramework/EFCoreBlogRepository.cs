using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterDataAccess.Abstract;
using WriterDataAccess.Repositories;

namespace WriterDataAccess.Concrete.EntityFramework
{
	public class EFCoreBlogRepository : GenericRepository<Blog>, IBlog
	{
		public List<Blog> GetListWithCategory()
		{
			using (var context = new WriterContext())
			{
				return context.Blogs.Include(i => i.Category).ToList();	
			}
		}
	}
}
