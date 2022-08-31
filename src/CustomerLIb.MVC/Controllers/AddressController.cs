using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System.Web.Mvc;

namespace CustomerLIb.MVC.Controllers
{
    public class AddressController : Controller
    {
        private readonly IRepository<Address> _addressRepository;

        public AddressController()
        {
            _addressRepository = new AddresRepository();
        }

        // GET: Address/5
        public ActionResult Index(int id)
        {
            var address = _addressRepository.GetAll(id.ToString());
            return View(address);
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
                //TODO:FIX
                return RedirectToAction("Index", address.CustomerId);
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Address/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Address/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Address/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
