namespace Frontend.Models
{
    public class UsuarioPreferencia
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoUva { get; set; }
        public int IdPais { get; set; }
        public int IdRegiao { get; set; }
        public double ValorMax { get; set; }
        public double ValorMin { get; set; }
        
    }
}