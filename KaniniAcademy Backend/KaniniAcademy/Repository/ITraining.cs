using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ITraining
    {
        IEnumerable<Training> gettraining();
        void posttraining(Training training);
        void deletetraining(int id);
        void updatetraining(int id, Training training);
        Training gettrainingByid(int id);
        Task<Training> GetTrainingWithCreatorAsync(int id);
        //get training with creator id
        public List<Training> GetTrainingByCreatorId(int CreatorId);
    }
}
