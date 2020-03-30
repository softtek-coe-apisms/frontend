using EcommerseClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerseClient.Services
{
    public class AdService
    {
        public static string BaseUrl = Environment.GetEnvironmentVariable("AdService");

        public static string Ad(string id)
        {
            return new HttpRequests().TheGet<Ad>("api/Ad/" + id, BaseUrl).description;
        }
    }
}
