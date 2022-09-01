using CustomerLIbrary.Entities;
using CustomerLIbrary.Interfaces;
using CustomerLIbrary.Repositories;
using System.Text.RegularExpressions;
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
                if (!string.IsNullOrWhiteSpace(customer.FirstName))
                    if (customer.FirstName.Length > 50)
                        ModelState.AddModelError("", "First name must be less 50!");
                if (string.IsNullOrWhiteSpace(customer.LastName))
                    ModelState.AddModelError("", "Last name is empty!");
                else
                    if (customer.LastName.Length > 50)
                    ModelState.AddModelError("", "Last name should be less 50!");
                if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
                    if (!Regex.IsMatch(customer.PhoneNumber, @"\D[0-9]{10}"))
                        ModelState.AddModelError("", "Phone number should looks like +12345678901!");
                if (!string.IsNullOrWhiteSpace(customer.Email))
                    if (!Regex.IsMatch(customer.Email, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
                        ModelState.AddModelError("", "Email should looks like name@mail.net");


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
                if (!string.IsNullOrWhiteSpace(customer.FirstName))
                    if (customer.FirstName.Length > 50)
                        ModelState.AddModelError("", "First name must be less 50!");
                if (string.IsNullOrWhiteSpace(customer.LastName))
                    ModelState.AddModelError("", "Last name is empty!");
                else
                    if (customer.LastName.Length > 50)
                    ModelState.AddModelError("", "Last name should be less 50!");
                if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
                    if (!Regex.IsMatch(customer.PhoneNumber, @"\D[0-9]{10}"))
                        ModelState.AddModelError("", "Phone number should looks like +12345678901!");
                if (!string.IsNullOrWhiteSpace(customer.Email))
                    if (!Regex.IsMatch(customer.Email, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$"))
                        ModelState.AddModelError("", "Email should looks like name@mail.net");
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
