using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> getblogs();
        void postblogs(Blog blog);
        void deleteblogs(int id);
        void updateblogs(int id, Blog blog);
    }
}
