using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CtcRegController : ControllerBase
    {
        private readonly ICtcReg _irepository;
        public CtcRegController(ICtcReg repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<CtcReg>> gett()
        {

            try
            {
                var g = _irepository.getctc();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPost]
        public void post(CtcReg ctcReg)
        {
            try
            {
                _irepository.postctc(ctcReg);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<CtcReg>> delete(int id)
        {

            _irepository.deletectc(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<CtcReg>> update(int id, CtcReg ctcReg)
        {
            _irepository.updatectc(id, ctcReg);
            return Ok();
        }

    }
}
