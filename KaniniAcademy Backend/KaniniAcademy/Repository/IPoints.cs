namespace KaniniAcademy.Repository
{
    public interface IPoints
    {
        IEnumerable<Point> getpoints();
        void postpoints(Point point);
        void deletepoints(int id);
        void updatepoints(int id, Point point);
    }
}
