using Microsoft.AspNetCore.Mvc;
using WriterBusinessLayer.Concrete;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterApplication.Controllers
{
    public class CategoryController : Controller
    {
        readonly CategoryManager cm = new CategoryManager(new EfCoreCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetList();

            return View(values);
        }
    }
}
