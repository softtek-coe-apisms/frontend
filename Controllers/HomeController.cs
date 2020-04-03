using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcommerseClient.Models;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using EcommerseClient.Services;

namespace EcommerseClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int page = 1, string currency = "USD", string name = "")
        {
            GenerateCookie();
            UpdateCurrency(currency);
            UpdatePage(page.ToString());
            ProductCatalog resultadoFinal = ProductCatalogService.Catalog(page.ToString(), name);
            foreach (var item in resultadoFinal.products)
            {
                double precio = CurrencyService.Conversion(new CurrencyChange()
                {
                    CurrencyCode = item.priceUsd.currencyCode,
                    Units = item.priceUsd.units,
                    Nano = item.priceUsd.nanos,
                    CurrencyType = currency
                });
                item.price = precio;
            }
            ViewBag.page = page;
            resultadoFinal.currentCurrency = currency;
            return View(resultadoFinal);
        }

        [HttpGet]
        public IActionResult SearchByName(string name, string currency, int page = 1)
        {
            ProductCatalog Found = ProductCatalogService.Catalog(page.ToString(), name);

            if (Found.products != null)
            {
                foreach (var item in Found.products)
                {
                    double precio = CurrencyService.Conversion(new CurrencyChange()
                    {
                        CurrencyCode = item.priceUsd.currencyCode,
                        Units = item.priceUsd.units,
                        Nano = item.priceUsd.nanos,
                        CurrencyType = currency
                    });
                    item.price = precio;
                }
                Found.currentCurrency = currency;
                ViewBag.page = page;
                return PartialView("_Found", Found);
            }
            else
            {
                return PartialView("Index", new ProductCatalog() { totalProducts = 0 });
            }
        }

        public void GenerateCookie()
        {
            if (HttpContext.Request.Cookies["UserId"] == null)
            {
                string info = Guid.NewGuid().ToString();
                var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions()
                {
                    Path = "/",
                    HttpOnly = false,
                    IsEssential = true, //<- there
                    Expires = DateTime.Now.AddMonths(1),
                };

                HttpContext.Response.Cookies.Append("UserId", info, cookieOptions);
            }
        }

        public void UpdateCurrency(string cur)
        {
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Path = "/",
                HttpOnly = false,
                IsEssential = true, //<- there
                Expires = DateTime.Now.AddMonths(1),
            };

            if (HttpContext.Request.Cookies["currency"] == null)
            {
                HttpContext.Response.Cookies.Append("currency", cur, cookieOptions);
            }
            else
            {
                HttpContext.Response.Cookies.Delete("currency");
                HttpContext.Response.Cookies.Append("currency", cur, cookieOptions);
            }
        }


        public void UpdatePage(string page)
        {
            var cookieOptions = new Microsoft.AspNetCore.Http.CookieOptions()
            {
                Path = "/",
                HttpOnly = false,
                IsEssential = true, //<- there
                Expires = DateTime.Now.AddMonths(1),
            };

            if (HttpContext.Request.Cookies["page"] == "1")
            {
                HttpContext.Response.Cookies.Append("page", page, cookieOptions);
            }
            else
            {
                HttpContext.Response.Cookies.Delete("page");
                HttpContext.Response.Cookies.Append("page", page, cookieOptions);
            }
        }

        [HttpGet]
        public IActionResult BuyProducts(string id, string currency = "USD")
        {
            Producto Theproduct = ProductCatalogService.Info(id);
            UpdateCurrency(currency);
            Theproduct.price = CurrencyService.Conversion(new CurrencyChange()
            {
                CurrencyCode = Theproduct.priceUsd.currencyCode,
                Units = Theproduct.priceUsd.units,
                Nano = Theproduct.priceUsd.nanos,
                CurrencyType = currency
            });
            Theproduct.priceUsd.currencyCode = currency;
            return PartialView(Theproduct);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
