using BlogProject.Areas.Admin.Models;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BlogProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class BlogController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult ExportDynamicExcelBlogList()
		{
			using (var workbook = new XLWorkbook())
			{
				var worksheet = workbook.Worksheets.Add("Blog Listesi");
				worksheet.Cell(1, 1).Value = "Blog ID";
				worksheet.Cell(1, 2).Value = "Blog Name";

				int BlogRowCount = 2;
				foreach(var item in BlogTitleList())
				{
					worksheet.Cell(BlogRowCount, 1).Value = item.BlogID;
					worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
					BlogRowCount++;
				}
				Context c= new Context();
				using(var stream=new MemoryStream())
				{
					workbook.SaveAs(stream);
					var content=stream.ToArray();
					return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogListesi.xlsx");
				}
			}
		}
		public List<BlogModel> BlogTitleList() { 
			List<BlogModel> bm = new List<BlogModel>();
		Context c=new Context();
			bm = c.Blogs.Select(x => new BlogModel
			{
				BlogID = x.BlogID,
				BlogName=x.BlogTitle,
			}).ToList();
			return bm;
	}
		public IActionResult BlogListExcel()
		{
			return View();
		}
}
}
