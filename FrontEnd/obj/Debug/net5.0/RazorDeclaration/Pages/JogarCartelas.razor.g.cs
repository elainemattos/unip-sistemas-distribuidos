// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
                MsgVitoria = "Parabéns Você Venceu!!!";
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
