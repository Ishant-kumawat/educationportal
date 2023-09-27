using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IFreeResourse
    {

        IEnumerable<FreeResource> getfree();
        void postfree(FreeResource freeResource);
        void deletefree(int id);
        public FreeResource GetFreeResource(int id);
        void updatefree(int id, FreeResource freeResource);
    }
}
