#pragma checksum "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48070999556f70d5481b9d7433ef0477d19f26e3"
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
#line 1 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\_ViewImports.cshtml"
using Microservices.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\_ViewImports.cshtml"
using Microservices.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48070999556f70d5481b9d7433ef0477d19f26e3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ae9fa31511f46e25c78babbe88af50608b05ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Microservices.MVC.Models.Catalog.CourseViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Kurslar</h2>\r\n<hr />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
 if (Model.Any())

{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {
        count++;
        if (count == 1 || (count % 3 == 1))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
       Write(Html.Raw("<div class='row row-cols-1 row-cols-md-3 g-4 mb-3' >"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                                                                             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\r\n            <div class=\"card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 470, "\"", 492, 1);
#nullable restore
#line 24 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 476, item.PictureUrl, 476, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 26 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-title\">");
#nullable restore
#line 27 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                                       Write(item.Category != null ? item.Category.Name : "Bulunamadı");

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h4 class=\"text-primary\">");
#nullable restore
#line 29 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL</h4>\r\n\r\n                    <div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48070999556f70d5481b9d7433ef0477d19f26e37506", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"

        if (count % 3 == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
       Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
                               
        }

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\eren_\Desktop\PROJELER\Microservices\Clients\MVC\Microservices.MVC\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Microservices.MVC.Models.Catalog.CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591