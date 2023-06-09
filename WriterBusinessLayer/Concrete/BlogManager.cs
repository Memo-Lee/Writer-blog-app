﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterBusinessLayer.Abstract;
using WriterDataAccess.Abstract;

namespace WriterBusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlog _blog;
        public BlogManager(IBlog blog)
        {
            _blog = blog;
        }
        public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

		public List<Blog> GetBlogListWithCategory()
		{
			return _blog.GetListWithCategory();
		}

		public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}
        public List<Blog> GetBlogByID(int id)
        {
			return _blog.GetListAll(i => i.BlogID == id);
        }
        public List<Blog> GetList()
		{
			return _blog.GetListAll();
		}
	}
}
