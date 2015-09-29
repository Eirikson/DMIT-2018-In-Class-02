using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required, StringLength(35, MinimumLength = 5)]
        public string Description { get; set; }

        [Range(0.01, 50.00)]
        public double CurrentPrice { get; set; }
        [Range(0.01, 30.00)]
        public double CurrentCost { get; set; }
        public bool Active { get; set; }

        
        public int? Calories { get; set; }
        public string Comment { get; set; }
        public int MenuCategoryID { get; set; }
        // Navigation Properties
        public virtual MenuCategory MenuCategory { get; set; }
    }
}
