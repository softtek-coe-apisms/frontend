#pragma checksum "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbead028d1403a013d75c4abb10604a9c8948e9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#line 5 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Curso\Desktop\frontend\Views\_ViewImports.cshtml"
using EcommerseClient;

#line default
#line hidden
#line 3 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
using EcommerseClient.Models;

#line default
#line hidden
#line 2 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
using EcommerseClient.Services;

#line default
#line hidden
#line 4 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
using System.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbead028d1403a013d75c4abb10604a9c8948e9e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5206f962b00f68c9331c8537c4ea0efed31222", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCatalog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(139, 95, true);
            WriteLiteral("<div id=\"contenedor\">\r\n    <div class=\"album py-5 bg-light\">\r\n        <div class=\"container\">\r\n");
            EndContext();
#line 9 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
             if (Model.totalItems == 0)
            {

#line default
#line hidden
            BeginContext(290, 63, true);
            WriteLiteral("                <h2 class=\"text-muted\">No products found</h2>\r\n");
            EndContext();
#line 12 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(401, 35, true);
            WriteLiteral("                <div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
                     foreach (var item in Model.products)
                    {

#line default
#line hidden
            BeginContext(518, 309, true);
            WriteLiteral(@"                        <div class=""col-md-4 px-2 py-1 my-4"">
                            <div class=""card shadow-sm h-100"">
                                <svg class=""bd-placeholder-img card-img-top"" height=""225"" width=""100%"" xmlns=""http://www.w3.org/2000/svg"">
                                    <image");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 827, "\"", 847, 1);
#line 21 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
WriteAttributeValue("", 834, item.picture, 834, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(848, 188, true);
            WriteLiteral(" height=\"100%\" width=\"100%\" />\r\n                                </svg>\r\n                                <div class=\"card-body\">\r\n                                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1037, 9, false);
#line 24 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
                                                      Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 150, true);
            WriteLiteral("</h5>\r\n                                    <div class=\"d-flex justify-content-between align-items-center\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1196, "\"", 1221, 3);
            WriteAttributeValue("", 1206, "Buy(\'", 1206, 5, true);
#line 26 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
WriteAttributeValue("", 1211, item.id, 1211, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1219, "\')", 1219, 2, true);
            EndWriteAttribute();
            BeginContext(1222, 96, true);
            WriteLiteral(" class=\"btn btn-sm btn-outline-secondary\">Buy</a>\r\n                                        <div>");
            EndContext();
            BeginContext(1319, 21, false);
#line 27 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
                                        Write(Model.currentCurrency);

#line default
#line hidden
            EndContext();
            BeginContext(1340, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1342, 34, false);
#line 27 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
                                                               Write(string.Format("{0:C}", item.price));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 160, true);
            WriteLiteral("</div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 32 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1559, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 34 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1598, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 35 "C:\Users\Curso\Desktop\frontend\Views\Home\Index.cshtml"
              await Html.RenderPartialAsync("Ad");

#line default
#line hidden
            BeginContext(1651, 54, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCatalog> Html { get; private set; }
    }
}
#pragma warning restore 1591
