using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using frontend.Models;
using frontend.Data;
using Frontend.Models;
using Frontend.DTOs;
using frontend.Services;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace frontend.Controllers
{
    public class TiposController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        private IWineServices _wineServices;

        public TiposController (ApplicationDbContext context, IWineServices wineServices, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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

            var vinhos = (

                from v in _context.Vinhos
                join tu in _context.TiposUva on v.IdTipoUva equals tu.Id
                where (v.TipoVinho.Id == idTipo || idTipo == 0)
                select new VinhoExibirListaDTO {
                    Id = v.Id,
                    Descricao = v.Descricao,
                    Valor = v.Valor,
                    TipoUva = tu.Descricao,
                    TipoVinho = ""
                }
            ).ToList();

            // IEnumerable<Vinho> vinhosFiltrados = 
            //     _context.Vinhos.Where(x => x.TipoVinho.Id == idTipo || idTipo == 0).ToList();

            ViewBag.Vinhos = vinhos;

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

        private Task<IdentityUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);


        public ActionResult<string> Cubanacan(int idVinho, double nota)
         {
            IdentityUser usuario = GetCurrentUserAsync().Result;

            // UsuarioNotaVinho usuarioNotaVinho = _context.UsuariosNotaVinho;

            //busca a relacao no banco
            UsuarioNotaVinho notaAtual = _context.UsuariosNotaVinhos
                .Where(x => x.IdVinho == idVinho 
                         && x.Usuario.Id == usuario.Id).FirstOrDefault();

            if (notaAtual == null)
            {
                notaAtual = new UsuarioNotaVinho();
                notaAtual.Usuario = usuario;
                notaAtual.IdVinho = idVinho;
                notaAtual.Nota = nota;
                _context.UsuariosNotaVinhos.Add(notaAtual);
            }
            else
            {
                notaAtual.Nota = nota;
            }
            notaAtual.Data = DateTime.Now;
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
