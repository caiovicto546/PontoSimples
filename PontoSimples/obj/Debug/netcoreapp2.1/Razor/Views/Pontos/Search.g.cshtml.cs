#pragma checksum "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e360d1e35aa531a3dde7cf6dbaed90f36c8c5c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pontos_Search), @"mvc.1.0.view", @"/Views/Pontos/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pontos/Search.cshtml", typeof(AspNetCore.Views_Pontos_Search))]
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
#line 1 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\_ViewImports.cshtml"
using PontoSimples;

#line default
#line hidden
#line 2 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\_ViewImports.cshtml"
using PontoSimples.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e360d1e35aa531a3dde7cf6dbaed90f36c8c5c5", @"/Views/Pontos/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e54d8dba0b4e3e3d23b9870b3126a8f5c5c7b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pontos_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PontoSimples.Models.Ponto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
  
    ViewData["Title"] = "Busca";

#line default
#line hidden
            BeginContext(85, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(91, 17, false);
#line 7 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(108, 86, true);
            WriteLiteral("</h2>\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(194, 932, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c58f2aa62dde49aba360775151128e82", async() => {
                BeginContext(246, 159, true);
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <input type=\"hidden\" class=\"form-control\" name=\"idFunc\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 405, "", 431, 1);
#line 15 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
WriteAttributeValue("", 412, ViewData["idFunc"], 412, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(431, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 635, "", 662, 1);
#line 19 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
WriteAttributeValue("", 642, ViewData["minDate"], 642, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(662, 204, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 866, "", 893, 1);
#line 23 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
WriteAttributeValue("", 873, ViewData["maxDate"], 873, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(893, 124, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n");
                EndContext();
                BeginContext(1111, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1126, 349, true);
            WriteLiteral(@"
    </div>
</nav>
<div class=""panel panel-primary"">
    <div class=""panel-heading"">
        <h3 class=""panel-title"">Busca Registro de Ponto</h3>
    </div>
    <div class=""panel-body"">
        <table class=""table table-striped table-hover"">
            <thead>
                <tr class=""success"">
                    <th>
                        ");
            EndContext();
            BeginContext(1476, 57, false);
#line 40 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayNameFor(model => model.Funcionario.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(1533, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1610, 52, false);
#line 43 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayNameFor(model => model.Funcionario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1662, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1739, 24, false);
#line 46 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayName("Data"));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1840, 36, false);
#line 49 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayName("Hora da Marcação"));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 90, true);
            WriteLiteral("\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 54 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2029, 70, true);
            WriteLiteral("                <tr>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2100, 56, false);
#line 58 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Funcionario.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2233, 51, false);
#line 61 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayFor(modelitem => item.Funcionario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2284, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2361, 43, false);
#line 64 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayFor(modelitem => item.Marcacao));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 76, true);
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2481, 84, false);
#line 67 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                   Write(Html.DisplayTextFor(modelitem => item.Marcacao.TimeOfDay).ToString().Substring(0, 5));

#line default
#line hidden
            EndContext();
            BeginContext(2565, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 70 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                }

#line default
#line hidden
            BeginContext(2632, 129, true);
            WriteLiteral("            </tbody>\n            <thead>\n                <tr>\n                    <td >\n                        Total de linhas: ");
            EndContext();
            BeginContext(2762, 24, false);
#line 75 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\Search.cshtml"
                                    Write(Model.Count().ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2786, 105, true);
            WriteLiteral("\n                    </td>\n                </tr>\n            </thead>\n        </table>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PontoSimples.Models.Ponto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
