using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificationRepository _irepository;
        public CertificateController(ICertificationRepository repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Certificate>> gett()
        {

            try
            {
                var g = _irepository.getcertificates();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Certificate>> delete(int id)
        {

            _irepository.deletecertificates(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Certificate>> update(int id, Certificate certificate)
        {
            _irepository.updatecertificates(id, certificate);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> getcertificatebyid(int id)
        {
            var tra = _irepository.getcertificateByid(id);
            if (tra != null)
            {
                return Ok(tra);

            }
            return NotFound();
        }
        public class Certificatemodel
        {
            public int Cid { get; set; }
            public string? Cname { get; set; }
            public int? Duration { get; set; }
            public string? Projects { get; set; }
            public int? Videoduration { get; set; }
            public IFormFile? ImageFile { get; set; }
            public string? TrainingFormat { get; set; }
            public string? CertificatePass { get; set; }
            public string? KeySkills { get; set; }
            public string? Description { get; set; }

            
        }
        [HttpPost]
        public async Task<IActionResult> PostCreatorWithImage([FromForm] Certificatemodel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.ImageFile.CopyToAsync(memoryStream);
                        var imageData = memoryStream.ToArray();

                        var certificate = new Certificate
                        {
                            Cid = model.Cid,
                            Image = imageData,
                            Description = model.Description,
                            Cname = model.Cname,
                            Projects=model.Projects,
                            Duration = model.Duration,
                            VideosDuration = model.Videoduration,
                            KeySkills=model.KeySkills,
                            TrainingFormat = model.TrainingFormat,
                            CertificatePass = model.CertificatePass

                        };

                        try
                        {
                            _irepository.postcertificates(certificate);
                            return Ok();
                        }
                        catch (Exception ex)
                        {
                            return BadRequest(ex.Message);
                        }
                    }
                }
                else
                {
                    return BadRequest("Image file is required.");
                }
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
