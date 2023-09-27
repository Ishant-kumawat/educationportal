using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks.Dataflow;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsabilityController : ControllerBase
    {
        public readonly IUsability _irepository;
        public UsabilityController(IUsability repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Usability>> GetUsabilities()
        {

            try
            {
                var g = _irepository.GetUsabilities();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        public void postusability(Usability usability)
        {
            try
            {
                _irepository.postusability(usability);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try {
                var usability = _irepository.getbyid(id);

                if (usability == null)
                {
                    return NotFound($"Usability not found with ID = {id}");
                }

                return Ok(usability);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }



    }
}
