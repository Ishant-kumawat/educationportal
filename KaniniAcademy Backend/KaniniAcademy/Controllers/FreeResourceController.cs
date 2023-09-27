using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreeResourceController : ControllerBase
    {

        private readonly IFreeResourse _irepository;
        public FreeResourceController(IFreeResourse repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<FreeResource>> gett()
        {

            try
            {
                var g = _irepository.getfree();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpGet("{id}")]
        public ActionResult<ICollection<FreeResource>> GetResource(int id)
        {
            var res = _irepository.GetFreeResource(id);
            return Ok(res);
        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<FreeResource>> delete(int id)
        {

            _irepository.deletefree(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<FreeResource>> update(int id, FreeResource freeResource)
        {
            _irepository.updatefree(id, freeResource);
            return Ok();
        }
        public class Freeresourcemodel
        {
            public int FreeRid { get; set; }
            public string? Title { get; set; }
            public string? Category { get; set; }
            public int? Downloads { get; set; }
            public string? Description { get; set; }
            public IFormFile? ImageFile { get; set; }
            public string? Book { get; set; }
            public string? Template { get; set; }
            public IFormFile? VideoFile { get; set; }
            public string? Mainfeature { get; set; }
            public int? CreatorId { get; set; }
            public Creator Creator { get; set; }

        }
        [HttpPost]
        public async Task<IActionResult> PostFreeResource([FromForm] Freeresourcemodel model)
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
                        var freeResource = new FreeResource
                        {
                            FreeRid = model.FreeRid,
                            Thumbnail = imageData,
                            Title = model.Title,
                            Category = model.Category,
                            Description = model.Description,
                            Downloads=model.Downloads,
                            Book=model.Book,
                            Template=model.Template,
                            Video=videoData,
                            mainfeature=model.Mainfeature,
                            CreatorId=model.CreatorId,
                        };

                        try
                        {
                            _irepository.postfree(freeResource);
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
