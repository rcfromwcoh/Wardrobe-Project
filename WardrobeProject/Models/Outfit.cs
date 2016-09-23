using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject.Models
{
    public class Outfit
    {

        [Key]

        public int OutfitID { get; set; }

       public virtual ICollection<Bottom> Bottoms { get; set; }
        public virtual ICollection<Top> Top { get; set; }
        public virtual ICollection<Shoe> Shoes { get; set; }
        public virtual ICollection<Accessory> Accessories { get; set; }


    }
}