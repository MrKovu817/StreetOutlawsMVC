using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StreetOutlaws.Data.Entities
{
    public class Driver
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(TeamId))]
        public int TeamId { get; set; } 
        public virtual Team Team { get; set; }
        public List<Car> Cars { get; set; }= new List<Car>();
    }
}