namespace Frontend.Models
{
    public class Regiao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Pais Pais { get; set; }
    }
}