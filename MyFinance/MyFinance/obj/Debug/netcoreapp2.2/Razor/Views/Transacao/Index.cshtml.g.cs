#pragma checksum "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0817726f6dbf24c90843f601edf7695d3ddfcea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transacao_Index), @"mvc.1.0.view", @"/Views/Transacao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transacao/Index.cshtml", typeof(AspNetCore.Views_Transacao_Index))]
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
#line 1 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance;

#line default
#line hidden
#line 2 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\_ViewImports.cshtml"
using MyFinance.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0817726f6dbf24c90843f601edf7695d3ddfcea", @"/Views/Transacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_Transacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 418, true);
            WriteLiteral(@"

<h3>Minhas Transações</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Data</th>
            <th>Tipo</th>
            <th>Valor</th>
            <th>Histórico</th>
            <th>Conta</th>
            <th>Plano de Contas</th>                        
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
          
            foreach (TransacaoModel item in (List<TransacaoModel>)ViewBag.ListaTransacao)
            {

#line default
#line hidden
            BeginContext(536, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 627, "\"", 664, 3);
            WriteAttributeValue("", 637, "Editar(", 637, 7, true);
#line 24 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
WriteAttributeValue("", 644, item.Id.ToString(), 644, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 663, ")", 663, 1, true);
            EndWriteAttribute();
            BeginContext(665, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 756, "\"", 794, 3);
            WriteAttributeValue("", 766, "Excluir(", 766, 8, true);
#line 25 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
WriteAttributeValue("", 774, item.Id.ToString(), 774, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 793, ")", 793, 1, true);
            EndWriteAttribute();
            BeginContext(795, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(844, 18, false);
#line 26 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                   Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(862, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(894, 20, false);
#line 27 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                   Write(item.Data.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(914, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(946, 68, false);
#line 28 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                   Write(item.Tipo.ToString().Replace("R", "Receita").Replace("D", "Despesa"));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 34, true);
            WriteLiteral("</td>\r\n                    <td>R$ ");
            EndContext();
            BeginContext(1049, 21, false);
#line 29 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                      Write(item.Valor.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1070, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1102, 25, false);
#line 30 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                   Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1127, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1159, 25, false);
#line 31 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                   Write(item.NomeConta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1184, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1216, 35, false);
#line 32 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
                   Write(item.DescricaoPlanoConta.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1251, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\Transacao\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1307, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(1333, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0817726f6dbf24c90843f601edf7695d3ddfcea9094", async() => {
                BeginContext(1420, 19, true);
                WriteLiteral("Registrar Transação");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1443, 229, true);
            WriteLiteral("\r\n\r\n<script>\r\n    function Editar(id) {\r\n        window.location.href = \"../Transacao/Registrar/\" + id;\r\n    }\r\n    function Excluir(id) {\r\n        window.location.href = \"../Transacao/ExcluirTransacao/\" + id;\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
