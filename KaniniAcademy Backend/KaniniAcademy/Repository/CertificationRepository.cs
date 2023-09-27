using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class CertificationRepository:ICertificationRepository
    {
        private readonly KaniniAcademyContext _context;

        public CertificationRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Certificate> getcertificates()
        {
            return _context.Certificates.ToList();
        }

        public void postcertificates(Certificate certificate)
        {
            _context.Certificates.Add(certificate);
            _context.SaveChanges();
        }

        public void deletecertificates(int id)
        {
            var certificate = _context.Certificates.Find(id);
            if (certificate != null)
            {
                _context.Remove(certificate);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public Certificate getcertificateByid(int id)
        {
            var certificate = _context.Certificates.Find(id);
            return certificate;

        }
        public void updatecertificates(int id, Certificate certificate)
        {
            var e = _context.Certificates.Find(id);
            if (e != null)
            {
                e.Projects = certificate.Projects;
                e.Cid = certificate.Cid;
                e.Image = certificate.Image;
                e.Description = certificate.Description;
                e.VideosDuration = certificate.VideosDuration;
                e.Cname = certificate.Cname;
                e.Duration = certificate.Duration;
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
