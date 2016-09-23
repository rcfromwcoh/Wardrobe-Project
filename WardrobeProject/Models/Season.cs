using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WardrobeProject.Models
{
    public class Season
    {
        [Key]
        public int SeasonsID { get; set; }
        public string SeasonsName { get; set; }

        //navigation properties

        public virtual ICollection<Outfit> Outfit { get; set; }


    }
}