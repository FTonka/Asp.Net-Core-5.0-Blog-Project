using BusinessLayer.Concrete;
using BusinessLayer.Fluent_Validation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cmg = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cmg.GetListAll().ToPagedList(page, 3);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category c)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult result = cv.Validate(c);
            if (result.IsValid)
            {
                c.CategoryStatus = true;
                cmg.Add(c);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                
            }
			return View();

		}
        public IActionResult MakePassive(int id) {
            var value = cmg.GetById(id);
            value.CategoryStatus = false;
            cmg.Update(value);
            return RedirectToAction("Index", "Category");
        
        
        }
    }
}
