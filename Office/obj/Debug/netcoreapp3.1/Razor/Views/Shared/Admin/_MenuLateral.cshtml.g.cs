#pragma checksum "C:\Users\rodrigo\Desktop\Office\Office\Views\Shared\Admin\_MenuLateral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9492e68809098902c45ccf5ef761ac6fa9a26799"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Admin__MenuLateral), @"mvc.1.0.view", @"/Views/Shared/Admin/_MenuLateral.cshtml")]
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
#line 1 "C:\Users\rodrigo\Desktop\Office\Office\Views\_ViewImports.cshtml"
using Office;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rodrigo\Desktop\Office\Office\Views\_ViewImports.cshtml"
using Office.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9492e68809098902c45ccf5ef761ac6fa9a26799", @"/Views/Shared/Admin/_MenuLateral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3fdf28ae0e3323ea83a67368aa4014112f9d50f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Admin__MenuLateral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""mt-2"">
    <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
        <li class=""nav-item has-treeview menu-open"">
            <a class=""nav-link active"">DashBoard</a>
        </li>

        <li class=""nav-item has-treeview menu-open"">
            ");
#nullable restore
#line 8 "C:\Users\rodrigo\Desktop\Office\Office\Views\Shared\Admin\_MenuLateral.cshtml"
       Write(Html.ActionLink("Calendário", "Calendario", "Admin", null, null, null, null, new { @class = "nav-link active" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </li>
        <li class=""nav-item"">
            <a class=""nav-link active"">Galeria</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link active"">E-mail</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link active"">Inbox</a>
        </li>
    </ul>
</nav>");
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
