#pragma checksum "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8140e2a098c5862c04deb481c646af068fec1e24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Edit), @"mvc.1.0.view", @"/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8140e2a098c5862c04deb481c646af068fec1e24", @"/Views/Users/Edit.cshtml")]
    public class Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.ViewModels.Users.EditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit</h1>\r\n<fieldset>\r\n    <form action=\"/Users/Edit\" method=\"post\">\r\n        ");
#nullable restore
#line 9 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 13 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 16 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 22 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 25 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 26 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 32 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 45 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 59 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 62 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 63 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.EditorFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 72 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Users\Edit.cshtml"
               Write(Html.ValidationMessageFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>

            <div class=""row"">
                <div class=""col-1"">
                    <input type=""submit"" value=""Edit"" />
                </div>
            </div>
        </div>
    </form>
</fieldset>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.ViewModels.Users.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
