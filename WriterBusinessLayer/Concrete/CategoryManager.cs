using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteEntity.Concrete;
using WriterBusinessLayer.Abstract;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterBusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCoreCategoryRepository efCoreCategoryRepository;

        public CategoryManager()
        {
            efCoreCategoryRepository = new EfCoreCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {
            efCoreCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            efCoreCategoryRepository.Delete(category);
        }

        public List<Category> CategoryListAll()
        {
            return efCoreCategoryRepository.GetAllList();
        }

        public void CategoryUpdate(Category category)
        {
            efCoreCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
            return efCoreCategoryRepository.GetById(id);
        }
    }
}
