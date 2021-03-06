#pragma checksum "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c466f8645e88bfa3e422dcf1f6be61cdab44522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PagerPartial), @"mvc.1.0.view", @"/Views/Shared/PagerPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c466f8645e88bfa3e422dcf1f6be61cdab44522", @"/Views/Shared/PagerPartial.cshtml")]
    public class Views_Shared_PagerPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.ViewModels.Shared.PagerVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
   
    var controller = this.ViewContext.RouteData.Values["controller"];
    var action = this.ViewContext.RouteData.Values["action"];

    string queryParams = "";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
     foreach (var key in this.Context.Request.Query.Keys) 
    {
        if (!key.StartsWith("Pager."))
        {
            queryParams += key + "=" + this.Context.Request.Query[key] + "&";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-3 pager\">\r\n        <script>\r\n                function itemsPP_OnChange() {\r\n                    var control = document.getElementById(\"ipp\");\r\n                    var url = \"/");
#nullable restore
#line 22 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                            Write(controller);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 22 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                                          Write(action);

#line default
#line hidden
#nullable disable
            WriteLiteral("?");
#nullable restore
#line 22 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                                                   Write(Html.Raw(queryParams));

#line default
#line hidden
#nullable disable
            WriteLiteral("Pager.ItemsPerPage=\" + control.options[control.selectedIndex].value;\r\n\r\n                    window.location.href = url;\r\n                }\r\n        </script>\r\n");
#nullable restore
#line 27 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
         for (int i = 1; i <= Model.PagesCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("class", " class=\"", 944, "\"", 981, 1);
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
WriteAttributeValue("", 952, i == Model.Page ? "b" : "", 952, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 982, "\"", 1088, 10);
            WriteAttributeValue("", 989, "/", 989, 1, true);
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
WriteAttributeValue("", 990, controller, 990, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1003, "/", 1003, 1, true);
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
WriteAttributeValue("", 1004, action, 1004, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1013, "?", 1013, 1, true);
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
WriteAttributeValue("", 1014, Html.Raw(queryParams), 1014, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1036, "Pager.ItemsPerPage=", 1036, 19, true);
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
WriteAttributeValue("", 1055, Model.ItemsPerPage, 1055, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1074, "&Pager.Page=", 1074, 12, true);
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
WriteAttributeValue("", 1086, i, 1086, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                                                                                                                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 30 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <select id=\"ipp\" onchange=\"itemsPP_OnChange()\">\r\n            <option ");
#nullable restore
#line 32 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                Write(Model.ItemsPerPage == 1 ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">1</option>\r\n            <option ");
#nullable restore
#line 33 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                Write(Model.ItemsPerPage == 2 ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">2</option>\r\n            <option ");
#nullable restore
#line 34 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                Write(Model.ItemsPerPage == 5 ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">5</option>\r\n            <option ");
#nullable restore
#line 35 "C:\Users\steli\source\repos\WebApplication\WebApplication\Views\Shared\PagerPartial.cshtml"
                Write(Model.ItemsPerPage == 10 ? "selected" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">10</option>\r\n        </select>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.ViewModels.Shared.PagerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
