#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef379e49edc63933a61b2dbf66aaf160b51818bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_Questionnaire), @"mvc.1.0.view", @"/Views/Questionnaire/Questionnaire.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/Questionnaire.cshtml", typeof(AspNetCore.Views_Questionnaire_Questionnaire))]
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
#line 1 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef379e49edc63933a61b2dbf66aaf160b51818bf", @"/Views/Questionnaire/Questionnaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FillInQuestionnaireModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 69, true);
            WriteLiteral("\r\n<h1>Complete a questionnaire</h1>\r\n<h4>The questionnaire is about: ");
            EndContext();
            BeginContext(118, 24, false);
#line 5 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Model.questionnaire.name);

#line default
#line hidden
            EndContext();
            BeginContext(142, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 6 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
 using (Html.BeginForm("CreateUserQuestion", "Questionnaire",
    new { userId=1 }, FormMethod.Post))
{

#line default
#line hidden
            BeginContext(256, 27, true);
            WriteLiteral("    <table class=\"table\">\r\n");
            EndContext();
#line 10 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
         foreach (var item in Model.questions)
        {
            if (item.questionType == QuestionType.MAILADDRESS)
            {

#line default
#line hidden
            BeginContext(421, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(494, 43, false);
#line 16 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(537, 37, true);
            WriteLiteral(" <br>\r\n                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 574, "\"", 596, 2);
            WriteAttributeValue("", 581, "Answer-", 581, 7, true);
#line 17 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 588, item.id, 588, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(597, 65, true);
            WriteLiteral(" type=\"text\">\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 20 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.DROPDOWN)
            {

#line default
#line hidden
            BeginContext(753, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(826, 43, false);
#line 25 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(869, 54, true);
            WriteLiteral(" <br>\r\n                        <select id=\"ddlOptions\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 923, "\"", 945, 2);
            WriteAttributeValue("", 930, "Answer-", 930, 7, true);
#line 26 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 937, item.id, 937, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(946, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(977, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e81c9597136454a809d3e108d9b157c", async() => {
                BeginContext(995, 13, true);
                WriteLiteral("Please select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1017, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(1117, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1149, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e6fe323826f4c23afe1d7280c11dfb1", async() => {
                BeginContext(1181, 13, false);
#line 30 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                          Write(option.option);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                   WriteLiteral(option.option);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(1236, 85, true);
            WriteLiteral("                        </select>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.OPEN_QUESTION)
            {

#line default
#line hidden
            BeginContext(1417, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1490, 43, false);
#line 40 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 40, true);
            WriteLiteral(" <br>\r\n                        <textarea");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1573, "\"", 1595, 2);
            WriteAttributeValue("", 1580, "Answer-", 1580, 7, true);
#line 41 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1587, item.id, 1587, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1596, 76, true);
            WriteLiteral(" type=\"text\"></textarea>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 44 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.RADIO_BUTTON)
            {

#line default
#line hidden
            BeginContext(1767, 81, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1848, "\"", 1861, 1);
#line 49 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1853, item.id, 1853, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1862, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1894, 43, false);
#line 50 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(1937, 7, true);
            WriteLiteral(" <br>\r\n");
            EndContext();
#line 51 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(2042, 51, true);
            WriteLiteral("                                <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2093, "\"", 2115, 1);
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2101, option.option, 2101, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2116, "\"", 2138, 2);
            WriteAttributeValue("", 2123, "Answer-", 2123, 7, true);
#line 53 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2130, item.id, 2130, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2139, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
            BeginContext(2176, 43, false);
#line 54 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 55 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(2256, 87, true);
            WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.CHECK_BOX)
            {

#line default
#line hidden
            BeginContext(2435, 81, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2516, "\"", 2529, 1);
#line 64 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2521, item.id, 2521, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2530, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(2562, 43, false);
#line 65 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(2605, 7, true);
            WriteLiteral(" <br>\r\n");
            EndContext();
#line 66 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(2710, 54, true);
            WriteLiteral("                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2764, "\"", 2786, 1);
#line 68 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2772, option.option, 2772, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2787, "\"", 2809, 2);
            WriteAttributeValue("", 2794, "Answer-", 2794, 7, true);
#line 68 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2801, item.id, 2801, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2810, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
            BeginContext(2847, 43, false);
#line 69 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
            EndContext();
            BeginContext(2890, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 70 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(2927, 87, true);
            WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 74 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3040, 135, true);
            WriteLiteral("    </table>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Submit answers\" class=\"btn btn-default\"/>\r\n    </div>\r\n");
            EndContext();
#line 80 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FillInQuestionnaireModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
