using FatmaApi.Controllers.Data;
using FatmaApi.Models;
using FatmaApi.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FatmaApi.Controllers
{
   



    public class TypeController : ApiController

    {
        TypeData TData =new TypeData();

      
        public HttpResponseMessage Get()
        {
           var productTypeList= TData.GetListProductTypes();
            return Request.CreateResponse(HttpStatusCode.OK, productTypeList);
                
        }
        public HttpResponseMessage Get(int Id)
        {
            var productType= TData.GetProductType(Id);
            if (productType == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, productType);
            }
            return Request.CreateResponse(HttpStatusCode.OK, productType);
        }
        public HttpResponseMessage Post(ProductType productType)
        {
           
                var CreateProductType = TData.CreateProductType(productType);
                if (CreateProductType == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotImplemented, CreateProductType);
                }
                return Request.CreateResponse(HttpStatusCode.Created, CreateProductType);
        
        }
    
        public HttpResponseMessage Put( int Id,ProductType productType)
        {
           
            if (ModelState.IsValid)
            {
                var UpdateProductType = TData.UpdateProductType(Id, productType);
                if (UpdateProductType == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotImplemented, productType);
                }
                return Request.CreateResponse(HttpStatusCode.OK, UpdateProductType);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }
        public HttpResponseMessage Delete(int Id)
        {
            var productType = TData.GetProductType(Id);
            if (productType == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, productType);
            }
            TData.DeleteProductType(Id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}
