#pragma checksum "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7e0418f61d45975bde32fb7666ee2888b918f08"
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
#line 1 "/home/ropoko/Documents/office/Views/_ViewImports.cshtml"
using Office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/ropoko/Documents/office/Views/_ViewImports.cshtml"
using Office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7e0418f61d45975bde32fb7666ee2888b918f08", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d8103be0d6b0c7d7f698ec5a7c6d2ba5aa9ece", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Office.Models.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Pedidos/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
  
    Layout = "_HeaderFooter";
    ViewData["Title"] = "Carrinho | Office Street";

    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"content\">\n    <div class=\"content-title col-md-12\">\n        <div class=\"title\">\n            <h2>Meus pedidos</h2>\n        </div>\n    </div>\n\n");
#nullable restore
#line 17 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
     if (Model.Count() == 0 || Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-12 nenhuma-reserva\">\n            <h2>Você não realizou nenhuma reserva :(</h2>\n        </div>\n");
#nullable restore
#line 22 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-12"">
            <table class=""table table-striped table-dark table-hover table-responsive-sm table-responsive-lg"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>#</th>
                        <th>Produto</th>
                        <th>Marca</th>
                        <th>Descrição</th>
                        <th>Preço</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 37 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                     foreach (var item in Model)
                    {
                        i++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"items\">\n                            <td>\n                                ");
#nullable restore
#line 43 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 46 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                           Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 49 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                           Write(item.Marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 52 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                           Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
#nullable restore
#line 55 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </td>\n                        </tr>\n");
#nullable restore
#line 58 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n");
#nullable restore
#line 62 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 67 "/home/ropoko/Documents/office/Views/Pedidos/Index.cshtml"
       await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <script>
        function ExcluirPedido(item) {
            swal({
                title: ""Tem certeza que deseja cancelar a reserva?"",
                text: ""Essa ação não poderá ser desfeita!"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {
                        $.get(""/Pedidos/ExcluirPedido"", { item }, function () { });
                        swal(""Sua reserva foi cancelada!"", {
                            icon: ""success"",
                        });
                    } else {
                        swal(""Sua reserva está segura!"");
                    }
                });
        }
    </script>
");
            }
            );
            WriteLiteral("\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7e0418f61d45975bde32fb7666ee2888b918f088737", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Office.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
