using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FatmaApi.Models.DataModels
{
    public class DataContext:DbContext

    {
        public DataContext() : base("NetlogOrnekConnection") { }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

    }
}