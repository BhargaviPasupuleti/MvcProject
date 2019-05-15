using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LoanDetail.Models;

namespace LoanDetail.Controllers
{
    public class DocumentUploadController : Controller
    {
       private ApplicationDbContext dbContext = null;

        public DocumentUploadController()
        {
            dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: DocumentUpload
        [HttpPost]
        public ActionResult Index(DocumentsUpload documentsUpload )
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index","Loandetail");
            }



            if (documentsUpload != null)
            {
                //FormsAuthentication.SetAuthCookie(documentsUpload.IdentityProof, false);
                return RedirectToAction("Payment", "Loandetail");
            }
            else
            {
                ModelState.AddModelError("", "Please Enter");
            }
            return View();
        }

        

    }
}