using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StreetOutlaws.Models.CarModel
{
    public class CarListItem
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        
    }
}