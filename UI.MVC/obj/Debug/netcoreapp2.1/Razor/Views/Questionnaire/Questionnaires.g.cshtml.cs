#pragma checksum "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d315993298c6fa7de3eb5a207bd0b292e68a462f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_Questionnaires), @"mvc.1.0.view", @"/Views/Questionnaire/Questionnaires.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/Questionnaires.cshtml", typeof(AspNetCore.Views_Questionnaire_Questionnaires))]
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
#line 1 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d315993298c6fa7de3eb5a207bd0b292e68a462f", @"/Views/Questionnaire/Questionnaires.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaires : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.Questionnaire>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 37, true);
            WriteLiteral("\r\n<h1>Questionnaires</h1> \r\n<p>\r\n    ");
            EndContext();
            BeginContext(80, 154, false);
#line 5 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
Write(Html.ActionLink("Create a new questionnaire", "CreateQuestionnairePage", 
        "Questionnaire", new { projectId=Model.ToList()[0].project.projectId }));

#line default
#line hidden
            EndContext();
            BeginContext(234, 177, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            <p>name</p>\r\n        </th>\r\n        <th>\r\n            <p>Amount of questions</p>\r\n        </th>\r\n    </tr>\r\n");
            EndContext();
#line 18 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
     foreach (var item in Model)
    {    

#line default
#line hidden
            BeginContext(456, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(517, 39, false);
#line 22 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
            EndContext();
            BeginContext(556, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(624, 49, false);
#line 25 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.DisplayFor(modelItem => item.questionAmount));

#line default
#line hidden
            EndContext();
            BeginContext(673, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(741, 134, false);
#line 28 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
               Write(Html.ActionLink("Complete Questionnaire", "Questionnaire", "Questionnaire"
                        , new { questionnaireId=item.id }));

#line default
#line hidden
            EndContext();
            BeginContext(875, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 32 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaires.cshtml"
        
    }

#line default
#line hidden
            BeginContext(936, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.Questionnaire>> Html { get; private set; }
    }
}
#pragma warning restore 1591
