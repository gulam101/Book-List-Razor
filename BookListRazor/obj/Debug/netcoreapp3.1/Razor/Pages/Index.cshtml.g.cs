#pragma checksum "D:\Projects\ASP.NET\BookListRazor\BookListRazor\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baffa1ce5d43600214c1a425423f702c49be8ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookListRazor.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace BookListRazor.Pages
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
#line 1 "D:\Projects\ASP.NET\BookListRazor\BookListRazor\Pages\_ViewImports.cshtml"
using BookListRazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baffa1ce5d43600214c1a425423f702c49be8ee4", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61eeec048b07d9cebb7c677f29d03bb0b044966d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Projects\ASP.NET\BookListRazor\BookListRazor\Pages\Index.cshtml"
  
	ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
	body {
		background-color: #ccccb3;
		margin: 0;
	}

	.text-box p {
		color: #666;
	}

	.text-box {
		width: 100%;
		height: 195px;
		padding: 12px 20px;
		box-sizing: border-box;
		border-radius: 4px;
		background-color: #ccccb3;
		resize: none;
		display: flex;
	}

	/*Animation*/

	.text-box:hover {
		background-color: white;
		transition: ease-in-out 1s;
	}

	 .text-box:hover p {
		color: black;
		transition: ease-in-out 1s;
	 }

	 /*Buttons*/

	button {
		background-color: #4CAF50;
		border: none;
		color: white;
		padding: 15px 32px;
		text-align: center;
		text-decoration: none;
		display: inline-block;
		font-size: 16px;
		display: block;
		margin: auto;
		width: 100%;
	}

	button:hover {
		background-color: black;
		color: #4CAF50;
		transition: ease-in-out 2s;
	}

	/*End Animation*/
</style>

<!--Introduction-->
<div class=""text-center"">
	<h1 class=""display-4"">Welcome To Our Online Book Store</h1>
</div>

<h1 style=""text-align:");
            WriteLiteral(@"center"">Why Us?</h1>
<div class=""text-box"">
	<p style=""font-size:23px;"">
		Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
		Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
		Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
		Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
	</p>
</div>

<!--End Introduction-->


<br />

<button>Join Our Club</button>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
