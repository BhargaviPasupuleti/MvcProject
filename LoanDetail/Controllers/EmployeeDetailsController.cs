using LoanDetail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LoanDetail.Controllers
{
    public class EmployeeDetailsController : Controller
    {
        private ApplicationDbContext dbContext = null;
        public EmployeeDetailsController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }



        // GET: EmployeeDetails
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult Employees()
        {
            var employees = dbContext.employees.Include(e => e.EmployeeDetails).ToList();
            return View();
        }
    }
}