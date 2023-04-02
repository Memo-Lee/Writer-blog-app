using Microsoft.AspNetCore.Mvc;
using WriterBusinessLayer.Concrete;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterApplication.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCoreCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
             
            return View(values);
        }
    }
}
