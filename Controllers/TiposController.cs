using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using frontend.Models;
using frontend.Data;
using Frontend.Models;
using frontend.Services;
using Microsoft.EntityFrameworkCore.Internal;

namespace frontend.Controllers
{
    public class TiposController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IWineServices _wineServices;

        public TiposController (ApplicationDbContext context, IWineServices wineServices)
        {
            _context = context;
            // _wineServices = wineServices;
        }

        // [Route("tipos/{idPais?}")]
        // public IActionResult VinhosPorPais(int idPais)
        // {
        //     IEnumerable<Vinho> vinhosFiltrados = 
        //         _context.Vinhos.Where(x => x.IdPais == idPais).ToList();


        //     ViewBag.Vinhos = vinhosFiltrados;

        //     return View();
        // }

        [Route("tipos/{idTipo?}")]
        public IActionResult Index(int idTipo = 0)
        {
            // IEnumerable<TipoVinho> listaTipos = _context.TiposVinho;

            ViewBag.ListaTipos = _context.TipoVinho;
            // var abc = _wineServices.teste().Result;

            IEnumerable<Vinho> vinhosFiltrados = 
                _context.Vinhos.Where(x => x.TipoVinho.Id == idTipo || idTipo == 0).ToList();

            ViewBag.Vinhos = vinhosFiltrados;

            ViewBag.abc = "";

            return View();
        }

        public ActionResult<string> InsereVinho()
        {
            Vinho vinho = new Vinho();
            vinho.Descricao = "Bla";
            vinho.IdRegiao = 1;
            vinho.IdPais = 2;
            vinho.IdTipoUva = 3;
            vinho.Valor = 55;
            vinho.Ano = 2016;
            vinho.IdTipoOcasiao = 5;
            // vinho.IdTipoVinho = 3;
            _context.Vinhos.Add(vinho);
            _context.SaveChanges();

            return "";
        }

        public ActionResult<string> Cubanacan(int idUsuario, int idVinho, double nota)
         {
            // UsuarioNotaVinho usuarioNotaVinho = _context.UsuariosNotaVinho;
            UsuarioNotaVinho usuarioNotaVinho = new UsuarioNotaVinho();
            usuarioNotaVinho.IdUsuario = idUsuario;
            usuarioNotaVinho.IdVinho = idVinho;
            usuarioNotaVinho.Nota = nota;
            usuarioNotaVinho.Data = DateTime.Now;

            _context.UsuariosNotaVinhos.Add(usuarioNotaVinho);
            _context.SaveChanges();
            return "";
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
