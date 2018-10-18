using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using RN.Lux.MvcWebUI.Models;

namespace RN.Lux.MvcWebUI.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {
            var model=new FooterVM();
           
            return View(model);
        }
    }
}
