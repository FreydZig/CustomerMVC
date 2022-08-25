using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerLIb.WebForm
{
    public partial class NoteAdd : System.Web.UI.Page
    {
        public IRepository<Notes> _noteRepository;

        public NoteAdd()
        {
            _noteRepository = new NotesRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickSave(object sender, EventArgs e)
        {
            var customerIDReq = Request.QueryString["customerID"];
            var note = new Notes()
            {
                CustomerId = Convert.ToInt32(customerIDReq),
                Note = noteTxt.Text
            };
            _noteRepository.Create(note);
            Response.Redirect("CustomerList.aspx");
        }
    }
}