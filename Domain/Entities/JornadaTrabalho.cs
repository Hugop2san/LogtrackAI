namespace LogtrackAI.Domain.Entities
{
    public class JornadaTrabalho
    {
        public int Id { get; set; }
        public Bases BaseOrigem { get; set; }
        public Motorista Motorista { get; set; }
        public ICollection<Entrega> Entregas { get; set; } = new List<Entrega>() ;
        public ICollection<Entrega> TrechoRota { get; set; } = new List<Entrega>();

    }
}
