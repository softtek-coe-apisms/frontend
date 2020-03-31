using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerseClient.Models;
using EcommerseClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace EcommerseClient.Controllers
{
    public class CheckoutController : Controller
    {
        [HttpPost]
        public IActionResult Index(UserInfo userinfo)
        {
            userinfo.UserId = HttpContext.Request.Cookies["UserId"];
            userinfo.CurrencyExchange = HttpContext.Request.Cookies["currency"];
            CheckoutModel checkoutModel = CheckoutService.Checkout(userinfo);
            ViewBag.currency = HttpContext.Request.Cookies["currency"];
            return View("CheckOut", checkoutModel);
        }
    }
}