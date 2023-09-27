using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IStatusOfLearning
    {   IEnumerable<StatusOfLearner> getstatus();
        void poststatus(StatusOfLearner statusOfLearner);
        void deletestatus(int id);
        void updatestatus(int id, StatusOfLearner statusOfLearner);
    }
}
