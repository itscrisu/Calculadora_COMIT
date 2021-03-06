#pragma checksum "C:\Users\Usuario\source\repos\Calculadora\Calculadora\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0d98e49b192d9f96f7121a753d28c04b0eaf39c"
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
#line 1 "C:\Users\Usuario\source\repos\Calculadora\Calculadora\Views\_ViewImports.cshtml"
using Calculadora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\Calculadora\Calculadora\Views\_ViewImports.cshtml"
using Calculadora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0d98e49b192d9f96f7121a753d28c04b0eaf39c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73bc683a9f979c652064084dbaeab0fe83a2029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\Calculadora\Calculadora\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"jumbotron\">Calculadora en HTML</h1>\r\n</div>\r\n<div id=\"Principal\">\r\n    <div class=\"row\">\r\n");
            WriteLiteral("        <div class=\"col-8\">\r\n            <input type=\"text\" id=\"txtResultadoId\" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n");
            WriteLiteral(@"        <div class=""col-2"">
            <button class=""botonCalculadora"">7</button>
        </div>
        <div class=""col-2"">
            <button class=""botonCalculadora"">8</button>
        </div>
        <div class=""col-2"">
            <button class=""botonCalculadora"">9</button>
        </div>
        <div class=""col-2"">
            <button class=""botonOperador"">-</button>
        </div>
    </div>
    <div class=""row"">
");
            WriteLiteral(@"        <div class=""col-2"">
            <button class=""botonCalculadora"">4</button>
        </div>
        <div class=""col-2"">
            <button class=""botonCalculadora"">5</button>
        </div>
        <div class=""col-2"">
            <button class=""botonCalculadora"">6</button>
        </div>
        <div class=""col-2"">
            <button class=""botonOperador"">+</button>
        </div>
    </div>
    <div class=""row"">
");
            WriteLiteral(@"        <div class=""col-2"">
            <button class=""botonCalculadora"" onclick=""MostrarNumero(1)"">1</button>
        </div>
        <div class=""col-2"">
            <button class=""botonCalculadora"" onclick=""MostrarNumero(2)"">2</button>
        </div>
        <div class=""col-2"">
            <button class=""botonCalculadora"" onclick=""MostrarNumero(3)"">3</button>
        </div>
        <div class=""col-2"">
            <button class=""botonOperador"">/</button>
        </div>
    </div>
    <div class=""row"">
");
            WriteLiteral(@"        <div class=""col-4"">
            <button class=""botonCero"">0</button>
        </div>
        <div class=""col-2"">
            <button class=""botonOperador"">x</button>
        </div>
        <div class=""col-2"">
            <button class=""botonOperador"">=</button>
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

        this.resultado = parseInt(textResultado.value);
        this.operadorIngresado = operador;
        this.textResultado.value = """";

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
