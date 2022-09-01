using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System.Web.Mvc;

namespace CustomerLIb.MVC.Controllers
{
    public class NotesController : Controller
    {

        private readonly IRepository<Notes> _notesRepository;

        private static int _customerId { get; set; }

        public NotesController()
        {
            _notesRepository = new NotesRepository();
        }

        // GET: Notes
        public ActionResult Index(int id)
        {
            _customerId = id;
            var notes = _notesRepository.GetAll(id.ToString());
            if(notes.Count > 0)
            return View(notes);
            else
                return RedirectToAction("Create", new { id = _customerId });
        }

        // GET: Notes/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Notes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notes/Create
        [HttpPost]
        public ActionResult Create(Notes notes)
        {
            try
            {
                _notesRepository.Create(notes);

                return RedirectToAction("Index", new { id = _customerId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Notes/Edit/5
        public ActionResult Edit(int id)
        {
            var note = _notesRepository.Read(id.ToString());
            return View(note);
        }

        // POST: Notes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Notes notes)
        {
            try
            {
                _notesRepository.Update(notes);

                return RedirectToAction("Index", new { id = _customerId });
            }
            catch
            {
                return View();
            }
        }

        // GET: Notes/Delete/5
        public ActionResult Delete(int id)
        {
            var note = _notesRepository.Read(id.ToString());
            return View(note);
        }

        // POST: Notes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                _notesRepository.Delete(id.ToString());

                return RedirectToAction("Index", new { id = _customerId });
            }
            catch
            {
                return View();
            }
        }
    }
}
