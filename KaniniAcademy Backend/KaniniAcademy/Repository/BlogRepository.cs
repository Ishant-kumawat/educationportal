using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class BlogRepository:IBlogRepository
    {
        private readonly KaniniAcademyContext _context;

        public BlogRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Blog> getblogs()
        {
            return _context.Blogs.ToList();
        }
        public void postblogs(Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }
        public void deleteblogs(int id)
        {
            var blog = _context.Blogs.Find(id);
            if (blog != null)
            {
                _context.Remove(blog);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updateblogs(int id, Blog blog)
        {
            var e = _context.Blogs.Find(id);
            if (e != null)
            {
                e.BlogId = blog.BlogId;
                e.Topic = blog.Topic;
                e.BlogCategory = blog.BlogCategory;
                e.DateOfUpload = blog.DateOfUpload;
                e.Description = blog.Description;
                e.Image = blog.Image;

                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }


    }
}
