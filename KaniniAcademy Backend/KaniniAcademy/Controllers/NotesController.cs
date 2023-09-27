using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {

        private readonly INotes _irepository;
        public NotesController(INotes repository)
        {

            _irepository = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Note>> gett()
        {

            try
            {
                var g = _irepository.getnotes();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPost]
        public void post(Note note)
        {
            try
            {
                _irepository.postnotes(note);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Note>> delete(int id)
        {

            _irepository.deletenotes(id);
            return Ok();



        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Note>> update(int id, Note note)
        {
            _irepository.updatenotes(id, note);
            return Ok();
        }

    }
}
