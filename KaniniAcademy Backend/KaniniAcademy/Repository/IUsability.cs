using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IUsability
    { 
        IEnumerable<Usability> GetUsabilities();
        public Usability getbyid(int id);
        public void postusability(Usability usability);
    }
}
