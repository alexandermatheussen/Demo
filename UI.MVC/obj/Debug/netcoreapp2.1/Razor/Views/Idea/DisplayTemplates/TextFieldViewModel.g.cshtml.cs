#pragma checksum "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Idea\DisplayTemplates\TextFieldViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c14edb0f3084f35638ba43eb11b04fdbce69c149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_DisplayTemplates_TextFieldViewModel), @"mvc.1.0.view", @"/Views/Idea/DisplayTemplates/TextFieldViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/DisplayTemplates/TextFieldViewModel.cshtml", typeof(AspNetCore.Views_Idea_DisplayTemplates_TextFieldViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c14edb0f3084f35638ba43eb11b04fdbce69c149", @"/Views/Idea/DisplayTemplates/TextFieldViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_DisplayTemplates_TextFieldViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<D.UI.MVC.Models.Ideas.TextFieldViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(55, 10, false);
#line 3 "C:\Users\Alex\Desktop\Stack\‌IntegratieProject 2019\GitRepo\Demo\UI.MVC\Views\Idea\DisplayTemplates\TextFieldViewModel.cshtml"
Write(Model.text);

#line default
#line hidden
            EndContext();
            BeginContext(65, 10, true);
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<D.UI.MVC.Models.Ideas.TextFieldViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
