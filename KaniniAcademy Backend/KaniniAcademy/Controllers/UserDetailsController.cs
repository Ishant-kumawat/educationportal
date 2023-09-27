using KaniniAcademy.Models;
using KaniniAcademy.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace KaniniAcademy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly IUserDetails _irepository;
        private readonly KaniniAcademyContext _context;
        public UserDetailsController(IUserDetails repository, KaniniAcademyContext context)
        {

            _irepository = repository;
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<UserDetail>> gett()
        {

            try
            {
                var g = _irepository.getuser();
                return Ok(g);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
        [HttpPost]
        public void post(UserDetail userDetail)
        {
            try
            {
                _irepository.postuser(userDetail);

            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<UserDetail>> delete(int id)
        {

            _irepository.deleteuser(id);
            return Ok();
        }
        [HttpPut("{email}")]
        public ActionResult<IEnumerable<UserDetail>> update(string email, UserDetail userDetail)
        {
            _irepository.updateuser(email, userDetail);
            return Ok();
        }
        [HttpGet("forgotPass")]
        public async Task<ActionResult> getUserByEmail(string email)
        {
            var user = _context.UserDetails.FirstOrDefault(x => x.Email == email);
            if (user == null)
            {
                return NotFound($"User Does'nt exists with email:- {email}");
            }
            return Ok(user);
        }

    }
}
