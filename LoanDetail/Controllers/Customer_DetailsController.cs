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
        public ActionResult Login(string Email,string pwd)
        {
           // var obj = db.UserProfiles.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
            var customer = dbContext.customers.SingleOrDefault(c => c.sEmail_ID == Email && c.sPassword==pwd);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return RedirectToAction("Index", "Loandetail");
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