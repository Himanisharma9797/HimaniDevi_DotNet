#pragma checksum "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ca25cf250c7fc141f778b850f4110e2fa2df482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_DisplayStudent), @"mvc.1.0.view", @"/Views/Student/DisplayStudent.cshtml")]
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
#line 1 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\_ViewImports.cshtml"
using ElearningSystem.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\_ViewImports.cshtml"
using ElearningSystem.Service.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ca25cf250c7fc141f778b850f4110e2fa2df482", @"/Views/Student/DisplayStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b6729ecd75c40b12370e04d9ac61afc33500ae3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_DisplayStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ElearningSystem.DataLayer.Models.StudentModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
  
    ViewData["Title"] = "DisplayStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<center>
    <h2>List of Students </h2>
</center>
<div class=""container"" style=""background-size:cover; background-color:lavender; height:605px"">
    <br />
    <table class=""table"" >
        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 15 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>Actions</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 40 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StudentEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1565, "\"", 1645, 1);
#nullable restore
#line 46 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
WriteAttributeValue("", 1572, Url.Action("DeleteStudent", "Student", new { studentId= item.StudentId}), 1572, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Delete </a>\r\n                        <!--");
#nullable restore
#line 47 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
                       Write(Html.ActionLink("Delete" , "DeleteStudent", new { id = item.StudentId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("--> ");
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\himani.devi\Desktop\ElearningSystem\ElearningSystem.Service\Views\Student\DisplayStudent.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ElearningSystem.DataLayer.Models.StudentModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591