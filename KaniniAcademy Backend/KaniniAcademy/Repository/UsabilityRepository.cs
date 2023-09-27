using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class UsabilityRepository:IUsability
    {
        private readonly KaniniAcademyContext _context;

        public UsabilityRepository(KaniniAcademyContext context)
        {
            _context = context;
        }

        public IEnumerable<Usability> GetUsabilities()
        {
            return _context.Usability.ToList();
        }
        public void postusability(Usability usability)
        {
            _context.Usability.Add(usability);
            _context.SaveChanges();
        }
        public Usability getbyid(int id)
        {
            var usability = _context.Usability.Find(id);
            return usability;
        }


    }
}
