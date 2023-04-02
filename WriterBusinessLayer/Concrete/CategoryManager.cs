using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterBusinessLayer.Abstract;
using WriterDataAccess.Abstract;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterBusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategory _category;
        public CategoryManager(ICategory category)
        {
            _category = category;
        }

        public void CategoryAdd(Category category)
        {
            _category.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _category.Delete(category);
        }

        public List<Category> GetList()
        {
            return _category.GetListAll();
        }

        public void CategoryUpdate(Category category)
        {
            _category.Update(category);
        }

        public Category GetById(int id)
        {
            return _category.GetById(id);
        }
    }
}
