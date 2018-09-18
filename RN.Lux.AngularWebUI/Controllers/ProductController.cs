using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RN.Lux.Business.Abstract;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.AngularWebUI.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("[action]")]
        public JsonResult GetProductList()
        {
            var products = _productService.GetAll();
            var result = Json(products);
            return result;

        }

        [HttpGet("[action]")]
        public List<Product> GetProducts()
        {
            var products = _productService.GetAll();

            return products;

        }
    }
}