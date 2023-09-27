using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _irepository;
        public CourseController(ICourseRepository repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Course>> gett()
        {

            try
            {
                var g = _irepository.getelements();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        } 
        public class CourseInputModel
        {
            public int CourseId { get; set; }
            public string? CourseName { get; set; }
            public string? CourseProvider { get; set; }
            public int? Rating { get; set; }
            public IFormFile? File { get; set; }
            public int? CreatorID { get; set; }
        }
        [HttpPost]
        [Route("postelements")]
        public IActionResult postelements([FromForm] CourseInputModel inputModel)
        {
            try
            {
                var course = new Course
                {
                    CourseId = inputModel.CourseId,
                    CourseName = inputModel.CourseName,
                    CourseProvider = inputModel.CourseProvider,
                    Rating = inputModel.Rating,
                    CreatorId = inputModel.CreatorID
                    
                    
                };

                _irepository.postelements(course, inputModel.File);

                return Ok("Course created successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var course = _irepository.GetCourseById(id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Course>> delete(int id)
        {

            _irepository.delete(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Course>> update(int id, Course course)
        {
            _irepository.update(id, course);
            return Ok();
        }
    }
}
