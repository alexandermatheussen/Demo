#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4b32f65903f30298c1799d1ae77fa448e40137"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ImageTest), @"mvc.1.0.view", @"/Views/Project/ImageTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/ImageTest.cshtml", typeof(AspNetCore.Views_Project_ImageTest))]
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
#line 2 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml"
using Microsoft.AspNetCore.Identity.UI.Pages.Internal;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4b32f65903f30298c1799d1ae77fa448e40137", @"/Views/Project/ImageTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_ImageTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Domain.ImageField>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml"
  
    ViewData["Title"] = "Upload page";

#line default
#line hidden
            BeginContext(142, 9, true);
            WriteLiteral("\r\n<script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 151, "\"", 193, 1);
#line 7 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml"
WriteAttributeValue("", 157, Url.Content("~/js/UploadScript.js"), 157, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(194, 203, true);
            WriteLiteral("></script>\r\n\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
            EndContext();
            BeginContext(397, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ebcfe5a31e94b47a67acc4e089853e8", async() => {
                BeginContext(476, 98, true);
                WriteLiteral("\r\n    <input id=\"files\" name=\"files\" type=\"file\" multiple onchange=\"fileupload(\'files\');\"/>\r\n   \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(581, 4, true);
            WriteLiteral("\r\n//");
            EndContext();
            BeginContext(686, 57, true);
            WriteLiteral(" \r\n\r\n<div class=\"container\">\r\n    <h2>\"Image list\"</h2>\r\n");
            EndContext();
#line 21 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml"
     foreach (var item in Model)
    {
        var base64 = Convert.ToBase64String(item.imageData);
       // var imageData = String.Format("data:image/png;base64,{0}", base64);
        ViewBag.imageData =String.Format("data:image/png;base64,{0}", base64);


#line default
#line hidden
            BeginContext(1007, 12, true);
            WriteLiteral("        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1019, "\"", 1043, 1);
#line 27 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml"
WriteAttributeValue("", 1025, ViewBag.imageData, 1025, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1044, 39, true);
            WriteLiteral(" style=\"height:100px;width:100px;\" />\r\n");
            EndContext();
#line 28 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Project\ImageTest.cshtml"
    }

#line default
#line hidden
            BeginContext(1090, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Domain.ImageField>> Html { get; private set; }
    }
}
#pragma warning restore 1591
