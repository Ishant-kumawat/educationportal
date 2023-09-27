using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class CreatorRepository:ICreator
    {
        private readonly KaniniAcademyContext _context;

        public CreatorRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Creator> getcreators()
        {
            return _context.Creators.ToList();
        }
        public void postcreators(Creator creator)
        {
            _context.Creators.Add(creator);
            _context.SaveChanges();
        }
        public void deletecreators(int id)
        {
            var creator = _context.Creators.Find(id);
            if (creator != null)
            {
                _context.Remove(creator);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatecreators(int id, Creator creator)
        {
            var e = _context.Creators.Find(id);
            if (e != null)
            {
                e.CreatorId = creator.CreatorId;
                e.CreatorName = creator.CreatorName;
                e.CreatorJob = creator.CreatorJob;

                e.CreatorImage = creator.CreatorImage;
                e.Description = creator.Description;


                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
        public Creator GetCreatorById(int id)
        {
            var creator = _context.Creators.Find(id);
            return creator;
        }
    }
}
