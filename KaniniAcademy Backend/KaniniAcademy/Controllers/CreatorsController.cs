using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreatorsController : ControllerBase
    {
        private readonly ICreator
            _irepository;
        public CreatorsController(ICreator repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Creator>> gett()
        {

            try
            {
                var g = _irepository.getcreators();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpGet("{id}")]
        
        public ActionResult<List<Creator>> GetCreatorById(int id)
        {
            var creator = _irepository.GetCreatorById(id);
            if (creator != null) 
            {
                return Ok(creator);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Creator>> delete(int id)
        {

            _irepository.deletecreators(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Creator>> update(int id, Creator creator)
        {
            _irepository.updatecreators(id, creator);
            return Ok();
        }
        public class Creatormodel
        {
            public int CreatorId { get; set; }
            public string? CreatorName { get; set; }
            public IFormFile? ImageFile { get; set; }
            public string? Description { get; set; }
            public string? CreatorJob { get; set; }
            public int? Followers { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> PostCreatorWithImage([FromForm] Creatormodel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.ImageFile.CopyToAsync(memoryStream);
                        var imageData = memoryStream.ToArray();

                        var creator = new Creator
                        {
                            CreatorId = model.CreatorId,
                            CreatorImage = imageData,
                            CreatorName = model.CreatorName,
                            CreatorJob = model.CreatorJob,
                            Followers = model.Followers,
                            Description = model.Description,


                        };

                        try
                        {
                            _irepository.postcreators(creator);
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
