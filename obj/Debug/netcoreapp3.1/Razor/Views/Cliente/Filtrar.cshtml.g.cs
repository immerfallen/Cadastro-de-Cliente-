#pragma checksum "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d5615a3f39b21d4043e77ce354a494e28c1619a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Filtrar), @"mvc.1.0.view", @"/Views/Cliente/Filtrar.cshtml")]
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
#line 1 "C:\Users\maro_\Desktop\testeTempus\Views\_ViewImports.cshtml"
using testeTempus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maro_\Desktop\testeTempus\Views\_ViewImports.cshtml"
using testeTempus.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d5615a3f39b21d4043e77ce354a494e28c1619a", @"/Views/Cliente/Filtrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3030fd12c8a29b16938da2a396d402698c730dfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Filtrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClienteModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control col-9 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filtrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Lista de Clientes</h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d5615a3f39b21d4043e77ce354a494e28c1619a4610", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-2 m-1\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9d5615a3f39b21d4043e77ce354a494e28c1619a4916", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 7 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Filtro);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-block btn-success col-3 px-1\" >Pesquisar</button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th class=""text-center"">#</th>
            <th class=""text-center"">#</th>            
            <th>Nome</th>            
            <th>Renda Familiar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
          
            foreach (var item in (List<ClienteModel>)ViewBag.ListaClientesFiltro)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\"><button type=\"button\" class=\"btn btn-warning \"");
            BeginWriteAttribute("onclick", " onclick=\"", 863, "\"", 889, 3);
            WriteAttributeValue("", 873, "Editar(", 873, 7, true);
#nullable restore
#line 26 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
WriteAttributeValue("", 880, item.Id, 880, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 888, ")", 888, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button></td>\r\n                    <td class=\"text-center\"><button type=\"button\" class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1001, "\"", 1028, 3);
            WriteAttributeValue("", 1011, "Excluir(", 1011, 8, true);
#nullable restore
#line 27 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
WriteAttributeValue("", 1019, item.Id, 1019, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1027, ")", 1027, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Excluir</button></td>                   \r\n                    <td>");
#nullable restore
#line 28 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                   Write(item.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                   \r\n");
#nullable restore
#line 29 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                     if(@item.RendaFamiliar<980)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td> <p class=\"renda rendaBaixa\"> R$ ");
#nullable restore
#line 31 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                                                        Write(item.RendaFamiliar.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 32 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                    } else if(@item.RendaFamiliar<2500){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td> <p class=\"renda rendaMedia\">R$ ");
#nullable restore
#line 33 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                                                       Write(item.RendaFamiliar.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 34 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                    } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <td> <p class=\"renda rendaAlta\">R$ ");
#nullable restore
#line 35 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                                                       Write(item.RendaFamiliar.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></td>\r\n");
#nullable restore
#line 36 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 38 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Filtrar.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<button class=""btn btn-block btn-primary"" type=""button"" onclick=""Cadastrar()"">Cadastrar Cliente</button>

<script>
    function Cadastrar() {
        window.location.href=""../Cliente/Cadastro""
    }
    function Editar(id) {
        window.location.href = ""../Cliente/Cadastro/"" + id
    }
    function Excluir(id) {
        window.location.href = ""../Cliente/Excluir/"" + id
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClienteModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
