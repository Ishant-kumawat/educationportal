using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointsController : ControllerBase
    {

        private readonly IPoints _irepository;
        public PointsController(IPoints repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Point>> gett()
        {

            try
            {
                var g = _irepository.getpoints();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPost]
        public void post(Point point)
        {
            try
            {
                _irepository.postpoints(point);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Point>> delete(int id)
        {

            _irepository.deletepoints(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Point>> update(int id, Point point)
        {
            _irepository.updatepoints(id,point);
            return Ok();
        }
    }
}
