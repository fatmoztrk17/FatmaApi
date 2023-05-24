using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FatmaApi.Models
{
    abstract public class BasicModel 
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
    }
}