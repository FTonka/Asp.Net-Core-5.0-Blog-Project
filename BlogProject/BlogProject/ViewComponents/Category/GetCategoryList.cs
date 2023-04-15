using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents.Category
{
	public class GetCategoryList:ViewComponent
	{
		CategoryManager cmg1 = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke()
		{
			var values = cmg1.GetListAll();
			return View(values);

		}
	}
}
