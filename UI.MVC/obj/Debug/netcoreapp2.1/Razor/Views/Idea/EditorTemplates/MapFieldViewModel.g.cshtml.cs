#pragma checksum "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Idea\EditorTemplates\MapFieldViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f1acee53fe6431b5a100cd97ec6da986aa2601"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Idea_EditorTemplates_MapFieldViewModel), @"mvc.1.0.view", @"/Views/Idea/EditorTemplates/MapFieldViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Idea/EditorTemplates/MapFieldViewModel.cshtml", typeof(AspNetCore.Views_Idea_EditorTemplates_MapFieldViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f1acee53fe6431b5a100cd97ec6da986aa2601", @"/Views/Idea/EditorTemplates/MapFieldViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Idea_EditorTemplates_MapFieldViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/maps.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 14, true);
            WriteLiteral("<fieldset>  \r\n");
            EndContext();
            BeginContext(130, 217, true);
            WriteLiteral("    <meta charset=\"utf-8\">  \r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">  \r\n    <link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\"> \r\n    ");
            EndContext();
            BeginContext(347, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "142ebe2a46244812897fd8bf69e0c4e8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(392, 14, true);
            WriteLiteral(" \r\n    <script");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 406, "\"", 440, 1);
#line 7 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Idea\EditorTemplates\MapFieldViewModel.cshtml"
WriteAttributeValue("", 412, Url.Content("~/js/Maps.js"), 412, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(441, 1178, true);
            WriteLiteral(@"></script>


    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>  
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js""></script>  
  
    <input id=""pac-input"" class=""controls"" type=""text"" placeholder=""Search Box"">

    <div id=""map"" style=""height:200px;width:50%;""></div>  
    <script>  
        function myMap() {  
            var myCenter = new google.maps.LatLng(51.2171918, 4.4212529);  
            var mapProp = { center: myCenter, zoom: 15, scrollwheel: false, draggable: true, mapTypeId: google.maps.MapTypeId.ROADMAP };  
            var map = new google.maps.Map(document.getElementById(""map""), mapProp);  
            var marker = new google.maps.Marker({ position: myCenter });  
            marker.setMap(map);  
        }  
    </script>  
    <script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBpGkcxEKiXUYAvr2HPj9bhYvs0uZsllW4&libraries=places&callback=initAutocomplete""
            async defer></sc");
            WriteLiteral("ript>\r\n    \r\n</fieldset>  \r\n<footer>  \r\n    <p style=\"background-color: Yellow; font-weight: bold; color:blue; text-align: center; font-style: oblique\">© ");
            EndContext();
            BeginContext(1620, 26, false);
#line 30 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Idea\EditorTemplates\MapFieldViewModel.cshtml"
                                                                                                             Write(DateTime.Now.ToLocalTime());

#line default
#line hidden
            EndContext();
            BeginContext(1646, 5, true);
            WriteLiteral("</p> ");
            EndContext();
            BeginContext(1668, 15, true);
            WriteLiteral("  \r\n</footer>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
