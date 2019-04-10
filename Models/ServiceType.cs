using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SparkAuto.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Service Name")]
        public string ServiceName { get; set; }

        [Required]
        [Display(Name="Service Price")]
        [DataType(DataType.Currency)]
        public double ServicePrice { get; set; }
    }
}
