#pragma checksum "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1b80529ec106a2b13e5a525d72275b3460b7d6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(P_MOOU_.Pages.Pages_UsuariosMySql), @"mvc.1.0.razor-page", @"/Pages/UsuariosMySql.cshtml")]
namespace P_MOOU_.Pages
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
using P_MOOU_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
using P_MOOU_.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
using P_MOOU_.Controlador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b80529ec106a2b13e5a525d72275b3460b7d6d", @"/Pages/UsuariosMySql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab35f72c7bf10c5037696f95e350e0e295ac236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UsuariosMySql : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
   int contadoralumno = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
  

    List<DatosMoodle> lista;
    Servicios servicios = new Servicios();
    lista = servicios.ListarMySql(-1);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"form-inline pull-right\">\r\n            <label>Buscar</label>\r\n            <input type=\"text\" id=\"txtSearch\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 460, "\"", 468, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>
    </div>
    <div class=""col-sm-12"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <th>Nro</th>
                    <th>RUT</th>
                    <th>Nombre</th>
                    <th>Apellido</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                 foreach (var c in lista)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 39 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(contadoralumno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(c.Id_student);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 41 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(c.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 42 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                       Write(c.Lastname1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 45 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\UsuariosMySql.cshtml"
                    contadoralumno++;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<P_MOOU_.Pages.UsuariosMySqlModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<P_MOOU_.Pages.UsuariosMySqlModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<P_MOOU_.Pages.UsuariosMySqlModel>)PageContext?.ViewData;
        public P_MOOU_.Pages.UsuariosMySqlModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
