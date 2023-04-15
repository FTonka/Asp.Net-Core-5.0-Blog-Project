using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void Add(Blog t)
		{
			_blogDal.Add(t);
		}

		public void Delete(Blog t)
		{
			_blogDal.Delete(t);
		}

		public List<Blog> GetBlogByID(int id)
		{
			return _blogDal.GetListAll(x => x.BlogID == id);
		}

		public List<Blog> GetBlogByWriter(int id)
		{
			return _blogDal.GetListAll(x => x.WriterID == id);
		}

		public Blog GetById(int id)
		{
			return _blogDal.GetById(id);
		}

		public List<Blog> GetListAll()
		{
			return _blogDal.GetAll();
		}

		public List<Blog> GetListWithCategory()
		{
			return _blogDal.GetBlogListWithCategory();
		}

		public void Update(Blog t)
		{
			_blogDal.Update(t);
		}
		public List<Blog> GetLast3Blog()
		{
			return _blogDal.GetAll().Take(3).ToList();
		}
		public List<Blog> GetBlogListWithCategoryByWriters(int id)
		{
			return _blogDal.GetBlogListWithCategoryByWriter(id);
		}
		
	}
}
