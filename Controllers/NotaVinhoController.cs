using System;
using frontend.Data;
using Frontend.DTOs;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers
{
    public class NotaVinhoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotaVinhoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Pais pais = _context.Paises.Find(1);         
            ViewBag.Paises = _context.Paises;
            return View();
        }
        [HttpPost]

        public IActionResult Post(UsuarioVinhoVotarDTO voto) 
        {
            //usuar

            // insere nota vinho
            UsuarioNotaVinho votoUsuario = new UsuarioNotaVinho();
            votoUsuario.IdVinho = voto.IdVinho;
            // votoUsuario.IdUsuario = voto.IdUsuario;
            votoUsuario.Nota = voto.Nota;
            votoUsuario.Data = DateTime.Now;
            _context.UsuariosNotaVinhos.Add(votoUsuario);
            _context.SaveChanges();
            return Ok(votoUsuario);
        }
        
        [HttpGet]
        public ActionResult<string> Votar()
        {
            Pais pais = _context.Paises.Find(3);
            pais.Descricao = "Jamaica";
            //pais.SaveChanges();
            Pais brasil = new Pais();
            brasil.Descricao = "Brasil";
            _context.Paises.Add(brasil);
            Regiao regiao = new Regiao();
            regiao.Descricao = "Sul";
            regiao.Pais = brasil;
            _context.Regioes.Add(regiao);
            _context.SaveChanges();
            return "";
            
        }

    }
}