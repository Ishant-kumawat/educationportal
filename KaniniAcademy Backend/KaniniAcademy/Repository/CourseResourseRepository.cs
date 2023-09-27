using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class CourseResourseRepository:ICourseResourceRepository
    {
        private readonly KaniniAcademyContext _context;

        public CourseResourseRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<CourseResource> getresources()
        {
            return _context.CourseResources.ToList();
        }
        public void postresources(CourseResource courseResource)
        {
            _context.CourseResources.Add(courseResource);
            _context.SaveChanges();
        }

        public void deleteresources(int id)
        {
            var courseResource = _context.CourseResources.Find(id);
            if (courseResource != null)
            {
                _context.Remove(courseResource);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updateresources(int id, CourseResource courseResource)
        {
            var e = _context.CourseResources.Find(id);
            if (e != null)
            {
                e.CourseId = courseResource.CourseId;
                e.Review = courseResource.Review;
                e.Resources = courseResource.Resources;
                e.Description = courseResource.Description;
                e.Video = courseResource.Video;
                e.Thumbnail = courseResource.Thumbnail;
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
    }
}
