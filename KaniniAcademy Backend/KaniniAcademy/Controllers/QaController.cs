using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QaController : ControllerBase
    {
        private readonly IQa _irepository;
        public QaController(IQa repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Qa>> gett()
        {

            try
            {
                var g = _irepository.getqa();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPost]
        public void post(Qa qa)
        {
            try
            {
                _irepository.postqa(qa);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Qa>> delete(int id)
        {

            _irepository.deleteqa(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Qa>> update(int id, Qa qa)
        {
            _irepository.updateqa(id, qa);
            return Ok();
        }
    }
}
