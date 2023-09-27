using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IAboutcertificatesRepository
    {
        IEnumerable<AboutTheCertificate> getaboutthecertificates();
        void postaboutthecertificates(AboutTheCertificate aboutthecertificates);
        void deleteaboutthecertificates(int id);
        void updateaboutthecertificate(int id, AboutTheCertificate aboutthecertificates);
    }
}
