using Entity_Framework_Core.Entities;
using Entity_Framework_Core.Persistence;

Console.WriteLine("eNtitiy framework core");
NoteMasterDbContext _context = new();

_context.Notes.Add(new("note 1"));
_context.Notes.Add(new("note 2"));
_context.Notes.Add(new("note 3"));

_context.SaveChanges();

List<Note> notes = _context.Notes.ToList();

using (var _context = new NoteMasterDbContext())
{
    var newNotes = new List<Note>
    {
        new Note { Text = "note 4" },
        new Note { Text = "note 5" },
        new Note { Text = "note 6" }
    };
  
    _context.Notes.AddRange(newNotes);
    _context.SaveChanges();
}


using var context = new NoteMasterDbContext();

var blog = context.Notes.OrderBy(e => e.Text).Include(e => e.).First();

context.Remove(notes);

context.SaveChanges();
var noteToUpdate = context.Notes.FirstOrDefault(n => n.Text=="text"); 

if (noteToUpdate != null)
{
    noteToUpdate.Text = "ths text write for uplading my project"; 

    context.SaveChanges();
    Console.WriteLine("Note uploaded.");
}

foreach (Note product in Notes)
{
    Console.WriteLine(notes);
}

_context.SaveChanges();

