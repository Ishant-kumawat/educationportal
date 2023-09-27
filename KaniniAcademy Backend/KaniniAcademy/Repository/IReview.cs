using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface IReview
    {
       
        IEnumerable<Review> getreview();
        void postreview(Review review);
        void deletereview(int id);
        void updatereview(int id, Review review);

    }
}
