#pragma checksum "/Users/jaredchristensen/Documents/GitHub/GradeCalculator/mission2assignment/Views/Blah/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f26eb69f30e17a3be0d5efd3b51d770c4f106032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blah_Index), @"mvc.1.0.view", @"/Views/Blah/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26eb69f30e17a3be0d5efd3b51d770c4f106032", @"/Views/Blah/Index.cshtml")]
    public class Views_Blah_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/jaredchristensen/Documents/GitHub/GradeCalculator/mission2assignment/Views/Blah/Index.cshtml"
Write(ViewData["title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" = ""About me"";


<h1>Jared Christensen</h1>
<!--import image-->
<img src=""img/JaredHunting.jpeg"" width=""400"" />
<p>
    I really hope to develope more of a love for coding! I have always loved it but last semester I started to stop
    having the same desire to be excelent at it. I really hope to get that back this semester and make it one of my
    strengths once again!
</p>
<h2>Top 3 jobs:</h2>
<ol>
    <li>Salesforce Consultant</li>
    <li>Project Manager</li>
    <li>Software Development</li>
</ol>
<br /><br />
<h2>Grade Calculator</h2>
<form>
    <label>Assignments: </label>
    <input id=""Assignments"" /><br />

    <label>Group Project: </label>
    <input id=""GroupProject"" /><br />

    <label>Quizes: </label>
    <input id=""Quizes"" /><br />

    <label>Exams: </label>
    <input id=""Exams"" /><br />

    <label>Intex: </label>
    <input id=""Intex"" /><br />

    <input id=""calc"" type=""button"" value=""Calculate"" />
</form>

<script src=""js/GradeCalc.js""></script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
