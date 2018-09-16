using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RN.Lux.Business.Abstract;
using RN.Lux.MvcWebUI.Models;

namespace RN.Lux.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1,int categoryId=0)
        {
            int pageSize = 10;

            var products = _productService.GetByCategoryId(categoryId);
            ProductListVM vm=new ProductListVM()
            {
                Products=products.Skip((page-1)*pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize = pageSize,
                CurrentCategory = categoryId,
                CurrentPage = page

            };
            return View(vm);
        }
    }
}