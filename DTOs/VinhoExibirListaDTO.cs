namespace Frontend.DTOs
{
    public class VinhoExibirListaDTO
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string TipoUva { get; set; }
        public double Valor { get; set; }
        public string TipoVinho { get; set; }
        public bool MostraNota { get; set; }
        public double Nota { get; set; }
    }
}