using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ICreator
    {
        
        IEnumerable<Creator> getcreators();
        void postcreators(Creator creator);
        void deletecreators(int id);
        void updatecreators(int id, Creator creator);
        Creator GetCreatorById(int creatorId);
    }
}
