using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface ISubmission
    {
        IEnumerable<Submission> getsub();
        void postsub(Submission submission);
        void deletesub(int id);
        void updatesub(int id, Submission submission);
    }
}
