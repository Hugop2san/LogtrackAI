namespace LogtrackAI.Domain.Entities
{
    public class Motorista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNH { get; set; }
        public ICollection<JornadaTrabalho> Jornadas { get; set; } = new List<JornadaTrabalho>();
    }
}
