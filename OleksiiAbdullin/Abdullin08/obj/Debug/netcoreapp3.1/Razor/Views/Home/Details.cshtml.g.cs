#pragma checksum "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a8c71ea05e0d6dc92a5f67f050b9e1a846526da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\_ViewImports.cshtml"
using Abdullin08;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\_ViewImports.cshtml"
using Abdullin08.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8c71ea05e0d6dc92a5f67f050b9e1a846526da", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc23eaeffe37f4ce750443e28de84e93d0d5c174", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Abdullin08.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
  
    ViewBag.Title = Model.FirstName + Model.SurName;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Sudent: ");
#nullable restore
#line 5 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
                        Write(Model.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<div>
    <table class=""table"">
        <thead>
            <tr>
                <td>Id</td>
                <td>FirstName</td>
                <td>SurName</td>
                <td>Group</td>
                <td>AcademicPerformance</td>
            </tr>
        </thead>
        <tbody>
            <td>");
#nullable restore
#line 18 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
           Write(Model.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
           Write(Model.Group);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\drftg\source\repos\OleksiiAbdullin\Abdullin08\Views\Home\Details.cshtml"
           Write(Model.AcademicPerformance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Abdullin08.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
