using BusinessLayer.Concrete;
using BusinessLayer.Fluent_Validation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bmg = new BlogManager(new EfBlogRepository());
        Context context = new Context();

        public IActionResult Index()
        {
            var values = bmg.GetListWithCategory();
            return View(values);
        }
        
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values=bmg.GetBlogByID(id);
            return View(values);
        }
        public IActionResult GetBlogsByWriter() {
            var usermail = User.Identity.Name;
            Context c = new Context();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = bmg.GetBlogListWithCategoryByWriters(writerID);
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBlog()
        {
            CategoryManager cmg=new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues=(from x in cmg.GetListAll() select new SelectListItem
            {
                Text=x.CategoryName,
                Value=x.CategoryID.ToString()
            }).ToList();
            ViewBag.cav = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult AddBlog(Blog b)
        {
            
            var usermail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            BlogValidator bv = new BlogValidator();
            ValidationResult result = bv.Validate(b);
            if (result.IsValid) { 
                    b.BlogStatus = true;
                    b.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    b.WriterID = writerID;
                    bmg.Add(b);
                return RedirectToAction("GetBlogsByWriter", "Blog");
            }
            else
            {
                foreach(var item in result.Errors) {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            }
            return View();
        }
        public IActionResult DeleteBlog(int id) {
            var DBlog = bmg.GetById(id);
            bmg.Delete(DBlog);
            return RedirectToAction("GetBlogsByWriter", "Blog");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            CategoryManager cmg = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in cmg.GetListAll()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cav = categoryValues;
            var value = bmg.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog b)
        {
            var usermail = User.Identity.Name;
            var writerID = context.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            b.WriterID = writerID;
            bmg.Update(b);
            return RedirectToAction("GetBlogsByWriter", "Blog");
        }



	}
}
