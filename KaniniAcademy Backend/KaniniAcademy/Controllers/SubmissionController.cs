using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmissionController : ControllerBase
    {
        private readonly ISubmission _irepository;
        public SubmissionController(ISubmission repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Submission>> gett()
        {

            try
            {
                var g = _irepository.getsub();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPost]
        public void post(Submission submission)
        {
            try
            {
                _irepository.postsub(submission);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Submission>> delete(int id)
        {

            _irepository.deletesub(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Submission>> update(int id, Submission submission)
        {
            _irepository.updatesub(id,submission);
            return Ok();
        }
    }
}
