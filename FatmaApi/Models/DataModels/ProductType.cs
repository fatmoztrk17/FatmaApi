using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FatmaApi.Models
{
    public class ProductType : BasicModel
    {
        [Required(ErrorMessage ="Plaka Zorunlu bir alandır..!")]
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal CapacityKG { get; set; }
        public decimal CapacityM3 { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}