using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System;

namespace CustomerLIb.WebForm
{
    public partial class CustomerAdd : System.Web.UI.Page
    {
        private IRepository<Customer> _customerRepositiry;

        public CustomerAdd()
        {
            _customerRepositiry = new CustomerRepository();
        }

        public CustomerAdd(IRepository<Customer> customerRepositiry)
        {
            _customerRepositiry = customerRepositiry;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickSave(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                FirstName = customerFirstName?.Text,
                LastName = customerLastName?.Text,
                PhoneNumber = customerPhoneNumber?.Text,
                Email = customerEmail?.Text,
                TotalPurchasesAmount = Convert.ToDecimal(customerTotalPurchasesAmount?.Text)
            };
            _customerRepositiry.Create(customer);
            Response.Redirect("CustomerList.aspx");
        }
    }
}