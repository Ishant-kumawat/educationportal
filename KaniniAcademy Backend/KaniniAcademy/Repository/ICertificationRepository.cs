using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ICertificationRepository
    {
       
        IEnumerable<Certificate> getcertificates();
        void postcertificates(Certificate certificate);
        void deletecertificates(int id);
        void updatecertificates(int id, Certificate certificate);
        Certificate getcertificateByid(int id);
    }
}
