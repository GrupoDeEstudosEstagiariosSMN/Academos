namespace Core.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public int IdEndereco { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string PublicoAlvo { get; set; }
        public decimal ValorIngresso { get; set; }
        public decimal Custo { get; set; }

    }
}