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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsletterDal;
        public NewsLetterManager(INewsLetterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }
        public void Add(NewsLetter t)
		{
			_newsletterDal.Add(t);
		}

		public void Delete(NewsLetter t)
		{
			throw new NotImplementedException();
		}

        public NewsLetter GetById(int id)
        {
            throw new NotImplementedException();
        }

        public NewsLetter GetElementById(int id)
		{
			throw new NotImplementedException();
		}

		public List<NewsLetter> GetListAll()
		{
			throw new NotImplementedException();
		}

		public void Update(NewsLetter t)
		{
			throw new NotImplementedException();
		}
	}
}
