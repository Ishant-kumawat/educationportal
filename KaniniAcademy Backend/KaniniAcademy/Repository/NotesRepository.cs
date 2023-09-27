using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public class NotesRepository:INotes
    {
        private readonly KaniniAcademyContext _context;

        public NotesRepository(KaniniAcademyContext context)
        {
            _context = context;
        }
        public IEnumerable<Note> getnotes()
        {
            return _context.Notes.ToList();
        }
        public void postnotes(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }
        public void deletenotes(int id)
        {
            var note = _context.Notes.Find(id);
            if (note != null)
            {
                _context.Remove(note);
                _context.SaveChanges();
            }
            else
            {

                throw new NotImplementedException("not found");
            }
        }
        public void updatenotes(int id, Note note)
        {
            var e = _context.Notes.Find(id);
            if (e != null)
            {
                e.Description = note.Description;
                e.Category = note.Category;
                e.UserId = note.UserId;


                _context.SaveChanges();
            }
            else
            {
                throw new NotImplementedException("not found");
            }

        }

    }
}
