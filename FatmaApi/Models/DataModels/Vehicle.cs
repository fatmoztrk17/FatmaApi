using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FatmaApi.Models
{
    public class Vehicle:BasicModel
    {
        public string Plate { get; set; }
        public int ModelYear { get; set; }
        public string Color { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
    }
}