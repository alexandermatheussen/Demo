#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39817d5834cb5f777fa670ed7763ccced7e3c7d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Project), @"mvc.1.0.view", @"/Views/Project/Project.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Project.cshtml", typeof(AspNetCore.Views_Project_Project))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39817d5834cb5f777fa670ed7763ccced7e3c7d6", @"/Views/Project/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectAndQuestions>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 11, true);
            WriteLiteral("\r\n\r\n\r\n<h2> ");
            EndContext();
            BeginContext(55, 18, false);
#line 6 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
Write(Model.project.name);

#line default
#line hidden
            EndContext();
            BeginContext(73, 177, true);
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>Ideation Id </p>\r\n        </th>\r\n\r\n        <th>\r\n            <p>Question</p>\r\n        </th>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 19 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
     foreach (var item in Model.ideationQuestions)
    {
        

#line default
#line hidden
            BeginContext(319, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(368, 55, false);
#line 24 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.DisplayFor( modelItem => item.ideation.ideationId));

#line default
#line hidden
            EndContext();
            BeginContext(423, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(493, 43, false);
#line 28 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(536, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(592, 123, false);
#line 31 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.ActionLink("Create Idea", "CreateIdeaPage", "Idea"
                    , new { ideationId=item.ideation.ideationId }));

#line default
#line hidden
            EndContext();
            BeginContext(715, 69, true);
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
            EndContext();
            BeginContext(785, 103, false);
#line 36 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
           Write(Html.ActionLink("Ideas", "Ideas", "Project"
                    , new { id=item.ideation.ideationId }));

#line default
#line hidden
            EndContext();
            BeginContext(888, 38, true);
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 41 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\Project.cshtml"
    }

#line default
#line hidden
            BeginContext(933, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectAndQuestions> Html { get; private set; }
    }
}
#pragma warning restore 1591
