using System.Collections.Generic;
using System.Web.Mvc;
using MovieStoreNew.Models;

namespace MovieStoreNew.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer> { new Customer { Id = 1, Name = "Varun" }, new Customer { Id = 2, Name = "Mansi" } };
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            if (customer != null)
                return View(customer);
            else
                return HttpNotFound();
        }
    }
}