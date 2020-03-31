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
        public IActionResult Index(string currency = "USD")
        {
            GenerateCookie();
            ProductCatalog resultadoFinal = ProductCatalogService.Catalog();
            UpdateCurrency(currency);

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
            resultadoFinal.currentCurrency = currency;
            return View(resultadoFinal);
        }

        [HttpGet]
        public IActionResult SearchByName(string name, string currency)
        {
            var Found = ProductCatalogService.CatalogByName(name);

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

            return PartialView("Index", Found);
        }

        public void GenerateCookie()
        {
            if (HttpContext.Request.Cookies["UserId"] == null)
            {
                string info = Guid.NewGuid().ToString();
                HttpContext.Response.Cookies.Append("UserId", info);
            }
        }

        public void UpdateCurrency(string cur)
        {
            if (HttpContext.Request.Cookies["currency"] == null)
            {
                HttpContext.Response.Cookies.Append("currency", cur);
            }
            else
            {
                HttpContext.Response.Cookies.Delete("currency");
                HttpContext.Response.Cookies.Append("currency", cur);
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
