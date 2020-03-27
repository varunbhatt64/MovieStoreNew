﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MovieStoreNew.Models;

namespace MovieStoreNew.Controllers
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
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); // if we don't use tolist then the query to db will not be executed here but when the list is iterated
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer != null)
                return View(customer);
            else
                return HttpNotFound();
        }
    }
}