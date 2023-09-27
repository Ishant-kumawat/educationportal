using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class DetailsRepository:IDetails
    {
        private readonly KaniniAcademyContext _context;

        public DetailsRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<DetailedCertificate> getdetailedcertificates()
        {
            return _context.DetailedCertificates.ToList();
        }
        public void postdetailedcertificates(DetailedCertificate detailedCertificate)
        {
            _context.DetailedCertificates.Add(detailedCertificate);
            _context.SaveChanges();
        }
        public void deletedetailedcertificates(int id)
        {
            var detailcert = _context.DetailedCertificates.Find(id);
            if (detailcert != null)
            {
                _context.Remove(detailcert);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }

        public void updatedetailedcertificates(int id, DetailedCertificate detailedCertificate)
        {
            var d = _context.DetailedCertificates.Find(id);
            if (d != null)
            {
                d.detailId = detailedCertificate.detailId;
                d.AboutAns1 = detailedCertificate.AboutAns1;
                d.AboutAns2 = detailedCertificate.AboutAns2;
                d.AboutAns3 = detailedCertificate.AboutAns3;
                d.AboutAns4 = detailedCertificate.AboutAns4;
                d.AboutAns5 = detailedCertificate.AboutAns5;
                d.AboutAns6 = detailedCertificate.AboutAns6;
                d.AboutAns7 = detailedCertificate.AboutAns7;
                d.AboutAns8 = detailedCertificate.AboutAns8;
                d.AboutAns9 = detailedCertificate.AboutAns9;
                d.AboutAns10 = detailedCertificate.AboutAns10;
                d.AboutAns11 = detailedCertificate.AboutAns11;
                d.Work1 = detailedCertificate.Work1;
                d.WorkAns1 = detailedCertificate.WorkAns1;
                d.Work2 = detailedCertificate.Work2;
                d.WorkAns2 = detailedCertificate.WorkAns2;
                d.Work3 = detailedCertificate.Work3;
                d.WorkAns3 = detailedCertificate.WorkAns3;
                d.FaqQues1 = detailedCertificate.FaqQues1;
                d.FaqAns1 = detailedCertificate.FaqAns1;
                d.FaqQues2 = detailedCertificate.FaqQues2;
                d.FaqAns2 = detailedCertificate.FaqAns2;
                d.FaqQues3 = detailedCertificate.FaqQues3;
                d.FaqAns3 = detailedCertificate.FaqAns3;
                d.FaqQues4 = detailedCertificate.FaqQues4;
                d.FaqAns4 = detailedCertificate.FaqAns4;
                d.FaqQues5 = detailedCertificate.FaqQues5;
                d.FaqAns5 = detailedCertificate.FaqAns5;
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
