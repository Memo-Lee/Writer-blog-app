using Microsoft.AspNetCore.Mvc;
using WriterBusinessLayer.Concrete;
using WriterDataAccess.Concrete.EntityFramework;

namespace WriterApplication.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCoreCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);

            return View(values);
        }
    }
}
