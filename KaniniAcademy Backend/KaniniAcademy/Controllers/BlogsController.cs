using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IBlogRepository _irepository;
        public BlogsController(IBlogRepository repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Blog>> gett()
        {

            try
            {
                var g = _irepository.getblogs();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
         [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Blog>> delete(int id)
        {

            _irepository.deleteblogs(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Blog>> update(int id, Blog blog)
        {
            _irepository.updateblogs(id, blog);
            return Ok();
        }
        public class BlogUploadModel
        {
            public int BlogId { get; set; }
            public IFormFile? ImageFile { get; set; }
            public string? Description { get; set; }
            public string? Topic { get; set; }
            public DateTime? DateOfUpload { get; set; } = DateTime.UtcNow;
            public string? BlogCategory { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> PostBlogWithImage([FromForm] BlogUploadModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await model.ImageFile.CopyToAsync(memoryStream);
                        var imageData = memoryStream.ToArray();

                        var blog = new Blog
                        {
                            BlogId = model.BlogId,
                            Image = imageData,
                            Description = model.Description,
                            DateOfUpload = model.DateOfUpload,
                            Topic = model.Topic,
                            BlogCategory = model.BlogCategory,


                        };

                        try
                        {
                            _irepository.postblogs(blog);
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


