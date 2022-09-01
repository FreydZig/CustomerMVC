using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace CustomerLIb.MVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly IRepository<Address> _addressRepository;

        private static int _customerId { get; set; }

        public AddressController()
        {
            _addressRepository = new AddresRepository();
        }

        // GET: Address/5
        public ActionResult Index(int id)
        {
            _customerId = id;
            var address = _addressRepository.GetAll(id.ToString());
            if (address.Count > 0)
            return View(address);
            else
                return RedirectToAction("Create", new { id = _customerId });
        }

        // GET: Address/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Address/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/Create
        [HttpPost]
        public ActionResult Create(Address address)
        {
            try
            {
                _addressRepository.Create(address);
                return RedirectToAction("Index",new { id = _customerId });
            }
            catch
            {
                if(address.AddressLine.Length > 100 || string.IsNullOrWhiteSpace(address.AddressLine))
                    ModelState.AddModelError("", "Address Line length should be more 0 and less 100!");
                if (address.AddressLine.Length > 100)
                    ModelState.AddModelError("", "Address Line length should be less 100!");
                if (address.AddressType != "Billing" || address.AddressType != "Shipping")
                    ModelState.AddModelError("", "Address Type should be Billing or Shipping!");
                if(address.Country != "USA" || address.Country != "Canada")
                    ModelState.AddModelError("", "Country should be USA or Canada!");
                if(!string.IsNullOrWhiteSpace(address.City))
                    if (address.City.Length > 50)
                        ModelState.AddModelError("", "City length should be less 50!");
                if (!string.IsNullOrWhiteSpace(address.PostalCode))
                {
                    if (!Regex.IsMatch(address.PostalCode, @"[0-9]{6}"))
                        ModelState.AddModelError("", "Postal Code should be looks like 123456!");
                }
                else
                    ModelState.AddModelError("", "Postal Code is Empty!");
                if(!string.IsNullOrWhiteSpace(address.State))
                    if (address.State.Length > 20)
                        ModelState.AddModelError("", "State length should be less 20!");

                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            var addres = _addressRepository.Read(id.ToString());
            return View(addres);
        }

        // POST: Address/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Address address)
        {
            try
            {
                _addressRepository.Update(address);

                return RedirectToAction("Index", new { id = _customerId });
            }
            catch
            {
                if (address.AddressLine.Length > 100 || string.IsNullOrWhiteSpace(address.AddressLine))
                    ModelState.AddModelError("", "Address Line length should be more 0 and less 100!");
                if (address.AddressLine.Length > 100)
                    ModelState.AddModelError("", "Address Line length should be less 100!");
                if (address.AddressType != "Billing" || address.AddressType != "Shipping")
                    ModelState.AddModelError("", "Address Type should be Billing or Shipping!");
                if (address.Country != "USA" || address.Country != "Canada")
                    ModelState.AddModelError("", "Country should be USA or Canada!");
                if (!string.IsNullOrWhiteSpace(address.City))
                    if (address.City.Length > 50)
                        ModelState.AddModelError("", "City length should be less 50!");
                if (!string.IsNullOrWhiteSpace(address.PostalCode))
                {
                    if (!Regex.IsMatch(address.PostalCode, @"[0-9]{6}"))
                        ModelState.AddModelError("", "Postal Code should be looks like 123456!");
                }
                else
                    ModelState.AddModelError("", "Postal Code is Empty!");
                if (!string.IsNullOrWhiteSpace(address.State))
                    if (address.State.Length > 20)
                        ModelState.AddModelError("", "State length should be less 20!");
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            var addres = _addressRepository.Read(id.ToString());
            return View(addres);
        }

        // POST: Address/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Address address)
        {
            try
            {
                _addressRepository.Delete(id.ToString());

                return RedirectToAction("Index", new { id = _customerId });
            }
            catch
            {
                return View(address);
            }
        }
    }
}
