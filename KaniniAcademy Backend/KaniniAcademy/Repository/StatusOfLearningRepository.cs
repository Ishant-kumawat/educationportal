using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class StatusOfLearningRepository:IStatusOfLearning
    {
        private readonly KaniniAcademyContext _context;

        public StatusOfLearningRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<StatusOfLearner> getstatus()
        {
            return _context.StatusOfLearners.ToList();
        }

        public void poststatus(StatusOfLearner statusOfLearner)
        {
            _context.StatusOfLearners.Add(statusOfLearner);
            _context.SaveChanges();
        }

        public void deletestatus(int id)
        {
            var statusOfLearner = _context.StatusOfLearners.Find(id);
            if (statusOfLearner != null)
            {
                _context.Remove(statusOfLearner);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatestatus(int id, StatusOfLearner statusOfLearner)
        {
            var e = _context.StatusOfLearners.Find(id);
            if (e != null)
            {
                e.StatusId = statusOfLearner.StatusId;
                e.CourseCompletion = statusOfLearner.CourseCompletion;




                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
