#pragma checksum "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96143bc3951a1ac410efae39edb99c27a671ddac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\_ViewImports.cshtml"
using MrVectorDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\_ViewImports.cshtml"
using MrVectorDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96143bc3951a1ac410efae39edb99c27a671ddac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f621a103320e5f58b7169548b64e453592840385", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Display of Vector's DataBase";
    string[] TableHeaders = new string[] {"Adress ID"
      ,"Address Line"
      ,"City"
      ,"State Province ID"
      ,"Postal Code"
      ,"Spatial Location"
      ,"Row ID"
      ,"Modified Date"};

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"table\">\r\n    <table class=\" = \" table table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n");
#nullable restore
#line 17 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                  
                    foreach (var head in TableHeaders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>\r\n                            ");
#nullable restore
#line 21 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                       Write(head);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n");
#nullable restore
#line 23 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n        </thead>\r\n        \r\n        <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
              
            if (Model != null)
            {
                foreach (var Data in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.AddressID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.AddressLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.StateProvinceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.SpatialLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.RowID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                   Write(Data.ModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 44 "C:\Users\Davidaikis\source\repos\MrVectorDatabase\MrVectorDatabase\Views\Home\Index.cshtml"
                }

            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <tbody>\r\n</div>>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
