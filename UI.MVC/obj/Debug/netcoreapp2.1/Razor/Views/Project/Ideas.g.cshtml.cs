#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a48de07abf0717421cdb81172eec2e1d2ee161b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Ideas), @"mvc.1.0.view", @"/Views/Project/Ideas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Ideas.cshtml", typeof(AspNetCore.Views_Project_Ideas))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a48de07abf0717421cdb81172eec2e1d2ee161b", @"/Views/Project/Ideas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Ideas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Idea>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 212, true);
            WriteLiteral("\r\n<h1>Projects</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>User</p>\r\n        </th>\r\n        <th>\r\n            <p>Title</p>\r\n        </th>\r\n        \r\n        <th>Content</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(286, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(335, 34, false);
#line 20 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml"
           Write(item.user.firstName.Substring(0,1));

#line default
#line hidden
            EndContext();
            BeginContext(369, 1, true);
            WriteLiteral(".");
            EndContext();
            BeginContext(371, 48, false);
#line 20 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.user.lastName));

#line default
#line hidden
            EndContext();
            BeginContext(419, 110, true);
            WriteLiteral("\r\n            \r\n           \r\n                          \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(530, 41, false);
#line 26 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml"
           Write(Html.DisplayFor(modelItem => item.ideaId));

#line default
#line hidden
            EndContext();
            BeginContext(571, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(641, 41, false);
#line 30 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml"
           Write(Html.DisplayFor(modelItem => item.ideaId));

#line default
#line hidden
            EndContext();
            BeginContext(682, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Ideas.cshtml"
    }

#line default
#line hidden
            BeginContext(725, 22, true);
            WriteLiteral("    \r\n    \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Idea>> Html { get; private set; }
    }
}
#pragma warning restore 1591
