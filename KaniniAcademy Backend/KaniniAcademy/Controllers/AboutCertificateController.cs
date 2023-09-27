using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutCertificateController : ControllerBase
    {
        private readonly IAboutcertificatesRepository _irepository;

        public AboutCertificateController(IAboutcertificatesRepository repository)
        {
            _irepository = repository;
        }

        [HttpGet]

        public ActionResult<IEnumerable<AboutTheCertificate>> gett()
        {
            try
            {
                var ab = _irepository.getaboutthecertificates();
                return Ok(ab);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<AboutTheCertificate>> delete(int id)
        {
            _irepository.deleteaboutthecertificates(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<AboutTheCertificate>> update(int id, AboutTheCertificate aboutTheCertificate)
        {
            _irepository.updateaboutthecertificate(id, aboutTheCertificate);
            return Ok();
        }

        public class AboutTheCertificateModel
        {
            public int ImageId { get; set; }
            public IFormFile? Image1 { get; set; }
            public string? shareCert { get; set; }
            public IFormFile? Image2 { get; set; }
            public string? onlinecour { get; set; }
            public IFormFile? Image3 { get; set; }
            public string? schedule { get; set; }
            public IFormFile? Image4 { get; set; }
            public string? level { get; set; }
            public IFormFile? Image5 { get; set; }
            public string? approtime { get; set; }
            public IFormFile? Image6 { get; set; }
            public string? language { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> PostCreatorWithImage([FromForm] AboutTheCertificateModel model)
        {
            if (ModelState.IsValid)
            {

                var about = new AboutTheCertificate
                {
                    ImageId = model.ImageId,
                    shareCert = model.shareCert,
                    onlinecour = model.onlinecour,
                    schedule = model.schedule,
                    level = model.level,
                    approtime = model.approtime,
                    language = model.language,


                };
                try
                {
                    if (model.Image1 != null && model.Image1.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.Image1.CopyToAsync(memoryStream);
                            about.Image1 = memoryStream.ToArray();
                        }
                    }

                    if (model.Image2 != null && model.Image2.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.Image2.CopyToAsync(memoryStream);
                            about.Image2 = memoryStream.ToArray();
                        }
                    }

                    if (model.Image3 != null && model.Image3.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.Image3.CopyToAsync(memoryStream);
                            about.Image3 = memoryStream.ToArray();
                        }
                    }

                    if (model.Image4 != null && model.Image4.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.Image4.CopyToAsync(memoryStream);
                            about.Image4 = memoryStream.ToArray();
                        }
                    }

                    if (model.Image5 != null && model.Image5.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.Image5.CopyToAsync(memoryStream);
                            about.Image5 = memoryStream.ToArray();
                        }
                    }

                    if (model.Image6 != null && model.Image6.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.Image6.CopyToAsync(memoryStream);
                            about.Image6 = memoryStream.ToArray();
                        }
                    }

                    _irepository.postaboutthecertificates(about);
                    return Ok();
                }

                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
            else
            {
                return BadRequest(ModelState);
            }


        }
    }
}
