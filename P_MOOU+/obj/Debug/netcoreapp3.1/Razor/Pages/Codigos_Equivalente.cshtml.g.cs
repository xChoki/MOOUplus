#pragma checksum "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e314d87c5535e06fed5e8ad9e39828a4f065f2d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(P_MOOU_.Pages.Pages_Codigos_Equivalente), @"mvc.1.0.razor-page", @"/Pages/Codigos_Equivalente.cshtml")]
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
#line 4 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
using Pintermedio.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
using Pintermedio.Controlador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e314d87c5535e06fed5e8ad9e39828a4f065f2d1", @"/Pages/Codigos_Equivalente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab35f72c7bf10c5037696f95e350e0e295ac236", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Codigos_Equivalente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h2>Generar Códigos Equivalente</h2>\r\n");
#nullable restore
#line 9 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
  
    Servicios servicio = new Servicios();
    /*
    List<CursosMoodle> listanotas = new List<CursosMoodle>();
    listanotas = servicio.GetNotas(-1);
    */

    List<CarrerasUmas> listacarreras = new List<CarrerasUmas>();
    listacarreras = servicio.GetCarreras(-1);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"accordion\" id=\"accordionExample\">\r\n");
#nullable restore
#line 22 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
      int ij = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
     foreach (var c in listacarreras)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"accordion-item\">\r\n\r\n            <h2 class=\"accordion-header\"");
            BeginWriteAttribute("id", " id=\"", 646, "\"", 662, 2);
            WriteAttributeValue("", 651, "heading_", 651, 8, true);
#nullable restore
#line 27 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
WriteAttributeValue("", 659, ij, 659, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapse_");
#nullable restore
#line 28 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
                                                                                                              Write(ij);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 806, "\"", 834, 2);
            WriteAttributeValue("", 822, "collapse_", 822, 9, true);
#nullable restore
#line 28 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
WriteAttributeValue("", 831, ij, 831, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 29 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
               Write(c.Carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </button>\r\n            </h2>\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 932, "\"", 949, 2);
            WriteAttributeValue("", 937, "collapse_", 937, 9, true);
#nullable restore
#line 32 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
WriteAttributeValue("", 946, ij, 946, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"accordion-collapse collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 986, "\"", 1015, 2);
            WriteAttributeValue("", 1004, "heading_", 1004, 8, true);
#nullable restore
#line 32 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
WriteAttributeValue("", 1012, ij, 1012, 3, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" data-bs-parent=""#accordionExample"">
                <div class=""accordion-body"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th scope=""col"">U+</th>
                                <th scope=""col"">Moodle</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>");
#nullable restore
#line 43 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
                               Write(c.Codcarr);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>[Insertar cod]</td>\r\n                            </tr>\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 51 "D:\GIT Clones\MOOUplus\P_MOOU+\Pages\Codigos_Equivalente.cshtml"
        ij++;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pintermedio.Pages.Codigos_EquivalenteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pintermedio.Pages.Codigos_EquivalenteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pintermedio.Pages.Codigos_EquivalenteModel>)PageContext?.ViewData;
        public Pintermedio.Pages.Codigos_EquivalenteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
