#pragma checksum "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb31983a307db7ec97186b42efa4c9294814d661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pintermedio.Pages.Pages_UsuariosMySql), @"mvc.1.0.razor-page", @"/Pages/UsuariosMySql.cshtml")]
namespace Pintermedio.Pages
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
#line 1 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\_ViewImports.cshtml"
using Pintermedio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
using Pintermedio.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
using Pintermedio.Controlador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb31983a307db7ec97186b42efa4c9294814d661", @"/Pages/UsuariosMySql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9426dcbc43a919bcc216c4d15c9ed277ebc31f9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UsuariosMySql : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
  

    List<Alumnos> lista;
    Servicios servicios = new Servicios();
    lista = servicios.ListarMySql(-1);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"form-inline pull-right\">\r\n            <label>Buscar</label>\r\n            <input type=\"text\" id=\"txtSearch\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 441, "\"", 449, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""col-sm-12"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>RUT</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 33 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                 foreach (var c in lista)
                {
                    //servicios.Insert_Usuario(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 38 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(c.Id_student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(c.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(c.Lastname1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 43 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pintermedio.Vistas.UsuariosMySqlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pintermedio.Vistas.UsuariosMySqlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pintermedio.Vistas.UsuariosMySqlModel>)PageContext?.ViewData;
        public Pintermedio.Vistas.UsuariosMySqlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591