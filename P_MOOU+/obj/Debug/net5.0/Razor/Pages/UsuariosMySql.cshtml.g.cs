#pragma checksum "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba7ebbb41f818ab66a273d11f4adc658c9cfaf6b"
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
#line 1 "D:\Clase2305\SPintermedio\Pintermedio\Pages\_ViewImports.cshtml"
using Pintermedio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
using Pintermedio.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
using Pintermedio.Controlador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba7ebbb41f818ab66a273d11f4adc658c9cfaf6b", @"/Pages/UsuariosMySql.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9426dcbc43a919bcc216c4d15c9ed277ebc31f9e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UsuariosMySql : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba7ebbb41f818ab66a273d11f4adc658c9cfaf6b3664", async() => {
                WriteLiteral(@"
    Nombre: <input type=""text"" name=""nombre"" id=""nombre"" required />
    Apellido: <input type=""text"" name=""apellido"" id=""apellido"" required />
    Correo: <input type=""text"" name=""correo"" id=""correo"" required />
    Saldo: <input type=""text"" name=""saldo"" id=""saldo"" required />
    <button type=""submit"" name=""benviar"">Agregar Persona</button>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 16 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
  
    List<Usuarios> lista;
    Servicios servicios = new Servicios();
    lista = servicios.ListarMySql(-1);


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nombre</th>\r\n            <th>Apellido</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
         foreach (var c in lista)
        {
            servicios.Insert_Usuario(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 37 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
               Write(c.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
               Write(c.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
               Write(c.Apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 42 "D:\Clase2305\SPintermedio\Pintermedio\Pages\UsuariosMySql.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
