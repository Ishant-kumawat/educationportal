using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ICtcReg
    {
        IEnumerable<CtcReg> getctc();
        void postctc(CtcReg ctcReg);
        void deletectc(int id);
        void updatectc(int id, CtcReg ctcReg);

    }
}
