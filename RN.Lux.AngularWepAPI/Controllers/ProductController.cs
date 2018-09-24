using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RN.Lux.Business.Abstract;
using RN.Lux.Entities.Concrete;

namespace RN.Lux.AngularWepAPI.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("[action]")]
        public List<Product> GetProducts()
        {
            var products = _productService.GetAll();

            return products;

        }
        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]Product product)
        {
            _productService.Add(product);
            return Ok(product);
        }

        [HttpPost]
        [Route("delete")]
        public ActionResult Delete([FromBody]Product product)
        {
            _productService.Delete(product.ProductId);
            return Ok(product);
        }
    }
}