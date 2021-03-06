using BlogTemplate.Data;
using BlogTemplate.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogTemplate.BLL
{
    public class BlogManager
    {
        public static IEnumerable<Blog> GetAll()
        {
            var db = new BlogContext();
            var bl = db.Blogs.ToList();
            return bl;
        }

        //public static void Add(Blog blog)
        //{
        //    var db = new BlogContext();
        //    db.Blogs.Add(blog);
        //    db.SaveChanges();
        //}

        public static void update(Blog blog)
        {
            var db = new BlogContext();
            var origBlog = db.Blogs.Find(blog.BlogID);
            origBlog.Title = blog.Title;
            origBlog.Date = blog.Date;
            origBlog.Content = blog.Content;
            origBlog.Summary = blog.Summary;
            origBlog.HeadImage = blog.HeadImage;
            db.SaveChanges();
        }

        public static Blog Find(int id)
        {
            var db = new BlogContext();
            var blog = db.Blogs.Find(id);
            return blog;
        }

        public static void Delete(Blog blog)
        {
            try
            {
                var db = new BlogContext();
                db.Blogs.Remove(blog);
                db.SaveChanges();
            }
            catch
            {

            }
        }
    }
}
