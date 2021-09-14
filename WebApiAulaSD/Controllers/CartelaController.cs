using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAulaSD.Controllers
{
    public class CartelaController : Controller
    {
        private FakeCartelaRep _cartelaHelper;


        public CartelaController() : base()
        {
            _cartelaHelper = new FakeCartelaRep();
        }

        [HttpGet("NovaCartela")]
        public async Task<ActionResult<Cartela>>Get()
        {
            return _cartelaHelper.GenerateCartela();
        }
       
    }
}
