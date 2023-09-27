using KaniniAcademy.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace KaniniAcademy.Repository
{
    public class TrainingRepository:ITraining
    {
        private readonly KaniniAcademyContext _context;

        public TrainingRepository(KaniniAcademyContext context)
        {
            _context = context;
        }

        public IEnumerable<Training> gettraining()
        {
            return _context.Training.ToList();
        }

        public void posttraining(Training training)
        {
            _context.Training.Add(training);
            _context.SaveChanges();
        }

        public void deletetraining(int id)
        {
            var training = _context.Training.Find(id);
            if (training != null)
            {
                _context.Remove(training);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatetraining(int id, Training training)
        {
            var e = _context.Training.Find(id);
            if (e != null)
            {
                e.Tid = training.Tid;
                e.Duration = training.Duration;
                e.Category = training.Category;
                e.Description = training.Description;
                e.Image = training.Image;
                e.Video = training.Video;
                e.Logo = training.Logo;
                e.Resources = training.Resources;
                e.Tname = training.Tname;



                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
        public async Task<Training> GetTrainingWithCreatorAsync(int id)
        {
            return await _context.Training
            .Include(training => training.Creator)
            .FirstOrDefaultAsync(training => training.Tid == id);
        }
        public List<Training> GetTrainingByCreatorId(int CreatorId)
        {
            var training = _context.Training.Where(t => t.CreatorId == CreatorId).ToList();
            return training;
        }
        public Training gettrainingByid(int id)
        {
            var training = _context.Training.Find(id);
            return training;

        }
    }
}
