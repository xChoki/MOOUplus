#pragma checksum "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b6a0982bc6507a378046363385f40fd7003f63"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b6a0982bc6507a378046363385f40fd7003f63", @"/Pages/MostrarNotasM.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab35f72c7bf10c5037696f95e350e0e295ac236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MostrarNotasM : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Generar Códigos Equivalente</h2>\r\n");
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

    List<DatosMoodle> lista;
    lista = servicio.ListarMySql(-1);

    List<CarrerasUmas> listacarreras = new List<CarrerasUmas>();
    listacarreras = servicio.GetCarreras(-1);

    List<EquivMoodleUmas> listaequiv = new List<EquivMoodleUmas>();
    listaequiv = servicio.GetEquivMoodleUmas("");

    List<CarrerasUmas> listanombres = new List<CarrerasUmas>();
    listanombres = servicio.GetNombreCarreras(-1);

    List<DatosNotasMoodle> listanotasmoodle = new List<DatosNotasMoodle>();
    listanotasmoodle = servicio.ListarNotasMoodle(-1);

    List<DatosMoodle> listaalumos;
    listaalumos = servicio.ListarMySql(-1);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 35 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
     foreach (var c in listaalumos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"accordion-item\">\r\n\r\n            <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 1067, "\"", 1083, 2);
            WriteAttributeValue("", 1072, "heading_", 1072, 8, true);
#nullable restore
#line 39 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 1080, ij, 1080, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse_");
#nullable restore
#line 40 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                                                                                              Write(ij);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1227, "\"", 1255, 2);
            WriteAttributeValue("", 1243, "collapse_", 1243, 9, true);
#nullable restore
#line 40 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 1252, ij, 1252, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 41 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
               Write(contadoralumno);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 41 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                 Write(c.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                              Write(c.Lastname1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                                           Write(c.Lastname2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </h2>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 1399, "\"", 1416, 2);
            WriteAttributeValue("", 1404, "collapse_", 1404, 9, true);
#nullable restore
#line 44 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 1413, ij, 1413, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 1453, "\"", 1482, 2);
            WriteAttributeValue("", 1471, "heading_", 1471, 8, true);
#nullable restore
#line 44 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
WriteAttributeValue("", 1479, ij, 1479, 3, false);

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
#line 55 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                             foreach (var e in listanotasmoodle)
                            {
                                if (e.Id_student == c.Id_student)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 60 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                   Write(e.Idcourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 61 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                   Write(e.Namecourse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 62 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                   Write(e.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 64 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
                                }
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 72 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\MostrarNotasM.cshtml"
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
