using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ToolShed.Models{

    public abstract class Items{
        public int ID { get; set; } // unique ID code
        [Display(Name = "Name")]
        public String name { get; set; } //Name of the item
        //[DisplayFormat(DataFormatString = "{$####.##}", ApplyFormatInEditMode = true)]
        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public float price { get; set; } // price of a item
        public int SKU { get; set; } // SKU of a item
        [Display(Name = "Acquisition Date")]
        [DataType(DataType.Date)]
        public DateTime acqDate { get; set; } // Acquisition Date of a item

    }
}