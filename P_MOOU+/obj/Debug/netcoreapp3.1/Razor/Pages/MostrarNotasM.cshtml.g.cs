#pragma checksum "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b22cfcbfaabd2d57c7558d1269e07ea45b3cead"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(P_MOOU_.Pages.Pages_MostrarNotasM), @"mvc.1.0.razor-page", @"/Pages/MostrarNotasM.cshtml")]
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
#line 4 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
using P_MOOU_.Controlador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
using P_MOOU_.Modelo;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b22cfcbfaabd2d57c7558d1269e07ea45b3cead", @"/Pages/MostrarNotasM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab35f72c7bf10c5037696f95e350e0e295ac236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MostrarNotasM : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Mostrar notas de Moodle</h2>\r\n");
#nullable restore
#line 9 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
  int ij = 1;
    int contadoralumno = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
  
    Servicios servicio = new Servicios();

    List<DatosNotasMoodle> listanotasmoodle = new List<DatosNotasMoodle>();
    listanotasmoodle = servicio.ListarNotasMoodle(-1);

    List<DatosMoodle> listaalumos;
    listaalumos = servicio.ListarMySql(-1);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 23 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
     foreach (var c in listaalumos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"accordion-item\">\r\n\r\n            <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 636, "\"", 652, 2);
            WriteAttributeValue("", 641, "heading_", 641, 8, true);
#nullable restore
#line 27 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 649, ij, 649, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse_");
#nullable restore
#line 28 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                                                                                              Write(ij);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 796, "\"", 824, 2);
            WriteAttributeValue("", 812, "collapse_", 812, 9, true);
#nullable restore
#line 28 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 821, ij, 821, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 29 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
               Write(contadoralumno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 29 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                 Write(c.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                              Write(c.Lastname1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                                           Write(c.Lastname2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </h2>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 968, "\"", 985, 2);
            WriteAttributeValue("", 973, "collapse_", 973, 9, true);
#nullable restore
#line 32 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 982, ij, 982, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1022, "\"", 1051, 2);
            WriteAttributeValue("", 1040, "heading_", 1040, 8, true);
#nullable restore
#line 32 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 1048, ij, 1048, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-bs-parent=""#accordionExample"">
                <div class=""accordion-body"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">ID curso</th>
                                <th scope=""col"">Nombre Curso</th>
                                <th scope=""col"">Nota</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 43 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                             foreach (var e in listanotasmoodle)
                            {
                                if (e.Id_student == c.Id_student)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 48 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                   Write(e.Idcourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                   Write(e.Namecourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                   Write(e.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 52 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                }
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 60 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
        contadoralumno++;
        ij++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<P_MOOU_.Pages.Codigos_EquivalenteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<P_MOOU_.Pages.Codigos_EquivalenteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<P_MOOU_.Pages.Codigos_EquivalenteModel>)PageContext?.ViewData;
        public P_MOOU_.Pages.Codigos_EquivalenteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
