#pragma checksum "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab2c869dfd135a34f9ea97fb283e1ada71038c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__CommentList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
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
#line 1 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2c869dfd135a34f9ea97fb283e1ada71038c51", @"/Views/Shared/Components/_CommentList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__CommentList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"comments mt-5\">\r\n    <h4 class=\"side-title \">Yorumlar (");
#nullable restore
#line 5 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                                 Write(ViewBag.commentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"media mt-4\">\r\n            <div class=\"img-circle\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 282, "\"", 310, 1);
#nullable restore
#line 10 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
WriteAttributeValue("", 288, item.AppUser.ImageUrl, 288, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" alt=\"...\">\r\n            </div>\r\n            <div class=\"media-body\">\r\n\r\n                <ul class=\"time-rply mb-2\">\r\n                    <li>\r\n                        <a href=\"#URL\" class=\"name mt-0 mb-2 d-block\"> ");
#nullable restore
#line 16 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                                                                  Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 16 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                                                                                     Write(item.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        ");
#nullable restore
#line 17 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
                    Write(((DateTime)item.CommentDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </li>
                    <li class=""reply-last"">
                        <a href=""#reply"" class=""reply"">
                            Yanıtla
                        </a>
                    </li>
                </ul>
                <p>
                    ");
#nullable restore
#line 27 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
               Write(item.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 31 "C:\Users\user\Desktop\TraversalCamp\TraversalCoreProje\TraversalCoreProje\Views\Shared\Components\_CommentList\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
