#pragma checksum "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df105f6ef601619ec4598bd14a8f870f96f66222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Laptop_Index), @"mvc.1.0.view", @"/Views/Laptop/Index.cshtml")]
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
#line 1 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\_ViewImports.cshtml"
using LaptopStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\_ViewImports.cshtml"
using LaptopStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df105f6ef601619ec4598bd14a8f870f96f66222", @"/Views/Laptop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc67ccf2d9697191f9d71db72c728f27f699edaa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Laptop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LaptopStore.Models.Laptop>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Laptop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    img {
        margin-bottom: 15px;
        transition: 0.3s ease-in-out;
    }


       img:hover {
            transition: 0.3s ease-in-out;
            transform: scale(1.1);
        }

    .carousel-inner img {
        margin: auto;
    }

  

    
</style>

<h4>");
#nullable restore
#line 29 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
Write(ViewBag.usr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<style>\r\n    .img-fluid {\r\n        max-width: 78%;\r\n        height: 181 px;\r\n    }\r\n</style>\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 38 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=", 679, "", 695, 1);
#nullable restore
#line 41 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
WriteAttributeValue("", 684, item.Image, 684, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"auto\" width=\"auto\" />\r\n        </div>\r\n        <div class=\"col-md-8\">\r\n            <h3>");
#nullable restore
#line 44 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
           Write(item.ItemTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <br />\r\n            <h4>\r\n                <span class=\"badge badge-pill badge-success\">  ");
#nullable restore
#line 47 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n              \r\n            </h4>\r\n");
#nullable restore
#line 50 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
              
                Random r = new Random();
                int num = r.Next(5);
                DayOfWeek wk = DateTime.Today.AddDays(num).DayOfWeek;

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n                <h4>Get it by ");
#nullable restore
#line 59 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
                         Write(wk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df105f6ef601619ec4598bd14a8f870f96f662227496", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
                                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n            \r\n            <hr  style=\"height:3px\"/>\r\n        </div>\r\n");
#nullable restore
#line 72 "D:\velocity\velocity\project\Phase 3 - Laptop Store\LaptopStore\LaptopStore\Views\Laptop\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LaptopStore.Models.Laptop>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
