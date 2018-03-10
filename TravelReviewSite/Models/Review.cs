using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set;}
        public string ReviewTitle { get; set; }
        public string AuthorUserName { get; set; }
        public string ContentPreview { get; set; }
        [Display(Name ="Rating (out of 10)")]
        public int Rating { get; set; }
        [Display(Name ="Date Reviewed")]
        [DisplayFormat(DataFormatString="{0:MM/dd/yyyy}")]
        public DateTime ReviewDate { get; set; }
        [Display(Name ="Date of Travel")]
        [DisplayFormat(DataFormatString ="{0:MM/yyyy}")]
        public DateTime TravelDate { get; set; }

        //Foreign Keys and Navigation Properties
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}