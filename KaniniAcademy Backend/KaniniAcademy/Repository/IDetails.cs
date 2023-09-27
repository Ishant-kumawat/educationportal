using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IDetails
    {
       IEnumerable<DetailedCertificate> getdetailedcertificates();
        void deletedetailedcertificates(int id);
        void postdetailedcertificates(DetailedCertificate detailedCertificate);
        void updatedetailedcertificates(int id, DetailedCertificate detailedCertificate);
    }
}
