using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject.Models
{
    public class Occasion
    {
        [Key]
        public int OccasionsID { get; set; }
        public string OccasionsName { get; set; }

        //navigation properties

        public virtual ICollection<Outfit> Outfit { get; set; }




    }
}