using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IQa
    {
        IEnumerable<Qa> getqa();
        void postqa(Qa qa);
        void deleteqa(int id);
        void updateqa(int id, Qa qa);
    }
}
