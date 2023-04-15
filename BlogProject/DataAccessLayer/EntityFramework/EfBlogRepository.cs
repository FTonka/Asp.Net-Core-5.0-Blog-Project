using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
	{
		Context c = new Context();
		public List<Blog> GetBlogListWithCategory()
		{
			return c.Blogs.Include(x => x.Category).ToList();
		}

		public List<Blog> GetBlogListWithCategoryByWriter(int id)
		{
			return c.Blogs.Include(x=>x.Category).Where(x=>x.WriterID == id).ToList();
		}
	}
}
