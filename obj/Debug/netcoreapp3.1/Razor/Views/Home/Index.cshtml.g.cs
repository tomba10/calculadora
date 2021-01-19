#pragma checksum "C:\Users\gerar\source\repos\Calculadora\Calculadora\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6adedcf2ef14bf637c6fbac33fd716b9febe485b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gerar\source\repos\Calculadora\Calculadora\Views\_ViewImports.cshtml"
using Calculadora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gerar\source\repos\Calculadora\Calculadora\Views\_ViewImports.cshtml"
using Calculadora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6adedcf2ef14bf637c6fbac33fd716b9febe485b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73bc683a9f979c652064084dbaeab0fe83a2029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\gerar\source\repos\Calculadora\Calculadora\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"jumbotron\">CALCULADORA en HTML</h1>\r\n\r\n    <div id=\"DivPrincipal\">\r\n\r\n\r\n");
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-8\">\r\n                <input type=\"text\" id=\"txtResultadoId\" />\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(7)"">7</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(8)"">8</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(9)"">9</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-success btn-sm"" onclick="" Operar('-')"">-</button>
            </div>
        </div>

");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(4)"">4</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(5)"">5</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(6)"">6</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-success btn-sm"" onclick="" Operar('+')"">+</button>
            </div>
        </div>


");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(1)"">1</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(2)"">2</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(3)"">3</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-success btn-sm"" onclick="" Operar('/')"">/</button>
            </div>
        </div>


");
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-4"">
                <button class=""MyBotonCalculadora btn btn-primary btn-sm"" onclick=""MostrarNumero(0)"">0</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-success btn-sm"" onclick="" Operar('x')"">x</button>
            </div>
            <div class=""col-2"">
                <button class=""MyBotonCalculadora btn btn-success btn-sm"" onclick="" Operar('=')"">=</button>
            </div>

        </div>

    </div>

</div>

<script>
    var textResultado = document.getElementById(""txtResultadoId"");
    var resultado = 0;
    var operador = null;
    


    function MostrarNumero(numero) {
        this.textResultado.value += numero;
        }

    function Operar(operador) {

        if (this.operador !== null) {
            switch (this.operador)
            {

                case ""+"":
                    this.resultado += Number.parseInt(textResultado.value);");
            WriteLiteral(@"
                    this.operador = null;
                    break;

                case ""-"":
                    this.resultado -= Number.parseInt(textResultado.value);
                    this.operador = null;
                    break;

                case ""x"":
                    this.resultado += Number.parseInt(textResultado.value);
                    this.operador = null;
                    break;

                case ""/"":
                    this.resultado += Number.parseInt(textResultado.value);
                    this.operador = null;
                    break;

            }
            this.textResultado.value = this.resultado;


        }
        else {
            this.resultado = Number.parseInt(textResultado.value);
            this.operador = operador;
            this.textResultado.value = """";
        }
        
        
    }

  
</script>

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
