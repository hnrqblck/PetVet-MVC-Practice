#pragma checksum "C:\Users\jorge\OneDrive\Documents\Cursos\SENAC Informática para Web\UC05\2ª Atividade\PetVet\Views\Home\Servicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c75fddba5d2012630394a5f77b0657a54bf75318"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Servicos), @"mvc.1.0.view", @"/Views/Home/Servicos.cshtml")]
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
#line 1 "C:\Users\jorge\OneDrive\Documents\Cursos\SENAC Informática para Web\UC05\2ª Atividade\PetVet\Views\_ViewImports.cshtml"
using PetVet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jorge\OneDrive\Documents\Cursos\SENAC Informática para Web\UC05\2ª Atividade\PetVet\Views\_ViewImports.cshtml"
using PetVet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c75fddba5d2012630394a5f77b0657a54bf75318", @"/Views/Home/Servicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e690833df41989c5602a82a69f24e3966c06de", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Servicos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jorge\OneDrive\Documents\Cursos\SENAC Informática para Web\UC05\2ª Atividade\PetVet\Views\Home\Servicos.cshtml"
  
    ViewData["Title"] = "Serviços";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"servicos\">\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\jorge\OneDrive\Documents\Cursos\SENAC Informática para Web\UC05\2ª Atividade\PetVet\Views\Home\Servicos.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

    <ul class=""serv"">
        <div class=""coluna1"">
            <li class=""mainLi"">Banho e Tosa</li>
            <ul class>
                <li>Banhos especiais e terapêuticos para o seu pet, incluindo uma tosa no estilo da sua preferência.</li>
                <li>R$69,90</li>
            </ul>
        </div>
        <div class=""coluna2"">
            <li class=""mainLi"">Hotel</li>
            <ul>
                <li>No hotelzinho da PetVet nós oferecemos interação supervisionada com outros pets, além de banho e uma alimentação balanceada enquanto eles estiverem hospedados em nossa casa.</li>
                <li>R$50/dia</li>
            </ul>
        </div>
        <div class=""coluna3"">
            <li class=""mainLi"">Check-up</li>
            <ul>
                <li>Traga o seu pet para uma revisão geral. Não deixe a saúde do seu pet para mais tarde!</li>
                <li>R$119,90</li>
            </ul>
        </div>
    </ul>
</div>
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
