using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseResourceController : ControllerBase
    {

        private readonly ICourseResourceRepository _irepository;
        public CourseResourceController(ICourseResourceRepository repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CourseResource>> gett()
        {

            try
            {
                var g = _irepository.getresources();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<CourseResource>> delete(int id)
        {

            _irepository.deleteresources(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<CourseResource>> update(int id, CourseResource courseResource)
        {
            _irepository.updateresources(id, courseResource);
            return Ok();
        }
        public class CourseResoursemodel
        {
            public int CourseResourceID { get; set; }
            public IFormFile? ImageFile { get; set; }
            public IFormFile? VideoFile { get; set; }
            public string? Description { get; set; }
            public string? Review { get; set; }
            public string? Resources { get; set; }
        }
        [HttpPost]
        public async Task<IActionResult> PostCreatorWithImage([FromForm] CourseResoursemodel model)
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
                        var courseResource = new CourseResource
                        {
                            CourseResourceID = model.CourseResourceID,
                            Thumbnail = imageData,
                            Description = model.Description,
                            Review = model.Review,
                           
                            Resources = model.Resources,
                          
                            Video = videoData,
                           
                        };

                        try
                        {
                            _irepository.postresources(courseResource);
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
