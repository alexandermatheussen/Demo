#pragma checksum "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc09785569cd5f66f77b9e7222613de1f7c8de2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc09785569cd5f66f77b9e7222613de1f7c8de2", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/park1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/straat2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/building3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/park4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/park3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/straat3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Overzicht";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(49, 12360, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "927ad93984414d098de16b44bb758ddd", async() => {
                BeginContext(55, 1020, true);
                WriteLiteral(@"
    <h2 class=""text-center""><b>Onze projecten</b></h2>
    <div class=""container mt-3"">

        <!-- tabs -->
        <ul class=""nav nav-tabs"">
            <li class=""nav-item"">
                <a class=""nav-link active"" data-toggle=""tab"" href=""#ongoing"">Ongoing</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-toggle=""tab"" href=""#closed"">Closed</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" data-toggle=""tab"" href=""#recent"">Recent</a>
            </li>
        </ul>
    </div>
    <!-- Tab panes -->
    <div class=""p-5"">
        <div class=""tab-content"">

            <div id=""ongoing"" class=""container tab-pane active"">

                <div class=""row mb-4"">
                    <div class=""col-md-4"">
                        <div class=""card bg-dark text-white text-center"">
                            <h5 class=""text-center""><b>Park project - Wilrijk</b></h5>
                            ");
                EndContext();
                BeginContext(1075, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8f7fafaaaa034fc683bf7a096ed84e91", async() => {
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
                BeginContext(1124, 788, true);
                WriteLiteral(@"
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:40%""></div>

                            </div>
                            <div>
                                <i class=""far fa-heart""></i>
                                <i class=""far fa-comments""></i>
                                <i class=""fas fa-share-alt""></i>


                            </div>
                        </div>
                    </div>


                    <div class=""col-md-4"">
                        <div class=""card bg-info text-white text-center"">
                            <h5 class=""text-center""><b>Straat project - Berchem</b></h5>
                            ");
                EndContext();
                BeginContext(1912, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "43972d2979b142c5985d4dfb91cd8af8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1963, 781, true);
                WriteLiteral(@"
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:60%""></div>
                            </div>
                            <div>
                                <i class=""far fa-heart""></i>
                                <i class=""far fa-comments""></i>
                                <i class=""fas fa-share-alt""></i>


                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card bg-dark text-white text-center"">
                            <h5 class=""text-center""><b>Gebouw project - Edegem</b></h5>
                            ");
                EndContext();
                BeginContext(2744, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c46f4c1a7e74e1fa0e5ef56e805f003", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2797, 845, true);
                WriteLiteral(@"
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:30%""></div>
                            </div>
                            <div>
                                <i class=""far fa-heart""></i>
                                <i class=""far fa-comments""></i>
                                <i class=""fas fa-share-alt""></i>


                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row mb-4"">
                    <div class=""col-md-4"">
                        <div class=""card bg-info text-white text-center"">
                            <h5 class=""text-center""><b>Park project - Boechout</b></h5>
                            ");
                EndContext();
                BeginContext(3642, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3bd1a5a136484bf2abef280565161021", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3691, 779, true);
                WriteLiteral(@"
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:10%""></div>
                            </div>
                            <div>
                                <i class=""far fa-heart""></i>
                                <i class=""far fa-comments""></i>
                                <i class=""fas fa-share-alt""></i>

                            </div>
                        </div>
                    </div>

                    <div class=""col-md-4"">
                        <div class=""card bg-dark text-white text-center"">
                            <h5 class=""text-center""><b>Park project - Deurne</b></h5>
                            ");
                EndContext();
                BeginContext(4470, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2e8b4aaf90ef4073a16b13181de625ed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4519, 780, true);
                WriteLiteral(@"
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:60%""></div>
                            </div>
                            <div>
                                <i class=""far fa-heart""></i>
                                <i class=""far fa-comments""></i>
                                <i class=""fas fa-share-alt""></i>
                            </div>

                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card bg-info text-white text-center"">
                            <h5 class=""text-center""><b>Straat project - Berchem</b></h5>
                            ");
                EndContext();
                BeginContext(5299, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e8132270568464bb5e2586cc90f2ce5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5350, 831, true);
                WriteLiteral(@"
                            <div class=""progress"">
                                <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:20%""></div>
                            </div>
                            <div>
                                <i class=""far fa-heart""></i>
                                <i class=""far fa-comments""></i>
                                <i class=""fas fa-share-alt""></i>

                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div id=""closed"" class=""container tab-pane fade"">
                <div class=""row"">
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een park project</b></h5>
                        ");
                EndContext();
                BeginContext(6181, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73ba74988161435b8d87d33e7f21c327", async() => {
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
                BeginContext(6230, 628, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:100%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een straat project</b></h5>
                        ");
                EndContext();
                BeginContext(6858, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "05193ee28c484e48ab60ded16455c465", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6909, 626, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:100%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een park project</b></h5>
                        ");
                EndContext();
                BeginContext(7535, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "695dfe5052004cf9b7ef478da675ad01", async() => {
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
                BeginContext(7584, 685, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:100%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een park project</b></h5>
                        ");
                EndContext();
                BeginContext(8269, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "089d6d9475ca49a8b02fadc886da4b8d", async() => {
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
                BeginContext(8318, 628, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:100%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een straat project</b></h5>
                        ");
                EndContext();
                BeginContext(8946, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1aa26f1a1d4e4639be5ef7a3e859166e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8997, 626, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:100%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een park project</b></h5>
                        ");
                EndContext();
                BeginContext(9623, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "933be140b41c4c70a700e4e697acd740", async() => {
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
                BeginContext(9672, 772, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:100%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                </div>
            </div>

            <div id=""recent"" class=""container tab-pane fade"">
                <div class=""row"">
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een gebouw project</b></h5>
                        ");
                EndContext();
                BeginContext(10444, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9b27a5ac0f394357b3e9f6c623e43ce8", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10497, 627, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:60%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een straat project</b></h5>
                        ");
                EndContext();
                BeginContext(11124, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a8365f8290f34c64a191d553e58f473c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11175, 625, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:60%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>


                        </div>
                    </div>
                    <div class=""column"">
                        <h5 class=""text-center""><b>Een park project</b></h5>
                        ");
                EndContext();
                BeginContext(11800, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b62f67250b514b159b4ee0568d5f05ac", async() => {
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
                BeginContext(11849, 553, true);
                WriteLiteral(@"
                        <div class=""progress"">
                            <div class=""progress-bar progress-bar-striped progress-bar-animated"" style=""width:60%""></div>
                        </div>
                        <div>
                            <i class=""far fa-heart""></i>
                            <i class=""far fa-comments""></i>
                            <i class=""fas fa-share-alt""></i>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
