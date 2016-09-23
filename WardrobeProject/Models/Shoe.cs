using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WardrobeProject.Models
{
    public class Shoe
  
    {
        public int shoeID { get; set; }

        public string shoeItemName { get; set; }
        public string photo { get; set; }

        public virtual ICollection<Type> ClothingItem { get; set; }
    }


}