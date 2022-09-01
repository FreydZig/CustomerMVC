using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System.Web.Mvc;

namespace CustomerLIb.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IRepository<Customer> _customerRepository;

        public CustomerController()
        {
            _customerRepository = new CustomerRepository();
        }

        public CustomerController(IRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _customerRepository.GetAll("");

            return View(customer);
        }

        // GET: Customer/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            try
            {
                _customerRepository.Create(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _customerRepository.Read(id.ToString());
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                _customerRepository.Update(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = _customerRepository.Read(id.ToString());
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Customer customer)
        {
            try
            {
                var _addresRepository = new AddresRepository();
                var _notesRepository = new NotesRepository();
                _addresRepository.Delete(id.ToString());
                _notesRepository.Delete(id.ToString());
                _customerRepository.Delete(id.ToString());

                return RedirectToAction("Index");
            }
            catch
            {
                return View(customer);
            }
        }
    }
}
