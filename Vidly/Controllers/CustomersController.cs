using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith", Id = 1},
                new Customer {Name = "Marry Smith", Id = 2}
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("customer/details/{Id}/")]
        public ActionResult Details(int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomersViewModel
            {
                Customer = customer
            };

            return View(viewModel);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
             {
                 new Customer { Id = 1, Name = "John Smith" },
                 new Customer { Id = 2, Name = "Mary Williams" }
             };
        }
    }
}