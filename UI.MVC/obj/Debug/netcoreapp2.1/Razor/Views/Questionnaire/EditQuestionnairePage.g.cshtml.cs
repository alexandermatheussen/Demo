#pragma checksum "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "515597df1e9704225dcec0275b9104e205bd3af6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questionnaire_EditQuestionnairePage), @"mvc.1.0.view", @"/Views/Questionnaire/EditQuestionnairePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questionnaire/EditQuestionnairePage.cshtml", typeof(AspNetCore.Views_Questionnaire_EditQuestionnairePage))]
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
#line 1 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC;

#line default
#line hidden
#line 2 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\_ViewImports.cshtml"
using D.UI.MVC.Models;

#line default
#line hidden
#line 1 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"515597df1e9704225dcec0275b9104e205bd3af6", @"/Views/Questionnaire/EditQuestionnairePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Questionnaire_EditQuestionnairePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionnaireQuestion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/dynamicForm.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 87, true);
            WriteLiteral("\r\n<script src=\"//ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(132, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ce59d13985f454099fdab36a4cd3c71", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 5 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
  
    int fieldSetCount = 1;
    int optionSetCount = 1;

#line default
#line hidden
            BeginContext(269, 33, true);
            WriteLiteral("\r\n<h1>Edit questionnaire</h1>\r\n\r\n");
            EndContext();
#line 14 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
 using (Html.BeginForm("EditQuestionnaire", "Questionnaire", FormMethod.Post))
{

#line default
#line hidden
            BeginContext(385, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(389, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "70c0a75986d34723920a93e6caf8e2fa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 16 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.questionnaire.id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(437, 129, true);
            WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td>\r\n                <h4>What is the name of your questionnaire?</h4>\r\n                ");
            EndContext();
            BeginContext(566, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c0e52265bc1b4a319c1fca1c56e7b532", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.questionnaire.name);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(614, 234, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <h4>Add questions to your existing questionnaire:</h4>\r\n                <button type=\"button\" id=\"btnAddField\">Add Question</button>\r\n                ");
            EndContext();
            BeginContext(849, 23, false);
#line 28 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(872, 37, true);
            WriteLiteral("\r\n                <div id=\"fields\">\r\n");
            EndContext();
#line 30 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                     foreach (var question in Model.questions)
                    {

#line default
#line hidden
            BeginContext(996, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1024, "\"", 1058, 1);
#line 32 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1029, "dynamicDiv"+fieldSetCount, 1029, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1059, 134, true);
            WriteLiteral(">\r\n                            <hr>\r\n                            <h5>What do you want to ask?</h5>\r\n                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1193, "\"", 1227, 1);
#line 35 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1200, "question-"+@question.id, 1200, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1228, 12, true);
            WriteLiteral(" type=\"text\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1240, "\"", 1266, 1);
#line 35 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1248, question.question, 1248, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1267, 146, true);
            WriteLiteral("/>\r\n                            <br>\r\n                            <h5>What type of a question is this?</h5>\r\n                            <fieldset");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1413, "\"", 1452, 1);
#line 38 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1418, "dynamicFieldset"+fieldSetCount, 1418, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1453, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 39 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                 if (question.questionType == QuestionType.OPEN_QUESTION)
                                {

#line default
#line hidden
            BeginContext(1580, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1600, "\"", 1639, 1);
#line 40 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1605, "dynamicTextArea"+fieldSetCount, 1605, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " \r\n                                           name=\"", 1640, "\"", 1726, 1);
#line 41 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1692, "dynamicFieldset"+fieldSetCount, 1692, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1727, 29, true);
            WriteLiteral(" value=\"textarea\" checked /> ");
            EndContext();
#line 41 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                                 }
                                else
                                {

#line default
#line hidden
            BeginContext(1830, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1850, "\"", 1889, 1);
#line 43 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1855, "dynamicTextArea"+fieldSetCount, 1855, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", " \r\n                                         name=\"", 1890, "\"", 1974, 1);
#line 44 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 1940, "dynamicFieldset"+fieldSetCount, 1940, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1975, 21, true);
            WriteLiteral(" value=\"textarea\" /> ");
            EndContext();
#line 44 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                       }

#line default
#line hidden
            BeginContext(1999, 95, true);
            WriteLiteral("                                <span> Text area</span>\r\n                                <br>\r\n");
            EndContext();
#line 47 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                 if (question.questionType == QuestionType.MAILADDRESS)
                                {

#line default
#line hidden
            BeginContext(2216, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2236, "\"", 2274, 1);
#line 48 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 2241, "dynamicEmail" + fieldSetCount, 2241, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                           name=\"", 2275, "\"", 2362, 1);
#line 49 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 2326, "dynamicFieldset" + fieldSetCount, 2326, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2363, 25, true);
            WriteLiteral(" value=\"email\" checked/> ");
            EndContext();
#line 49 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                               }
                                else
                                {

#line default
#line hidden
            BeginContext(2462, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2482, "\"", 2520, 1);
#line 51 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 2487, "dynamicEmail" + fieldSetCount, 2487, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                        name=\"", 2521, "\"", 2605, 1);
#line 52 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 2569, "dynamicFieldset" + fieldSetCount, 2569, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2606, 18, true);
            WriteLiteral(" value=\"email\" /> ");
            EndContext();
#line 52 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                     }

#line default
#line hidden
            BeginContext(2627, 98, true);
            WriteLiteral("                                <span> E-mail field</span>\r\n                                <br>\r\n");
            EndContext();
#line 55 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                 if (question.questionType == QuestionType.DROPDOWN)
                                {

#line default
#line hidden
            BeginContext(2844, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2864, "\"", 2905, 1);
#line 56 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 2869, "dynamicDropDown" + fieldSetCount, 2869, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                         name=\"", 2906, "\"", 2991, 1);
#line 57 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 2955, "dynamicFieldset" + fieldSetCount, 2955, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2992, 28, true);
            WriteLiteral(" value=\"dropdown\" checked/> ");
            EndContext();
#line 57 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3094, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3114, "\"", 3155, 1);
#line 59 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 3119, "dynamicDropDown" + fieldSetCount, 3119, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                         name=\"", 3156, "\"", 3241, 1);
#line 60 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 3205, "dynamicFieldset" + fieldSetCount, 3205, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3242, 21, true);
            WriteLiteral(" value=\"dropdown\" /> ");
            EndContext();
#line 60 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                         }

#line default
#line hidden
            BeginContext(3266, 99, true);
            WriteLiteral("                                <span> Dropdown menu</span>\r\n                                <br>\r\n");
            EndContext();
#line 63 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                 if (question.questionType == QuestionType.RADIO_BUTTON)
                                {

#line default
#line hidden
            BeginContext(3488, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3508, "\"", 3552, 1);
#line 64 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 3513, "dynamicRadioButton" + fieldSetCount, 3513, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                        name=\"", 3553, "\"", 3637, 1);
#line 65 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 3601, "dynamicFieldset" + fieldSetCount, 3601, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3638, 31, true);
            WriteLiteral(" value=\"radiobutton\" checked/> ");
            EndContext();
#line 65 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                                  }
                                else
                                {

#line default
#line hidden
            BeginContext(3743, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3763, "\"", 3807, 1);
#line 67 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 3768, "dynamicRadioButton" + fieldSetCount, 3768, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                         name=\"", 3808, "\"", 3893, 1);
#line 68 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 3857, "dynamicFieldset" + fieldSetCount, 3857, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3894, 24, true);
            WriteLiteral(" value=\"radiobutton\" /> ");
            EndContext();
#line 68 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                            }

#line default
#line hidden
            BeginContext(3921, 99, true);
            WriteLiteral("                                <span> Radio buttons</span>\r\n                                <br>\r\n");
            EndContext();
#line 71 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                 if (question.questionType == QuestionType.CHECK_BOX)
                                {

#line default
#line hidden
            BeginContext(4140, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4160, "\"", 4201, 1);
#line 72 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4165, "dynamicCheckBox" + fieldSetCount, 4165, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                         name=\"", 4202, "\"", 4287, 1);
#line 73 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4251, "dynamicFieldset" + fieldSetCount, 4251, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4288, 28, true);
            WriteLiteral(" value=\"checkbox\" checked/> ");
            EndContext();
#line 73 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                                }
                                else
                                {

#line default
#line hidden
            BeginContext(4390, 20, true);
            WriteLiteral(" <input type=\"radio\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4410, "\"", 4451, 1);
#line 75 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4415, "dynamicCheckBox" + fieldSetCount, 4415, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                         name=\"", 4452, "\"", 4537, 1);
#line 76 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4501, "dynamicFieldset" + fieldSetCount, 4501, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4538, 21, true);
            WriteLiteral(" value=\"checkbox\" /> ");
            EndContext();
#line 76 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                                                                                         }

#line default
#line hidden
            BeginContext(4562, 170, true);
            WriteLiteral("                                <span> Check boxes</span>\r\n                                <br>\r\n                            </fieldset>\r\n                            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4732, "\"", 4776, 1);
#line 80 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4737, "addOptionPlaceholder"+fieldSetCount, 4737, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4777, 56, true);
            WriteLiteral(">\r\n                                <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4833, "\"", 4869, 1);
#line 81 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4838, "btnAddOption"+fieldSetCount, 4838, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4870, 90, true);
            WriteLiteral(">Add option</button>\r\n                            </div>\r\n                            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4960, "\"", 5003, 1);
#line 83 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 4965, "optionPlaceholder" + fieldSetCount, 4965, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5004, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 84 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                   var currentOption = optionSetCount; 

#line default
#line hidden
            BeginContext(5081, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 85 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                 foreach (var option in question.options)
                                {

#line default
#line hidden
            BeginContext(5191, 40, true);
            WriteLiteral("                                    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5231, "\"", 5280, 1);
#line 87 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 5236, "optionField"+currentOption+fieldSetCount, 5236, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5281, 61, true);
            WriteLiteral(">\r\n                                        <input type=\"text\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5342, "\"", 5391, 1);
#line 88 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 5347, "inputOption"+currentOption+fieldSetCount, 5347, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("name", "\r\n                                               name=\"", 5392, "\"", 5518, 1);
#line 89 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 5447, "question.options-"+currentOption+"-"+fieldSetCount+"-"+@question.id, 5447, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                               value=\"", 5519, "\"", 5589, 1);
#line 90 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 5575, option.option, 5575, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5590, 65, true);
            WriteLiteral("/>\r\n                                        <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5655, "\"", 5719, 1);
#line 91 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 5660, "btnRemoveOption-" + currentOption + "-" + fieldSetCount, 5660, 59, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5720, 213, true);
            WriteLiteral(">\r\n                                            Remove option\r\n                                        </button>\r\n                                    </div>\r\n                                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 5933, "\"", 5991, 1);
#line 95 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 5940, "currentOption-"+currentOption+"-"+fieldSetCount, 5940, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", "\r\n                                           value=\"", 5992, "\"", 6095, 1);
#line 96 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 6044, "currentOption-"+currentOption+"-"+fieldSetCount, 6044, 51, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6096, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 97 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                                    currentOption++;
                                }

#line default
#line hidden
            BeginContext(6190, 67, true);
            WriteLiteral("                                <input type=\"hidden\" name=\"options\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6257, "\"", 6290, 1);
#line 99 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 6262, "options-"+@fieldSetCount, 6262, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 6291, "\"", 6313, 1);
#line 99 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 6299, currentOption, 6299, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6314, 90, true);
            WriteLiteral(" />\r\n                            </div>\r\n                            <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6404, "\"", 6442, 1);
#line 101 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 6409, "btnRemoveField"+fieldSetCount, 6409, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6443, 59, true);
            WriteLiteral(">Remove question</button>\r\n                        </div>\r\n");
            EndContext();
#line 103 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
                        { fieldSetCount++; }
                    }

#line default
#line hidden
            BeginContext(6571, 136, true);
            WriteLiteral("                </div>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n    <input type=\"hidden\" name=\"fieldSetCount\" id=\"fieldSetCount\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6707, "\"", 6729, 1);
#line 109 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
WriteAttributeValue("", 6715, fieldSetCount, 6715, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6730, 286, true);
            WriteLiteral(@" />
    <h4>Keep in mind that if you edit this questionnaire, all the collected data will be lost because it would not be relevant to the newly edited version!</h4>
    <div class=""form-group"">
        <input type=""submit"" value=""Save changes"" class=""btn btn-default""/>
    </div>
");
            EndContext();
#line 114 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Questionnaire\EditQuestionnairePage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionnaireQuestion> Html { get; private set; }
    }
}
#pragma warning restore 1591
