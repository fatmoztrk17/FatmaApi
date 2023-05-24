using FatmaApi.Models;
using FatmaApi.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace FatmaApi.Controllers.Data
{
    public class TypeData
    {
        DataContext db = new DataContext();

        public List<ProductType> GetListProductTypes() 
        {
            List<ProductType> ProductTypeList = new List<ProductType>();
            ProductTypeList = db.ProductType.Where(x => x.IsDelete == false).ToList();

            return ProductTypeList;
        }
        public ProductType GetProductType(int Id)
        {

            ProductType productType = db.ProductType.Find(Id);
            if (productType==null ||  productType.IsDelete == true) 
            {
                return null;

            }

            return productType;
        }
     
        public ProductType CreateProductType(ProductType productType)
        {

            db.ProductType.Add(productType);
            db.SaveChanges();
            return productType;
        }
        public ProductType UpdateProductType(int Id, ProductType productType)
        {
            ProductType productTypeControl = db.ProductType.Find(Id);
            if (productTypeControl == null || productTypeControl.IsDelete == true)
            {
                return null;

            }
            productTypeControl.Brand = productType.Brand;
            productTypeControl.CapacityM3= productType.CapacityM3;
            productTypeControl.CapacityKG = productType.CapacityKG;
            productTypeControl.IsActive = productType.IsActive;
            productTypeControl.IsDelete = productType.IsDelete;
            productTypeControl.Model = productType.Model;

            db.SaveChanges();
            return productType;
        }
        public void DeleteProductType(int Id)
        {

            ProductType productType = db.ProductType.Find(Id);
            productType.IsDelete = true;
            db.SaveChanges();
           
        }
    }
}