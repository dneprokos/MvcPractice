using MvcPractice.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        #region Actions

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers;
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        #endregion

        #region private helpers

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Alan Smith"},
                new Customer {Id = 2, Name = "Agent Smith"},
                new Customer {Id = 3, Name = "Will Smith"}
            };
        }

        #endregion
    }
}