using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class ReviewRepository:IReview
    {
        private readonly KaniniAcademyContext _context;

        public ReviewRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Review> getreview()
        {
            return _context.Reviews.ToList();
        }

        public void postreview(Review review)
        {
            _context.Reviews.Add(review);
            _context.SaveChanges();
        }

        public void deletereview(int id)
        {
            var review = _context.Reviews.Find(id);
            if (review != null)
            {
                _context.Remove(review);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatereview(int id, Review review)
        {
            var e = _context.Reviews.Find(id);
            if (e != null)
            {
                /*e.Tid= review.Tid;*/
                e.Description = review.Description;
                e.UserId = review.UserId;
                e.CourseId = review.CourseId;



                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
