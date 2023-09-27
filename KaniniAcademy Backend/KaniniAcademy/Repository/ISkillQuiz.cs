using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ISkillQuiz
    {
        IEnumerable<SkillQuiz> getskill();
        void postskill(SkillQuiz skillQuiz);
        void deleteskill(int id);
        void updateskill(int id, SkillQuiz skillQuiz);
    }
}
