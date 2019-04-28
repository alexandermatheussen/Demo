#pragma checksum "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64768b8c269da13dceabd3f045db12f315ed08e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64768b8c269da13dceabd3f045db12f315ed08e", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e921430786b9bb2d70116aa71166443f450cca8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Cem\Documents\GitHub\Demo\UI.MVC\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Admin page";

#line default
#line hidden
            BeginContext(46, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(54, 12201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab5ee6035221491dbea594d4244d7f72", async() => {
                BeginContext(60, 7745, true);
                WriteLiteral(@"



    <!-- ACTIONS -->
    <section id=""actions"" class=""py-4 mb-4"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <a href=""#"" class=""btn btn-primary btn-block"" data-toggle=""modal"" data-target=""#addPostModal"">
                        <i class=""fas fa-plus""></i> Add Post
                    </a>
                </div>
                <div class=""col-md-3"">
                    <a href=""#"" class=""btn btn-success btn-block"" data-toggle=""modal"" data-target=""#addCategoryModal"">
                        <i class=""fas fa-plus""></i> Add Category
                    </a>
                </div>
                <div class=""col-md-3"">
                    <a href=""#"" class=""btn btn-warning btn-block"" data-toggle=""modal"" data-target=""#addUserModal"">
                        <i class=""fas fa-plus""></i> Add User
                    </a>
                </div>
            </div>
        </div>
    </section>

    <!-- POSTS -->");
                WriteLiteral(@"
    <section id=""posts"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-9"">
                    <div class=""card bg-dark"">
                        <div class=""card-header"">
                            <h4>Recente Posts</h4>
                        </div>
                        <table class=""table text-white"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>#</th>
                                    <th>Titel</th>
                                    <th>Onderwerp</th>
                                    <th>Datum</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>1</td>
                                    <td>Post One</td>
                                    <td>dummy</");
                WriteLiteral(@"td>
                                    <td>May 10 2018</td>
                                    <td>
                                        <a href=""details.html"" class=""btn btn-secondary"">
                                            <i class=""fas fa-angle-double-right""></i> Details
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>2</td>
                                    <td>Post Two</td>
                                    <td>dummy</td>
                                    <td>May 11 2018</td>
                                    <td>
                                        <a href=""details.html"" class=""btn btn-secondary"">
                                            <i class=""fas fa-angle-double-right""></i> Details
                                        </a>
                                    </td>
                                </tr>");
                WriteLiteral(@"
                                <tr>
                                    <td>3</td>
                                    <td>Post Three</td>
                                    <td>dummy</td>
                                    <td>May 13 2018</td>
                                    <td>
                                        <a href=""details.html"" class=""btn btn-secondary"">
                                            <i class=""fas fa-angle-double-right""></i> Details
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>4</td>
                                    <td>Post Four</td>
                                    <td>dummy</td>
                                    <td>May 15 2018</td>
                                    <td>
                                        <a href=""details.html"" class=""btn btn-secondary"">
                            ");
                WriteLiteral(@"                <i class=""fas fa-angle-double-right""></i> Details
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>5</td>
                                    <td>Post Five</td>
                                    <td>dummy </td>
                                    <td>May 17 2018</td>
                                    <td>
                                        <a href=""details.html"" class=""btn btn-secondary"">
                                            <i class=""fas fa-angle-double-right""></i> Details
                                        </a>
                                    </td>
                                </tr>
                                <tr>
                                    <td>6</td>
                                    <td>Post Six</td>
                                    <td>dummy</td>
                           ");
                WriteLiteral(@"         <td>May 20 2018</td>
                                    <td>
                                        <a href=""details.html"" class=""btn btn-secondary"">
                                            <i class=""fas fa-angle-double-right""></i> Details
                                        </a>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""col-md-3"">
                    <div class=""card text-center bg-primary text-white mb-3"">
                        <div class=""card-body"">
                            <h3>Posts</h3>
                            <h4 class=""display-4"">
                                <i class=""fas fa-pencil-alt""></i> 6
                            </h4>
                            <a href=""posts.html"" class=""btn btn-outline-light btn-sm"">View</a>
                        </div>
                 ");
                WriteLiteral(@"   </div>

                    <div class=""card text-center bg-success text-white mb-3"">
                        <div class=""card-body"">
                            <h3>Categories</h3>
                            <h4 class=""display-4"">
                                <i class=""fas fa-folder""></i> 4
                            </h4>
                            <a href=""categories.html"" class=""btn btn-outline-light btn-sm"">View</a>
                        </div>
                    </div>

                    <div class=""card text-center bg-warning text-white mb-3"">
                        <div class=""card-body"">
                            <h3>Users</h3>
                            <h4 class=""display-4"">
                                <i class=""fas fa-users""></i> 4
                            </h4>
                            <a href=""users.html"" class=""btn btn-outline-light btn-sm"">View</a>
                        </div>
                    </div>
                </div>
            </di");
                WriteLiteral(@"v>
        </div>
    </section>


    <!-- MODALS -->
    <!-- ADD POST MODAL -->
    <div class=""modal fade"" id=""addPostModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header bg-primary text-white"">
                    <h5 class=""modal-title"">Add Post</h5>
                    <button class=""close"" data-dismiss=""modal"">
                        <span>&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(7805, 1502, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e38ee32f00d4062b41e7634db00a66a", async() => {
                    BeginContext(7811, 425, true);
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""title"">Title</label>
                            <input type=""text"" class=""form-control"">
                        </div>
                        <div class=""form-group"">
                            <label for=""category"">Category</label>
                            <select class=""form-control"">
                                ");
                    EndContext();
                    BeginContext(8236, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d7bcb23b12c488f9fcd81bbafcc26d5", async() => {
                        BeginContext(8253, 5, true);
                        WriteLiteral("dummy");
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
                    BeginContext(8267, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(8301, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fa47d36eff448cd9fb52c3e02dea692", async() => {
                        BeginContext(8318, 5, true);
                        WriteLiteral("dummy");
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
                    BeginContext(8332, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(8366, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d1e4219ee3f422f951382e39cfd65d3", async() => {
                        BeginContext(8383, 5, true);
                        WriteLiteral("dummy");
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
                    BeginContext(8397, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                    BeginContext(8431, 31, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26200f1ab5514491a77365d96cf32a49", async() => {
                        BeginContext(8448, 5, true);
                        WriteLiteral("dummy");
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
                    BeginContext(8462, 838, true);
                    WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""image"">Upload Image</label>
                            <div class=""custom-file"">
                                <input type=""file"" class=""custom-file-input"" id=""image"">
                                <label for=""image"" class=""custom-file-label"">Choose File</label>
                            </div>
                            <small class=""form-text text-muted"">Max Size 3mb</small>
                        </div>
                        <div class=""form-group"">
                            <label for=""body"">Body</label>
                            <textarea name=""editor1"" class=""form-control""></textarea>
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9307, 768, true);
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-primary"" data-dismiss=""modal"">Save Changes</button>
                </div>
            </div>
        </div>
    </div>

    <!-- ADD CATEGORY MODAL -->
    <div class=""modal fade"" id=""addCategoryModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header bg-success text-white"">
                    <h5 class=""modal-title"">Add Category</h5>
                    <button class=""close"" data-dismiss=""modal"">
                        <span>&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(10075, 249, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57c3ec1ddf284fccad374854f5e447e1", async() => {
                    BeginContext(10081, 236, true);
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <label for=\"title\">Title</label>\r\n                            <input type=\"text\" class=\"form-control\">\r\n                        </div>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(10324, 756, true);
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-success"" data-dismiss=""modal"">Save Changes</button>
                </div>
            </div>
        </div>
    </div>

    <!-- ADD USER MODAL -->
    <div class=""modal fade"" id=""addUserModal"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header bg-warning text-white"">
                    <h5 class=""modal-title"">Add User</h5>
                    <button class=""close"" data-dismiss=""modal"">
                        <span>&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    ");
                EndContext();
                BeginContext(11080, 919, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ec88fcf93374652a86757a3a678c33f", async() => {
                    BeginContext(11086, 906, true);
                    WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""name"">Name</label>
                            <input type=""text"" class=""form-control"">
                        </div>
                        <div class=""form-group"">
                            <label for=""email"">Email</label>
                            <input type=""email"" class=""form-control"">
                        </div>
                        <div class=""form-group"">
                            <label for=""password"">Password</label>
                            <input type=""password"" class=""form-control"">
                        </div>
                        <div class=""form-group"">
                            <label for=""password2"">Confirm Password</label>
                            <input type=""password"" class=""form-control"">
                        </div>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(11999, 249, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n                    <button class=\"btn btn-warning\" data-dismiss=\"modal\">Save Changes</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n   \r\n");
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
            BeginContext(12255, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
