using MvcPractice.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class CustomersController : Controller
    {
        #region Actions

        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

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