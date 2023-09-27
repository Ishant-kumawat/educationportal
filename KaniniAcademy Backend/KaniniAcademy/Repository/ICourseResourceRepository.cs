using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ICourseResourceRepository
    {
        IEnumerable<CourseResource> getresources();
        void postresources(CourseResource courseResource);
        void deleteresources(int id);
        void updateresources(int id, CourseResource courseResource);
    }
}
