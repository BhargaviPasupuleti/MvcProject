using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LoanDetail.Models
{
    public class Loandetail
    {

        public int Id { get; set; }
        [Display(Name ="Type of Loan")]
        [Required]
        public string loan_Type { get; set; }

        [Display(Name = "Interest %")]
        [Required]
        public double dIntrest { get; set; }

        [Display(Name = "Required Amount")]
        [Required]
        public double dAmount { get; set; }

        [Display(Name = "Payment Type")]
        [Required]
        public string sPayment_Type { get; set; }

        [Display(Name = "Applied on")]
        [Required]
        public DateTime dApplied_Date { get; set; }


        [Display(Name = "Next Installment on")]
        [Required]
        public DateTime dDue_Date { get; set; }

        [Display(Name = "Id Proof")]
        public string sDocument_Type { get; set; }

        public string sStatus { get; set; }
        [Display(Name ="Duration in Month")]

        public int iDuration { get; set; }



        public Customer_Details Customer_Details { get; set; }

        public int Customer_DetailsId { get; set; }







    }
}