using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;

namespace WriterBusinessLayer.Abstract
{
	public interface IBlogService
	{
		void BlogAdd(Blog blog);
		void BlogUpdate(Blog blog);
		void BlogDelete(Blog blog);
		List<Blog> GetList();
		Blog GetById(int id);
		List<Blog> GetBlogListWithCategory();
	}
}
