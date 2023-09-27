using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class UserDetailsRepository:IUserDetails
    {
        private readonly KaniniAcademyContext _context;

        public UserDetailsRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<UserDetail> getuser()
        {
            return _context.UserDetails.ToList();
        }

        public void postuser(UserDetail userDetail)
        {
            _context.UserDetails.Add(userDetail);
            _context.SaveChanges();
        }

        public void deleteuser(int id)
        {
            var userDetail = _context.UserDetails.Find(id);
            if (userDetail != null)
            {
                _context.Remove(userDetail);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updateuser(string email, UserDetail userDetail)
        {
            var e = _context.UserDetails.FirstOrDefault(x => x.Email == email);
            if (e != null)
            {
               
                e.Password = userDetail.Password;
                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }
        public Course GetCourseById(int courseId)
        {
            throw new NotImplementedException();
        }

    }
}
