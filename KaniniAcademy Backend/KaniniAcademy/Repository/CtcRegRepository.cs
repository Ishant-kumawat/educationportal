using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class CtcRegRepository:ICtcReg
    {

        private readonly KaniniAcademyContext _context;

        public CtcRegRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<CtcReg> getctc()
        {
            return _context.CtcRegs.ToList();
        }
        public void postctc(CtcReg ctcReg)
        {
            _context.CtcRegs.Add(ctcReg);
            _context.SaveChanges();
        }

        public void deletectc(int id)
        {
            var ctcReg = _context.CtcRegs.Find(id);
            if (ctcReg != null)
            {
                _context.Remove(ctcReg);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatectc(int id, CtcReg ctcReg)
        {
            var e = _context.CtcRegs.Find(id);
            if (e != null)
            {
                /*e.Tid = ctcReg.Tid;
                e.Cid = ctcReg.Cid;*/
                e.CourseId = ctcReg.CourseId;
                e.UserId = ctcReg.UserId;

                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
    }
}
