#pragma checksum "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ced9fd86196a3389039b0beba9116faefe97682e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Index), @"mvc.1.0.view", @"/Views/Tasks/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ced9fd86196a3389039b0beba9116faefe97682e", @"/Views/Tasks/Index.cshtml")]
    public class Views_Tasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.ViewModels.Tasks.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<fieldset>\r\n    <legend>PROJECT</legend>\r\n    <div class=\"grid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-1 b\">\r\n                Project Name\r\n            </div>\r\n            <div class=\"col-3\">\r\n                ");
#nullable restore
#line 11 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(Model.ParentProject.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</fieldset>\r\n\r\n\r\n<div class=\"grid\">\r\n    <form action=\"/Tasks/Index\" method=\"get\">\r\n        ");
#nullable restore
#line 20 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
   Write(Html.HiddenFor(m => m.ParentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 23 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(Html.LabelFor(m => m.Filter.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 26 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(Html.EditorFor(m => m.Filter.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 31 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(Html.LabelFor(m => m.Filter.AssigneeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 34 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(Html.DropDownListFor(m => m.Filter.AssigneeId, Model.Filter.Assignees, "-"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-1\">\r\n                <input type=\"submit\" value=\"Search\" />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1170, "\"", 1214, 2);
            WriteAttributeValue("", 1177, "/Tasks/Index?ParentId=", 1177, 22, true);
#nullable restore
#line 40 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 1199, Model.ParentId, 1199, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Clear</a>\r\n            </div>\r\n        </div>\r\n    </form>\r\n\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1284, "\"", 1337, 2);
            WriteAttributeValue("", 1291, "/Tasks/Create?ParentId=", 1291, 23, true);
#nullable restore
#line 45 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 1314, Model.ParentProject.Id, 1314, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Add a new task</a>
    <hr />
    <div class=""row"">
        <div class=""col-1"" margin: 10px;"">
            Project Tasks
        </div>
        <div class=""col-2"">
        </div>
    </div>
    <div class=""row b"">
        <div class=""col-1"">
            Task Title
        </div>
        <div class=""col-2"">
            Task Description
        </div>
        <div class=""col-2"">
            Task Deadline
        </div>
        <div class=""col-2"">
            Assigneed User
        </div>
        <div class=""col-2"">
            Task Status
        </div>
    </div>

");
#nullable restore
#line 72 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
     foreach (Common.Entities.Task item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-1\">\r\n                ");
#nullable restore
#line 76 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 79 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 82 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(item.Deadline);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 85 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(item.Assignee.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 85 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
                                    Write(item.Assignee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
                                                             Write(item.Assignee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </div>\r\n            <div class=\"col-2\">\r\n                ");
#nullable restore
#line 88 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
           Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-2\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2561, "\"", 2591, 2);
            WriteAttributeValue("", 2568, "/Tasks/Edit?id=", 2568, 15, true);
#nullable restore
#line 91 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 2583, item.Id, 2583, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2621, "\"", 2653, 2);
            WriteAttributeValue("", 2628, "/Tasks/Delete?id=", 2628, 17, true);
#nullable restore
#line 92 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 2645, item.Id, 2645, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Delete this item?\')\">delete</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2731, "\"", 2770, 2);
            WriteAttributeValue("", 2738, "/Tasks/Details?ParentId=", 2738, 24, true);
#nullable restore
#line 93 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
WriteAttributeValue("", 2762, item.Id, 2762, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">details</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 96 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Tasks\Index.cshtml"
       Html.RenderPartial("/Views/Shared/PagerPartial.cshtml", Model.Pager);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"/Projects/Index\">Back</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.ViewModels.Tasks.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591