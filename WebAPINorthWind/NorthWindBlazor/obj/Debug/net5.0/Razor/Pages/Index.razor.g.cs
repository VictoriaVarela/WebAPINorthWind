#pragma checksum "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1880576f8df91a4141d210f4f974cdef31961e59"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthWindBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using NorthWindBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\_Imports.razor"
using NorthWindBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-field");
            __builder.AddMarkupContent(4, "<label>Id:</label>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "id", "id");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                                              Product.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Product.Id = __value, Product.Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-field");
            __builder.AddMarkupContent(14, "<label>Nombre:</label>\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "id", "name");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                                                Product.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Product.Name = __value, Product.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-field");
            __builder.AddMarkupContent(24, "<label>Precio Unitario:</label>\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "id", "unitPrice");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                                                     Product.UnitPrice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Product.UnitPrice = __value, Product.UnitPrice));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "form-field mt-2 mb-2");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          AddProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-primary");
            __builder.AddMarkupContent(37, "\r\n            Agregar un producto\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          ShowProducts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddMarkupContent(42, "\r\n            Mostrar Productos\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          FindByld

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "btn btn-primary");
            __builder.AddMarkupContent(47, "\r\n            Buscar por Id\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          UpdateProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "class", "btn btn-primary");
            __builder.AddMarkupContent(52, "\r\n            Modificar producto\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                          DeleteProduct

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "class", "btn btn-primary");
            __builder.AddMarkupContent(57, "\r\n            Eliminar producto\r\n        ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "div");
            __builder.AddContent(60, 
#nullable restore
#line 45 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
           Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.OpenElement(63, "table");
            __builder.AddAttribute(64, "id", "products");
            __builder.AddAttribute(65, "class", "table table-bordered table-striped table-hover table-sm");
            __builder.AddMarkupContent(66, "<thead><tr><th>Id</th>\r\n                <th>Name</th>\r\n                <th>UnitPrice</th></tr></thead>\r\n        ");
            __builder.OpenElement(67, "tbody");
            __builder.AddContent(68, 
#nullable restore
#line 56 "C:\Users\usuario\Pictures\PROYECTOS\WebAPINorthWind\WebAPINorthWind\NorthWindBlazor\Pages\Index.razor"
                TBody

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
