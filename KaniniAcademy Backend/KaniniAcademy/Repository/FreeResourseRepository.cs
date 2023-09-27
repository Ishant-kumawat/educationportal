using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class FreeResourseRepository:IFreeResourse
    {
        private readonly KaniniAcademyContext _context;

        public FreeResourseRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<FreeResource> getfree()
        {
            return _context.FreeResources.ToList();
        }
        public FreeResource GetFreeResource(int id)
        {
            var resource = _context.FreeResources.Find(id);
            return resource;
        }
        public void postfree(FreeResource freeResource)
        {
            _context.FreeResources.Add(freeResource);
            _context.SaveChanges();
        }
        public void deletefree(int id)
        {
            var freeResource = _context.FreeResources.Find(id);
            if (freeResource != null)
            {
                _context.Remove(freeResource);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatefree(int id, FreeResource freeResource)
        {
            var e = _context.FreeResources.Find(id);
            if (e != null)
            {
                e.FreeRid = freeResource.FreeRid;
                e.Title = freeResource.Title;
                e.Description = freeResource.Description;
                e.Category = freeResource.Category;
                e.Book = freeResource.Book;
                e.Video = freeResource.Video;
                e.Downloads = freeResource.Downloads;
                e.Thumbnail = freeResource.Thumbnail;
                e.Template = freeResource.Template;

                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
