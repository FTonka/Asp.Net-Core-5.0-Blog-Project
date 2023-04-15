using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Comment
{
	public class CommentListByBlog : ViewComponent
	{
		CommentManager cmg = new CommentManager(new EfCommentRepository());
		public IViewComponentResult Invoke(int id)
		{
			var values = cmg.GetList(id);
			return View(values);
		}
	}
}
