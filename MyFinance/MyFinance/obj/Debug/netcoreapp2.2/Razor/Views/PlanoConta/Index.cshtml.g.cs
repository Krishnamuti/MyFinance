#pragma checksum "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22f3d217ce621a8503578e6ee4069d6799a67466"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlanoConta_Index), @"mvc.1.0.view", @"/Views/PlanoConta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PlanoConta/Index.cshtml", typeof(AspNetCore.Views_PlanoConta_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f3d217ce621a8503578e6ee4069d6799a67466", @"/Views/PlanoConta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05dd6abef5a8ff60f9a555c67ee727241a6c480", @"/Views/_ViewImports.cshtml")]
    public class Views_PlanoConta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PlanoConta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CriarPlanoConta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 269, true);
            WriteLiteral(@"
<h3>Plano de Contas</h3>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>#</th>
            <th>#</th>
            <th>Id</th>
            <th>Descrição</th>
            <th>Tipo</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
          
            foreach (PlanoContaModel item in (List<PlanoContaModel>)ViewBag.ListaPlanoConta)
            {

#line default
#line hidden
            BeginContext(433, 91, true);
            WriteLiteral("                <tr>\r\n                    <td><button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 524, "\"", 561, 3);
            WriteAttributeValue("", 534, "Editar(", 534, 7, true);
#line 23 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 541, item.Id.ToString(), 541, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 560, ")", 560, 1, true);
            EndWriteAttribute();
            BeginContext(562, 91, true);
            WriteLiteral(">Editar</button></td>\r\n                    <td><button type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 653, "\"", 691, 3);
            WriteAttributeValue("", 663, "Excluir(", 663, 8, true);
#line 24 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
WriteAttributeValue("", 671, item.Id.ToString(), 671, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 690, ")", 690, 1, true);
            EndWriteAttribute();
            BeginContext(692, 48, true);
            WriteLiteral(">Excluir</button></td>\r\n                    <td>");
            EndContext();
            BeginContext(741, 18, false);
#line 25 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                   Write(item.Id.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(759, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(791, 25, false);
#line 26 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                   Write(item.Descricao.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(816, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(848, 68, false);
#line 27 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
                   Write(item.tipo.ToString().Replace("R", "Receita").Replace("D", "Despesa"));

#line default
#line hidden
            EndContext();
            BeginContext(916, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 29 "F:\Documentos\CURSOS\MyFinance\MyFinance\Views\PlanoConta\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(972, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            BeginContext(998, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22f3d217ce621a8503578e6ee4069d6799a674667724", async() => {
                BeginContext(1092, 20, true);
                WriteLiteral("Criar Plano de Conta");
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
            BeginContext(1116, 262, true);
            WriteLiteral(@"

<script>
    function Editar(id_conta) {
        window.location.href = ""../PlanoConta/CriarPlanoConta/"" + id_conta;
    }
    function Excluir(id_conta) {
        window.location.href = ""../PlanoConta/ExcluirPlanoConta/"" + id_conta;
    }
</script>
");
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