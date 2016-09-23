using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject.Models
{
    public class Color
    {
        [Key]
        public int colorID { get; set; }

        public string colorName { get; set; }
     

       public virtual ICollection<Outfit> Outfit { get; set; }


    }
}