#pragma checksum "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f6784635f35277d10fdc396420fea8c53a54636"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Connections), @"mvc.1.0.view", @"/Views/Home/Connections.cshtml")]
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
#nullable restore
#line 1 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\_ViewImports.cshtml"
using UnibucWebAgentFrontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\_ViewImports.cshtml"
using UnibucWebAgentFrontend.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f6784635f35277d10fdc396420fea8c53a54636", @"/Views/Home/Connections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4df649a80c1110220c88bc3d5591f6bc051751b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Connections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UnibucWebAgentFrontend.Models.Connection>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessagePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteConnection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateConnection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
  
    ViewData["Title"] = "Connections";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h4>Connections established between Unibuc and students</h4>\r\n\r\n<a id=\"create_connection\" href=\"#CreateConnectionModal\" data-toggle=\"modal\" style=\"text-decoration:none\">New Connection</a>\r\n\r\n    <br />\r\n    <br />\r\n\r\n");
#nullable restore
#line 14 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
     foreach (var connection in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h6 class=\"text-center text-md-left\">Alias: ");
#nullable restore
#line 17 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                                   Write(connection.alias);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (Peer DID: ");
#nullable restore
#line 17 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                                                                Write(connection.their_did);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h6>\r\n            <ul class=\"d-md-flex flex-wrap\">\r\n                <li class=\"mr-md-5\">\r\n                    <i class=\"mr-2\"></i>Connection ID: ");
#nullable restore
#line 20 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                                  Write(connection.connection_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"mr-md-5\">\r\n                    <i class=\"mr-2\"></i>Date created: ");
#nullable restore
#line 23 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                                 Write(connection.created_at);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"mr-md-5\">\r\n                    <i class=\"mr-2\"></i>State: ");
#nullable restore
#line 26 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                          Write(connection.rfc23_state);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li class=\"mr-md-5\">\r\n                    <i class=\"mr-2\"></i>User agent: ");
#nullable restore
#line 29 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                               Write(connection.their_label);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n            <div class=\"flex-row\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6784635f35277d10fdc396420fea8c53a546369747", async() => {
                WriteLiteral("Send a message");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                                  WriteLiteral(connection.connection_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6784635f35277d10fdc396420fea8c53a5463612302", async() => {
                WriteLiteral("Delete this connection");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
                                            WriteLiteral(connection.connection_id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n");
#nullable restore
#line 38 "C:\Users\paulvasile\Desktop\net core projects\UnibucWebAgentFrontend\UnibucWebAgentFrontend\UnibucWebAgentFrontend\Views\Home\Connections.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div id=\"CreateConnectionModal\" class=\"modal fade\">\r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f6784635f35277d10fdc396420fea8c53a5463615334", async() => {
                WriteLiteral(@"
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Create a new connection</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-hidden=""true"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <div class=""form-group"">
                            <label>Enter a student ID to reference this connection</label>
                            <input type=""text"" class=""form-control"" required=""required"" name=""alias"" />
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <input type=""button"" class=""btn btn-default"" data-dismiss=""modal"" value=""Cancel"" />
                        <input type=""Submit"" class=""btn btn-info"" value=""Create"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UnibucWebAgentFrontend.Models.Connection>> Html { get; private set; }
    }
}
#pragma warning restore 1591
