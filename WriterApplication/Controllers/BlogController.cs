using Microsoft.AspNetCore.Mvc;
using WriterBusinessLayer.Concrete;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterApplication.Controllers
{
    public class BlogController : Controller
    {
		BlogManager bm = new BlogManager(new EFCoreBlogRepository());

		public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();

            return View(values);
        }
        public IActionResult BlogDetails(int id) 
        {
            ViewBag.Id = id;
            var values = bm.GetBlogByID(id);

            return View(values);
        }
    }
}
