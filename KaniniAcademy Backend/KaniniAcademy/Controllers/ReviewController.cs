using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        private readonly IReview _irepository;
        public ReviewController(IReview repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Review>> gett()
        {
            try
            {
                var g = _irepository.getreview();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public void post(Review review)
        {
            try
            {
                review.CreatedAt = DateTime.Now; 

                _irepository.postreview(review);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Review>> delete(int id)
        {

            _irepository.deletereview(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Review>> update(int id, Review review)
        {
            _irepository.updatereview(id, review);
            return Ok();
        }

    }
}
