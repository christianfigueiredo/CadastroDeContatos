#pragma checksum "F:\Projetos\outros\aspnetcore\CadastroDeContato\CadastroDeContato\Views\Contato\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd25b82bc948105291b1ee7a86f5557320c5b91a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contato_Index), @"mvc.1.0.view", @"/Views/Contato/Index.cshtml")]
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
#line 1 "F:\Projetos\outros\aspnetcore\CadastroDeContato\CadastroDeContato\Views\_ViewImports.cshtml"
using CadastroDeContato;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projetos\outros\aspnetcore\CadastroDeContato\CadastroDeContato\Views\_ViewImports.cshtml"
using CadastroDeContato.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd25b82bc948105291b1ee7a86f5557320c5b91a", @"/Views/Contato/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e6e24daefd982c773ce5586ac031a42d0a20ac", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Contato_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Projetos\outros\aspnetcore\CadastroDeContato\CadastroDeContato\Views\Contato\Index.cshtml"
  
    ViewData["Title"] = "Listagem de Contatos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <div class=""d-grid gap-2 d-md-flex justify-content-md-start"">
        <a class=""btn btn-primary"" role=""button"">Adicionar novo contato</a>
    </div>
    <br />

    <h1 class=""display-4"">Listagem de Contatos</h1>

    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Celular</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto@email.com</td>
                <td>22 99999-2222</td>
                <td class=""btn-group"" role=""group"">
                    <a role=""button"" class=""btn btn-primary"">Editar</a>
                    <a role=""button"" class=""btn btn-danger"">Apagar</a>

                </td>
            </tr>
            <tr>
              ");
            WriteLiteral(@"  <th scope=""row"">2</th>
                <td>Jacob</td>
                <td>Thornton@email.com</td>
                <td>22 99999-2222</td>
                <td class=""btn-group"" role=""group"">
                    <a role=""button"" class=""btn btn-primary"">Editar</a>
                    <a role=""button"" class=""btn btn-danger"">Apagar</a>

                </td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td>Larry</td>
                <td>larry@email.com</td>
                <td>22 99999-2222</td>
                <td class=""btn-group"" role=""group"">
                    <a role=""button"" class=""btn btn-primary"">Editar</a>
                    <a role=""button"" class=""btn btn-danger"">Apagar</a>

                </td>
            </tr>
        </tbody>
    </table>

</div>

");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
