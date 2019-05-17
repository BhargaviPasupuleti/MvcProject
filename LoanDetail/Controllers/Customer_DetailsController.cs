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
        private ApplicationDbContext dbContext = null;

        public Customer_DetailsController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        
        }

        public ActionResult Index()
        {
    
            return View();

           
        }
        // GET: Customer_Details
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Login(Customer_Details customer)
        {



            
                var validUser = dbContext.customers.SingleOrDefault(u => u.sEmail_ID == customer.sEmail_ID && u.sPassword == customer.sPassword);
                if (validUser != null)
                {
                    //FormsAuthentication.SetAuthCookie(customer.sEmail_ID, false);
                    return RedirectToAction("Index", "Loandetail");
                }
            else
            {
                //bootbox.alert("Your message here…");
                ModelState.AddModelError("", "The username or password is invalid");
            }

            return View(customer);
            
        }

        [HttpGet]
        public ActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Register(Customer_Details customer_Details)
        {

            if (ModelState.IsValid)
            {
                dbContext.customers.Add(customer_Details);
                dbContext.SaveChanges();
                
                return RedirectToAction("Login", "Customer_Details");
            }
            else
            {
  
                return View(customer_Details);
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Loandetail");
        }
       
    }

}