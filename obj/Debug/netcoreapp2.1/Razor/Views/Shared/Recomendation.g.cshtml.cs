#pragma checksum "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce63a70187f7a193fcba9feebf65213036b208de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Recomendation), @"mvc.1.0.view", @"/Views/Shared/Recomendation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Recomendation.cshtml", typeof(AspNetCore.Views_Shared_Recomendation))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Curso\Desktop\EcommerseClient\Views\_ViewImports.cshtml"
using EcommerseClient;

#line default
#line hidden
#line 2 "C:\Users\Curso\Desktop\EcommerseClient\Views\_ViewImports.cshtml"
using EcommerseClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce63a70187f7a193fcba9feebf65213036b208de", @"/Views/Shared/Recomendation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5206f962b00f68c9331c8537c4ea0efed31222", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Recomendation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Producto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 231, true);
            WriteLiteral("\r\n<style>\r\n    .carousel-item {\r\n        height: 500px;\r\n    }\r\n\r\n    .carousel-item img {\r\n        position: absolute;\r\n        object-fit: cover;\r\n        top: 0;\r\n        left: 0;\r\n        min-height: 500px;\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
#line 17 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
            BeginContext(281, 57, true);
            WriteLiteral("    <h2 class=\"text-muted\">Products you might like</h2>\r\n");
            EndContext();
            BeginContext(340, 134, true);
            WriteLiteral("    <div id=\"carouselExampleIndicators\" class=\"carousel slide w-100\" data-ride=\"carousel\">\r\n        <ol class=\"carousel-indicators\">\r\n");
            EndContext();
#line 23 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
             for (int i = 0; i < Model.Count; i++)
            {
                if (i == 0)
                {

#line default
#line hidden
            BeginContext(589, 80, true);
            WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(670, 1, false);
#line 27 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(671, 24, true);
            WriteLiteral("\" class=\"active\"></li>\r\n");
            EndContext();
#line 28 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(755, 80, true);
            WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
            EndContext();
            BeginContext(836, 1, false);
#line 31 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                                                                           Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(837, 9, true);
            WriteLiteral("\"></li>\r\n");
            EndContext();
#line 32 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(880, 55, true);
            WriteLiteral("        </ol>\r\n\r\n        <div class=\"carousel-inner\">\r\n");
            EndContext();
#line 37 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
              
                bool first = true;
                foreach (var item in Model)
                {
                    if (first)
                    {

#line default
#line hidden
            BeginContext(1106, 68, true);
            WriteLiteral("                            <a class=\"carousel-item active\" href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1174, "\"", 1199, 3);
            WriteAttributeValue("", 1184, "Buy(\'", 1184, 5, true);
#line 43 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
WriteAttributeValue("", 1189, item.id, 1189, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1197, "\')", 1197, 2, true);
            EndWriteAttribute();
            BeginContext(1200, 61, true);
            WriteLiteral(">\r\n                                <img class=\"d-block w-100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1261, "\"", 1280, 1);
#line 44 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
WriteAttributeValue("", 1267, item.picture, 1267, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1281, "\"", 1295, 1);
#line 44 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
WriteAttributeValue("", 1287, item.id, 1287, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1296, 125, true);
            WriteLiteral(">\r\n                                <div class=\"carousel-caption d-none d-md-block\">\r\n                                    <h5>");
            EndContext();
            BeginContext(1422, 9, false);
#line 46 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                                   Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 81, true);
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </a>\r\n");
            EndContext();
#line 49 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                        first = false;
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1624, 61, true);
            WriteLiteral("                            <a class=\"carousel-item\" href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1685, "\"", 1710, 3);
            WriteAttributeValue("", 1695, "Buy(\'", 1695, 5, true);
#line 53 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
WriteAttributeValue("", 1700, item.id, 1700, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1708, "\')", 1708, 2, true);
            EndWriteAttribute();
            BeginContext(1711, 61, true);
            WriteLiteral(">\r\n                                <img class=\"d-block w-100\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1772, "\"", 1791, 1);
#line 54 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
WriteAttributeValue("", 1778, item.picture, 1778, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1792, "\"", 1806, 1);
#line 54 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
WriteAttributeValue("", 1798, item.id, 1798, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1807, 125, true);
            WriteLiteral(">\r\n                                <div class=\"carousel-caption d-none d-md-block\">\r\n                                    <h5>");
            EndContext();
            BeginContext(1933, 9, false);
#line 56 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                                   Write(item.name);

#line default
#line hidden
            EndContext();
            BeginContext(1942, 81, true);
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </a>\r\n");
            EndContext();
#line 59 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
                    }
                }
            

#line default
#line hidden
            BeginContext(2080, 534, true);
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
");
            EndContext();
#line 72 "C:\Users\Curso\Desktop\EcommerseClient\Views\Shared\Recomendation.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Producto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
