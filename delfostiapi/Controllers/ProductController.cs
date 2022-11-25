using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using delfostiservice;
using Newtonsoft.Json.Linq;

namespace delfostiapi.Controllers
{
    public class ProductController : ApiController
    {

        [HttpPost]
        [AllowAnonymous]
        [Route("api/product/all")]
        public JArray GetAllProduct(JObject param)
        {
            ProductService service = new ProductService();
            string result = service.GetAllProduct(param.ToString());
            return JArray.Parse(result.ToString());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/product/get")]
        public JArray GetProduct(JObject param)
        {
            ProductService service = new ProductService();
            string result = service.GetProduct(param.ToString());
            return JArray.Parse(result.ToString());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/product/delete")]
        public JArray DeleteProduct(JObject param)
        {
            ProductService service = new ProductService();
            string result = service.DeleteProduct(param.ToString());
            return JArray.Parse(result.ToString());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/product/modify")]
        public JArray ModifyProduct(JObject param)
        {
            ProductService service = new ProductService();
            string result = service.ModifyProduct(param.ToString());
            return JArray.Parse(result.ToString());
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("api/product/search")]
        public JArray SearchProduct(JObject param)
        {
            ProductService service = new ProductService();
            string result = service.SearchProduct(param.ToString());
            return JArray.Parse(result.ToString());
        }
    }
}