#pragma checksum "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0762baaf60434b3e3cdfc6c3823d1c0124a25f1d"
// <auto-generated/>
#pragma warning disable 1591
namespace FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using FrontEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/_Imports.razor"
using Cbm.BaseRazor.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
using Compartilhado.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/jogar")]
    public partial class JogarCartelas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Bingo</h3>\r\n\r\n");
            __builder.OpenElement(1, "h3");
            __builder.AddContent(2, "Bem vindo ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
               jogador.Nome

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " [");
            __builder.AddContent(5, 
#nullable restore
#line 8 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                              jogador.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, "]");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(8, "<h3>NumerosSorteados:</h3>\r\n");
            __builder.OpenElement(9, "h1");
#nullable restore
#line 13 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
     foreach (var sort in Sorteados)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, 
#nullable restore
#line 15 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
         sorteioFormatar(sort)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 15 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                              
     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                                          Sortear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Sortear Pedra");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                                          adiquirirCartela

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Adquirir Cartela");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n<br>\r\n<br>\r\n<br>");
#nullable restore
#line 27 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
 if (jogador.MinhasCartelas is not null)
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
     if (jogador.MinhasCartelas.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table");
            __builder.AddMarkupContent(24, "<thead><tr><th>A</th>\r\n                    <th>B</th>\r\n                    <th>C</th></tr></thead>\r\n            ");
            __builder.OpenElement(25, "tbody");
            __builder.OpenElement(26, "tr");
#nullable restore
#line 40 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                     foreach (var num in jogador.MinhasCartelas[0].CartelaNumeros)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 42 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                             num

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "tr");
#nullable restore
#line 46 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                     foreach (var sorteado in jogador.MinhasCartelas[0].CartelaMarcacao)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "td");
            __builder.AddContent(32, 
#nullable restore
#line 48 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                             XorEmpty(sorteado)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 49 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<br>\r\n\r\n    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
                                              VerificarBingo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Bingo!");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "h1");
            __builder.AddContent(40, 
#nullable restore
#line 59 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
          MsgVitoria

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "/Users/elainemattos/unip/WebApiAulaSD_Bingo/FrontEnd/Pages/JogarCartelas.razor"
           
        public Usuario jogador = new Usuario { Nome = "Arthur", Id = 1, MinhasCartelas = new List<Cartela>() };
        public List<int> Sorteados = new List<int>();
        private string MsgVitoria = "";

        protected override void OnInitialized()
        {
            jogador = new Usuario { Nome = "Arthur", Id = 1, MinhasCartelas = new List<Cartela>() };

        }


        public void adiquirirCartela()
        {
            var novaCartela = repCartelas.GenerateCartela();
            if (jogador.MinhasCartelas.Count == 0)
                jogador.MinhasCartelas.Add(novaCartela);
            else
                jogador.MinhasCartelas[0] = novaCartela;

            StateHasChanged();
        }

        private string XorEmpty(bool valor)
        {
            if (valor)
                return "X";
            else
                return "_";
        }

        private void Sortear()
        {
            var sorteado = repBingo.SortearPedra();
            Sorteados.Add(sorteado);
            jogador.MinhasCartelas[0].Verificar(sorteado);
            StateHasChanged();
        }

        private void VerificarBingo()
        {
            if(repBingo.VericarCartela(jogador.MinhasCartelas[0]))
            {
                MsgVitoria = "Parab??ns Voc?? Venceu!!!";
            }
        }

        private string sorteioFormatar(int n)
        {
            return n + " | ";
        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositoryBingo repBingo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositoryCartela repCartelas { get; set; }
    }
}
#pragma warning restore 1591
