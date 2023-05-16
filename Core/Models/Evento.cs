namespace Core.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public int IdPalestrante { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Localizacao { get; set; }
        public string PublicoAlvo { get; set; }
        public decimal ValorIngresso { get; set; }
        public decimal Custo { get; set; }
        //isso representa apenas o relacionamento de evento com palestrante, não é um atributo
        public Palestrante Palestrante { get; set; }
    }
}
