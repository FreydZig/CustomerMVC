using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System;

namespace CustomerLIb.WebForm
{
    public partial class AddresAdd : System.Web.UI.Page
    {
        public IRepository<Address> _addresRepository;

        public AddresAdd()
        {
            _addresRepository = new AddresRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClickSave(object sender, EventArgs e)
        {
            var customerIDReq = Request.QueryString["customerID"];
            var addres = new Address()
            {
                CustomerId = Convert.ToInt32(customerIDReq),
                AddressLine = addresAddresLine.Text,
                AddressLine2 = addresAddresLine2.Text,
                AddressType = addresAddresType.Text,
                City = addresCity.Text,
                PostalCode = addresPostalCode.Text,
                State = addresState.Text,
                Country = addresCountry.Text
            };
            _addresRepository.Create(addres);
            Response.Redirect("CustomerList.aspx");
        }
    }
}