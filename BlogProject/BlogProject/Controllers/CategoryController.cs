using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cmg=new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cmg.GetListAll();
            return View(values);
        }
    }
}
