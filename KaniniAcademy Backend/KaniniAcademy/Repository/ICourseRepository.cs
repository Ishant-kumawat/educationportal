using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ICourseRepository
    {
        
        IEnumerable<Course> getelements();
        void postelements(Course course, IFormFile file);
        void delete(int id);
        void update(int id, Course course);
        Course GetCourseById(int courseId);

    }
}
