#pragma checksum "C:\Users\X\Documents\SDSU\unidad 2\107\PropertyRental\Views\Catalog\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d132f72e78496a271af296e20d4c582eb34e50d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Register), @"mvc.1.0.view", @"/Views/Catalog/Register.cshtml")]
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
#line 1 "C:\Users\X\Documents\SDSU\unidad 2\107\PropertyRental\Views\_ViewImports.cshtml"
using PropertyRental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\X\Documents\SDSU\unidad 2\107\PropertyRental\Views\_ViewImports.cshtml"
using PropertyRental.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d132f72e78496a271af296e20d4c582eb34e50d", @"/Views/Catalog/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a59eb52cf4fd9ebb4436dd5a1fef24adf2457ae8", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Register Property</h2>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d132f72e78496a271af296e20d4c582eb34e50d3633", async() => {
                WriteLiteral(@"

                <div class=""form-group"">
                    <label for=""txtTitle"">Title</label>
                    <input type=""text"" id=""txtTitle"" class=""control form-control"" placeholder=""Title"">
                </div>

                <div class=""form-group"">
                    <label for=""txtPrice"">Price</label>
                    <input type=""number"" id=""txtPrice"" class=""control form-control"" placeholder=""Price"" >
                </div>

                <div class=""form-group"">
                    <label for=""txtImageURL"">Image URL</label>
                    <input type=""url"" id=""txtImageURL"" class=""control form-control"" placeholder=""Image URL"">
                </div>

                <div class=""form-group"">
                    <label for=""txtBeds"">Beds</label>
                    <input type=""number"" id=""txtBeds"" class=""control form-control"" placeholder=""Beds"">
                </div>

                <div class=""form-group"" >        
                    <label for=""txtBath");
                WriteLiteral(@"s"">Baths</label>
                    <input type=""number"" id=""txtBaths"" class=""control form-control"" placeholder=""Baths"">
                </div>

                <div class=""form-group"" >        
                    <label for=""txtArea"">Area</label>
                    <input type=""text"" id=""txtArea"" class=""control form-control"" placeholder=""Area"">
                </div>

                <div class=""form-group"" >        
                    <label for=""txtDescription"">Description</label>
                    <input type=""text"" id=""txtDescription"" class=""control form-control"" placeholder=""Description"">
                </div>

                <div class=""form-group"" >        
                    <label >Parking Include</label>
                    
                    
                    <input type=""radio"" id=""rbRadio_0"" name=""rbRadio_0"" value=""true"" class=""control"">
                    <label for=""radio_0"">Yes</label>

                    <input type=""radio"" id=""rbRadio_1"" name=""rbRadio_0""");
                WriteLiteral(" value=\"false\" class=\"control\">\r\n                    <label for=\"radio_0\">No</label>\r\n\r\n                </div>\r\n\r\n                <button id=\"btnSave\" class=\"btn btn-info form-control\">Save</button>    \r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLabel"">Modal</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div id=""message"" class=""modal-body"">sssss</div>
      
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
      </div>
    </div>
  </div>
</div>



");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/register.js\"></script>\r\n");
            }
            );
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
