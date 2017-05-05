using Price_Cutaion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Price_Cutaion.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customrs
        ApplicationDbContext _Context = new ApplicationDbContext();

        public ActionResult Index()
        {
            var customers = _Context.Customers.ToList();
            return View(customers);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _Context.Customers.Add(customer);
                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var customers = _Context.Customers.Find(Id);
            return View(customers);
        }
        [HttpPost]
        public ActionResult Edit(int Id, Customer customer)
        {
            if (ModelState.IsValid)
            {
                var customers = _Context.Customers.Find(Id);
                customers.customerId = customer.customerId;
                customers.customerName = customer.customerName;
                customers.customerEmail = customer.customerEmail;
                customers.customerPhone = customer.customerPhone;

                _Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var customers = _Context.Customers.Find(Id);
            return View(customers);
         }
        [HttpPost]
        public ActionResult Delete(int Id, Customer customer)
        {
            customer = _Context.Customers.Find(Id);
            _Context.Customers.Remove(customer);
            _Context.SaveChanges();
            return RedirectToAction("index");

        }
        public ActionResult Details(int Id)
        {
            var customers = _Context.Customers.Find(Id);
            return View(customers);
        }
    }
}