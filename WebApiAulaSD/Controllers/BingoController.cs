using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAulaSD.Controllers
{
    public class BingoController : Controller
    {
        private FakeBingoRep _bingoHelper;

        public BingoController() : base()
        {
            _bingoHelper = new FakeBingoRep();
        }

        [HttpGet("NumeroSorteio")]
        public List<int> NumerosSorteados(int id_bingo)
        {
            return _bingoHelper.GetNumerosSorteados();
        }

        [HttpPost]
        public void SortearPedra(int id_bingo)
        {
             _bingoHelper.SortearPedra();
            return;
        }

        [HttpPost("verificar")]
        public bool VerificarCartela(Cartela cartela)
        {
            var retorno = _bingoHelper.VericarCartela(cartela);
            return retorno;
        }

    }
}
