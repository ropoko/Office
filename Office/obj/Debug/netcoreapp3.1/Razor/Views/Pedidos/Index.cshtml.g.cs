#pragma checksum "C:\Users\Rodrigo\Desktop\Office\Office\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1582ba3935de47cac6427a8adf6f5833358f06e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Rodrigo\Desktop\Office\Office\Views\_ViewImports.cshtml"
using Office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rodrigo\Desktop\Office\Office\Views\_ViewImports.cshtml"
using Office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1582ba3935de47cac6427a8adf6f5833358f06e", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fdf28ae0e3323ea83a67368aa4014112f9d50f", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Rodrigo\Desktop\Office\Office\Views\Pedidos\Index.cshtml"
  
    Layout = "Pedidos/_LayoutPedidos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header id=""header"">
    <!--header-->
</header><!--/header-->
<section id=""cart_items"">
    <div class=""container"">
        <div class=""breadcrumbs"">
            <ol class=""breadcrumb"">
            </ol>
        </div>
        <div class=""table-responsive cart_info"">
            <table class=""table table-condensed"">
                <thead>
                    <tr class=""cart_menu"">
                        <td class=""image"">Item</td>
                        <td class=""description"">Descrição</td>
                        <td class=""price"">Preço</td>
                        <td class=""quantity"">Quantidade</td>
                        <td class=""total"">Total</td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td class=""cart_product"">
                        <td class=""cart_description"">
                        </td>
                        <td class=""cart_price"">
           ");
            WriteLiteral("             </td>\r\n                        <td class=\"cart_quantity\">\r\n                            <div class=\"cart_quantity_button\">\r\n                                <a class=\"cart_quantity_up\"");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1273, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\r\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\r\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 1480, "\"", 1487, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 1754, "\"", 1761, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>

                    <tr>
                        <td class=""cart_product"">
                        </td>
                        <td class=""cart_description"">
                        </td>
                        <td class=""cart_price"">
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 2305, "\"", 2312, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\r\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\r\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 2519, "\"", 2526, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 2793, "\"", 2800, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>
                    <tr>
                        <td class=""cart_product"">
                        </td>
                        <td class=""cart_description"">
                        </td>
                        <td class=""cart_price"">
                        </td>
                        <td class=""cart_quantity"">
                            <div class=""cart_quantity_button"">
                                <a class=""cart_quantity_up""");
            BeginWriteAttribute("href", " href=\"", 3342, "\"", 3349, 0);
            EndWriteAttribute();
            WriteLiteral("> + </a>\r\n                                <input class=\"cart_quantity_input\" type=\"text\" name=\"quantity\" value=\"1\" autocomplete=\"off\" size=\"2\">\r\n                                <a class=\"cart_quantity_down\"");
            BeginWriteAttribute("href", " href=\"", 3556, "\"", 3563, 0);
            EndWriteAttribute();
            WriteLiteral(@"> - </a>
                            </div>
                        </td>
                        <td class=""cart_total"">
                        </td>
                        <td class=""cart_delete"">
                            <a class=""cart_quantity_delete""");
            BeginWriteAttribute("href", " href=\"", 3830, "\"", 3837, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-times""></i></a>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    <div>
        <button type=""submit"" class=""btn btn-default"">Resevar</i></button>
    </div>
</section> <!--/#cart_items-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
