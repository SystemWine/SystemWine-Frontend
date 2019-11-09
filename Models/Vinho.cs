namespace Frontend.Models
{
    public class Vinho
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int IdRegiao { get; set; }
        public int IdPais { get; set; }
        public int IdTipoUva { get; set; }
        public double Valor { get; set; }
        public int Ano { get; set; }
        public TipoVinho TipoVinho { get; set; }
        public int IdTipoOcasiao { get; set; }


    }
}