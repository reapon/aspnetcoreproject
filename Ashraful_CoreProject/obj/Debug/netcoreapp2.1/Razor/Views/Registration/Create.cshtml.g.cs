#pragma checksum "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b14cea5fb72978957d75d6949bd148320e2395f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Create), @"mvc.1.0.view", @"/Views/Registration/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registration/Create.cshtml", typeof(AspNetCore.Views_Registration_Create))]
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
#line 1 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\_ViewImports.cshtml"
using Ashraful_CoreProject;

#line default
#line hidden
#line 2 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\_ViewImports.cshtml"
using Ashraful_CoreProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b14cea5fb72978957d75d6949bd148320e2395f", @"/Views/Registration/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9949eb28f92a207fe06ddab790c8a3892754afb0", @"/Views/_ViewImports.cshtml")]
    public class Views_Registration_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ashraful_CoreProject.Models.Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 5 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
 using (Html.BeginForm("Create", "Registration"))
{
    

#line default
#line hidden
            BeginContext(114, 23, false);
#line 7 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(141, 285, true);
            WriteLiteral(@"    <div class=""modal-header"">
        <h2 class=""modal-title"" style=""text-align:center;"">Registration Form</h2>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
");
            EndContext();
            BeginContext(428, 61, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(490, 64, false);
#line 19 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(554, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(603, 97, false);
#line 21 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.FullName, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(700, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(755, 97, false);
#line 23 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.FullName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(852, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(871, 86, false);
#line 24 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FullName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(957, 88, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1046, 94, false);
#line 30 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.Email, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(1140, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(1195, 94, false);
#line 32 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1308, 83, false);
#line 33 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1391, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1478, 94, false);
#line 38 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.Phone, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(1627, 94, false);
#line 40 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1740, 83, false);
#line 41 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1823, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1910, 96, false);
#line 46 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(2006, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(2061, 96, false);
#line 48 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2157, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2176, 85, false);
#line 49 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2261, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2348, 92, false);
#line 54 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.Age, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(2440, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(2495, 92, false);
#line 56 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.Age, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(2606, 81, false);
#line 57 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Age, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2687, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2774, 96, false);
#line 62 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.RegDate, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(2870, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(2925, 96, false);
#line 64 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.RegDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3021, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3040, 85, false);
#line 65 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.RegDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3125, 88, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3214, 97, false);
#line 71 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3311, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(3366, 97, false);
#line 73 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3463, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3482, 86, false);
#line 74 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3568, 86, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(3655, 104, false);
#line 79 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
       Write(Html.LabelFor(model => model.ConfirmPassword, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3759, 54, true);
            WriteLiteral("\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(3814, 104, false);
#line 81 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.EditorFor(model => model.ConfirmPassword, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3918, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(3937, 93, false);
#line 82 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4030, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(4082, 207, true);
            WriteLiteral("    <div class=\"modal-footer\">\r\n        <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        <input type=\"submit\" class=\"btn btn-success\" value=\"Save\" />\r\n    </div>\r\n");
            EndContext();
#line 91 "G:\C# .Net Course\AspNetCore\Ashraful_CoreProject\Ashraful_CoreProject\Views\Registration\Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ashraful_CoreProject.Models.Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591
