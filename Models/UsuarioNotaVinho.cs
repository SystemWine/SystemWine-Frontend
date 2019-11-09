using System;
namespace Frontend.Models
{
    public class UsuarioNotaVinho
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdVinho { get; set; }
        public double Nota { get; set; }
        public DateTime Data { get; set; }

    }
}