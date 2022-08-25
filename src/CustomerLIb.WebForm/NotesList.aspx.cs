using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System;
using System.Collections.Generic;

namespace CustomerLIb.WebForm
{
    public partial class NotesList : System.Web.UI.Page
    {
        public IRepository<Notes> _notesRepository { get; set; }
        public List<Notes> Notes { get; set; }

        public NotesList()
        {
            _notesRepository = new NotesRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadNotesFromDB();
        }

        public void LoadNotesFromDB()
        {
            var customerIDReq = Request.QueryString["customerID"];
            if (customerIDReq == null) throw new Exception("Null");
            Notes = _notesRepository.GetAll(customerIDReq);
        }
    }
}