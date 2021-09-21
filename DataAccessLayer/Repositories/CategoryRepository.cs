using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDAL
    {
        Context sqlContext = new Context();

        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public Category CategoryGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> CategoryListAll()
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category parametre)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category parametre)
        {
            throw new NotImplementedException();
        }

        public void Update(Category parametre)
        {
            throw new NotImplementedException();
        }
    }
}
