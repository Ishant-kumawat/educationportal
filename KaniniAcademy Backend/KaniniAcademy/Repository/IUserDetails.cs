using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IUserDetails
    {
        IEnumerable<UserDetail> getuser();
        void postuser(UserDetail userDetail);
        void deleteuser(int id);
        void updateuser(string email, UserDetail userDetail);
    }
}
