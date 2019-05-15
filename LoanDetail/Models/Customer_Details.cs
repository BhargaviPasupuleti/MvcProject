using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace LoanDetail.Models
{
    public class Customer_Details
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string sFirst_Name { get; set; }

        [Display(Name = "Last Name")]
        public string sLast_Name { get; set; }


        [Required]
        [Display(Name = "Mobile Number")]
        public string iMobile_Number { get; set; }

        [Required]
        [Display(Name = "Email-ID")]
        public string sEmail_ID { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Password")]
        public string sPassword { get; set; }

        [Required]
        [Display(Name = "City")]
        public string sCity { get; set; }

        [Display(Name = "Address")]
        public string sAddress { get; set; }

        [Required]
        [Display(Name = "Occupation")]
        public String sOccupation { get; set; }

        [Display(Name = "Gender")]
        public string sGender { get; set; }

        [Required]
        [Display(Name = "UPI-ID(Unique Public Id)")]
        public string sUpi_Id { get; set; }

      
        [Required]
        [Display(Name = "Account Number")]
        public int iAccount_Number { get; set; }

        [Required]
        [Display(Name = "Initial Amount")]
        public int iInitial_Deposite_Amount { get; set; }



    }

}