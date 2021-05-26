using Microsoft.AspNetCore.Components;
using NorthWindBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindBlazor.Pages
{
    public partial class Index
    {
        [Inject]
        HttpClient HttpClient { get; set; }

        List<Product> Products = new List<Product>();

        Product Product = new Product();
        string Message;
        MarkupString TBody;
        const String RequestUri = "api/products";

        async Task GetProducts()
        {

            try
            {
                //invocar la web API

                var Response =
                    await HttpClient.GetAsync(RequestUri);
                if (Response.IsSuccessStatusCode)
                {
                    //Si la respuesta fue exitosa
                    //Obtener los productos desde el cuerpo de la respuesta.

                    Products =
                        await Response.Content.ReadFromJsonAsync<List<Product>>();

                    //Generar el codigo HTML para mostrar los productos
                    SetProducts();

                }
                else
                {
                    //Si la respuesta no fue exitosa,procesar la respuesta
                    await HandleResponse(Response);
                    //Actualizar el codigo HTML para no mostrar productos
                    Products = new List<Product>();
                    SetProducts();
                }
            }

            catch (Exception ex)
            {
                Message = $"No se pudo obtener la informacion. {ex.Message}";
                Products = new List<Product>();
                SetProducts();
            }

        }

        async Task ShowProducts()
        {
            Message = "Procesando...";
            await GetProducts();
            if (Products.Count > 0)
            {
                Message = $"{Products.Count} registros leidos.";
            }

        }

        async void FindByld()
        {
            try
            {

                Message = "Procesando...";
                //Invocar la web Api

                var Response =
                    await HttpClient.GetAsync($"{RequestUri}/Product.Id");
                if (Response.IsSuccessStatusCode)
                {
                    //Si la respuesta fue exitosa

                    //Obtener los datos desde el cuerpo de la respuesta
                    Product = await Response.Content.ReadFromJsonAsync<Product>();
                    Message = $"Producto {Product.Id} encontrado.";

                }

                else

                {

                    if (Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {

                        //El estatus not found (HTTP 404) indica que el prox producto no fue encontrado
                        Message = $"Producto {Product.Id} no encontrado.";
                        Product.Name = "";
                        Product.UnitPrice = null;

                    }

                    else
                    {

                        //Procesar la respuesta para codigos de estado
                        //distintos de 404
                        await HandleResponse(Response);
                    }
                }

            }

            catch (Exception ex)
            {

                Message = $"No se pudo obtener la informacion. {ex.Message}";
                Product.Name = "";
                Product.UnitPrice = null;
            }

            //Indicar que hubo cambios en los datos
            // y es necesario actualizar los cambios

            StateHasChanged();

        }

        async Task AddProduct()
        {

            try
            {

                Message = "Procesando...";
                Product.Id = 0;
                //Invocar la web API
                var Response =
                    await HttpClient.PostAsJsonAsync(RequestUri, Product);
                if (Response.IsSuccessStatusCode)
                {

                    //Si la respuesta es exitosa
                    //Obtener el nuevo producto desde el cuerpo de la respuesta
                    Product = await Response.Content.ReadFromJsonAsync<Product>();
                    Message = $"Product {Product.Id} agregado.";

                    //Actualizar el estado de productos
                    await GetProducts();

                }

                else
                {

                    //procesar la respuesta no exitosa
                    await HandleResponse(Response);

                }

            }

            catch (Exception ex)
            {

                Message = $"No se pudo agregar el producto. {ex.Message}";
            }

            StateHasChanged();
        }

        async Task UpdateProduct()
        {

            try
            {

                Message = "Procesando...";
                //Invocar la web API
                var Response =
                    await HttpClient.PutAsJsonAsync(
                        $"{RequestUri}/{Product.Id}", Product);
                if (Response.IsSuccessStatusCode)
                {

                    //respuesta exitosa
                    Message = $"Product {Product.Id} modificado.";

                    //Actualizar el estado de productos
                    await GetProducts();

                }

                else
                {

                    if (Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {


                        //El producto a modificar no fue encontrado 
                        Message =
                            $"Producto {Product.Id} no encontrado.";
                    }
                    else
                    {

                        //procesar codigos de estado distintos de 404
                        await HandleResponse(Response);

                    }
                }

            }

            catch (Exception ex)
            {

                Message = $"No se pudo modificar el producto. {ex.Message}";
            }

            StateHasChanged();
        }

        async Task DeleteProduct()
        {

            try
            {

                Message = "Procesando...";
                //Invocar la web API
                var Response =
                    await HttpClient.DeleteAsync(
                        $"{RequestUri}/{Product.Id}");
                if (Response.IsSuccessStatusCode)
                {

                    //respuesta exitosa
                    Message = $"Product {Product.Id} eliminado.";

                    //Actualizar el estado de productos
                    await GetProducts();

                }

                else
                {

                    if (Response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {


                        //El producto a eliminar no fue encontrado 
                        Message =
                            $"Producto {Product.Id} no encontrado.";
                    }
                    else
                    {

                        //procesar codigos de estado distintos de 404
                        await HandleResponse(Response);

                    }
                }

            }

            catch (Exception ex)
            {

                Message = $"No se pudo eliminar el producto. {ex.Message}";
            }

            StateHasChanged();
        }

        void SetProducts()
        {

            var SB = new StringBuilder();
            foreach (var p in Products)
            {

                SB.Append("<tr>");
                SB.Append($"<td> {p.Id}</td>");
                SB.Append($"<td> {p.Name}</td>");
                SB.Append($"<td> {p.UnitPrice}</td>");
                SB.Append("<tr>");
            }
            TBody = (MarkupString)SB.ToString();
            StateHasChanged();
        }

        async Task HandleResponse(HttpResponseMessage response)
        {


            switch (response.StatusCode)
            {

                case System.Net.HttpStatusCode.InternalServerError:
                    //Es un estatus  500. Obtener el detalle del error que
                    //viene como texto plano  en el cuerpo  de la respuesta.


                    var Detail =
                          await response.Content.ReadAsStringAsync();
                    Message = $"HTTP 500 Internal Server Error: {Detail}";
                    break;
                default:
                    //Es un estatus distinto  a 500, Obtener los datos  del error
                    //que vienen en formato Json segun el RFC 7807
                    (int Status, string Title, string Detail) ProblemDetails =
                        await response.Content
                        .ReadFromJsonAsync<(int, string, string)>();
                    Message =
                        $"{ProblemDetails.Status},{ProblemDetails.Title}, " +
                        $"{ProblemDetails.Detail}";
                    break;
            }
        }
    }
}
