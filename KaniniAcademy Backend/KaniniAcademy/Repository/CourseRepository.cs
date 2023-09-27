using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class CourseRepository:ICourseRepository
    {
        private readonly KaniniAcademyContext _context;

        public CourseRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> getelements()
        {
            return _context.Courses.ToList();
        }
        public void postelements(Course course, IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                throw new ArgumentException("No file uploaded.");
            }

            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream);
                var imageData = memoryStream.ToArray();

                course.Image = imageData;

                _context.Courses.Add(course);
                _context.SaveChanges();
            }
        }
        public void delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Remove(course);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void update(int id, Course course)
        {
            var e = _context.Courses.Find(id);
            if (e != null)
            {
                e.CourseName = course.CourseName;
                e.CourseId = course.CourseId;
                e.CourseProvider = course.CourseProvider;
                e.Rating = course.Rating;


                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }Course ICourseRepository.GetCourseById(int courseId)
        {
           var c= _context.Courses.Find(courseId);
            return c;
        }
    }
}
