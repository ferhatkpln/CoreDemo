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
    public class NewsLatterManager : INewsLatterService
    {
        INewsLatterDAL _newsLatterDAL;

        public NewsLatterManager(INewsLatterDAL newsLatterDAL)
        {
            _newsLatterDAL = newsLatterDAL;
        }

        public NewsLetter TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<NewsLetter> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(NewsLetter t)
        {
            _newsLatterDAL.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(NewsLetter t)
        {
            throw new NotImplementedException();
        }
    }
}
