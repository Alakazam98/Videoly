using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videoly.Models;
using System.Data.Entity;
using Videoly.ViewModel;

namespace Videoly.Controllers
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


        
        public ActionResult Save(Customers customers)
        {
            if(customers.Id == 0)
                _context.Customers.Add(customers);
            else
            {
                var customersInDb = _context.Customers.SingleOrDefault(c => c.Id == customers.Id);
                
                
                customersInDb.Name = customers.Name;
                customersInDb.BirthDate = customers.BirthDate;
                customersInDb.MembershipTypeId = customers.MembershipTypeId;
                customersInDb.IsSubscribedToNewsletter = customers.IsSubscribedToNewsletter;

            }
            _context.SaveChanges();

            return RedirectToAction("Customers", "Customers");
        }
        // GET: Customers
        public ActionResult Customers()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult CustomerForm(int id)
        {

            var customers = _context.Customers.SingleOrDefault(c=> c.Id == id);

            if (customers == null)
                return HttpNotFound();
            var viewModel = new CustomerFormViewModel
            {
                Customers = customers,
                MembershipTypes = _context.MembershipTypes.ToList()
            };


            return View("CustomerForm", viewModel);
        }

        
    }
}