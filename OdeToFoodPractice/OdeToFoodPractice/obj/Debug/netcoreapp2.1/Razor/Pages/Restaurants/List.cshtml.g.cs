#pragma checksum "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1135155a7b2b0e45f0f8dd21ba57f18e0d9cadf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFoodPractice.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(OdeToFoodPractice.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace OdeToFoodPractice.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\_ViewImports.cshtml"
using OdeToFoodPractice;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1135155a7b2b0e45f0f8dd21ba57f18e0d9cadf7", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f545bd48235ee363b13b9bd982211ea360e5217e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 53, true);
            WriteLiteral("\r\n<h1>Restaurants</h1>\r\n\r\n<table class=\"table\">\r\n    ");
            EndContext();
            BeginContext(85, 465, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00b901b699904540a9e5a5a2d1108087", async() => {
                BeginContext(104, 439, true);
                WriteLiteral(@"
        <div class=""form-group"">
            <div class=""input-group"">
                <input type=""search"" class=""form-control"" value="""" /> 
                <span class=""input-group-btn"">
                    <button class=""btn btn-default"">
                        <i class=""glyphicon glyphicon-search"">
                        </i>
                    </button>
                </span>
            </div>
        </div>
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(550, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 25 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml"
     foreach (var restaurant in Model.Restaurants)
    {

#line default
#line hidden
            BeginContext(617, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(648, 15, false);
#line 28 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml"
           Write(restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(663, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(687, 19, false);
#line 29 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml"
           Write(restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(706, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(730, 18, false);
#line 30 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml"
           Write(restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(748, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml"
    }

#line default
#line hidden
            BeginContext(777, 20, true);
            WriteLiteral("\r\n</table>\r\n\r\n<div> ");
            EndContext();
            BeginContext(798, 13, false);
#line 36 "C:\Users\KristianaBlake\Projects\.NETCoreFundamentals\OdeToFoodPractice\OdeToFoodPractice\OdeToFoodPractice\Pages\Restaurants\List.cshtml"
 Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(811, 7, true);
            WriteLiteral(" </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ListModel>)PageContext?.ViewData;
        public ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
