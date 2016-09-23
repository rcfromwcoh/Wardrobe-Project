using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WardrobeProject.Models
{
    public class Type
    {
        [Key]
        public int typeID { get; set; }

        public string typeItemName { get; set; }
        public string photo { get; set; }

        [ForeignKey("Top")]
        public int topID { get; set; }
        public virtual Top Top { get; set; }

        [ForeignKey("Bottom")]
        public int bottomID { get; set; }
        public virtual Bottom Bottom { get; set; }

        [ForeignKey("Shoe")]
        public int shoeID { get; set; }
        public virtual Shoe Shoe { get; set; }

        [ForeignKey("Accessory")]
        public int accessoryID { get; set; }
        public virtual Accessory Accessory { get; set; }
    }
}