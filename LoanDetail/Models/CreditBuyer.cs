using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoanDetail.Models
{
    public class CreditBuyer
    {

        public int Id { get; set; }
        public string sStatus { get; set; }

        public EmployeeDetails EmployeeDetails { get; set; }
        public int EmployeeDetailsId { get; set; }


        public Loandetail Loandetail { get; set; }
        public int LoandetailId { get; set; }

        public Customer_Details Customer_Details { get; set; }
        public int CustomerDetailsId { get; set; }
    }
}