using BlogProject.Areas.Admin.Models;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BlogProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list=new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 10
            });
            list.Add(new CategoryClass
            {
                categoryname = "Bilim",
                categorycount = 18
            });
            list.Add(new CategoryClass
            {
                categoryname = "Siyaset",
                categorycount = 3
            });
            list.Add(new CategoryClass
            {
                categoryname = "Askeri",
                categorycount = 11
            });
            return Json(new {jsonlist= list});
        }
    }
}
