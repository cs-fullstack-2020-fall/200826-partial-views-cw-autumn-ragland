#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\StreamingPlatforms\_PlatformDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4b186253a74f94a985b4076a7d852bfbbf3ffdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StreamingPlatforms__PlatformDetails), @"mvc.1.0.view", @"/Views/StreamingPlatforms/_PlatformDetails.cshtml")]
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
#line 1 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\_ViewImports.cshtml"
using Classwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\_ViewImports.cshtml"
using Classwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4b186253a74f94a985b4076a7d852bfbbf3ffdb", @"/Views/StreamingPlatforms/_PlatformDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"608ff8d9849d6836adede9c20af7cc390cf76207", @"/Views/_ViewImports.cshtml")]
    public class Views_StreamingPlatforms__PlatformDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">Platform Name : ");
#nullable restore
#line 3 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\StreamingPlatforms\_PlatformDetails.cshtml"
                                      Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 4 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\StreamingPlatforms\_PlatformDetails.cshtml"
     foreach (Media media in @Model.availableMedia)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h6 class=\"card-subtitle mb-2 text-muted\">Media Title : ");
#nullable restore
#line 6 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\StreamingPlatforms\_PlatformDetails.cshtml"
                                                           Write(media.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <p class=\"card-text\">Media Description : ");
#nullable restore
#line 7 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\StreamingPlatforms\_PlatformDetails.cshtml"
                                            Write(media.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200826\200826-partial-views-cw-autumn-ragland\Classwork\Views\StreamingPlatforms\_PlatformDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n<br>\r\n");
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
