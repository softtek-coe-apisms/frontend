using EcommerseClient.Models;
using System;

namespace EcommerseClient.Services
{
    public class ProductCatalogService
    {
        public static string BaseUrl = Environment.GetEnvironmentVariable("ProductCatalogService");

        public static ProductCatalog Catalog(string page = "1", string name = "")
        {
            return new HttpRequests().TheGet<ProductCatalog>("api/ProductCatalogService?pageNumber=" + page + "&name=" + name, BaseUrl);
        }

        public static Producto Info(string id)
        {
            return new HttpRequests().TheGet<Producto>("api/ProductCatalogService/" + id, BaseUrl);
        }

        public static ProductCatalog CatalogByName(string name)
        {
            return new HttpRequests().TheGet<ProductCatalog>("api/ProductCatalogService?name=" + name, BaseUrl);
        }
    }
}
