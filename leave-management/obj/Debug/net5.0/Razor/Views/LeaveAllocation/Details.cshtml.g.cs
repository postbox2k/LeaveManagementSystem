#pragma checksum "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0deb290a07e1a26cc6fa05537dcc219355176f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveAllocation_Details), @"mvc.1.0.view", @"/Views/LeaveAllocation/Details.cshtml")]
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
#line 1 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\_ViewImports.cshtml"
using leave_management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\_ViewImports.cshtml"
using leave_management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0deb290a07e1a26cc6fa05537dcc219355176f97", @"/Views/LeaveAllocation/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212022b1585c0b4772d85d22f826c2d122e08994", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LeaveAllocation_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<leave_management.Models.ViewAllocationsVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h1>Details For - ");
#nullable restore
#line 7 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
                 Write(Model.Employee.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 7 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
                                           Write(Model.Employee.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 13 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 16 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 19 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 22 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 25 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 28 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 31 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 34 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 37 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 40 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 43 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.TaxId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 46 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.TaxId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 49 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 52 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 55 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 58 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.DateJoined));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n\n\n<hr />\n\n<h2>Leave Allocations</h2>\n\n    <div class=\"card\" >\n        <ul class=\"list-group list-group-flush\">\n");
#nullable restore
#line 70 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
             foreach (var item in Model.LeaveAllocations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">\n                <h6>");
#nullable restore
#line 73 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
               Write(item.LeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-secondary\">");
#nullable restore
#line 73 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
                                                                        Write(item.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb290a07e1a26cc6fa05537dcc219355176f9713303", async() => {
                WriteLiteral("<i class=\"fa fa-pencil\"></i> Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
                                                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </h6>\n            </li>\n");
#nullable restore
#line 75 "C:\Users\LENOVO\Downloads\leave-management-dotnetcore-master\leave-management-dotnetcore-master\leave-management\Views\LeaveAllocation\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n<br/>\n    <div>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0deb290a07e1a26cc6fa05537dcc219355176f9716080", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<leave_management.Models.ViewAllocationsVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
