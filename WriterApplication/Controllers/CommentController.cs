using Microsoft.AspNetCore.Mvc;
using WriterBusinessLayer.Concrete;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterApplication.Controllers
{
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCoreCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		public PartialViewResult PartialAddComment()
		{
			return	PartialView();
		}
		public PartialViewResult CommentListByBlog(int id)
		{
			var values = cm.GetList(id);

			return PartialView(values);
		}

	}
}
