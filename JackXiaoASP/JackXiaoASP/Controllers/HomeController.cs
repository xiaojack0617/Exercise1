using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JackXiaoASP.Models;

namespace JackXiaoASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        CustomersEntities db = new CustomersEntities();
        public  PartialViewResult All()
        {
            List<Customer> model = db.Customers.ToList();

            return PartialView("~/Views/Shared/CustomerList.cshtml", model);
           
        }


        public PartialViewResult Add()
        {   

            return PartialView("~/Views/Shared/AddCustomer.cshtml");

        }


        public PartialViewResult Hide()
        {

            return PartialView("~/Views/Shared/Hide.cshtml");

        }





    }
}