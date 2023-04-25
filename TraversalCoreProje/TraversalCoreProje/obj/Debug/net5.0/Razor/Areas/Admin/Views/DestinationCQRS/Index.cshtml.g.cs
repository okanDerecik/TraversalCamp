#pragma checksum "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36d2f907fd2c023df459de19842da369254d6a15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DestinationCQRS_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36d2f907fd2c023df459de19842da369254d6a15", @"/Areas/Admin/Views/DestinationCQRS/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3476764290aa848c98a873fa5a9a3602c6f26af5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_DestinationCQRS_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetAllDestinationQueryResult>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>CQRS Tur Rotası Verileri</h2>
<br />

<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Şehir</th>
        <th>Gün - Gece</th>
        <th>Fiyat</th>
        <th>Kapasite</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 21 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
     foreach(var item in Model)
            {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
                   Write(item.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
                   Write(item.daynight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
                   Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
                   Write(item.capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 761, "\"", 817, 2);
            WriteAttributeValue("", 768, "/Admin/DestinationCQRS/DeleteDestination/", 768, 41, true);
#nullable restore
#line 30 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 809, item.id, 809, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 890, "\"", 943, 2);
            WriteAttributeValue("", 897, "/Admin/DestinationCQRS/GetDestination/", 897, 38, true);
#nullable restore
#line 31 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
WriteAttributeValue("", 935, item.id, 935, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\DestinationCQRS\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/DestinationCQRS/AddDestination/\" class=\"btn btn-outline-primary\">Yeni Tur Rotası Girişi</a>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetAllDestinationQueryResult>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
