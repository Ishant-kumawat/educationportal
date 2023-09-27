using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingController : ControllerBase
    {
        private readonly ITraining _irepository;
        public TrainingController(ITraining repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Training>> gett()
        {

            try
            {
                var g = _irepository.gettraining();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Training>> delete(int id)
        {

            _irepository.deletetraining(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Training>> update(int id, Training training)
        {
            _irepository.updatetraining(id, training);
            return Ok();
        }
        public class Trainingmodel
        {
            public int Tid { get; set; }
            public string? Description { get; set; }
            public IFormFile? VideoFile { get; set; }
            public IFormFile? ImageFile { get; set; }
            public string? Tname { get; set; }
            public string? Category { get; set; }
            public IFormFile? LogoFile { get; set; }
            public int? Duration { get; set; }
            public int CreatorID { get; set; }
            public string? Resources { get; set; }

 
        }
        [HttpPost]
        public async Task<IActionResult> Posttraining([FromForm] Trainingmodel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (model.ImageFile != null && model.ImageFile.Length > 0)
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            await model.ImageFile.CopyToAsync(memoryStream);
                            var imageData = memoryStream.ToArray();

                            byte[]? videoData = null;
                            if (model.VideoFile != null && model.VideoFile.Length > 0)
                            {
                                using (var videoStream = new MemoryStream())
                                {
                                    await model.VideoFile.CopyToAsync(videoStream);
                                    videoData = videoStream.ToArray();
                                }
                            }

                            byte[]? logoData = null;
                            if (model.LogoFile != null && model.LogoFile.Length > 0)
                            {
                                using (var logoStream = new MemoryStream())
                                {
                                    await model.LogoFile.CopyToAsync(logoStream);
                                    logoData = logoStream.ToArray();
                                }
                            }

                            var training = new Training
                            {
                                Tid = model.Tid,
                                Image = imageData,
                                Description = model.Description,
                                Category = model.Category,
                                Tname = model.Tname,
                                Duration = model.Duration,
                                Resources = model.Resources,
                                Video = videoData,
                                Logo = logoData,
                                CreatorId = model.CreatorID
                            };

                            try
                            {
                                _irepository.posttraining(training);
                                return Ok();
                            }
                            catch (Exception ex)
                            {
                                // Log the inner exception for debugging
                                while (ex.InnerException != null)
                                    ex = ex.InnerException;

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
            catch (Exception outerEx)
            {
               
                return BadRequest(outerEx.Message);
            }
        }
        [HttpGet("traning/{CreatorId}")]
        public IActionResult GetTDetailsByCId(int UserId)
        {

            var res = _irepository.GetTrainingByCreatorId(UserId);
            return Ok(res);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> getTrainingById(int id)
        {
            var tra=_irepository.gettrainingByid(id);
            if (tra != null)
            {
                return Ok(tra);

            }
            return NotFound();
        }
        [HttpGet("test/{id}")]
        public async Task<IActionResult> GetTrainingWithCreatorAsync(int id)
        {
            try
            {
                var training = await _irepository.GetTrainingWithCreatorAsync(id);

                return Ok(training);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
