using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StreetOutlaws.Models.DriverModels
{
    public class DriverCreate
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [ForeignKey(nameof(TeamId))]
        public int TeamId { get; set; }
    }
}