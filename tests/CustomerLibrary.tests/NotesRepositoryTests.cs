using CustomerLIbrary.Entities;
using CustomerLIbrary.Repositories;
using Xunit;

namespace CustomerLibrary.tests
{
    //public class NotesRepositoryTests
    //{
    //    NotesRepositoryFixture Fixture => new NotesRepositoryFixture();

    //    [Fact]
    //    public void ShouldBeAbleToCreateNotesRepository()
    //    {
    //        var repository = new NotesRepository();
    //        Assert.NotNull(repository);
    //    }

    //    [Fact]
    //    public void ShouldBeAbleToCreateNotes()
    //    {
    //        Fixture.DeleteAll();
    //        var repository = new NotesRepository();
    //        var note = new Notes()
    //        {
    //            CustomerId = 127,
    //            Note = "c"
    //        };
    //        repository.Create(note);
    //    }

    //    [Fact]
    //    public void ShouldBeAbleToReadNotes()
    //    {
    //        Fixture.DeleteAll();
    //        var noteCustomer = Fixture.CreateNotesRepository().Read("16");
    //        Assert.Equal(16, noteCustomer.NoteId);
    //    }

    //    [Fact]
    //    public void ShouldNotBeAbleToReadNotes()
    //    {
    //        Fixture.DeleteAll();
    //        var noteCustomer = Fixture.CreateNotesRepository().Read("1");
    //        Assert.Null(noteCustomer);
    //    }

    //    [Fact]
    //    public void ShouldBeAbleToUodateNotes()
    //    {
    //        Fixture.DeleteAll();
    //        var notes = new Notes()
    //        {
    //            NoteId = 16,
    //            CustomerId = 127,
    //            Note = "b"
    //        };
    //        Fixture.CreateNotesRepository().Update(notes);
    //    }

    //    [Fact]
    //    public void ShouldBeAbleToDeleteCustomer()
    //    {
    //        var notes = new Notes()
    //        {
    //            CustomerId = 127,
    //            Note = "c"
    //        };
    //        Fixture.CreateNotesRepository().Create(notes);
    //        Fixture.CreateNotesRepository().Delete(notes.Note);
    //    }      
    //}
    //public class NotesRepositoryFixture
    //{
    //    public void DeleteAll()
    //    {
    //        var repository = new CustomerRepository();
    //        repository.DeleteAll();
    //    }

    //    public NotesRepository CreateNotesRepository()
    //    {
    //        return new NotesRepository();
    //    }
    //}
}
