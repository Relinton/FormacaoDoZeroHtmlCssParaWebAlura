#pragma checksum "C:\Users\RAY DOUGLAS\Desktop\FormacaoFrontEnd\FormacaoDoZeroComHtmlCss\FormacaoDoZeroHtmlCss\Views\Portfolio\Curriculo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97909a05f558c4fd87115e6c0b468f2aae7edec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_Curriculo), @"mvc.1.0.view", @"/Views/Portfolio/Curriculo.cshtml")]
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
#line 1 "C:\Users\RAY DOUGLAS\Desktop\FormacaoFrontEnd\FormacaoDoZeroComHtmlCss\FormacaoDoZeroHtmlCss\Views\_ViewImports.cshtml"
using FormacaoDoZeroHtmlCss;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RAY DOUGLAS\Desktop\FormacaoFrontEnd\FormacaoDoZeroComHtmlCss\FormacaoDoZeroHtmlCss\Views\_ViewImports.cshtml"
using FormacaoDoZeroHtmlCss.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97909a05f558c4fd87115e6c0b468f2aae7edec3", @"/Views/Portfolio/Curriculo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"789f148d7e06b0387620964adfb3452eee38032f", @"/Views/_ViewImports.cshtml")]
    public class Views_Portfolio_Curriculo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Relinton.PNG"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Foto de Relinton Pinheiro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\RAY DOUGLAS\Desktop\FormacaoFrontEnd\FormacaoDoZeroComHtmlCss\FormacaoDoZeroHtmlCss\Views\Portfolio\Curriculo.cshtml"
  
    ViewData["Title"] = "Curriculo";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""apresentacao"">
    <section class=""apresentacao__conteudo"">
        <h1 class=""apresentacao__conteudo__titulo"">Currículo</h1>
        <p class=""apresentacao__conteudo__texto"">
            Apresentação e informações principais
        </p>
        <h2 class=""apresentacao__conteudo__titulo"">Experiências</h2>
        <p class=""apresentacao__conteudo__texto"">
            <ul class=""apresentacao__conteudo__texto"">
                <li> Empresa tal (2020 - 2021) - fazia isso e aquilo </li>
                <li> Empresa tal (2021 - 2023) - fazia isso e aquilo </li>
            </ul>
        </p>
        <h2 class=""apresentacao__conteudo__titulo"">Estudos</h2>
        <p class=""apresentacao__conteudo__texto"">
            <ul class=""apresentacao__conteudo__texto"">
                <li>Curso tal - Alura Cursos <a href=""linkdocertificado"">com certificado</a> </li>
                <li>Curso tal - Alura Cursos <a href=""linkdocertificado"">com certificado</a></li>
                <li>Curso tal -");
            WriteLiteral(" Alura Cursos <a href=\"linkdocertificado\">com certificado</a></li>\r\n            </ul>\r\n        </p>\r\n    </section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97909a05f558c4fd87115e6c0b468f2aae7edec35483", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</main>\r\n\r\n");
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
