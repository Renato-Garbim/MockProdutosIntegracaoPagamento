using IBBA.Services.DTO;
using IBBA.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockProdutosIntegracaoPagamento.Models;
using MockProdutosIntegracaoPagamento.Models.Home;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MockProdutosIntegracaoPagamento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPixApiService _pixApiService;

        public HomeController(ILogger<HomeController> logger, IPixApiService pixApiService)
        {
            _logger = logger;
            _pixApiService = pixApiService;
        }

        public PartialViewResult CarregarFormularioCompra()
        {
            var model = new ModalViewModel();

            var token = _pixApiService.GerarToken();

            var dados = popularModelPix();

            var pedido = _pixApiService.GerarPedido(token.access_token, dados);
                        
            model.QRCode = _pixApiService.ObterQRCodePixPor(pedido.Txid, token.access_token);

            return PartialView("ModalAssinatura", model);
        }

        private DadosEnvioPixDTO popularModelPix()
        {
            var model = new DadosEnvioPixDTO();

            model.Calendario = new CalendarioDTO() { Expiracao = 50 };
            model.Chave = "10230480001960"; //chave pix
            model.Devedor = new DevedorDTO
            {
                Nome = "Renato Garbim",
                Cpf = "12345678910"
            };
            model.Valor = new ValorDTO
            {
                Original = 140
            };

            return model;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        
    }
}
