using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System;
using System.Collections.Generic;

namespace CustomerLIb.WebForm
{
    public partial class CustomerList : System.Web.UI.Page
    {
        public IRepository<Customer> _customerRepository { get; set; }
        public List<Customer> Customers { get; set; }            

        public CustomerList()
        {
            _customerRepository = new CustomerRepository();
        }

        public CustomerList(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomersFromDatabase();
            Delete();
        }

        public void LoadCustomersFromDatabase()
        {
            Customers = _customerRepository.GetAll("");   
        }

        protected void Delete()
        {
            var customerIDReq = Request.QueryString["customerID"];
            if (customerIDReq != null) 
            {
                NotesRepository notesRepository = new NotesRepository();
                AddresRepository addresRepository = new AddresRepository();
                notesRepository.DeleteAll(customerIDReq);
                addresRepository.DeleteAll(customerIDReq);
                _customerRepository.Delete(customerIDReq);
                Response.Redirect("CustomerList.aspx");
            }
        }
    }
}