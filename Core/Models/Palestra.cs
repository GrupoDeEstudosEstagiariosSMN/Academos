namespace Core.Models
{
    public class Palestra
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Horas { get; set; }

        public IEnumerable<EventoPalestra> EventosPalestras { get; set; }
        // public IEnumerable<PalestraPalestrante> EventosPalestras { get; set; }
    }
}