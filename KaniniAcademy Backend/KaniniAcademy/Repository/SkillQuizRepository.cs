using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class SkillQuizRepository:ISkillQuiz
    {
        private readonly KaniniAcademyContext _context;

        public SkillQuizRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<SkillQuiz> getskill()
        {
            return _context.SkillQuizzes.ToList();
        }

        public void postskill(SkillQuiz skillQuiz)
        {
            _context.SkillQuizzes.Add(skillQuiz);
            _context.SaveChanges();
        }

        public void deleteskill(int id)
        {
            var skillQuiz = _context.SkillQuizzes.Find(id);
            if (skillQuiz != null)
            {
                _context.Remove(skillQuiz);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updateskill(int id, SkillQuiz skillQuiz)
        {
            var e = _context.SkillQuizzes.Find(id);
            if (e != null)
            {
                e.Subject = skillQuiz.Subject;
                e.Topic = skillQuiz.Topic;
                e.Thumbnail = skillQuiz.Thumbnail;
                e.QuizId = skillQuiz.QuizId;




                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
    }
}
