#pragma checksum "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5e87a5f7e27cc03c70e306cb1b8bbfe40817c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pontos_GroupingSearch), @"mvc.1.0.view", @"/Views/Pontos/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pontos/GroupingSearch.cshtml", typeof(AspNetCore.Views_Pontos_GroupingSearch))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5e87a5f7e27cc03c70e306cb1b8bbfe40817c5", @"/Views/Pontos/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e54d8dba0b4e3e3d23b9870b3126a8f5c5c7b7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Pontos_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Funcionario, Ponto>>>
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
            BeginContext(50, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
  
    ViewData["Title"] = "Busca Agrupada por funcionário";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(254, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(260, 17, false);
#line 9 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(277, 85, true);
            WriteLiteral("</h2>\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\n        ");
            EndContext();
            BeginContext(362, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cde7ffa0b84642038978b9ceafd18369", async() => {
                BeginContext(414, 212, true);
                WriteLiteral("\n\n            <div class=\"form-group\">\n                <div class=\"form-group\">\n                    <label for=\"minDate\">Min Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 626, "", 653, 1);
#line 18 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
WriteAttributeValue("", 633, ViewData["minDate"], 633, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(653, 200, true);
                WriteLiteral(" />\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"maxDate\">Max Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 853, "", 880, 1);
#line 22 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
WriteAttributeValue("", 860, ViewData["maxDate"], 860, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(880, 128, true);
                WriteLiteral(" />\n                </div>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\n        ");
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
            BeginContext(1015, 20, true);
            WriteLiteral("\n    </div>\n</nav>\n\n");
            EndContext();
#line 30 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
 foreach (var funcionariosGroup in Model)
{

#line default
#line hidden
            BeginContext(1079, 115, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\n        <div class=\"panel-heading\">\n            <h3 class=\"panel-title\">Nome ");
            EndContext();
            BeginContext(1195, 26, false);
#line 34 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                                    Write(funcionariosGroup.Key.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1221, 645, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Matricula
                        </th>
                        <th>
                            Nome
                        </th>
                        <th>
                            Data
                        </th>
                        <th>
                            Hora da Marcação
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 55 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                     foreach(var item in funcionariosGroup)
                    {

#line default
#line hidden
            BeginContext(1948, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2031, 56, false);
#line 59 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Funcionario.Matricula));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2176, 51, false);
#line 62 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelitem => item.Funcionario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2227, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2316, 43, false);
#line 65 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                       Write(Html.DisplayFor(modelitem => item.Marcacao));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(2448, 84, false);
#line 68 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                       Write(Html.DisplayTextFor(modelitem => item.Marcacao.TimeOfDay).ToString().Substring(0, 5));

#line default
#line hidden
            EndContext();
            BeginContext(2532, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 71 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
                    }

#line default
#line hidden
            BeginContext(2611, 72, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n");
            EndContext();
#line 76 "C:\VISUAL STUDIO\Web\PontoSimples\PontoSimples\Views\Pontos\GroupingSearch.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Funcionario, Ponto>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
