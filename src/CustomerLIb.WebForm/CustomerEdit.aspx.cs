using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System;

namespace CustomerLIb.WebForm
{
    public partial class CustomerEdit : System.Web.UI.Page
    {
        private IRepository<Customer> _customerRepositiry;

        public CustomerEdit()
        {
            _customerRepositiry = new CustomerRepository();
        }

        public CustomerEdit(IRepository<Customer> customerRepositiry)
        {
            _customerRepositiry = customerRepositiry;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var customerIDReq = Request.QueryString["customerID"];
                if (customerIDReq != null)
                {
                    var customer = _customerRepositiry.Read(customerIDReq);
                    customerID.Text = customerIDReq;
                    customerFirstName.Text = customer.FirstName;
                    customerLastName.Text = customer.LastName;
                    customerEmail.Text = customer.Email;
                    customerPhoneNumber.Text = customer.PhoneNumber;
                    customerTotalPurchasesAmount.Text = customer.TotalPurchasesAmount.ToString();
                }
            }         
        }

        public void OnClickSave(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                CustomerId = Convert.ToInt32(customerID?.Text),
                FirstName = customerFirstName?.Text,
                LastName = customerLastName?.Text,  
                PhoneNumber = customerPhoneNumber?.Text,
                Email = customerEmail?.Text,
                TotalPurchasesAmount = Convert.ToDecimal(customerTotalPurchasesAmount?.Text)
            };
            _customerRepositiry.Update(customer);
            Response.Redirect("CustomerList.aspx");
        }
    }
}