using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailedCertificateController : ControllerBase
    {
        private readonly IDetails _irepository;
         public DetailedCertificateController(IDetails irepository)
        {
            _irepository = irepository;
        }

        [HttpGet]

        public ActionResult<IEnumerable<DetailedCertificate>> gett()
        {
            try
            {
                var dc = _irepository.getdetailedcertificates();
                return Ok(dc);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<DetailedCertificate>> delete(int id)
        {
            _irepository.deletedetailedcertificates(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<DetailedCertificate>> update(int id, DetailedCertificate detailedCertificate)
        {
            _irepository.updatedetailedcertificates(id, detailedCertificate);
            return Ok();
        }

        public class DetailedCertificateModel
        {
            public int detailId { get; set; }
            public string? AboutAns1 { get; set; }
            public string? AboutAns2 { get; set; }
            public string? AboutAns3 { get; set; }
            public string? AboutAns4 { get; set; }
            public string? AboutAns5 { get; set; }
            public string? AboutAns6 { get; set; }
            public string? AboutAns7 { get; set; }
            public string? AboutAns8 { get; set; }
            public string? AboutAns9 { get; set; }
            public string? AboutAns10 { get; set; }
            public string? AboutAns11 { get; set; }
            public string? Work1 { get; set; }
            public string? WorkAns1 { get; set; }
            public string? Work2 { get; set; }
            public string? WorkAns2 { get; set; }
            public string? Work3 { get; set; }
            public string? WorkAns3 { get; set; }
            public string? FaqQues1 { get; set; }
            public string? FaqAns1 { get; set; }
            public string? FaqQues2 { get; set; }
            public string? FaqAns2 { get; set; }
            public string? FaqQues3 { get; set; }
            public string? FaqAns3 { get; set; }
            public string? FaqQues4 { get; set; }
            public string? FaqAns4 { get; set; }
            public string? FaqQues5 { get; set; }
            public string? FaqAns5 { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> postdetailedcertificate([FromForm] DetailedCertificateModel model)
        {
            if (ModelState.IsValid)
            {
                var detail = new DetailedCertificate
                {
                    detailId = model.detailId,
                    AboutAns1 = model.AboutAns1,
                    AboutAns2 = model.AboutAns2,
                    AboutAns3 = model.AboutAns3,
                    AboutAns4 = model.AboutAns4,
                    AboutAns5 = model.AboutAns5,
                    AboutAns6 = model.AboutAns6,
                    AboutAns7 = model.AboutAns7,
                    AboutAns8 = model.AboutAns8,
                    AboutAns9 = model.AboutAns9,
                    AboutAns10 = model.AboutAns10,
                    AboutAns11 = model.AboutAns11,
                    Work1 = model.Work1,
                    Work2 = model.Work2,
                    Work3 = model.Work3,
                    WorkAns1 = model.WorkAns1,
                    WorkAns2 = model.WorkAns2,
                    WorkAns3 = model.WorkAns3,
                    FaqQues1 = model.FaqQues1,
                    FaqAns1 = model.FaqAns1,
                    FaqQues2 = model.FaqQues2,
                    FaqAns2 = model.FaqAns2,
                    FaqQues3 = model.FaqQues3,
                    FaqAns3 = model.FaqAns3,
                    FaqQues4 = model.FaqQues4,
                    FaqAns4 = model.FaqAns4,
                    FaqQues5 = model.FaqQues5,
                    FaqAns5 = model.FaqQues5,
                };
                _irepository.postdetailedcertificates(detail);
                return Ok();
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }
}
