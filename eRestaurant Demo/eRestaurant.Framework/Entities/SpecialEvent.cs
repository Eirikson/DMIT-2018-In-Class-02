using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Framework.Entities
{
    public class SpecialEvent
    {
        [Key]
        [Required(ErrorMessage = "An event code is required (one character only")]
        [StringLength(1, ErrorMessage = "Event Codes only use a single character")]
        public string EventCode { get; set; }

        [Required()]
        [StringLength(30, MinimumLength = 5)]
        public string Description { get; set; }
        public bool Active { get; set; }
        // Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }

        public SpecialEvent()
        {
            Active = true;
            // To avoid null-reference errors for our navigation property
            Reservations = new HashSet<Reservation>();
        }
    }
}
