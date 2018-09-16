using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using RN.Lux.Business.Abstract;
using RN.Lux.MvcWebUI.Models;

namespace RN.Lux.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        public ICategoryService _categoryService;
        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model=new CategoryListVM
            {
                Categories=_categoryService.GetAll(),
                CurrentCategory=Convert.ToInt32(HttpContext.Request.Query["categoryId"])
            };
            return View(model);
        }

    }
}
