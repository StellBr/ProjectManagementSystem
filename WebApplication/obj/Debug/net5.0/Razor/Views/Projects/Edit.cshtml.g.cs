#pragma checksum "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Projects\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13d0cfd807ffd5e147d2d0f5c6b0aca69726149c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Projects_Edit), @"mvc.1.0.view", @"/Views/Projects/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13d0cfd807ffd5e147d2d0f5c6b0aca69726149c", @"/Views/Projects/Edit.cshtml")]
    public class Views_Projects_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.ViewModels.Projects.EditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Projects\Edit.cshtml"
  
    ViewBag.Title = "Edit Project";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Project</h1>\r\n<fieldset>\r\n    <form action=\"/Projects/Edit\" method=\"post\">\r\n        ");
#nullable restore
#line 10 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Projects\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Projects\Edit.cshtml"
               Write(Html.LabelFor(p => p.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-1\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Projects\Edit.cshtml"
               Write(Html.EditorFor(p => p.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Projects\Edit.cshtml"
               Write(Html.ValidationMessageFor(p => p.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col-1"">
                    <a href=""/Projects/Index"">Back</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.ViewModels.Projects.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591