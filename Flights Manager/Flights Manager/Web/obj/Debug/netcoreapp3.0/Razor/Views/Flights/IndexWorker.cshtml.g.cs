#pragma checksum "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ff03ca65dda2cc58235736eb9065c5e131b45861f4e4db6390e1fea4b9ae9295"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flights_IndexWorker), @"mvc.1.0.view", @"/Views/Flights/IndexWorker.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
using Web.Models.Flights;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
using Web.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ff03ca65dda2cc58235736eb9065c5e131b45861f4e4db6390e1fea4b9ae9295", @"/Views/Flights/IndexWorker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bfe644860a5938836acf617a2ec23d8e184d3413d439bb2e49accb48deec538e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Flights_IndexWorker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.Flights.FlightsIndexViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexWorker", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
  
    ViewData["Title"] = "IndexWorker";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<h4>Flights</h4>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff03ca65dda2cc58235736eb9065c5e131b45861f4e4db6390e1fea4b9ae92955072", async() => {
                WriteLiteral("\r\n    <button style=\"padding: 5px 10px; background-color: #F0FF17; color: black; border: none; border-radius: 5px; cursor: pointer; float: right\">Open Reservations</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<button style=""padding: 5px 10px; background-color: #4CAF50; color: white; border: none; border-radius: 5px; cursor: pointer;"" OnClick=""Button_Click"">10</button>
<button style=""padding: 5px 10px; background-color: #008CBA; color: white; border: none; border-radius: 5px; cursor: pointer;"" OnClick=""Button_Click"">25</button>
<button style=""padding: 5px 10px; background-color: #f44336; color: white; border: none; border-radius: 5px; cursor: pointer;"" OnClick=""Button_Click"">50</button>

<br />

<table class=""table"">
    <thead>
        <tr>
            <th>
                Plane number
            </th>
            <th>
                Location from
            </th>
            <th>
                Location to
            </th>
            <th>
                Take-off
            </th>
            <th>
                Flights Duration
            </th>
            <th>
                Plane type
            </th>
            <th>
                Pilot name
            </th>
    ");
            WriteLiteral("        <th>\r\n                Unoccupied seats\r\n            </th>\r\n            <th>\r\n                Unoccupied business seats\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
         foreach (FlightsViewModel item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlaneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.LocationFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.LocationTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 70 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.TakeOff));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.PlaneType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnoccupiedSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnoccupiedBusinessSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 91 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
         for (var i = 1; i <= Model.Pager.PagesCount; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2938, "\"", 3003, 2);
            WriteAttributeValue("", 2946, "page-item", 2946, 9, true);
#nullable restore
#line 93 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
WriteAttributeValue(" ", 2955, i == Model.Pager.CurrentPage ? "active" : "", 2956, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff03ca65dda2cc58235736eb9065c5e131b45861f4e4db6390e1fea4b9ae929512645", async() => {
#nullable restore
#line 94 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
                                                                 Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Pager.CurrentPage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 94 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
                                    WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Pager.CurrentPage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Pager.CurrentPage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Pager.CurrentPage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 96 "C:\Users\kyord\Desktop\Flights-manager\Flights Manager\Flights Manager\Web\Views\Flights\IndexWorker.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.Flights.FlightsIndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
