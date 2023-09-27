using KaniniAcademy.Models;
namespace KaniniAcademy.Repository
{
    public interface INotes
    { 
        IEnumerable<Note> getnotes();
        void postnotes(Note note);
        void deletenotes(int id);
        void updatenotes(int id, Note note);
    }
}
