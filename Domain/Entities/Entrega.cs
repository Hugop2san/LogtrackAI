namespace LogtrackAI.Domain.Entities
{
    public class Entrega
    {
        public int Id { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public Rota Rota { get; set; }          // composição
        public Motorista? Motorista { get; set; } // associação
        public Previsao? Previsao { get; set; }   // composição
        public string Status { get; set; } // Pendente, EmTransporte, Entregue
        public DateTime CriadoEm { get; set; }
    }
}
