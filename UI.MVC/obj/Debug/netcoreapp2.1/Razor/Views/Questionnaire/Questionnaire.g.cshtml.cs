#pragma checksum "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ae372a8d5a151ddb406dbe71bdd733378dce7c7"
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
#line 1 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC;

#line default
#line hidden
#line 2 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC.Models;

#line default
#line hidden
#line 1 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae372a8d5a151ddb406dbe71bdd733378dce7c7", @"/Views/Questionnaire/Questionnaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_Questionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CombinedModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ddlOptions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 26, true);
            WriteLiteral("\r\n<h1>Questionnaire</h1>\r\n");
            EndContext();
#line 5 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
 using (Html.BeginForm("CreateUserQuestion", "Questionnaire",
    new { userId=1 }, FormMethod.Post))
{

#line default
#line hidden
            BeginContext(170, 27, true);
            WriteLiteral("    <table class=\"table\">\r\n");
            EndContext();
#line 9 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
         foreach (var item in Model.questions)
        {
            //Is het oke om de id zo mee te geven?

#line default
#line hidden
            BeginContext(308, 50, true);
            WriteLiteral("            <input type=\"hidden\" name=\"questionId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 358, "\"", 374, 1);
#line 12 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 366, item.id, 366, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(375, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
#line 13 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            if (item.questionType == QuestionType.MAILADDRESS)
            {

#line default
#line hidden
            BeginContext(458, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(531, 43, false);
#line 17 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(574, 31, true);
            WriteLiteral(" <br>\r\n                        ");
            EndContext();
            BeginContext(605, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "323bfbf94b4e41179ff969f02a95523a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 18 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.questionUser.Answer);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(654, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 21 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.DROPDOWN)
            {

#line default
#line hidden
            BeginContext(797, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(870, 43, false);
#line 26 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(913, 31, true);
            WriteLiteral(" <br>\r\n                        ");
            EndContext();
            BeginContext(944, 376, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0580feaf6ad84dde84711db94405f934", async() => {
                BeginContext(998, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1028, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f703df783b6496c89739663e9db6740", async() => {
                    BeginContext(1046, 13, true);
                    WriteLiteral("Please select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1068, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
                BeginContext(1168, 32, true);
                WriteLiteral("                                ");
                EndContext();
                BeginContext(1200, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "559f7b0de2834667977bc030b3bda06c", async() => {
                    BeginContext(1232, 13, false);
#line 31 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                          Write(option.option);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 31 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
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
                BeginContext(1254, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
                BeginContext(1287, 24, true);
                WriteLiteral("                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 27 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.questionUser.Answer);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1320, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 36 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.OPEN_QUESTION)
            {

#line default
#line hidden
            BeginContext(1468, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1541, 43, false);
#line 41 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                   Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 31, true);
            WriteLiteral(" <br>\r\n                        ");
            EndContext();
            BeginContext(1615, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6d68f1ce59841458e1e04cae6a549c0", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
#line 42 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.questionUser.Answer);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1678, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 45 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.RADIO_BUTTON)
            {

#line default
#line hidden
            BeginContext(1825, 81, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1906, "\"", 1919, 1);
#line 50 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 1911, item.id, 1911, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1920, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(1952, 43, false);
#line 51 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 7, true);
            WriteLiteral(" <br>\r\n");
            EndContext();
#line 52 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(2100, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2132, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b58a7fcf99ac4497ac8b51c2a65e0487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 54 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.questionUser.Answer);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#line 54 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                                             WriteLiteral(option.option);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 54 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                                                                                                   WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2222, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2257, 43, false);
#line 55 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
            EndContext();
            BeginContext(2300, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 56 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(2337, 87, true);
            WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 60 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
            if (item.questionType == QuestionType.CHECK_BOX)
            {

#line default
#line hidden
            BeginContext(2516, 81, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2597, "\"", 2610, 1);
#line 65 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2602, item.id, 2602, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2611, 31, true);
            WriteLiteral(">\r\n                            ");
            EndContext();
            BeginContext(2643, 43, false);
#line 66 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                       Write(Html.DisplayFor(modelItem => item.question));

#line default
#line hidden
            EndContext();
            BeginContext(2686, 7, true);
            WriteLiteral(" <br>\r\n");
            EndContext();
#line 67 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                             foreach (var option in item.options)
                            {

#line default
#line hidden
            BeginContext(2791, 54, true);
            WriteLiteral("                                <input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2845, "\"", 2867, 1);
#line 69 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue("", 2853, option.option, 2853, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2868, "\"", 2892, 2);
            WriteAttributeValue("", 2875, "CheckBox", 2875, 8, true);
#line 69 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
WriteAttributeValue(" ", 2883, item.id, 2884, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2893, 4, true);
            WriteLiteral("/>\r\n");
            EndContext();
            BeginContext(2930, 43, false);
#line 70 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                           Write(Html.DisplayFor(modelItem => option.option));

#line default
#line hidden
            EndContext();
            BeginContext(2973, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
#line 71 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
                            }

#line default
#line hidden
            BeginContext(3010, 87, true);
            WriteLiteral("                        </fieldset>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 75 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(3123, 204, true);
            WriteLiteral("    </table>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Submit answers\" class=\"btn btn-default\"/>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 83 "D:\OneDrive\Documenten\Nieuwe map\Demo\UI.MVC\Views\Questionnaire\Questionnaire.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CombinedModel> Html { get; private set; }
    }
}
#pragma warning restore 1591