using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace LoanDetail.Models
{
    public class DocumentsUpload
    {
        [Required]
        public int Id { get; set; }
       
        [Display(Name = "Document Type")]
        [Required]
        public string IdentityProof { get; set; }

        [Display(Name = "Address Proof")]
        [Required]
        public string AddressProof { get; set; }

        [Display(Name = "Income Proof")]
        [Required]
        public string Statements { get; set; }


    }
}