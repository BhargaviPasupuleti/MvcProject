using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoanDetail.Models
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext():base("Loan")
        {
        }

        public DbSet<Loandetail> Loandetails { get; set; }
        public DbSet<Customer_Details> customers{ get; set; }
        public DbSet<DocumentsUpload> documents { get; set; }
        public DbSet<EmployeeDetails> employees  { get; set; }
        public DbSet<RiskContentUnit> riskContents { get; set; }
        public DbSet<Verification>  verifications { get; set; }
        public DbSet<CreditBuyer> creditbuyers { get; set; }
        public DbSet<CreditManager> creditmanagers{ get; set; }
    }
}