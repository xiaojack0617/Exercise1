using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JackXiaoASP.Models;
using JackXiaoASP.CustumerViewModel;

namespace JackXiaoASP.Controllers
{
    public class CustomersController : Controller
    {
        private CustomersEntities _customersContext;
        

        public CustomersController()
        {

            _customersContext = new CustomersEntities();
        }



        // GET: Customers
        public ActionResult Index()
        {
            return View(_customersContext.Customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = _customersContext.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            CustomerViewModel customerViewModel = new CustomerViewModel();
            customerViewModel.CustomerName = customer.CustomerName;
            customerViewModel.CustomerID = customer.CustomerID;
            customerViewModel.ContactName = customer.ContactName;
            customerViewModel.Address = customer.Address;
            customerViewModel.City = customer.City;
            customerViewModel.Country = customer.Country;
            customerViewModel.PostalCode = customer.PostalCode;
            customerViewModel.MessageToClient = "I am from ViewModel";

            return View(customerViewModel);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,CustomerName,ContactName,Address,City,PostalCode,Country")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customersContext.Customers.Add(customer);
                _customersContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = _customersContext.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,CustomerName,ContactName,Address,City,PostalCode,Country")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customersContext.Entry(customer).State = EntityState.Modified;
                _customersContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = _customersContext.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = _customersContext.Customers.Find(id);
            _customersContext.Customers.Remove(customer);
            _customersContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _customersContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
