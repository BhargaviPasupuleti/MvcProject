using LoanDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoanDetail.Controllers
{
    public class Customer_DetailsController : Controller
    {
        // GET: Customer_Details
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register(Customer_Details customer_Details)
        {

            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Loandetail");
        }
    }

}