using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class AboutCertificateRepository : IAboutcertificatesRepository
    {
        private readonly KaniniAcademyContext _context;

        public AboutCertificateRepository(KaniniAcademyContext context)
        {
            _context = context;
        }

        public IEnumerable<AboutTheCertificate> getaboutthecertificates()
        {
            return _context.AboutTheCertificates.ToList();
        }

        public void postaboutthecertificates(AboutTheCertificate aboutthecertificates)
        {
            _context.AboutTheCertificates.Add(aboutthecertificates);
            _context.SaveChanges();
        }

        public void deleteaboutthecertificates(int id)
        {
            var aboutcert = _context.AboutTheCertificates.Find(id);
            if (aboutcert != null)
            {
                _context.Remove(aboutcert);
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }
        }

        public void updateaboutthecertificate(int id, AboutTheCertificate aboutthecertificates)
        {
            var e = _context.AboutTheCertificates.Find(id);
            if (e != null)
            {
               
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }
        }
    }
}
