#pragma checksum "C:\Repos\DotaLeague\DotaLeague\DotaLeague\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef19913a2dc61ec69340539200deea286a92712e"
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
#line 1 "C:\Repos\DotaLeague\DotaLeague\DotaLeague\Views\_ViewImports.cshtml"
using DotaLeague;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repos\DotaLeague\DotaLeague\DotaLeague\Views\_ViewImports.cshtml"
using DotaLeague.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repos\DotaLeague\DotaLeague\DotaLeague\Views\_ViewImports.cshtml"
using DotaLeague.Models.IdentityViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repos\DotaLeague\DotaLeague\DotaLeague\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef19913a2dc61ec69340539200deea286a92712e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6bed6ef801a4e0d77155500c2c263fcf76f2e78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Repos\DotaLeague\DotaLeague\DotaLeague\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""content"">
    <div class=""row"">
        <div class=""col-12"">
        </div>
    </div>
    <div class=""row"">
    </div>
    <div class=""row"">
        <div class=""col-lg-12 col-md-12"">
            <div class=""card"">
                <div class=""card-header text-center"">
                    <h2 class=""card-title""><strong>GOLD DIVISION</strong></h2>
                </div>
                <div class=""card-body"" style=""margin-top: 10px"">
                    <div class=""table-responsive"">
                        <table class=""table tablesorter """);
            BeginWriteAttribute("id", " id=\"", 620, "\"", 625, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <thead class="" text-primary"">
                                <tr>
                                    <th>
                                        #
                                    </th>
                                    <th>
                                        NickName
                                    </th>
                                    <th>
                                        Win Rate
                                    </th>
                                    <th>
                                        MMR
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>
                                        icon
                                    </td>
                                    <td>
                                        Stojcee
                      ");
            WriteLiteral(@"              </td>
                                    <td>
                                        33%
                                    </td>
                                    <td>
                                        933
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        icon
                                    </td>
                                    <td>
                                        Cedica
                                    </td>
                                    <td>
                                        50%
                                    </td>
                                    <td>
                                        1333
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                      ");
            WriteLiteral(@"                  icon
                                    </td>
                                    <td>
                                        Cowboy
                                    </td>
                                    <td>
                                        100%
                                    </td>
                                    <td>
                                        1933
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        icon
                                    </td>
                                    <td>
                                        Heary_Freak
                                    </td>
                                    <td>
                                        99%
                                    </td>
                                    <td>
                                        1833");
            WriteLiteral(@"
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>

                <div class=""card-footer text-center"">
                    <button class=""btn  btn-info"" onclick=""JoinQueue()"">Join Queue</button>
                    <button class=""btn  btn-warning"">Leave Queue</button>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    function JoinQueue() {
        $.ajax({
            type: ""GET"",
            url: ""/Home/Queue"",
            data: { ""leagueId"": 1 },
            contentType: ""application/json"",

            success: function (data) {
                console.log(""opp op"");
                console.log(data);
            },
            error: function (xhr) {
                console.log(xhr);
            }
        });
    }
</script>");
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
