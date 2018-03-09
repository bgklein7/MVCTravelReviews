using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        //Navigation Property
        public virtual ICollection<Review> Reviews { get; set; }
    }
}