#pragma checksum "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6de2cf74c6148d199758f0fe434f0d3e252afec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Producto_Views_Producto_Index), @"mvc.1.0.view", @"/Areas/Producto/Views/Producto/Index.cshtml")]
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
#line 1 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\_ViewImports.cshtml"
using ProyectoCristian;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\_ViewImports.cshtml"
using ProyectoCristian.Areas.Producto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\_ViewImports.cshtml"
using ProyectoCristian.Models.Paginador;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6de2cf74c6148d199758f0fe434f0d3e252afec0", @"/Areas/Producto/Views/Producto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1402f55ae65f596c0b6c7c88c92c8792384f1ab8", @"/Areas/Producto/Views/_ViewImports.cshtml")]
    public class Areas_Producto_Views_Producto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataPaginador<Productos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px; height:100px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col-md-12"">
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title"">Bordered Table</h3>
        </div>
        <!-- /.card-header -->
        <div class=""card-body"">
            <table class=""table table-bordered"">
                <thead>
                    <tr>
                        <th style=""width: 10px"">Id Producto</th>
                        <th>Imagen</th>
                        <th>Nombre</th>
                        <th>Descripcion</th>
                        <th >Categoria</th>
                        <th>Precio</th>
                        <th>Cantidad</th>
                        <th>Acciones</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 23 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                 foreach (Productos a in Model.Lista)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                       Write(a.id_productos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6de2cf74c6148d199758f0fe434f0d3e252afec05339", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 990, "~/imagenes/", 990, 11, true);
#nullable restore
#line 28 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
AddHtmlAttributeValue("", 1001, a.Imagen, 1001, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                       Write(a.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                       Write(a.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                          
                            switch (a.id_categoria)
                            {
                                case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Accesorios</td>\r\n");
#nullable restore
#line 36 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
 break;
                                case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Camisas</td>\r\n");
#nullable restore
#line 39 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
 break;
                                case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Zapatos</td>\r\n");
#nullable restore
#line 42 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
break;
                            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 44 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                       Write(a.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                       Write(a.cantidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1758, "\"", 1810, 2);
            WriteAttributeValue("", 1765, "/Producto/Producto/Editar/?id=", 1765, 30, true);
#nullable restore
#line 47 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
WriteAttributeValue("", 1795, a.id_productos, 1795, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mb-2 mt-2\">Editar</a>\r\n");
#nullable restore
#line 48 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                              
                                if (a.estado == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 1977, "\"", 2046, 4);
            WriteAttributeValue("", 1984, "/Producto/Producto/Estado/?id=", 1984, 30, true);
#nullable restore
#line 50 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
WriteAttributeValue("", 2014, a.id_productos, 2014, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2029, "&estado=", 2029, 8, true);
#nullable restore
#line 50 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
WriteAttributeValue("", 2037, a.estado, 2037, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Activar</a> ");
#nullable restore
#line 50 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                                                                                                                                              }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 2160, "\"", 2229, 4);
            WriteAttributeValue("", 2167, "/Producto/Producto/Estado/?id=", 2167, 30, true);
#nullable restore
#line 52 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
WriteAttributeValue("", 2197, a.id_productos, 2197, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2212, "&estado=", 2212, 8, true);
#nullable restore
#line 52 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
WriteAttributeValue("", 2220, a.estado, 2220, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Inactivar</a> ");
#nullable restore
#line 52 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                                                                                                                                               }

                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            \r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <!-- /.card-body -->
        <div class=""card-footer clearfix"">
            <!-- <ul class=""pagination pagination-sm m-0 float-right"">
         <li class=""page-item""><a class=""page-link"" href=""#"">&laquo;</a></li>
         <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
         <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
         <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
         <li class=""page-item""><a class=""page-link"" href=""#"">&raquo;</a></li>
     </ul>-->
            ");
#nullable restore
#line 71 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
       Write(Html.Raw(Model.Pagi_info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 72 "C:\Users\Cristian\source\repos\Proyecto-Cristian\ProyectoCristian\Areas\Producto\Views\Producto\Index.cshtml"
       Write(Html.Raw(Model.Pagi_navegacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <!-- /.card -->\r\n\r\n   \r\n    <!-- /.card -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPaginador<Productos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
