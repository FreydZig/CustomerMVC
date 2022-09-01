﻿using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
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
                //TODO:FIX
                return RedirectToAction("Index",new { id = _customerId });
            }
            catch
            {
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
