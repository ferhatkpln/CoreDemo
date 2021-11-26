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
        IBlogDAL _blogDAL;

        public BlogManager(IBlogDAL blogDAL)
        {
            _blogDAL = blogDAL;
        }

        public void AddBlog(Blog blog)
        {
            _blogDAL.Insert(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDAL.Delete(blog);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDAL.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _blogDAL.GetById(id);
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDAL.GetListAll(x => x.BlogID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDAL.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            //return _blogDAL.GetListAll().Take(3).ToList();
            return _blogDAL.GetListAll().OrderByDescending(i => i.BlogCreateDate).Take(3).ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDAL.Update(blog);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDAL.GetListAll(x=>x.WriterID==id);
        }
    }
}
