using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class PointsRepository:IPoints
    {
        private readonly KaniniAcademyContext _context;

        public PointsRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Point> getpoints()
        {
            return _context.Points.ToList();
        }
        public void postpoints(Point point)
        {
            _context.Points.Add(point);
            _context.SaveChanges();
        }
        public void deletepoints(int id)
        {
            var point = _context.Points.Find(id);
            if (point != null)
            {
                _context.Remove(point);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatepoints(int id, Point point)
        {
            var e = _context.Points.Find(id);
            if (e != null)
            {
                /*e.Qid = point.Qid;
                e.Uid = point.Uid;*/
                e.Date = point.Date;
                e.Points = point.Points;


                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
