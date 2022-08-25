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
    public partial class AddressList : System.Web.UI.Page
    {
        public IRepository<Address> _addressRepository { get; set; }
        public List<Address> Address { get; set; }

        public AddressList()
        {
            _addressRepository = new AddresRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LoadAddressFromDB();
        }

        public void LoadAddressFromDB()
        {
            var customerIDReq = Request.QueryString["customerID"];
            Address = _addressRepository.GetAll(customerIDReq);
        }
    }
}