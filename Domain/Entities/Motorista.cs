namespace LogtrackAI.Domain.Entities
{
    public class Motorista      // MEXER !
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Veiculo { get; set; }
        public List<Rota> Rotas { get; set; }
        public bool isactive { get; set; }

    }
}
