using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class SubmissionRepository:ISubmission
    {
        private readonly KaniniAcademyContext _context;

        public SubmissionRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Submission> getsub()
        {
            return _context.Submissions.ToList();
        }

        public void postsub(Submission submission)
        {
            _context.Submissions.Add(submission);
            _context.SaveChanges();
        }

        public void deletesub(int id)
        {
            var submission = _context.Submissions.Find(id);
            if (submission != null)
            {
                _context.Remove(submission);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatesub(int id, Submission submission)
        {
            var e = _context.Submissions.Find(id);
            if (e != null)
            {
                
                e.Work = submission.Work;


                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
    }
}
