using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static KaniniAcademy.Controllers.CreatorsController;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillQuizController : ControllerBase
    {
        private readonly ISkillQuiz _irepository;
        public SkillQuizController(ISkillQuiz repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<SkillQuiz>> gett()
        {

            try
            {
                var g = _irepository.getskill();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<SkillQuiz>> delete(int id)
        {

            _irepository.deleteskill(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<SkillQuiz>> update(int id, SkillQuiz skillQuiz)
        {
            _irepository.updateskill(id, skillQuiz);
            return Ok();
        }
        public class Skillmodel
        {
            public int QuizId { get; set; }
            public string? Subject { get; set; }
            public string? Topic { get; set; }
            public IFormFile? ImageFile { get; set; }
        }
        [HttpPost]
        public async Task<IActionResult> PostSkillWithImage([FromForm] Skillmodel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.ImageFile.CopyToAsync(memoryStream);
                        var imageData = memoryStream.ToArray();

                        var skillQuiz = new SkillQuiz
                        {
                            QuizId = model.QuizId,
                            Thumbnail = imageData,
                            Subject = model.Subject,
                            Topic = model.Topic,
                           

                        };

                        try
                        {
                            _irepository.postskill(skillQuiz);
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
