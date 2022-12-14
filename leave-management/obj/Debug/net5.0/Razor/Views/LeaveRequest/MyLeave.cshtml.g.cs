#pragma checksum "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5bc9c8808e6bc656609b0b3cce8f04793f80e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LeaveRequest_MyLeave), @"mvc.1.0.view", @"/Views/LeaveRequest/MyLeave.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\_ViewImports.cshtml"
using leave_management;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\_ViewImports.cshtml"
using leave_management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5bc9c8808e6bc656609b0b3cce8f04793f80e2", @"/Views/LeaveRequest/MyLeave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212022b1585c0b4772d85d22f826c2d122e08994", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_LeaveRequest_MyLeave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeLeaveRequestViewVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to cancel this request?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
  
    ViewData["Title"] = "MyLeave";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Allocations</h2>\n<div class=\"jumbotron col-md-6\">\n    <div class=\"card\">\n        <ul class=\"list-group list-group-flush\">\n");
#nullable restore
#line 11 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
             foreach (var item in Model.LeaveAllocations)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"list-group-item\">\n                    <h6>");
#nullable restore
#line 14 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                   Write(item.LeaveType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"badge badge-secondary\">");
#nullable restore
#line 14 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                                                                            Write(item.NumberOfDays);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>    </h6>\n                </li>\n");
#nullable restore
#line 16 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>
</div>


<hr/>
<h1>Request Records</h1>
<table class=""table table-dark"">
    <!--id=""tblData""-->
    <thead >
        <tr>
            <th>
                Leave Type
            </th>
            <th>
                Start Date
            </th>
            <th>
                End Date
            </th>
            <th>
                Date Requested
            </th>
            
            <th>
                Approval State
            </th>
            
            <th>
                Cancel Request
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 51 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
 foreach (var item in Model.LeaveRequests) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 54 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaveType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 57 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 60 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n            <td>\n                ");
#nullable restore
#line 64 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateRequested, new { @value = item.DateRequested.ToString("yyyy-mm-dd") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n            <td>\n");
#nullable restore
#line 68 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                 if (item.Cancelled)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"badge badge-secondary\">Cancelled</span>\n");
#nullable restore
#line 71 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                }
                else if (item.Approved == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-success\">Approved</span>\n");
#nullable restore
#line 75 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                }
                else if (item.Approved == false)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-danger\">Rejected</span>\n");
#nullable restore
#line 79 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-warning\">Pending Approval</span>\n");
#nullable restore
#line 83 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n           \n            <td>\n");
#nullable restore
#line 87 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                 if ((!item.Cancelled && item.StartDate > DateTime.Now ))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5bc9c8808e6bc656609b0b3cce8f04793f80e211219", async() => {
                WriteLiteral("\n                        <i class=\"fa fa-trash\" aria-hidden=\"true\"></i>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 92 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 96 "C:\Users\LENOVO\OneDrive\Documents\Project\LeaveManagementSystem\leave-management-dotnetcore-master\leave-management\Views\LeaveRequest\MyLeave.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeLeaveRequestViewVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
