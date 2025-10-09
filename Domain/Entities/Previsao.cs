namespace LogtrackAI.Domain.Entities
{
    public class Previsao
    {
        
        public int Id { get; set; }
        public TimeSpan TempoEstimado { get; set; }
        public string Risco { get; set; }
        public string Motivo { get; set; } // Ex: "chuva e tráfego intenso"
        public DateTime GeradoEm { get; set; }
    }

}
