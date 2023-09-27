using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusofLearnerController : ControllerBase
    {

        private readonly IStatusOfLearning _irepository;
        public StatusofLearnerController(IStatusOfLearning repository)
        {
            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<StatusOfLearner>> gett()
        {

            try
            {
                var g = _irepository.getstatus();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public void post(StatusOfLearner statusOfLearner)
        {
            try
            {
                _irepository.poststatus(statusOfLearner);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<StatusOfLearner>> delete(int id)
        {

            _irepository.deletestatus(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<StatusOfLearner>> update(int id, StatusOfLearner statusOfLearner)
        {
            _irepository.updatestatus(id, statusOfLearner);
            return Ok();
        }
    }
}
