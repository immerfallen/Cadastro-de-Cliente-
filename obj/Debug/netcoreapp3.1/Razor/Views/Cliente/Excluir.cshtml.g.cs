#pragma checksum "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Excluir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9c2de3731b56b842659dfff9e1ede1d97c255c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Excluir), @"mvc.1.0.view", @"/Views/Cliente/Excluir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9c2de3731b56b842659dfff9e1ede1d97c255c0", @"/Views/Cliente/Excluir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3030fd12c8a29b16938da2a396d402698c730dfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Excluir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h2>Excluir Cliente?</h2>

<h3>Deseja realmente excluir o cliente selecionado?</h3>

<button type=""button"" class=""btn btn-danger"" onclick=""Nao()"">Não</button>
<button type=""button"" class=""btn btn-success"" onclick=""Sim()"">Sim</button>

<script>
    function Sim() {
        window.location.href = ""../../Cliente/ExcluirCliente/"" + '");
#nullable restore
#line 10 "C:\Users\maro_\Desktop\testeTempus\Views\Cliente\Excluir.cshtml"
                                                             Write(ViewData["IdExcluir"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\'; //Precisa colocar aspas simples no código C# pois ele roda no cliente\r\n    }\r\n\r\n    function Nao() {\r\n        window.location.href= \"../../Cliente/Listar\"\r\n    }\r\n</script>");
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
