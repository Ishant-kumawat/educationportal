using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class QaRepository:IQa
    {
        private readonly KaniniAcademyContext _context;

        public QaRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Qa> getqa()
        {
            return _context.Qas.ToList();
        }

        public void postqa(Qa qa)
        {
            _context.Qas.Add(qa);
            _context.SaveChanges();
        }

        public void deleteqa(int id)
        {
            var qa = _context.Qas.Find(id);
            if (qa != null)
            {
                _context.Remove(qa);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updateqa(int id, Qa qa)
        {
            var e = _context.Qas.Find(id);
            if (e != null)
            {
                e.Qid = qa.Qid;
                /*e.QuizId= qa.QuizId;*/
                e.Question = qa.Question;
                e.Hint = qa.Hint;
                e.Op1 = qa.Op1;
                e.Op2 = qa.Op2;
                e.Op3 = qa.Op3;
                e.Op4 = qa.Op4;
                /*e.Qid = option.Qid;*/
                e.Ans = qa.Ans;


                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }


    }
}
